using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
using System.Data;
using System.Reflection;
using System.Windows.Controls;

namespace CapaPresentacion
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }


        private void Clear()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            cbocategoria.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;

            txtcodigo.Select();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Llamar al método de validaciones
            if (!validacionesCampos())
            {
                return;
            }

            MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


            string mensaje = string.Empty;

            Producto obj = new Producto()
            {
                IdProducto = Convert.ToInt32(txtid.Text),
                Codigo = txtcodigo.Text,
                Nombre = txtnombre.Text,
                Descripcion = txtdescripcion.Text,
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)cbocategoria.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false
            };
            if (obj.IdProducto == 0)
            {
                int idgenerado = new CN_Producto().Registrar(obj, out mensaje);
                if (idgenerado != 0)
                {

                    dgvdata.Rows.Add(new object[] {
                        "",
                        idgenerado,
                        txtcodigo.Text,
                        txtnombre.Text,
                        txtdescripcion.Text,
                        ((OpcionCombo)cbocategoria.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cboestado.SelectedItem).Texto.ToString(),

                        ((OpcionCombo)cboestado.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cboestado.SelectedItem).Texto.ToString()
            });
                    Clear();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }
            else
            {
                bool resultado = new CN_Producto().Editar(obj, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Codigo"].Value = txtid.Text;
                    row.Cells["Nombre"].Value = txtnombre.Text;
                    row.Cells["Descripcion"].Value = txtdescripcion.Text;
                    row.Cells["Idcategoria"].Value = ((OpcionCombo)cbocategoria.SelectedItem).Valor.ToString();
                    row.Cells["Categoria"].Value = ((OpcionCombo)cbocategoria.SelectedItem).Texto.ToString();

                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboestado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboestado.SelectedItem).Texto.ToString();

                    Clear();

                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }




        }

        private bool validacionesCampos()
        {

            if (string.IsNullOrWhiteSpace(txtcodigo.Text) || !txtcodigo.Text.All(char.IsDigit))
            {
                MessageBox.Show("El código debe contener solo números y no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcodigo.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtnombre.Text) || !txtnombre.Text.All(char.IsLetter))
            {
                MessageBox.Show("El nombre debe contener solo letras y no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnombre.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtdescripcion.Text))
            {
                MessageBox.Show("La descripción no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdescripcion.Focus();
                return false;
            }


            if (cbocategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona una categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbocategoria.Focus();
                return false;
            }


            if (cboestado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboestado.Focus();
                return false;
            }

            // Si todas las validaciones pasan
            return true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            List<Categoria> listacategoria = new CN_Categoria().Listar();
            foreach (Categoria item in listacategoria)
            {
                cbocategoria.Items.Add(new OpcionCombo() { Valor = item.IdCategoria, Texto = item.Descripcion });
            }
            cbocategoria.DisplayMember = "Texto";
            cbocategoria.ValueMember = "Valor";
            cbocategoria.SelectedIndex = 0;


            //Mostrar usuarios
            List<Producto> listaProducto = new CN_Producto().Listar();
            foreach (Producto item in listaProducto)
            {
                dgvdata.Rows.Add(new object[] {
                 "",
                 item.IdProducto,
                 item.Codigo,
                 item.Nombre,
                 item.Descripcion,
                 item.oCategoria.IdCategoria,
                 item.oCategoria.Descripcion,
                 item.Stock,
                 item.PrecioCompra,
                 item.PrecioVenta,
                 item.Estado == true ? 1 : 0,
                 item.Estado == true ? "Activo" : "Inactivo"
             });
            }

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Obtener el ensamblado actual
                var assembly = Assembly.GetExecutingAssembly();

                // Reemplaza el string con el nombre correcto del recurso
                using (Stream stream = assembly.GetManifestResourceStream("CapaPresentacion.Resources.checkicon2"))
                {
                    if (stream != null)
                    {
                        // Cargar la imagen desde el stream
                        // var checkImage = Image.FromStream(stream);

                        // Dimensiones de la celda
                        int cellWidth = e.CellBounds.Width;
                        int cellHeight = e.CellBounds.Height;

                        // Dibujar la imagen en la celda ajustada completamente al tamaño de la celda
                        //e.Graphics.DrawImage(checkImage, new Rectangle(e.CellBounds.Left, e.CellBounds.Top, cellWidth, cellHeight));
                    }
                }

                // Marcar el evento como manejado
                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();

                    txtcodigo.Text = dgvdata.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtnombre.Text = dgvdata.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtdescripcion.Text = dgvdata.Rows[indice].Cells["Descripcion"].Value.ToString();

                    foreach (OpcionCombo oc in cbocategoria.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdCategoria"].Value))
                        {
                            int indice_combo = cbocategoria.Items.IndexOf(oc);
                            cbocategoria.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                    foreach (OpcionCombo oc in cboestado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboestado.Items.IndexOf(oc);
                            cboestado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Quiere eliminar el producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Producto obj = new Producto()
                    {
                        IdProducto = Convert.ToInt32(txtid.Text)
                    };
                    bool respuesta = new CN_Producto().Eliminar(obj, out mensaje);
                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Crear y definir las columnas del DataTable manualmente
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Columns.Add("IdCategoria", typeof(string));
            dt.Columns.Add("Categoria", typeof(string));
            dt.Columns.Add("Stock", typeof(string));
            dt.Columns.Add("PrecioCompra", typeof(string));
            dt.Columns.Add("PrecioVenta", typeof(string));
            dt.Columns.Add("EstadoValor", typeof(string));
            dt.Columns.Add("Estado", typeof(string));

            // Agregar filas
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                if (row.Visible)
                {
                    dt.Rows.Add(new object[]
                    {
                row.Cells["Id"].Value?.ToString() ?? "",
                row.Cells["Nombre"].Value?.ToString() ?? "",
                row.Cells["Descripcion"].Value?.ToString() ?? "",
                row.Cells["IdCategoria"].Value?.ToString() ?? "",
                row.Cells["Categoria"].Value?.ToString() ?? "",
                row.Cells["Stock"].Value?.ToString() ?? "",
                row.Cells["PrecioCompra"].Value?.ToString() ?? "",
                row.Cells["PrecioVenta"].Value?.ToString() ?? "",
                row.Cells["EstadoValor"].Value?.ToString() ?? "",
                row.Cells["Estado"].Value?.ToString() ?? ""
                    });
                }
            }

            // Guardar el archivo
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("ReporteProducto_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
            savefile.Filter = "Excel Files | *.xlsx";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XLWorkbook wb = new XLWorkbook();
                    var hoja = wb.Worksheets.Add(dt, "Informe");
                    hoja.ColumnsUsed().AdjustToContents();
                    wb.SaveAs(savefile.FileName);
                    MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }





    }
}
