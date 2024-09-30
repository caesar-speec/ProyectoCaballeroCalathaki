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
            // Llamar al método de validaciones
            if (!validacionesCampos())
            {
                return;
            }

            
            MessageBox.Show("Proveedor guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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




    }
}
