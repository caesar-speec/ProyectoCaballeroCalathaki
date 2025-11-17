namespace CapaPresentacion
{
    partial class frmBackup
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
            label7 = new Label();
            groupBox1 = new GroupBox();
            btnBrowse = new FontAwesome.Sharp.IconButton();
            txtBackupName = new TextBox();
            label4 = new Label();
            btnCrearBackup = new FontAwesome.Sharp.IconButton();
            txtBackupPath = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            btnRestaurar = new FontAwesome.Sharp.IconButton();
            cboBackups = new ComboBox();
            label5 = new Label();
            progressBar = new ProgressBar();
            label2 = new Label();
            folderBrowserDialog = new FolderBrowserDialog();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DarkSeaGreen;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1172, 567);
            label1.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(42, 41);
            label7.Name = "label7";
            label7.Size = new Size(323, 31);
            label7.TabIndex = 20;
            label7.Text = "Copia de Seguridad (Backup)";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(btnBrowse);
            groupBox1.Controls.Add(txtBackupName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnCrearBackup);
            groupBox1.Controls.Add(txtBackupPath);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(42, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(721, 192);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crear Copia de Seguridad";
            // 
            // btnBrowse
            // 
            btnBrowse.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowse.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            btnBrowse.IconColor = Color.Black;
            btnBrowse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBrowse.IconSize = 20;
            btnBrowse.Location = new Point(664, 61);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(51, 29);
            btnBrowse.TabIndex = 25;
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtBackupName
            // 
            txtBackupName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBackupName.Location = new Point(23, 131);
            txtBackupName.Name = "txtBackupName";
            txtBackupName.ReadOnly = true;
            txtBackupName.Size = new Size(462, 27);
            txtBackupName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 108);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 3;
            label4.Text = "Nombre del Archivo:";
            // 
            // btnCrearBackup
            // 
            btnCrearBackup.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrearBackup.IconChar = FontAwesome.Sharp.IconChar.Database;
            btnCrearBackup.IconColor = Color.Black;
            btnCrearBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrearBackup.IconSize = 28;
            btnCrearBackup.Location = new Point(513, 119);
            btnCrearBackup.Name = "btnCrearBackup";
            btnCrearBackup.Size = new Size(183, 47);
            btnCrearBackup.TabIndex = 2;
            btnCrearBackup.Text = "Crear Backup Ahora";
            btnCrearBackup.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCrearBackup.UseVisualStyleBackColor = true;
            btnCrearBackup.Click += btnCrearBackup_Click;
            // 
            // txtBackupPath
            // 
            txtBackupPath.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBackupPath.Location = new Point(23, 62);
            txtBackupPath.Name = "txtBackupPath";
            txtBackupPath.Size = new Size(635, 27);
            txtBackupPath.TabIndex = 1;
            txtBackupPath.TextChanged += txtBackupPath_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 39);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 0;
            label3.Text = "Ubicación:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(btnRestaurar);
            groupBox2.Controls.Add(cboBackups);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(42, 283);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(721, 136);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Restaurar Copia de Seguridad";
            // 
            // btnRestaurar
            // 
            btnRestaurar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestaurar.IconChar = FontAwesome.Sharp.IconChar.Upload;
            btnRestaurar.IconColor = Color.DarkRed;
            btnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRestaurar.IconSize = 28;
            btnRestaurar.Location = new Point(513, 57);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(183, 47);
            btnRestaurar.TabIndex = 5;
            btnRestaurar.Text = "Restaurar Backup";
            btnRestaurar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // cboBackups
            // 
            cboBackups.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBackups.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboBackups.FormattingEnabled = true;
            cboBackups.Location = new Point(23, 67);
            cboBackups.Name = "cboBackups";
            cboBackups.Size = new Size(462, 28);
            cboBackups.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 44);
            label5.Name = "label5";
            label5.Size = new Size(218, 20);
            label5.TabIndex = 0;
            label5.Text = "Seleccionar Backup a Restaurar:";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(42, 464);
            progressBar.MarqueeAnimationSpeed = 30;
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(721, 23);
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.TabIndex = 24;
            progressBar.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(42, 433);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 6;
            label2.Text = "Progreso:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkSeaGreen;
            pictureBox1.Image = Resource1.iconoplantita;
            pictureBox1.Location = new Point(809, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 321);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // frmBackup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1172, 567);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(progressBar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "frmBackup";
            Text = "frmBackup";
            Load += frmBackup_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnCrearBackup;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBackupName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnRestaurar;
        private System.Windows.Forms.ComboBox cboBackups;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private PictureBox pictureBox1;
    }
}