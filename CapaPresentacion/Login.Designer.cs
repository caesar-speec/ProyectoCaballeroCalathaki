namespace CapaPresentacion
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            Tdni = new TextBox();
            Tpassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btn_ingresar = new FontAwesome.Sharp.IconButton();
            btn_cancelar = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(85, 107, 47);
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(332, 166);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(85, 107, 47);
            label2.Font = new Font("Segoe Print", 16F, FontStyle.Bold);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(125, 102);
            label2.Name = "label2";
            label2.Size = new Size(69, 38);
            label2.TabIndex = 1;
            label2.Text = "P&&A";
            label2.Click += label2_Click;
            // 
            // Tdni
            // 
            Tdni.BackColor = Color.FromArgb(240, 255, 240);
            Tdni.BorderStyle = BorderStyle.FixedSingle;
            Tdni.ForeColor = Color.DarkOliveGreen;
            Tdni.Location = new Point(80, 192);
            Tdni.Name = "Tdni";
            Tdni.Size = new Size(171, 23);
            Tdni.TabIndex = 3;
            // 
            // Tpassword
            // 
            Tpassword.BackColor = Color.FromArgb(240, 255, 240);
            Tpassword.BorderStyle = BorderStyle.FixedSingle;
            Tpassword.ForeColor = Color.DarkOliveGreen;
            Tpassword.Location = new Point(80, 248);
            Tpassword.Name = "Tpassword";
            Tpassword.PasswordChar = '*';
            Tpassword.Size = new Size(171, 23);
            Tpassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(80, 174);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 5;
            label3.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkOliveGreen;
            label4.Location = new Point(80, 230);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // btn_ingresar
            // 
            btn_ingresar.BackColor = Color.FromArgb(60, 179, 113);
            btn_ingresar.FlatAppearance.BorderSize = 0;
            btn_ingresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 139, 34);
            btn_ingresar.FlatStyle = FlatStyle.Flat;
            btn_ingresar.ForeColor = Color.White;
            btn_ingresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btn_ingresar.IconColor = Color.WhiteSmoke;
            btn_ingresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_ingresar.Location = new Point(43, 278);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(117, 51);
            btn_ingresar.TabIndex = 7;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.TextAlign = ContentAlignment.MiddleRight;
            btn_ingresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_ingresar.UseVisualStyleBackColor = false;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.FromArgb(178, 34, 34);
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.ForeColor = Color.White;
            btn_cancelar.IconChar = FontAwesome.Sharp.IconChar.Close;
            btn_cancelar.IconColor = Color.WhiteSmoke;
            btn_cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_cancelar.Location = new Point(167, 278);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(115, 51);
            btn_cancelar.TabIndex = 8;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.TextAlign = ContentAlignment.MiddleRight;
            btn_cancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(85, 107, 47);
            label5.Font = new Font("Segoe Print", 12F);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(123, 129);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 9;
            label5.Text = "Plantas";
            // 
            // logo
            // 
            logo.BackColor = Color.FromArgb(85, 107, 47);
            logo.Image = Resource1.iconoplantita;
            logo.Location = new Point(111, 12);
            logo.Margin = new Padding(4, 3, 4, 3);
            logo.Name = "logo";
            logo.Size = new Size(94, 87);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 10;
            logo.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(332, 350);
            Controls.Add(logo);
            Controls.Add(label5);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_ingresar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Tpassword);
            Controls.Add(Tdni);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.DarkOliveGreen;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Tdni;
        private TextBox Tpassword;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton btn_ingresar;
        private FontAwesome.Sharp.IconButton btn_cancelar;
        private Label label5;
        private PictureBox logo;
    }


}