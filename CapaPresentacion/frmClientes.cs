using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace CapaPresentacion
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Mensaje de confirmación
            MessageBox.Show("Datos guardados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string mensaje = string.Empty;

            Cliente obj = new Cliente()
            {
                IdCliente = Convert.ToInt32(txtid.Text),
                Documento = txtdocumento.Text,
                NombreCompleto = txtnombrecompleto.Text,
                Correo = txtcorreo.Text,
                Telefono = txttelefono.Text,
                Estado = true // Siempre activo por defecto
            };

            if (obj.IdCliente == 0)
            {
                int idgenerado = new CN_Cliente().Registrar(obj, out mensaje);
                if (idgenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] {
                "",
                idgenerado,
                txtdocumento.Text,
                txtnombrecompleto.Text,
                txtcorreo.Text,
                txttelefono.Text,
                1,              // EstadoValor = 1 (activo)
                "Activo"        // Estado texto fijo
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
                bool resultado = new CN_Cliente().Editar(obj, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Documento"].Value = txtdocumento.Text;
                    row.Cells["NombreCompleto"].Value = txtnombrecompleto.Text;
                    row.Cells["Correo"].Value = txtcorreo.Text;
                    row.Cells["Telefono"].Value = txttelefono.Text;
                    row.Cells["EstadoValor"].Value = 1;       // Activo
                    row.Cells["Estado"].Value = "Activo";     // Texto

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

            if (string.IsNullOrWhiteSpace(txtdocumento.Text) || !txtdocumento.Text.All(char.IsDigit))
            {
                MessageBox.Show("El documento debe contener solo números y no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdocumento.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtnombrecompleto.Text) || !txtnombrecompleto.Text.All(char.IsLetter))
            {
                MessageBox.Show("El nombre completo debe contener solo letras y no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnombrecompleto.Focus();
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


            return true;
        }
        private void Clear()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtdocumento.Text = "";
            txtnombrecompleto.Text = "";
            txtcorreo.Text = "";
            txttelefono.Text = "";
            cboestado.SelectedIndex = 0;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;


            //Mostrar usuarios
            List<Cliente> lista = new CN_Cliente().Listar();
            foreach (Cliente item in lista)
            {
                dgvdata.Rows.Add(new object[] {"",item.IdCliente,item.Documento, item.NombreCompleto, item.Correo, item.Telefono,
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
                    using (Stream stream = assembly.GetManifestResourceStream("CapaPresentacion.Resources.checkicon.png"))
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
                    txtnombrecompleto.Text = dgvdata.Rows[indice].Cells["NombreCompleto"].Value.ToString();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Quiere eliminar el cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Cliente obj = new Cliente()
                    {
                        IdCliente = Convert.ToInt32(txtid.Text)
                    };
                    bool respuesta = new CN_Cliente().Eliminar(obj, out mensaje);
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

        private void txtdocumento_TextChanged(object sender, EventArgs e)
        {
            // Permitir solo números y hasta 8 caracteres
            TextBox txt = sender as TextBox;
            if (txt == null) return;

            // Eliminar cualquier caracter no numérico
            string textoLimpio = new string(txt.Text.Where(char.IsDigit).ToArray());

            // Limitar a 8 caracteres
            if (textoLimpio.Length > 8)
                textoLimpio = textoLimpio.Substring(0, 8);

            // Si cambió el texto, lo actualiza sin mover el cursor
            if (txt.Text != textoLimpio)
            {
                int pos = txt.SelectionStart;
                txt.Text = textoLimpio;
                txt.SelectionStart = Math.Min(pos, txt.Text.Length);
            }
        }



        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;

            // Validar formato de correo mientras se escribe
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (Regex.IsMatch(txt.Text, patronCorreo))
            {
                txt.BackColor = Color.LightGreen; // formato correcto
            }
            else
            {
                txt.BackColor = Color.LightCoral; // formato incorrecto
            }
        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;

            // Remove non-digit characters
            string textoLimpio = new string(txt.Text.Where(char.IsDigit).ToArray());

            // Limit to 10 characters
            if (textoLimpio.Length > 10)
                textoLimpio = textoLimpio.Substring(0, 10);

            // Update text without moving cursor unexpectedly
            if (txt.Text != textoLimpio)
            {
                int pos = txt.SelectionStart;
                txt.Text = textoLimpio;
                txt.SelectionStart = Math.Min(pos, txt.Text.Length);
            }

            // Visual feedback: valid only when exactly 10 digits
            if (textoLimpio.Length == 10)
                txt.BackColor = Color.LightGreen;
            else
                txt.BackColor = Color.LightCoral;
        }


        private void txtnombrecompleto_TextChanged(object sender, EventArgs e)
        {
           
            TextBox txt = sender as TextBox;
            if (txt == null) return;

            int selStart = txt.SelectionStart;

            // Keep only letters and space characters
            string cleaned = new string(txt.Text.Where(c => char.IsLetter(c) || c == ' ').ToArray());

            // Replace multiple spaces with a single space to normalize internal spacing
            cleaned = Regex.Replace(cleaned, @"\s{2,}", " ");

            // If text changed, update and adjust caret
            if (txt.Text != cleaned)
            {
                // Compute new selection start to avoid jumping too far left when characters removed
                int diff = txt.Text.Length - cleaned.Length;
                int newSel = Math.Max(0, selStart - Math.Max(0, diff));
                txt.Text = cleaned;
                txt.SelectionStart = Math.Min(newSel, txt.Text.Length);
            }

            // Validate: one or more letter groups separated by single spaces, no leading/trailing spaces
            bool isValid = Regex.IsMatch(cleaned, @"^[\p{L}]+(?: [\p{L}]+)*$");

            // Visual feedback: valid -> LightGreen, invalid/empty -> LightCoral
            txt.BackColor = isValid ? Color.LightGreen : Color.LightCoral;
        }



    }
}
