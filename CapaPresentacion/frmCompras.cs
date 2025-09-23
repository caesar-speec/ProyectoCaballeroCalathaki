using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Data;
using System.Linq.Expressions;
using System.Reflection;

namespace CapaPresentacion
{
    public partial class frmCompras : Form
    {
        private Usuario _Usuario;
        public frmCompras(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbuscarproveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtidproveedor.Text = modal._Proveedor.IdProveedor.ToString();
                    txtdocproveedor.Text = modal._Proveedor.Documento;
                    txtnombreproveedor.Text = modal._Proveedor.RazonSocial;
                }
                else
                {
                    txtdocproveedor.Select();
                }

            }
            if (string.IsNullOrWhiteSpace(txtdocproveedor.Text) || !txtdocproveedor.Text.All(char.IsDigit))
            {
                MessageBox.Show("El campo Documento del Proveedor es obligatorio y solo debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Producto.IdProducto.ToString();
                    txtcodproducto.Text = modal._Producto.Codigo;
                    txtproducto.Text = modal._Producto.Nombre;
                    txtpreciocompra.Select();
                }
                else
                {
                    txtcodproducto.Select();
                }

            }
            if (string.IsNullOrWhiteSpace(txtcodproducto.Text) || !txtcodproducto.Text.All(char.IsDigit))
            {
                MessageBox.Show("El campo Código de Producto es obligatorio y solo debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtidproducto.Text = "0";
            txtidproveedor.Text = "0";
        }

        private void txtcodproducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txtcodproducto.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    txtcodproducto.BackColor = System.Drawing.Color.Honeydew;
                    txtidproducto.Text = oProducto.IdProducto.ToString();
                    txtproducto.Text = oProducto.Nombre;
                    txtpreciocompra.Select();
                }
                else
                {
                    txtcodproducto.BackColor = System.Drawing.Color.MistyRose;
                    txtidproducto.Text = "0";
                    txtproducto.Text = "";
                }
            }
        }

        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            decimal preciocompra = 0;
            decimal precioventa = 0;
            bool producto_existe = false;

            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtpreciocompra.Text, out preciocompra))
            {
                MessageBox.Show("Precio Compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpreciocompra.Select();
                return;
            }

            if (!decimal.TryParse(txtprecioventa.Text, out precioventa))
            {
                MessageBox.Show("Precio Venta - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecioventa.Select();
                return;
            }

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in fila.Cells)
                {
                    // Asegurarse de que la celda actual sea la de idProducto
                    if (cell.OwningColumn.Name == "idProducto" &&
                        cell.Value != null &&
                        cell.Value.ToString() == txtidproducto.Text)
                    {
                        producto_existe = true;
                        break;
                    }
                }

                if (producto_existe)
                    break;
            }

            if (!producto_existe)
            {
                dataGridView1.Rows.Add(new object[]
                {
        txtidproducto.Text,
        txtproducto.Text,
        preciocompra.ToString("0.00"),
        precioventa.ToString("0.00"),
        txtcantidad.Value.ToString(),
        (txtcantidad.Value * preciocompra).ToString("0.00")
                });
                calcularTotal();
                limpiarProducto();
                txtcodproducto.Select();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    dataGridView1.Rows.RemoveAt(indice);
                    calcularTotal();
                }
            }
        }
        private void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txtcodproducto.Text = "";
            txtcodproducto.BackColor = System.Drawing.Color.White;
            txtproducto.Text = "";
            txtpreciocompra.Text = "";
            txtprecioventa.Text = "";
            txtcantidad.Value = 1;
        }
        private void calcularTotal()
        {
            decimal total = 0;

            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Verificar que no sea la fila nueva y que la celda no sea null ni vacía
                    if (!row.IsNewRow && row.Cells["SubTotal"].Value != null &&
                    decimal.TryParse(row.Cells["SubTotal"].Value.ToString(), out decimal subtotal))
                    {
                        total += subtotal;
                    }
                }
            }

            txttotalpagar.Text = total.ToString("0.00");
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Obtener el ensamblado actual
                var assembly = Assembly.GetExecutingAssembly();

                // Reemplaza el string con el nombre correcto del recurso
                using (Stream stream = assembly.GetManifestResourceStream("CapaPresentacion.Resources.deleteicon.png"))
                {
                    if (stream != null)
                    {
                        // Cargar la imagen desde el stream
                        var checkImage = Image.FromStream(stream);

                        // Dimensiones de la celda
                        int cellWidth = e.CellBounds.Width;
                        int cellHeight = e.CellBounds.Height;

                        // Dibujar la imagen en la celda ajustada completamente al tamaño de la celda
                        e.Graphics.DrawImage(checkImage, new Rectangle(e.CellBounds.Left, e.CellBounds.Top, cellWidth, cellHeight));
                    }
                }

                // Marcar el evento como manejado
                e.Handled = true;
            }
        }

        private void txtpreciocompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpreciocompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }

        }

        private void txtprecioventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtprecioventa.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            // Validación inicial (esto estaba bien)
            if (Convert.ToInt32(txtidproveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // 1. Crear el DataTable para el detalle de la compra.
            
            DataTable detalle_compra = new DataTable();
            detalle_compra.Columns.Add("IdProducto", typeof(int));
            detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
            detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_compra.Columns.Add("Cantidad", typeof(int));
            detalle_compra.Columns.Add("SubTotal", typeof(decimal));

            // 2. Llenar el DataTable recorriendo el DataGridView.
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {


                try
                {
                    detalle_compra.Rows.Add(
                    Convert.ToInt32(row.Cells["IdProducto"].Value),
                    Convert.ToDecimal(row.Cells["PrecioCompra"].Value),
                    Convert.ToDecimal(row.Cells["PrecioVenta"].Value), // El valor ya está validado
                    Convert.ToInt32(row.Cells["Cantidad"].Value),
                    Convert.ToDecimal(row.Cells["SubTotal"].Value)
                );
                }
                catch (Exception ex)
                {
                    // Código para manejar la excepción
                    // Puedes mostrar un mensaje de error, registrar la excepción, etc.
                    // Por ejemplo:
                    Console.WriteLine($"Ocurrió un error: {ex.Message}");
                }



                
            }

            // 3. Obtener el número de documento correlativo.
            // La capa de negocio nos dará el siguiente número.
            int idcorrelativo = new CN_Compra().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idcorrelativo);

            // 4. Crear y llenar el objeto Compra (el encabezado).
            Compra oCompra = new Compra()
            {
                // IMPORTANTE: Debes obtener el usuario logueado. Aquí pongo un ejemplo.
                oUsuario = new Usuario() { IdUsuario = 1 }, // Reemplazar con el ID del usuario real.
                oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(txtidproveedor.Text) },
                TipoDocumento = cbotipodocumento.SelectedItem.ToString(), // Asumiendo que tienes un ComboBox.
                NumeroDocumento = numeroDocumento,
                MontoTotal = Convert.ToDecimal(txttotalpagar.Text) // Asumiendo que tienes un TextBox para el total.
            };

            // 5. Llamar a la capa de negocio para registrar TODO.
            string mensaje = string.Empty;
            bool respuesta = new CN_Compra().Registrar(oCompra, detalle_compra, out mensaje);

            if (respuesta)
            {
                // Si todo sale bien, limpiamos el formulario.
                var result = MessageBox.Show("Número de compra generado:\n" + numeroDocumento, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtidproveedor.Text = "0";
                // Limpiar otros campos...
                dataGridView1.Rows.Clear();
                // Calcular y mostrar el nuevo total...
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
   }

