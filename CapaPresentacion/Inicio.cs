using CapaEntidad;
namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
    private static Usuario usuarioActual; 
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

        }
    }
}
