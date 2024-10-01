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
            MenuProvedores = new FontAwesome.Sharp.IconMenuItem();
            MenuReportes = new FontAwesome.Sharp.IconMenuItem();
            ReportesCompras = new ToolStripMenuItem();
            MenuVentas = new FontAwesome.Sharp.IconMenuItem();
            submenuregistrarventa = new ToolStripMenuItem();
            submenuverdetalleventa = new ToolStripMenuItem();
            MenuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            MenuClientes = new FontAwesome.Sharp.IconMenuItem();
            MenuProductos = new FontAwesome.Sharp.IconMenuItem();
            menucompras = new FontAwesome.Sharp.IconMenuItem();
            registrarCompraToolStripMenuItem = new ToolStripMenuItem();
            verDetalleToolStripMenuItem = new ToolStripMenuItem();
            MenuTitulo = new MenuStrip();
            label1 = new Label();
            panel1 = new Panel();
            Contenedor = new Panel();
            lblusuario = new Label();
            Menu2.SuspendLayout();
            Contenedor.SuspendLayout();
            SuspendLayout();
            // 
            // Menu2
            // 
            Menu2.BackColor = SystemColors.GrayText;
            Menu2.ImageScalingSize = new Size(20, 20);
            Menu2.Items.AddRange(new ToolStripItem[] { MenuProvedores, MenuReportes, MenuVentas, MenuUsuarios, MenuClientes, MenuProductos, menucompras });
            Menu2.Location = new Point(0, 57);
            Menu2.Name = "Menu2";
            Menu2.Size = new Size(765, 73);
            Menu2.TabIndex = 0;
            Menu2.Text = "menuStrip1";
            // 
            // MenuProvedores
            // 
            MenuProvedores.AutoSize = false;
            MenuProvedores.ForeColor = SystemColors.ButtonHighlight;
            MenuProvedores.IconChar = FontAwesome.Sharp.IconChar.Computer;
            MenuProvedores.IconColor = Color.WhiteSmoke;
            MenuProvedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuProvedores.IconSize = 50;
            MenuProvedores.ImageScaling = ToolStripItemImageScaling.None;
            MenuProvedores.Name = "MenuProvedores";
            MenuProvedores.Size = new Size(80, 69);
            MenuProvedores.Text = "Provedores";
            MenuProvedores.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuProvedores.Click += MenuProvedores_Click;
            // 
            // MenuReportes
            // 
            MenuReportes.AutoSize = false;
            MenuReportes.DropDownItems.AddRange(new ToolStripItem[] { ReportesCompras });
            MenuReportes.ForeColor = SystemColors.ButtonHighlight;
            MenuReportes.IconChar = FontAwesome.Sharp.IconChar.ArrowTrendUp;
            MenuReportes.IconColor = Color.WhiteSmoke;
            MenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuReportes.IconSize = 50;
            MenuReportes.ImageScaling = ToolStripItemImageScaling.None;
            MenuReportes.Name = "MenuReportes";
            MenuReportes.Size = new Size(80, 69);
            MenuReportes.Text = "Reportes";
            MenuReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuReportes.Click += MenuReportes_Click;
            // 
            // ReportesCompras
            // 
            ReportesCompras.Name = "ReportesCompras";
            ReportesCompras.Size = new Size(171, 22);
            ReportesCompras.Text = "Reportes Compras";
            ReportesCompras.Click += ReportesCompras_Click;
            // 
            // MenuVentas
            // 
            MenuVentas.AutoSize = false;
            MenuVentas.DropDownItems.AddRange(new ToolStripItem[] { submenuregistrarventa, submenuverdetalleventa });
            MenuVentas.ForeColor = SystemColors.ButtonHighlight;
            MenuVentas.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            MenuVentas.IconColor = Color.WhiteSmoke;
            MenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuVentas.IconSize = 50;
            MenuVentas.ImageScaling = ToolStripItemImageScaling.None;
            MenuVentas.Name = "MenuVentas";
            MenuVentas.Size = new Size(122, 69);
            MenuVentas.Text = "Ventas";
            MenuVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuVentas.Click += MenuVentas_Click;
            // 
            // submenuregistrarventa
            // 
            submenuregistrarventa.Name = "submenuregistrarventa";
            submenuregistrarventa.Size = new Size(129, 22);
            submenuregistrarventa.Text = "Registrar";
            submenuregistrarventa.Click += submenuregistrarventa_Click_1;
            // 
            // submenuverdetalleventa
            // 
            submenuverdetalleventa.Name = "submenuverdetalleventa";
            submenuverdetalleventa.Size = new Size(129, 22);
            submenuverdetalleventa.Text = "Ver Detalle";
            submenuverdetalleventa.Click += submenuverdetalleventa_Click;
            // 
            // MenuUsuarios
            // 
            MenuUsuarios.AutoSize = false;
            MenuUsuarios.ForeColor = SystemColors.ButtonHighlight;
            MenuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            MenuUsuarios.IconColor = Color.WhiteSmoke;
            MenuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuUsuarios.IconSize = 50;
            MenuUsuarios.ImageScaling = ToolStripItemImageScaling.None;
            MenuUsuarios.Name = "MenuUsuarios";
            MenuUsuarios.Size = new Size(80, 69);
            MenuUsuarios.Text = "Usuarios";
            MenuUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuUsuarios.Click += MenuReponedor_Click;
            // 
            // MenuClientes
            // 
            MenuClientes.AutoSize = false;
            MenuClientes.ForeColor = SystemColors.ButtonHighlight;
            MenuClientes.IconChar = FontAwesome.Sharp.IconChar.UsersBetweenLines;
            MenuClientes.IconColor = Color.WhiteSmoke;
            MenuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuClientes.IconSize = 50;
            MenuClientes.ImageScaling = ToolStripItemImageScaling.None;
            MenuClientes.Name = "MenuClientes";
            MenuClientes.Size = new Size(80, 69);
            MenuClientes.Text = "Clientes";
            MenuClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuClientes.Click += MenuClientes_Click;
            // 
            // MenuProductos
            // 
            MenuProductos.AutoSize = false;
            MenuProductos.ForeColor = SystemColors.ButtonHighlight;
            MenuProductos.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            MenuProductos.IconColor = Color.WhiteSmoke;
            MenuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuProductos.IconSize = 50;
            MenuProductos.ImageScaling = ToolStripItemImageScaling.None;
            MenuProductos.Name = "MenuProductos";
            MenuProductos.Size = new Size(122, 69);
            MenuProductos.Text = "Productos";
            MenuProductos.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuProductos.Click += menumantenedor_Click;
            // 
            // menucompras
            // 
            menucompras.AutoSize = false;
            menucompras.DropDownItems.AddRange(new ToolStripItem[] { registrarCompraToolStripMenuItem, verDetalleToolStripMenuItem });
            menucompras.ForeColor = SystemColors.ButtonHighlight;
            menucompras.IconChar = FontAwesome.Sharp.IconChar.DollyBox;
            menucompras.IconColor = Color.WhiteSmoke;
            menucompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menucompras.IconSize = 50;
            menucompras.ImageScaling = ToolStripItemImageScaling.None;
            menucompras.Name = "menucompras";
            menucompras.Size = new Size(122, 69);
            menucompras.Text = "Compras";
            menucompras.TextImageRelation = TextImageRelation.ImageAboveText;
            menucompras.Click += menucompras_Click;
            // 
            // registrarCompraToolStripMenuItem
            // 
            registrarCompraToolStripMenuItem.Name = "registrarCompraToolStripMenuItem";
            registrarCompraToolStripMenuItem.Size = new Size(166, 22);
            registrarCompraToolStripMenuItem.Text = "Registrar Compra";
            registrarCompraToolStripMenuItem.Click += registrarCompraToolStripMenuItem_Click;
            // 
            // verDetalleToolStripMenuItem
            // 
            verDetalleToolStripMenuItem.Name = "verDetalleToolStripMenuItem";
            verDetalleToolStripMenuItem.Size = new Size(166, 22);
            verDetalleToolStripMenuItem.Text = "Ver Detalle";
            verDetalleToolStripMenuItem.Click += verDetalleToolStripMenuItem_Click;
            // 
            // MenuTitulo
            // 
            MenuTitulo.AutoSize = false;
            MenuTitulo.BackColor = Color.Green;
            MenuTitulo.ImageScalingSize = new Size(20, 20);
            MenuTitulo.Location = new Point(0, 0);
            MenuTitulo.Name = "MenuTitulo";
            MenuTitulo.RightToLeft = RightToLeft.Yes;
            MenuTitulo.Size = new Size(765, 57);
            MenuTitulo.TabIndex = 1;
            MenuTitulo.Text = "menuStrip2";
            MenuTitulo.ItemClicked += MenuTitulo_ItemClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Green;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(70, 20);
            label1.Name = "label1";
            label1.Size = new Size(209, 29);
            label1.TabIndex = 2;
            label1.Text = "Sistema de Ventas";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(231, 194);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 29);
            panel1.TabIndex = 3;
            // 
            // Contenedor
            // 
            Contenedor.BackColor = SystemColors.ScrollBar;
            Contenedor.Controls.Add(lblusuario);
            Contenedor.Dock = DockStyle.Fill;
            Contenedor.ForeColor = SystemColors.ButtonHighlight;
            Contenedor.Location = new Point(0, 130);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(765, 231);
            Contenedor.TabIndex = 4;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.ForeColor = SystemColors.ActiveCaptionText;
            lblusuario.Location = new Point(650, 23);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(25, 15);
            lblusuario.TabIndex = 0;
            lblusuario.Text = "aaa";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 361);
            Controls.Add(Contenedor);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(Menu2);
            Controls.Add(MenuTitulo);
            MainMenuStrip = Menu2;
            Name = "Inicio";
            Text = "4";
            Load += Inicio_Load;
            Menu2.ResumeLayout(false);
            Menu2.PerformLayout();
            Contenedor.ResumeLayout(false);
            Contenedor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menu2;
        private MenuStrip MenuTitulo;
        private Label label1;
        private FontAwesome.Sharp.IconMenuItem MenuClientes;
        private FontAwesome.Sharp.IconMenuItem MenuProvedores;
        private FontAwesome.Sharp.IconMenuItem MenuReportes;
        private FontAwesome.Sharp.IconMenuItem MenuVentas;
        private FontAwesome.Sharp.IconMenuItem MenuUsuarios;
        private Panel panel1;
        private Panel Contenedor;
        private FontAwesome.Sharp.IconMenuItem MenuProductos;
        private ToolStripMenuItem submenuregistrarventa;
        private ToolStripMenuItem submenuverdetalleventa;
        private Label lblusuario;
        private ToolStripMenuItem comprasToolStripMenuItem;
        private ToolStripMenuItem ReportesCompras;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private ToolStripMenuItem registrarCompraToolStripMenuItem;
        private ToolStripMenuItem verDetalleToolStripMenuItem;
    }
}
