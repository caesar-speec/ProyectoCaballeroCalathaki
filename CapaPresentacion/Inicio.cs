using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        // CAMPOS
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form formularioActivo = null;

        
        public Inicio(Usuario objusuario)
        {
            usuarioActual = objusuario;
            InitializeComponent();
        }

        // CARGA DEL FORMULARIO Y PERMISOS
        private void Inicio_Load(object sender, EventArgs e)
        {
            // 1. Mostrar Usuario
            lblusuario.Text = usuarioActual.NombreCompleto;

            // 2. Obtener Permisos
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);

            // 3. Filtrar Menús por Permisos
            foreach (IconMenuItem iconmenu in Menu2.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconmenu.Name);
                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }
            }

            // 4. Seguridad Extra (Hardcoded para Admin)
            // Backup solo para ID 1
            menuBackup.Visible = (usuarioActual.IdUsuario == 1);
            // Gestión Clientes solo para Rol Admin (1)
            clientesAdmin.Visible = (usuarioActual.oRol.IdRol == 1);
        }

        // METODO PRINCIPAL PARA ABRIR FORMULARIOS
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            // Resaltar menú activo
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            if (menu != null)
            {
                menu.BackColor = Color.Silver;
                MenuActivo = menu;
            }

            // Cerrar formulario anterior
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            // Configurar y mostrar nuevo formulario
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.DarkSeaGreen;

            // IMPORTANTE: Esto agrega el formulario al panel contenedor
            // El pictureBox1 quedará detrás del formulario, lo cual es correcto
            Contenedor.Controls.Add(formulario);
            formulario.BringToFront();
            formulario.Show();
        }

        // --------------------------------------
        // EVENTOS DE MENÚS
        // --------------------------------------

        // --- USUARIOS ---
        private void MenuReponedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmUsuario());
        }

        // --- PROVEEDORES ---
        private void MenuProvedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());
        }

        // --- PRODUCTOS ---
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuProductos, new frmProductos());
        }
        private void agregarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuProductos, new frmCategoria());
        }

        // --- CLIENTES ---
        private void MenuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes()); // Clientes vista estándar
        }
        private void clientesAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmListarClientes()); // Clientes vista admin (baja lógica)
        }

        // --- COMPRAS ---
        private void registrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmCompras(usuarioActual));
        }
        private void verMisComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmVerMisCompras(usuarioActual));
        }

        // --- VENTAS ---
        private void submenuregistrarventa_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new frmVentas(usuarioActual));
        }
        private void verMisVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new FrmVerMisVentas(usuarioActual));
        }
        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new frmListadoProductos());
        }
        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new frmDetalleVenta());
        }

        // --- REPORTES ---
        private void ReportesCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuReportes, new frmReporteCompras());
        }
        private void reportesVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuReportes, new frmListarVentas());
        }
        private void ReporteEstadistico_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuReportes, new FrmReportesEstadisticos());
        }

        // --- BACKUP ---
        private void menuBackup_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmBackup());
        }
    }
}