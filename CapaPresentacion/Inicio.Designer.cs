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
            MenuReponedor = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
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
            Menu2.Items.AddRange(new ToolStripItem[] { MenuVendedor, MenuGerente, MenuVentas, MenuReponedor, iconMenuItem1 });
            Menu2.Location = new Point(0, 57);
            Menu2.Name = "Menu2";
            Menu2.Size = new Size(800, 73);
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
            MenuReponedor.Text = "Reponedor";
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
            // MenuTitulo
            // 
            MenuTitulo.AutoSize = false;
            MenuTitulo.BackColor = Color.Green;
            MenuTitulo.ImageScalingSize = new Size(20, 20);
            MenuTitulo.Location = new Point(0, 0);
            MenuTitulo.Name = "MenuTitulo";
            MenuTitulo.RightToLeft = RightToLeft.Yes;
            MenuTitulo.Size = new Size(800, 57);
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
            Contenedor.Controls.Add(iconPictureBox1);
            Contenedor.Dock = DockStyle.Fill;
            Contenedor.ForeColor = SystemColors.ButtonHighlight;
            Contenedor.Location = new Point(0, 130);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(800, 320);
            Contenedor.TabIndex = 4;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.ScrollBar;
            iconPictureBox1.ForeColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 6;
            iconPictureBox1.Location = new Point(230, 53);
            iconPictureBox1.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(7, 6);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Contenedor);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(Menu2);
            Controls.Add(MenuTitulo);
            MainMenuStrip = Menu2;
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
    }
}
