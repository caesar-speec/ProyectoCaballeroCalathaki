using FontAwesome.Sharp;
using CapaEntidad;
using CapaNegocio;
using System.Text;
namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form formularioActivo = null;
        public Inicio(Usuario objusuario)
        {
            usuarioActual = objusuario;

            InitializeComponent();
        }

        private void MenuTitulo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);
            foreach (IconMenuItem iconmenu in Menu2.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconmenu.Name);
                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }
                lblusuario.Text = usuarioActual.NombreCompleto;
            }
        }
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;
            Contenedor.Controls.Add(formulario);
            formulario.Show();
        }



        private void menuusuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmUsuario());
        }

        private void submenucategoria_Click(object sender, EventArgs e)
        {
            //AbrirFormulario((menumantenedor, new frmCategoria());
        }
        private void submenuproducto_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(menumantenedor, new frmproducto());
        }
        private void submenuregistrarventa_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(MenuVentas, new frmventas());
        }

        private void menumantenedor_Click(object sender, EventArgs e)
        {

        }

        private void MenuReponedor_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
