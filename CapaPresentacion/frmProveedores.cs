using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Reflection;

namespace CapaPresentacion
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            // Llamar al método de validaciones antes de continuar
            if (!validacionesCampos())
            {
                return;
            }
            MessageBox.Show("Datos guardados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);




            string mensaje = string.Empty;
            Proveedor obj = new Proveedor()
            {
                IdProveedor = Convert.ToInt32(txtid.Text),
                Documento = txtdocumento.Text,
                RazonSocial = txtrazonsocial.Text,
                Correo = txtcorreo.Text,
                Telefono = txttelefono.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false
            };
            if (obj.IdProveedor == 0)
            {
                int idgenerado = new CN_Proveedor().Registrar(obj, out mensaje);
                if (idgenerado != 0)
                {

                    dgvdata.Rows.Add(new object[] {"",idgenerado,txtdocumento.Text, txtrazonsocial.Text, txtcorreo.Text, txttelefono.Text,
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
                bool Resultado = new CN_Proveedor().Editar(obj, out mensaje);
                if (Resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Documento"].Value = txtdocumento.Text;
                    row.Cells["RazonSocial"].Value = txtrazonsocial.Text;
                    row.Cells["Correo"].Value = txtcorreo.Text;
                    row.Cells["Telefono"].Value = txttelefono.Text;
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
        private void Clear()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtdocumento.Text = "";
            txtrazonsocial.Text = "";
            txtcorreo.Text = "";
            txttelefono.Text = "";
            cboestado.SelectedIndex = 0;
        }

        private bool validacionesCampos()
        {

            if (string.IsNullOrWhiteSpace(txtdocumento.Text) || !txtdocumento.Text.All(char.IsDigit))
            {
                MessageBox.Show("El documento debe contener solo números y no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdocumento.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtrazonsocial.Text) || !txtrazonsocial.Text.All(char.IsLetter))
            {
                MessageBox.Show("La razón social debe contener solo letras y no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtrazonsocial.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtcorreo.Text) || !IsValidEmail(txtcorreo.Text))
            {
                MessageBox.Show("Por favor, ingresa un correo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcorreo.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txttelefono.Text) || !txttelefono.Text.All(char.IsDigit))
            {
                MessageBox.Show("El teléfono debe contener solo números y no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttelefono.Focus();
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


        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;



            //Mostrar usuarios
            List<Proveedor> lista = new CN_Proveedor().Listar();
            foreach (Proveedor item in lista)
            {
                dgvdata.Rows.Add(new object[] {"",item.IdProveedor,item.Documento, item.RazonSocial, item.Correo, item.Telefono,
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

        private void da(object sender, EventArgs e)
        {

        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            {
                if (e.RowIndex < 0)
                    return;

                if (e.ColumnIndex == 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    // Obtener el ensamblado actual
                    var assembly = Assembly.GetExecutingAssembly();

                    // Reemplaza el string con el nombre correcto del recurso
                    using (Stream stream = assembly.GetManifestResourceStream("CapaPresentacion.Resources.check.png"))
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
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Quiere eliminar el Proveedor?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Proveedor obj = new Proveedor()
                    {
                        IdProveedor = Convert.ToInt32(txtid.Text)
                    };
                    bool respuesta = new CN_Proveedor().Eliminar(obj, out mensaje);
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

        private void dgvdata_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            {
                if (e.RowIndex < 0)
                    return;

                if (e.ColumnIndex == 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    // Obtener el ensamblado actual
                    var assembly = Assembly.GetExecutingAssembly();

                    // Reemplaza el string con el nombre correcto del recurso
                    using (Stream stream = assembly.GetManifestResourceStream("CapaPresentacion.Resources.check.png"))
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
                    txtdocumento.Text = dgvdata.Rows[indice].Cells["Documento"].Value.ToString();
                    txtrazonsocial.Text = dgvdata.Rows[indice].Cells["RazonSocial"].Value.ToString();
                    txtcorreo.Text = dgvdata.Rows[indice].Cells["Correo"].Value.ToString();
                    txttelefono.Text = dgvdata.Rows[indice].Cells["Telefono"].Value.ToString();
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
    }
}
