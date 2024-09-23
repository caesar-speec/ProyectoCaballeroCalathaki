﻿namespace CapaPresentacion
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
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            Tdni = new TextBox();
            Tpassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btn_ingresar = new FontAwesome.Sharp.IconButton();
            btn_cancelar = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.ForestGreen;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(379, 221);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.ForestGreen;
            label2.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(144, 146);
            label2.Name = "label2";
            label2.Size = new Size(74, 30);
            label2.TabIndex = 1;
            label2.Text = "P && A";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.ForestGreen;
            iconPictureBox1.ForeColor = SystemColors.ButtonFace;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PlantWilt;
            iconPictureBox1.IconColor = SystemColors.ButtonFace;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 104;
            iconPictureBox1.Location = new Point(131, 13);
            iconPictureBox1.Margin = new Padding(3, 4, 3, 4);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(104, 129);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // Tdni
            // 
            Tdni.Location = new Point(91, 256);
            Tdni.Margin = new Padding(3, 4, 3, 4);
            Tdni.Name = "Tdni";
            Tdni.Size = new Size(195, 27);
            Tdni.TabIndex = 3;
            // 
            // Tpassword
            // 
            Tpassword.Location = new Point(91, 331);
            Tpassword.Margin = new Padding(3, 4, 3, 4);
            Tpassword.Name = "Tpassword";
            Tpassword.PasswordChar = '*';
            Tpassword.Size = new Size(195, 27);
            Tpassword.TabIndex = 4;
            Tpassword.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(91, 232);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 5;
            label3.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(91, 307);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // btn_ingresar
            // 
            btn_ingresar.BackColor = Color.SeaGreen;
            btn_ingresar.FlatStyle = FlatStyle.Flat;
            btn_ingresar.ForeColor = Color.WhiteSmoke;
            btn_ingresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btn_ingresar.IconColor = Color.WhiteSmoke;
            btn_ingresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_ingresar.Location = new Point(49, 371);
            btn_ingresar.Margin = new Padding(3, 4, 3, 4);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(134, 51);
            btn_ingresar.TabIndex = 7;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.TextAlign = ContentAlignment.MiddleRight;
            btn_ingresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_ingresar.UseVisualStyleBackColor = false;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.Firebrick;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.ForeColor = Color.WhiteSmoke;
            btn_cancelar.IconChar = FontAwesome.Sharp.IconChar.Close;
            btn_cancelar.IconColor = Color.WhiteSmoke;
            btn_cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_cancelar.Location = new Point(191, 371);
            btn_cancelar.Margin = new Padding(3, 4, 3, 4);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(131, 51);
            btn_cancelar.TabIndex = 8;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.TextAlign = ContentAlignment.MiddleRight;
            btn_cancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.ForestGreen;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(144, 176);
            label5.Name = "label5";
            label5.Size = new Size(108, 26);
            label5.TabIndex = 9;
            label5.Text = "Plantas";
            label5.Click += label5_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(379, 452);
            Controls.Add(label5);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_ingresar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Tpassword);
            Controls.Add(Tdni);
            Controls.Add(iconPictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.LightGray;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox Tdni;
        private TextBox Tpassword;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton btn_ingresar;
        private FontAwesome.Sharp.IconButton btn_cancelar;
        private Label label5;
    }
}