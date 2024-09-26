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
            MenuVendedor = new FontAwesome.Sharp.IconMenuItem();
            MenuGerente = new FontAwesome.Sharp.IconMenuItem();
            MenuVentas = new FontAwesome.Sharp.IconMenuItem();
            submenuregistrarventa = new ToolStripMenuItem();
            submenuverdetalleventa = new ToolStripMenuItem();
            MenuReponedor = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            menumantenedor = new FontAwesome.Sharp.IconMenuItem();
            submenucategoria = new ToolStripMenuItem();
            submenuproducto = new ToolStripMenuItem();
            MenuTitulo = new MenuStrip();
            label1 = new Label();
            panel1 = new Panel();
            Contenedor = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            Menu2.SuspendLayout();
            Contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Menu2
            // 
            Menu2.BackColor = SystemColors.GrayText;
            Menu2.ImageScalingSize = new Size(20, 20);
            Menu2.Items.AddRange(new ToolStripItem[] { MenuVendedor, MenuGerente, MenuVentas, MenuReponedor, iconMenuItem1, menumantenedor });
            Menu2.Location = new Point(0, 76);
            Menu2.Name = "Menu2";
            Menu2.Padding = new Padding(7, 3, 0, 3);
            Menu2.Size = new Size(914, 75);
            Menu2.TabIndex = 0;
            Menu2.Text = "menuStrip1";
            // 
            // MenuVendedor
            // 
            MenuVendedor.AutoSize = false;
            MenuVendedor.ForeColor = SystemColors.ButtonHighlight;
            MenuVendedor.IconChar = FontAwesome.Sharp.IconChar.Computer;
            MenuVendedor.IconColor = Color.WhiteSmoke;
            MenuVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuVendedor.IconSize = 50;
            MenuVendedor.ImageScaling = ToolStripItemImageScaling.None;
            MenuVendedor.Name = "MenuVendedor";
            MenuVendedor.Size = new Size(80, 69);
            MenuVendedor.Text = "Vendedor";
            MenuVendedor.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // MenuGerente
            // 
            MenuGerente.AutoSize = false;
            MenuGerente.ForeColor = SystemColors.ButtonHighlight;
            MenuGerente.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            MenuGerente.IconColor = Color.WhiteSmoke;
            MenuGerente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuGerente.IconSize = 50;
            MenuGerente.ImageScaling = ToolStripItemImageScaling.None;
            MenuGerente.Name = "MenuGerente";
            MenuGerente.Size = new Size(80, 69);
            MenuGerente.Text = "Gerente";
            MenuGerente.TextImageRelation = TextImageRelation.ImageAboveText;
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
            submenuregistrarventa.Size = new Size(224, 26);
            submenuregistrarventa.Text = "Registrar";
            // 
            // submenuverdetalleventa
            // 
            submenuverdetalleventa.Name = "submenuverdetalleventa";
            submenuverdetalleventa.Size = new Size(224, 26);
            submenuverdetalleventa.Text = "Ver Detalle";
            // 
            // MenuReponedor
            // 
            MenuReponedor.AutoSize = false;
            MenuReponedor.ForeColor = SystemColors.ButtonHighlight;
            MenuReponedor.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            MenuReponedor.IconColor = Color.WhiteSmoke;
            MenuReponedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuReponedor.IconSize = 50;
            MenuReponedor.ImageScaling = ToolStripItemImageScaling.None;
            MenuReponedor.Name = "MenuReponedor";
            MenuReponedor.Size = new Size(80, 69);
            MenuReponedor.Text = "Usuarios";
            MenuReponedor.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.AutoSize = false;
            iconMenuItem1.ForeColor = SystemColors.ButtonHighlight;
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.UsersBetweenLines;
            iconMenuItem1.IconColor = Color.WhiteSmoke;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.IconSize = 50;
            iconMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(80, 69);
            iconMenuItem1.Text = "Clientes";
            iconMenuItem1.TextImageRelation = TextImageRelation.ImageAboveText;
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
            // 
            // submenucategoria
            // 
            submenucategoria.Name = "submenucategoria";
            submenucategoria.Size = new Size(255, 26);
            submenucategoria.Text = "Agregar nuevo producto";
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
            MenuTitulo.Size = new Size(914, 76);
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
            Contenedor.Controls.Add(iconPictureBox1);
            Contenedor.Dock = DockStyle.Fill;
            Contenedor.ForeColor = SystemColors.ButtonHighlight;
            Contenedor.Location = new Point(0, 151);
            Contenedor.Margin = new Padding(3, 4, 3, 4);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(914, 449);
            Contenedor.TabIndex = 4;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.ScrollBar;
            iconPictureBox1.ForeColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 8;
            iconPictureBox1.Location = new Point(263, 71);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(8, 8);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Contenedor);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(Menu2);
            Controls.Add(MenuTitulo);
            MainMenuStrip = Menu2;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Inicio";
            Text = "Form1";
            Load += Inicio_Load;
            Menu2.ResumeLayout(false);
            Menu2.PerformLayout();
            Contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menu2;
        private MenuStrip MenuTitulo;
        private Label label1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem MenuVendedor;
        private FontAwesome.Sharp.IconMenuItem MenuGerente;
        private FontAwesome.Sharp.IconMenuItem MenuVentas;
        private FontAwesome.Sharp.IconMenuItem MenuReponedor;
        private Panel panel1;
        private Panel Contenedor;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconMenuItem menumantenedor;
        private ToolStripMenuItem submenucategoria;
        private ToolStripMenuItem submenuproducto;
        private ToolStripMenuItem submenuregistrarventa;
        private ToolStripMenuItem submenuverdetalleventa;
    }
}
