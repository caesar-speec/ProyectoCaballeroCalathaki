using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmCompras : Form
    {
        private Usuario _Usuario;
        private string _DireccionProveedor = ""; // Variable para guardar la dirección

        // Plantilla HTML para Compra
        string PlantillaHtml = @"
        <html>
            <head>
                <style>
                    table.border { border-collapse: collapse; width: 100%; }
                    table.border th { padding: 5px; border: 1px solid black; background-color: #D3D3D3; }
                    table.border td { padding: 5px; border: 1px solid black; }
                </style>
            </head>
            <body>
                <table border='0' style='width:100%'>
                    <tr>
                        <td style='width:100%'>
                            <table border='0' style='width:100%'>
                                <tr>
                                    <td align='center' valign='top'>
                                        <h2>ORDEN DE COMPRA</h2>
                                        <h3>P&A Plantas S.A.</h3>
                                        <span>Junin 980, Corrientes</span><br>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td align='center'>
                            <br>
                            <strong>@tipodocumento</strong><br>
                            <strong>Nro: @numerodocumento</strong><br>
                            Fecha: @fecharegistro
                        </td>
                    </tr>
                </table>
                <br>
                <table border='0' style='width:100%'>
                    <tr>
                        <td><strong>Proveedor:</strong> @nombreproveedor</td>
                        <td><strong>RUC/DNI:</strong> @docproveedor</td>
                    </tr>
                    <tr>
                        <td colspan='2'><strong>Dirección:</strong> @direcproveedor</td>
                    </tr>
                </table>
                <br>
                <table class='border'>
                    <thead>
                        <tr>
                            <th>Producto</th>
                            <th>Precio Compra</th>
                            <th>Cantidad</th>
                            <th>Total</th>
                        </tr>
                    </thead>
                    <tbody>
                        @filas
                    </tbody>
                </table>
                <br>
                <table border='0' style='width:100%'>
                    <tr>
                        <td align='right'><strong>Monto Total:</strong> @montototal</td>
                    </tr>
                </table>
            </body>
        </html>";

        public frmCompras(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
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

                    // Capturar dirección (manejando nulos)
                    _DireccionProveedor = modal._Proveedor.Domicilio != null ? modal._Proveedor.Domicilio : "";
                }
                else
                {
                    txtdocproveedor.Select();
                }
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
            if (string.IsNullOrWhiteSpace(txtidproducto.Text) || txtidproducto.Text == "0")
            {
                MessageBox.Show("Debe seleccionar un producto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtcantidad.Value == 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtcantidad.Select();
                return;
            }

            if (!decimal.TryParse(txtpreciocompra.Text, out decimal preciocompra))
            {
                MessageBox.Show("Precio de compra con formato incorrecto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpreciocompra.Select();
                return;
            }

            if (!decimal.TryParse(txtprecioventa.Text, out decimal precioventa))
            {
                MessageBox.Show("Precio de venta con formato incorrecto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecioventa.Select();
                return;
            }

            bool productoExiste = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Any(fila => fila.Cells["idProducto"].Value?.ToString() == txtidproducto.Text);

            if (productoExiste)
            {
                MessageBox.Show("El producto ya fue agregado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGridView1.Rows.Add(
                txtidproducto.Text,
                txtproducto.Text,
                preciocompra.ToString("0.00"),
                precioventa.ToString("0.00"),
                txtcantidad.Value.ToString(),
                (txtcantidad.Value * preciocompra).ToString("0.00")
            );

            calcularTotal();
            limpiarProducto();
            txtcodproducto.Select();
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
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dataGridView1.Columns["btnEliminar"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var icon = Properties.Resources.deleteicono;
                if (icon != null)
                {
                    int iconSize = (int)(e.CellBounds.Height * 0.6);
                    int x = e.CellBounds.Left + (e.CellBounds.Width - iconSize) / 2;
                    int y = e.CellBounds.Top + (e.CellBounds.Height - iconSize) / 2;
                    e.Graphics.DrawImage(icon, new Rectangle(x, y, iconSize, iconSize));
                }
                e.Handled = true;
            }
        }

        private void txtpreciocompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else
            {
                if (txtpreciocompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".") { e.Handled = true; }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".") { e.Handled = false; }
                    else { e.Handled = true; }
                }
            }
        }

        private void txtprecioventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else
            {
                if (txtprecioventa.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".") { e.Handled = true; }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".") { e.Handled = false; }
                    else { e.Handled = true; }
                }
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
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

            DataTable detalle_compra = new DataTable();
            detalle_compra.Columns.Add("IdProducto", typeof(int));
            detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
            detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_compra.Columns.Add("Cantidad", typeof(int));
            detalle_compra.Columns.Add("MontoTotal", typeof(decimal));

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                detalle_compra.Rows.Add(new object[]
                {
                    Convert.ToInt32(row.Cells["IdProducto"].Value.ToString()),
                    row.Cells["PrecioCompra"].Value.ToString(),
                    row.Cells["PrecioVenta"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString()
                });
            }

            int idcorrelativo = new CN_Compra().ObtenerCorrelativo();
            String numeroDocumento = String.Format("{0:00000}", idcorrelativo);

            Compra oCompra = new Compra()
            {
                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(txtidproveedor.Text) },
                TipoDocumento = ((OpcionCombo)cbotipodocumento.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                MontoTotal = Convert.ToDecimal(txttotalpagar.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Compra().Registrar(oCompra, detalle_compra, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de compra generado:\n" + numeroDocumento + "\n\nDesea imprimir el comprobante?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    string Texto_Html = PlantillaHtml;

                    Texto_Html = Texto_Html.Replace("@tipodocumento", oCompra.TipoDocumento.ToUpper());
                    Texto_Html = Texto_Html.Replace("@numerodocumento", oCompra.NumeroDocumento);
                    Texto_Html = Texto_Html.Replace("@fecharegistro", DateTime.Now.ToString("dd/MM/yyyy"));

                    Texto_Html = Texto_Html.Replace("@nombreproveedor", txtnombreproveedor.Text);
                    Texto_Html = Texto_Html.Replace("@docproveedor", txtdocproveedor.Text);
                    Texto_Html = Texto_Html.Replace("@direcproveedor", _DireccionProveedor); // Usamos la dirección capturada

                    string filas = string.Empty;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        filas += "<tr>";
                        filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["PrecioCompra"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                        filas += "</tr>";
                    }
                    Texto_Html = Texto_Html.Replace("@filas", filas);
                    Texto_Html = Texto_Html.Replace("@montototal", txttotalpagar.Text);

                    mdComprobante modal = new mdComprobante(Texto_Html);
                    modal.ShowDialog();
                }
                else
                {
                    // Si no imprime, ofrecer copiar al portapapeles (opcional)
                    MessageBox.Show("Compra registrada exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                txtidproveedor.Text = "0";
                txtdocproveedor.Text = "";
                txtnombreproveedor.Text = "";
                _DireccionProveedor = "";
                dataGridView1.Rows.Clear();
                calcularTotal();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Eventos vacíos
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
    }
}