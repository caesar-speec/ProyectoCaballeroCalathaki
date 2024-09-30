namespace CapaPresentacion
{
    public partial class frmProductos : Form
    {
        public frmProductos()
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

            MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


    }
}
