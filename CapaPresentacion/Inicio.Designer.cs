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
            menureportes = new FontAwesome.Sharp.IconMenuItem();
            MenuVentas = new FontAwesome.Sharp.IconMenuItem();
            submenuregistrarventa = new ToolStripMenuItem();
            submenuverdetalleventa = new ToolStripMenuItem();
            menuusuarios = new FontAwesome.Sharp.IconMenuItem();
            MenuClientes = new FontAwesome.Sharp.IconMenuItem();
            agregarClienteToolStripMenuItem = new ToolStripMenuItem();
            modificarClientesToolStripMenuItem = new ToolStripMenuItem();
            menumantenedor = new FontAwesome.Sharp.IconMenuItem();
            submenucategoria = new ToolStripMenuItem();
            submenuproducto = new ToolStripMenuItem();
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
            Menu2.Items.AddRange(new ToolStripItem[] { MenuProvedores, menureportes, MenuVentas, menuusuarios, MenuClientes, menumantenedor });
            Menu2.Location = new Point(0, 76);
            Menu2.Name = "Menu2";
            Menu2.Padding = new Padding(7, 3, 0, 3);
            Menu2.Size = new Size(874, 75);
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
            // 
            // menureportes
            // 
            menureportes.AutoSize = false;
            menureportes.ForeColor = SystemColors.ButtonHighlight;
            menureportes.IconChar = FontAwesome.Sharp.IconChar.ArrowTrendUp;
            menureportes.IconColor = Color.WhiteSmoke;
            menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menureportes.IconSize = 50;
            menureportes.ImageScaling = ToolStripItemImageScaling.None;
            menureportes.Name = "menureportes";
            menureportes.Size = new Size(80, 69);
            menureportes.Text = "Reportes";
            menureportes.TextImageRelation = TextImageRelation.ImageAboveText;
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
            MenuVentas.Size = new Size(80, 69);
            MenuVentas.Text = "Ventas";
            MenuVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenuregistrarventa
            // 
            submenuregistrarventa.Name = "submenuregistrarventa";
            submenuregistrarventa.Size = new Size(165, 26);
            submenuregistrarventa.Text = "Registrar";
            // 
            // submenuverdetalleventa
            // 
            submenuverdetalleventa.Name = "submenuverdetalleventa";
            submenuverdetalleventa.Size = new Size(165, 26);
            submenuverdetalleventa.Text = "Ver Detalle";
            // 
            // menuusuarios
            // 
            menuusuarios.AutoSize = false;
            menuusuarios.ForeColor = SystemColors.ButtonHighlight;
            menuusuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            menuusuarios.IconColor = Color.WhiteSmoke;
            menuusuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuusuarios.IconSize = 50;
            menuusuarios.ImageScaling = ToolStripItemImageScaling.None;
            menuusuarios.Name = "menuusuarios";
            menuusuarios.Size = new Size(80, 69);
            menuusuarios.Text = "Usuarios";
            menuusuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            menuusuarios.Click += MenuReponedor_Click;
            // 
            // MenuClientes
            // 
            MenuClientes.AutoSize = false;
            MenuClientes.DropDownItems.AddRange(new ToolStripItem[] { agregarClienteToolStripMenuItem, modificarClientesToolStripMenuItem });
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
            // 
            // agregarClienteToolStripMenuItem
            // 
            agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            agregarClienteToolStripMenuItem.Size = new Size(212, 26);
            agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            // 
            // modificarClientesToolStripMenuItem
            // 
            modificarClientesToolStripMenuItem.Name = "modificarClientesToolStripMenuItem";
            modificarClientesToolStripMenuItem.Size = new Size(212, 26);
            modificarClientesToolStripMenuItem.Text = "Modificar Clientes";
            // 
            // menumantenedor
            // 
            menumantenedor.AutoSize = false;
            menumantenedor.DropDownItems.AddRange(new ToolStripItem[] { submenucategoria, submenuproducto });
            menumantenedor.ForeColor = SystemColors.ButtonHighlight;
            menumantenedor.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            menumantenedor.IconColor = Color.WhiteSmoke;
            menumantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menumantenedor.IconSize = 50;
            menumantenedor.ImageScaling = ToolStripItemImageScaling.None;
            menumantenedor.Name = "menumantenedor";
            menumantenedor.Size = new Size(80, 69);
            menumantenedor.Text = "Productos";
            menumantenedor.TextImageRelation = TextImageRelation.ImageAboveText;
            menumantenedor.Click += menumantenedor_Click;
            // 
            // submenucategoria
            // 
            submenucategoria.Name = "submenucategoria";
            submenucategoria.Size = new Size(255, 26);
            submenucategoria.Text = "Agregar nuevo producto";
            submenucategoria.Click += submenucategoria_Click_1;
            // 
            // submenuproducto
            // 
            submenuproducto.Name = "submenuproducto";
            submenuproducto.Size = new Size(255, 26);
            submenuproducto.Text = "Modificar Productos";
            submenuproducto.Click += submenuproducto_Click;
            // 
            // MenuTitulo
            // 
            MenuTitulo.AutoSize = false;
            MenuTitulo.BackColor = Color.Green;
            MenuTitulo.ImageScalingSize = new Size(20, 20);
            MenuTitulo.Location = new Point(0, 0);
            MenuTitulo.Name = "MenuTitulo";
            MenuTitulo.Padding = new Padding(7, 3, 0, 3);
            MenuTitulo.RightToLeft = RightToLeft.Yes;
            MenuTitulo.Size = new Size(874, 76);
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
            label1.Location = new Point(80, 27);
            label1.Name = "label1";
            label1.Size = new Size(260, 38);
            label1.TabIndex = 2;
            label1.Text = "Sistema de Ventas";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(264, 259);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 39);
            panel1.TabIndex = 3;
            // 
            // Contenedor
            // 
            Contenedor.BackColor = SystemColors.ScrollBar;
            Contenedor.Controls.Add(lblusuario);
            Contenedor.Dock = DockStyle.Fill;
            Contenedor.ForeColor = SystemColors.ButtonHighlight;
            Contenedor.Location = new Point(0, 151);
            Contenedor.Margin = new Padding(3, 4, 3, 4);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(874, 330);
            Contenedor.TabIndex = 4;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.ForeColor = SystemColors.ActiveCaptionText;
            lblusuario.Location = new Point(709, 21);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(33, 20);
            lblusuario.TabIndex = 0;
            lblusuario.Text = "aaa";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 481);
            Controls.Add(Contenedor);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(Menu2);
            Controls.Add(MenuTitulo);
            MainMenuStrip = Menu2;
            Margin = new Padding(3, 4, 3, 4);
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
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private FontAwesome.Sharp.IconMenuItem MenuVentas;
        private FontAwesome.Sharp.IconMenuItem menuusuarios;
        private Panel panel1;
        private Panel Contenedor;
        private FontAwesome.Sharp.IconMenuItem menumantenedor;
        private ToolStripMenuItem submenucategoria;
        private ToolStripMenuItem submenuproducto;
        private ToolStripMenuItem submenuregistrarventa;
        private ToolStripMenuItem submenuverdetalleventa;
        private ToolStripMenuItem agregarClienteToolStripMenuItem;
        private ToolStripMenuItem modificarClientesToolStripMenuItem;
        private Label lblusuario;
        private ToolStripMenuItem comprasToolStripMenuItem;
    }
}
