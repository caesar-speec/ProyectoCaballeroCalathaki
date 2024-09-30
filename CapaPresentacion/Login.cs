using CapaEntidad;
using CapaNegocio;
using System.Data;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
            Inicio form = new Inicio(ousuario);
            form.Show();
            this.Hide();
            form.FormClosing += frm_closing;
        }


        private void frm_closing(object sender, FormClosingEventArgs e)
        {


            this.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Tdni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
