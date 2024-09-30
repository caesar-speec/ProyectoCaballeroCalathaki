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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            DNI = new Label();
            txtdocumento = new TextBox();
            txtnombrecompleto = new TextBox();
            label3 = new Label();
            txtcorreo = new TextBox();
            label4 = new Label();
            txtclave = new TextBox();
            label5 = new Label();
            txtclave2 = new TextBox();
            label6 = new Label();
            label2 = new Label();
            cborol = new ComboBox();
            cboestado = new ComboBox();
            label7 = new Label();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            dgvdata = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            IdUsuario = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Clave = new DataGridViewTextBoxColumn();
            IdRol = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label9 = new Label();
            txtid = new TextBox();
            txtindice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.ForestGreen;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 465);
            label1.TabIndex = 0;
            // 
            // DNI
            // 
            DNI.AutoSize = true;
            DNI.BackColor = Color.ForestGreen;
            DNI.ForeColor = SystemColors.ControlLightLight;
            DNI.Location = new Point(12, 47);
            DNI.Name = "DNI";
            DNI.Size = new Size(30, 15);
            DNI.TabIndex = 1;
            DNI.Text = "DNI:";
            // 
            // txtdocumento
            // 
            txtdocumento.Location = new Point(12, 65);
            txtdocumento.Name = "txtdocumento";
            txtdocumento.Size = new Size(149, 23);
            txtdocumento.TabIndex = 3;
            // 
            // txtnombrecompleto
            // 
            txtnombrecompleto.Location = new Point(12, 109);
            txtnombrecompleto.Name = "txtnombrecompleto";
            txtnombrecompleto.Size = new Size(149, 23);
            txtnombrecompleto.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.ForestGreen;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre Completo:";
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(12, 153);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(149, 23);
            txtcorreo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.ForestGreen;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(12, 135);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 6;
            label4.Text = "Correo:";
            // 
            // txtclave
            // 
            txtclave.Location = new Point(12, 197);
            txtclave.Name = "txtclave";
            txtclave.PasswordChar = '*';
            txtclave.Size = new Size(149, 23);
            txtclave.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.ForestGreen;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(12, 179);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 8;
            label5.Text = "Contraseña:";
            // 
            // txtclave2
            // 
            txtclave2.Location = new Point(12, 241);
            txtclave2.Name = "txtclave2";
            txtclave2.PasswordChar = '*';
            txtclave2.Size = new Size(149, 23);
            txtclave2.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.ForestGreen;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(12, 223);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 10;
            label6.Text = "Confirmar Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.ForestGreen;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 267);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 12;
            label2.Text = "Rol:";
            // 
            // cborol
            // 
            cborol.DropDownStyle = ComboBoxStyle.DropDownList;
            cborol.FormattingEnabled = true;
            cborol.Location = new Point(12, 285);
            cborol.Name = "cborol";
            cborol.Size = new Size(149, 23);
            cborol.TabIndex = 13;
            // 
            // cboestado
            // 
            cboestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboestado.FormattingEnabled = true;
            cboestado.Location = new Point(12, 329);
            cboestado.Name = "cboestado";
            cboestado.Size = new Size(149, 23);
            cboestado.TabIndex = 15;
            cboestado.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.ForestGreen;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(12, 311);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 14;
            label7.Text = "Estado:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.YellowGreen;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.LightYellow;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 16;
            btnGuardar.Location = new Point(12, 372);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(149, 23);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.RoyalBlue;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditar.IconColor = Color.White;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 16;
            btnEditar.Location = new Point(12, 401);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(149, 23);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnEliminar.IconColor = Color.White;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 16;
            btnEliminar.Location = new Point(12, 430);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(149, 23);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.ForestGreen;
            label8.Font = new Font("Segoe UI", 15F);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(146, 28);
            label8.TabIndex = 19;
            label8.Text = "Nuevo Usuario:";
            label8.Click += label8_Click;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.AllowUserToDeleteRows = false;
            dgvdata.AllowUserToResizeColumns = false;
            dgvdata.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, IdUsuario, Documento, NombreCompleto, Correo, Clave, IdRol, Rol, EstadoValor, Estado });
            dgvdata.Location = new Point(187, 101);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowHeadersWidth = 51;
            dgvdata.Size = new Size(910, 323);
            dgvdata.TabIndex = 20;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // btnseleccionar
            // 
            btnseleccionar.HeaderText = "";
            btnseleccionar.MinimumWidth = 6;
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.ReadOnly = true;
            btnseleccionar.Width = 30;
            // 
            // IdUsuario
            // 
            IdUsuario.HeaderText = "IdUsuario";
            IdUsuario.MinimumWidth = 6;
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            IdUsuario.Visible = false;
            IdUsuario.Width = 125;
            // 
            // Documento
            // 
            Documento.HeaderText = "Nro Documento";
            Documento.MinimumWidth = 6;
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            Documento.Width = 150;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.MinimumWidth = 6;
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Width = 180;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 125;
            // 
            // Clave
            // 
            Clave.HeaderText = "Clave";
            Clave.MinimumWidth = 6;
            Clave.Name = "Clave";
            Clave.ReadOnly = true;
            Clave.Visible = false;
            Clave.Width = 125;
            // 
            // IdRol
            // 
            IdRol.HeaderText = "IdRol";
            IdRol.MinimumWidth = 6;
            IdRol.Name = "IdRol";
            IdRol.ReadOnly = true;
            IdRol.Visible = false;
            IdRol.Width = 125;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.MinimumWidth = 6;
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            Rol.Width = 125;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "EstadoValor";
            EstadoValor.MinimumWidth = 6;
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            EstadoValor.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 125;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ControlLight;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(187, 40);
            label9.Name = "label9";
            label9.Size = new Size(910, 46);
            label9.TabIndex = 21;
            label9.Text = "Lista Usuarios:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtid
            // 
            txtid.Location = new Point(121, 39);
            txtid.Name = "txtid";
            txtid.Size = new Size(18, 23);
            txtid.TabIndex = 22;
            txtid.Text = "0";
            txtid.Visible = false;
            // 
            // txtindice
            // 
            txtindice.Location = new Point(97, 39);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(18, 23);
            txtindice.TabIndex = 23;
            txtindice.Text = "-1";
            txtindice.Visible = false;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1118, 465);
            Controls.Add(txtindice);
            Controls.Add(txtid);
            Controls.Add(label9);
            Controls.Add(dgvdata);
            Controls.Add(label8);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(cboestado);
            Controls.Add(label7);
            Controls.Add(cborol);
            Controls.Add(label2);
            Controls.Add(txtclave2);
            Controls.Add(label6);
            Controls.Add(txtclave);
            Controls.Add(label5);
            Controls.Add(txtcorreo);
            Controls.Add(label4);
            Controls.Add(txtnombrecompleto);
            Controls.Add(label3);
            Controls.Add(txtdocumento);
            Controls.Add(DNI);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "FrmUsuario";
            Text = "Usuario";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label DNI;
        private TextBox txtdocumento;
        private TextBox txtnombrecompleto;
        private Label label3;
        private TextBox txtcorreo;
        private Label label4;
        private TextBox txtclave;
        private Label label5;
        private TextBox txtclave2;
        private Label label6;
        private Label label2;
        private ComboBox cborol;
        private ComboBox cboestado;
        private Label label7;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private Label label8;
        private DataGridView dgvdata;
        private Label label9;
        private TextBox txtid;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn IdRol;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        private TextBox txtindice;
    }
}