using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

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

            // Llamar al método de validaciones antes de continuar
            if (!validacionesCampos())
            {
                return;
            }
            MessageBox.Show("Datos guardados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);




            string mensaje = string.Empty;
            Cliente obj = new Cliente()
            {
                IdCliente = Convert.ToInt32(txtid.Text),
                Documento = txtcorreo.Text,
                NombreCompleto = txtnombrecompleto.Text,
                Correo = txtcorreo.Text,
                Telefono = txttelefono.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false
            };
            if (obj.IdCliente == 0)
            {
                int idgenerado = new CN_Cliente().Registrar(obj, out mensaje);
                if (idgenerado != 0)
                {

                    dgvdata.Rows.Add(new object[] {"",idgenerado,txtdocumento.Text, txtnombrecompleto.Text, txtcorreo.Text, txttelefono.Text,
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
                bool resultado = new CN_Cliente().Editar(obj, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Documento"].Value = txtdocumento.Text;
                    row.Cells["NombreCompleto"].Value = txtnombrecompleto.Text;
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


            if (cboestado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboestado.Focus();
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

            List<Rol> listaRol = new CN_Rol().Listar();


            //Mostrar usuarios
            List<Cliente> lista= new CN_Cliente().Listar();
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
    }
}
