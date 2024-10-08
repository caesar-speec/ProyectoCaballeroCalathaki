﻿using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;
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

            // Limpia el contenedor y agrega el formulario
            Contenedor.Controls.Clear();
            Contenedor.Controls.Add(formulario);
            formulario.BringToFront();
            formulario.Show();
        }





        private void MenuProvedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());
        }



        private void MenuReportes_Click(object sender, EventArgs e)
        {

        }



        private void submenuregistrarventa_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new frmVentas());
        }
        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new frmDetalleVenta());
        }



        private void MenuReponedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmUsuario());

        }



        private void submenuAgregarClientes_Click(object sender, EventArgs e)
        {

        }
        private void SubmenuModificarClientes_Click(object sender, EventArgs e)
        {

        }



        private void submenucategoria_Click_1(object sender, EventArgs e)
        {

        }
        private void submenuproducto_Click(object sender, EventArgs e)
        {
            //AbrirFormulario(menumantenedor, new frmProductos());
        }



        private void menumantenedor_Click(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void ReportesCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuReportes, new frmReporteCompras());
        }

        private void MenuVentas_Click(object sender, EventArgs e)
        {

        }

        private void registrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmCompras());
        }

        private void verDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmDetalleCompra());
        }

        private void menucompras_Click(object sender, EventArgs e)
        {

        }

        private void MenuReportes_Click_1(object sender, EventArgs e)
        {

        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportesVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmReporteVentas());
        }

        private void agregarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmCategoria());
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmProductos());
        }
    }
}

