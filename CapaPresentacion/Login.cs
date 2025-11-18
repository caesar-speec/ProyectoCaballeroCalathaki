using CapaEntidad;
using CapaNegocio;
using System.Data;
using System; // Agregado para EventArgs
using System.Windows.Forms; // Agregado para KeyEventArgs y Keys

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // --- INICIO DE MODIFICACIÓN ---
            // Conectamos los eventos KeyDown de los TextBoxes
            // 1. Conectar el evento del TextBox DNI (Tdni)
            this.Tdni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tdni_KeyDown);

            // 2. Conectar el evento del TextBox Contraseña (Tpassword)
            this.Tpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tpassword_KeyDown);
            // --- FIN DE MODIFICACIÓN ---
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == Tdni.Text && u.Clave == Tpassword.Text).FirstOrDefault();

            if (ousuario != null)
            {
                Inicio form = new Inicio(ousuario);
                form.Show();
                this.Hide();
                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("Usuario no encontrado o datos incorrectas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {


            this.Show();
            Tdni.Text = "";
            Tpassword.Text = "";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Tdni_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


      
        private void Tdni_KeyDown(object sender, KeyEventArgs e)
        {
            // Comprueba si la tecla presionada es 'Enter'
            if (e.KeyCode == Keys.Enter)
            {
                // Mueve el foco al TextBox de la contraseña
                this.Tpassword.Select();

                // Suprime el sonido "ding" de Windows al presionar Enter
                e.SuppressKeyPress = true;
            }
        }

        
        private void Tpassword_KeyDown(object sender, KeyEventArgs e)
        {
            // Comprueba si la tecla presionada es 'Enter'
            if (e.KeyCode == Keys.Enter)
            {
                // Llama al mismo código que hace clic en el botón "Ingresar"
                btn_ingresar_Click(this, EventArgs.Empty);

                // Suprime el sonido "ding" de Windows al presionar Enter
                e.SuppressKeyPress = true;
            }
        }


    }
}