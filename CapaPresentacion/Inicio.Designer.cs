namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Menu2 = new MenuStrip();
            MenuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            MenuProvedores = new FontAwesome.Sharp.IconMenuItem();
            MenuProductos = new FontAwesome.Sharp.IconMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            agregarCategoriaToolStripMenuItem = new ToolStripMenuItem();
            clientesAdmin = new FontAwesome.Sharp.IconMenuItem();
            MenuClientes = new FontAwesome.Sharp.IconMenuItem();
            menucompras = new FontAwesome.Sharp.IconMenuItem();
            registrarCompraToolStripMenuItem = new ToolStripMenuItem();
            verMisComprasToolStripMenuItem = new ToolStripMenuItem();
            MenuVentas = new FontAwesome.Sharp.IconMenuItem();
            submenuregistrarventa = new ToolStripMenuItem();
            submenuverdetalleventa = new ToolStripMenuItem();
            verMisVentasToolStripMenuItem = new ToolStripMenuItem();
            submenuVerProductos = new ToolStripMenuItem();
            MenuReportes = new FontAwesome.Sharp.IconMenuItem();
            ReportesCompras = new ToolStripMenuItem();
            reportesVentasToolStripMenuItem = new ToolStripMenuItem();
            ReporteEstadistico = new ToolStripMenuItem();
            menuBackup = new FontAwesome.Sharp.IconMenuItem();
            menutitulo = new Panel();
            label2 = new Label();
            lblusuario = new Label();
            label1 = new Label();
            Contenedor = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Menu2.SuspendLayout();
            menutitulo.SuspendLayout();
            Contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Menu2
            // 
            Menu2.BackColor = Color.WhiteSmoke;
            Menu2.ImageScalingSize = new Size(20, 20);
            Menu2.Items.AddRange(new ToolStripItem[] { MenuUsuarios, MenuProvedores, MenuProductos, clientesAdmin, MenuClientes, menucompras, MenuVentas, MenuReportes, menuBackup });
            Menu2.Location = new Point(0, 85);
            Menu2.Name = "Menu2";
            Menu2.Size = new Size(1347, 83);
            Menu2.TabIndex = 0;
            Menu2.Text = "menuStrip1";
            // 
            // MenuUsuarios
            // 
            MenuUsuarios.AutoSize = false;
            MenuUsuarios.ForeColor = Color.Black;
            MenuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            MenuUsuarios.IconColor = Color.Black;
            MenuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuUsuarios.IconSize = 50;
            MenuUsuarios.ImageScaling = ToolStripItemImageScaling.None;
            MenuUsuarios.Name = "MenuUsuarios";
            MenuUsuarios.Size = new Size(80, 79);
            MenuUsuarios.Text = "Usuarios";
            MenuUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuUsuarios.Click += MenuReponedor_Click;
            // 
            // MenuProvedores
            // 
            MenuProvedores.AutoSize = false;
            MenuProvedores.ForeColor = Color.Black;
            MenuProvedores.IconChar = FontAwesome.Sharp.IconChar.Truck;
            MenuProvedores.IconColor = Color.Black;
            MenuProvedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuProvedores.IconSize = 50;
            MenuProvedores.ImageScaling = ToolStripItemImageScaling.None;
            MenuProvedores.Name = "MenuProvedores";
            MenuProvedores.Size = new Size(100, 79);
            MenuProvedores.Text = "Proveedores";
            MenuProvedores.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuProvedores.Click += MenuProvedores_Click;
            // 
            // MenuProductos
            // 
            MenuProductos.AutoSize = false;
            MenuProductos.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem, agregarCategoriaToolStripMenuItem });
            MenuProductos.ForeColor = Color.Black;
            MenuProductos.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            MenuProductos.IconColor = Color.Black;
            MenuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuProductos.IconSize = 50;
            MenuProductos.ImageScaling = ToolStripItemImageScaling.None;
            MenuProductos.Name = "MenuProductos";
            MenuProductos.Size = new Size(90, 79);
            MenuProductos.Text = "Productos";
            MenuProductos.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(163, 26);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // agregarCategoriaToolStripMenuItem
            // 
            agregarCategoriaToolStripMenuItem.Name = "agregarCategoriaToolStripMenuItem";
            agregarCategoriaToolStripMenuItem.Size = new Size(163, 26);
            agregarCategoriaToolStripMenuItem.Text = "Categorías";
            agregarCategoriaToolStripMenuItem.Click += agregarCategoriaToolStripMenuItem_Click;
            // 
            // clientesAdmin
            // 
            clientesAdmin.AutoSize = false;
            clientesAdmin.ForeColor = Color.Black;
            clientesAdmin.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            clientesAdmin.IconColor = Color.Black;
            clientesAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            clientesAdmin.IconSize = 50;
            clientesAdmin.ImageScaling = ToolStripItemImageScaling.None;
            clientesAdmin.Name = "clientesAdmin";
            clientesAdmin.Size = new Size(125, 79);
            clientesAdmin.Text = "Clientes (Admin)";
            clientesAdmin.TextImageRelation = TextImageRelation.ImageAboveText;
            clientesAdmin.Click += clientesAdmin_Click;
            // 
            // MenuClientes
            // 
            MenuClientes.AutoSize = false;
            MenuClientes.ForeColor = Color.Black;
            MenuClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            MenuClientes.IconColor = Color.Black;
            MenuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuClientes.IconSize = 50;
            MenuClientes.ImageScaling = ToolStripItemImageScaling.None;
            MenuClientes.Name = "MenuClientes";
            MenuClientes.Size = new Size(80, 79);
            MenuClientes.Text = "Clientes";
            MenuClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuClientes.Click += MenuClientes_Click;
            // 
            // menucompras
            // 
            menucompras.AutoSize = false;
            menucompras.DropDownItems.AddRange(new ToolStripItem[] { registrarCompraToolStripMenuItem, verMisComprasToolStripMenuItem });
            menucompras.ForeColor = Color.Black;
            menucompras.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            menucompras.IconColor = Color.Black;
            menucompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menucompras.IconSize = 50;
            menucompras.ImageScaling = ToolStripItemImageScaling.None;
            menucompras.Name = "menucompras";
            menucompras.Size = new Size(90, 79);
            menucompras.Text = "Compras";
            menucompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // registrarCompraToolStripMenuItem
            // 
            registrarCompraToolStripMenuItem.Name = "registrarCompraToolStripMenuItem";
            registrarCompraToolStripMenuItem.Size = new Size(201, 26);
            registrarCompraToolStripMenuItem.Text = "Registrar";
            registrarCompraToolStripMenuItem.Click += registrarCompraToolStripMenuItem_Click;
            // 
            // verMisComprasToolStripMenuItem
            // 
            verMisComprasToolStripMenuItem.Name = "verMisComprasToolStripMenuItem";
            verMisComprasToolStripMenuItem.Size = new Size(201, 26);
            verMisComprasToolStripMenuItem.Text = "Ver mis compras";
            verMisComprasToolStripMenuItem.Click += verMisComprasToolStripMenuItem_Click;
            // 
            // MenuVentas
            // 
            MenuVentas.AutoSize = false;
            MenuVentas.DropDownItems.AddRange(new ToolStripItem[] { submenuregistrarventa, submenuverdetalleventa, verMisVentasToolStripMenuItem, submenuVerProductos });
            MenuVentas.ForeColor = Color.Black;
            MenuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            MenuVentas.IconColor = Color.Black;
            MenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuVentas.IconSize = 50;
            MenuVentas.ImageScaling = ToolStripItemImageScaling.None;
            MenuVentas.Name = "MenuVentas";
            MenuVentas.Size = new Size(90, 79);
            MenuVentas.Text = "Ventas";
            MenuVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenuregistrarventa
            // 
            submenuregistrarventa.Name = "submenuregistrarventa";
            submenuregistrarventa.Size = new Size(186, 26);
            submenuregistrarventa.Text = "Registrar";
            submenuregistrarventa.Click += submenuregistrarventa_Click_1;
            // 
            // submenuverdetalleventa
            // 
            submenuverdetalleventa.Name = "submenuverdetalleventa";
            submenuverdetalleventa.Size = new Size(186, 26);
            submenuverdetalleventa.Text = "Ver Detalle";
            submenuverdetalleventa.Visible = false;
            submenuverdetalleventa.Click += submenuverdetalleventa_Click;
            // 
            // verMisVentasToolStripMenuItem
            // 
            verMisVentasToolStripMenuItem.Name = "verMisVentasToolStripMenuItem";
            verMisVentasToolStripMenuItem.Size = new Size(186, 26);
            verMisVentasToolStripMenuItem.Text = "Ver mis ventas";
            verMisVentasToolStripMenuItem.Click += verMisVentasToolStripMenuItem_Click;
            // 
            // submenuVerProductos
            // 
            submenuVerProductos.Name = "submenuVerProductos";
            submenuVerProductos.Size = new Size(186, 26);
            submenuVerProductos.Text = "Ver Productos";
            submenuVerProductos.Click += verProductosToolStripMenuItem_Click;
            // 
            // MenuReportes
            // 
            MenuReportes.AutoSize = false;
            MenuReportes.DropDownItems.AddRange(new ToolStripItem[] { ReportesCompras, reportesVentasToolStripMenuItem, ReporteEstadistico });
            MenuReportes.ForeColor = Color.Black;
            MenuReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            MenuReportes.IconColor = Color.Black;
            MenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuReportes.IconSize = 50;
            MenuReportes.ImageScaling = ToolStripItemImageScaling.None;
            MenuReportes.Name = "MenuReportes";
            MenuReportes.Size = new Size(90, 79);
            MenuReportes.Text = "Reportes";
            MenuReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // ReportesCompras
            // 
            ReportesCompras.Name = "ReportesCompras";
            ReportesCompras.Size = new Size(220, 26);
            ReportesCompras.Text = "Reportes Compras";
            ReportesCompras.Click += ReportesCompras_Click;
            // 
            // reportesVentasToolStripMenuItem
            // 
            reportesVentasToolStripMenuItem.Name = "reportesVentasToolStripMenuItem";
            reportesVentasToolStripMenuItem.Size = new Size(220, 26);
            reportesVentasToolStripMenuItem.Text = "Reportes Ventas";
            reportesVentasToolStripMenuItem.Click += reportesVentasToolStripMenuItem_Click;
            // 
            // ReporteEstadistico
            // 
            ReporteEstadistico.Name = "ReporteEstadistico";
            ReporteEstadistico.Size = new Size(220, 26);
            ReporteEstadistico.Text = "Reporte Estadistico";
            ReporteEstadistico.Click += ReporteEstadistico_Click;
            // 
            // menuBackup
            // 
            menuBackup.AutoSize = false;
            menuBackup.ForeColor = Color.Black;
            menuBackup.IconChar = FontAwesome.Sharp.IconChar.Database;
            menuBackup.IconColor = Color.Black;
            menuBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuBackup.IconSize = 50;
            menuBackup.ImageScaling = ToolStripItemImageScaling.None;
            menuBackup.Name = "menuBackup";
            menuBackup.Size = new Size(80, 79);
            menuBackup.Text = "Back-Up";
            menuBackup.TextImageRelation = TextImageRelation.ImageAboveText;
            menuBackup.Click += menuBackup_Click;
            // 
            // menutitulo
            // 
            menutitulo.BackColor = Color.DarkOliveGreen;
            menutitulo.Controls.Add(pictureBox2);
            menutitulo.Controls.Add(label2);
            menutitulo.Controls.Add(lblusuario);
            menutitulo.Controls.Add(label1);
            menutitulo.Dock = DockStyle.Top;
            menutitulo.Location = new Point(0, 0);
            menutitulo.Name = "menutitulo";
            menutitulo.Size = new Size(1347, 85);
            menutitulo.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1100, 20);
            label2.Name = "label2";
            label2.Size = new Size(104, 23);
            label2.TabIndex = 1;
            label2.Text = "Bienvenido:";
            // 
            // lblusuario
            // 
            lblusuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblusuario.AutoSize = true;
            lblusuario.BackColor = Color.Transparent;
            lblusuario.Font = new Font("Segoe UI", 10F);
            lblusuario.ForeColor = Color.White;
            lblusuario.Location = new Point(1100, 45);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(68, 23);
            lblusuario.TabIndex = 0;
            lblusuario.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 16);
            label1.Name = "label1";
            label1.Size = new Size(259, 54);
            label1.TabIndex = 2;
            label1.Text = "P&&A Plantas";
            // 
            // Contenedor
            // 
            Contenedor.BackColor = Color.DarkSeaGreen;
            Contenedor.Controls.Add(pictureBox1);
            Contenedor.Dock = DockStyle.Fill;
            Contenedor.ForeColor = Color.Black;
            Contenedor.Location = new Point(0, 168);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(1347, 612);
            Contenedor.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Resource1.iconoplantita;
            pictureBox1.Location = new Point(532, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 266);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Resource1.iconoplantita;
            pictureBox2.Location = new Point(275, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 73);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1347, 780);
            Controls.Add(Contenedor);
            Controls.Add(Menu2);
            Controls.Add(menutitulo);
            MainMenuStrip = Menu2;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Ventas - Jardinería";
            Load += Inicio_Load;
            Menu2.ResumeLayout(false);
            Menu2.PerformLayout();
            menutitulo.ResumeLayout(false);
            menutitulo.PerformLayout();
            Contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu2;
        private System.Windows.Forms.Panel menutitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem MenuClientes;
        private FontAwesome.Sharp.IconMenuItem MenuProvedores;
        private FontAwesome.Sharp.IconMenuItem MenuReportes;
        private FontAwesome.Sharp.IconMenuItem MenuVentas;
        private FontAwesome.Sharp.IconMenuItem MenuUsuarios;
        private System.Windows.Forms.Panel Contenedor;
        private FontAwesome.Sharp.IconMenuItem MenuProductos;
        private System.Windows.Forms.ToolStripMenuItem submenuregistrarventa;
        private System.Windows.Forms.ToolStripMenuItem submenuverdetalleventa;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.ToolStripMenuItem ReportesCompras;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private System.Windows.Forms.ToolStripMenuItem registrarCompraToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem reportesVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCategoriaToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem menuBackup;
        private System.Windows.Forms.ToolStripMenuItem ReporteEstadistico;
        private System.Windows.Forms.ToolStripMenuItem verMisVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMisComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submenuVerProductos;
        private FontAwesome.Sharp.IconMenuItem clientesAdmin;
        private PictureBox pictureBox2;
    }
}