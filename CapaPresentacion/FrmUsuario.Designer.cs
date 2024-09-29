namespace CapaPresentacion
{
    partial class FrmUsuario
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
            DNI = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 479);
            label1.TabIndex = 0;
            // 
            // DNI
            // 
            DNI.AutoSize = true;
            DNI.Location = new Point(12, 21);
            DNI.Name = "DNI";
            DNI.Size = new Size(30, 15);
            DNI.TabIndex = 1;
            DNI.Text = "DNI:";
            DNI.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre Completo:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 206);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(149, 23);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 175);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 6;
            label4.Text = "Correo:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 278);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(149, 23);
            textBox4.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 247);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 8;
            label5.Text = "Contraseña:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 347);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(149, 23);
            textBox5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 316);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 10;
            label6.Text = "Confirmar Contraseña:";
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(682, 479);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(DNI);
            Controls.Add(label1);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label DNI;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
    }
}