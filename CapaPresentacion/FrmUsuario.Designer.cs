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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            label10 = new Label();
            cbobusqueda = new ComboBox();
            txtbusqueda = new TextBox();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            label11 = new Label();
            btnbackup = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DarkOliveGreen;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(208, 620);
            label1.TabIndex = 0;
            // 
            // DNI
            // 
            DNI.AutoSize = true;
            DNI.BackColor = Color.DarkOliveGreen;
            DNI.ForeColor = SystemColors.ControlLightLight;
            DNI.Location = new Point(14, 63);
            DNI.Name = "DNI";
            DNI.Size = new Size(38, 20);
            DNI.TabIndex = 1;
            DNI.Text = "DNI:";
            // 
            // txtdocumento
            // 
            txtdocumento.Location = new Point(14, 87);
            txtdocumento.Margin = new Padding(3, 4, 3, 4);
            txtdocumento.Name = "txtdocumento";
            txtdocumento.Size = new Size(170, 27);
            txtdocumento.TabIndex = 3;
            // 
            // txtnombrecompleto
            // 
            txtnombrecompleto.Location = new Point(14, 145);
            txtnombrecompleto.Margin = new Padding(3, 4, 3, 4);
            txtnombrecompleto.Name = "txtnombrecompleto";
            txtnombrecompleto.Size = new Size(170, 27);
            txtnombrecompleto.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkOliveGreen;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(14, 121);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre Completo:";
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(14, 204);
            txtcorreo.Margin = new Padding(3, 4, 3, 4);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(170, 27);
            txtcorreo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkOliveGreen;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(14, 180);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 6;
            label4.Text = "Correo:";
            // 
            // txtclave
            // 
            txtclave.Location = new Point(14, 263);
            txtclave.Margin = new Padding(3, 4, 3, 4);
            txtclave.Name = "txtclave";
            txtclave.PasswordChar = '*';
            txtclave.Size = new Size(170, 27);
            txtclave.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkOliveGreen;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(14, 239);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 8;
            label5.Text = "Contraseña:";
            // 
            // txtclave2
            // 
            txtclave2.Location = new Point(14, 321);
            txtclave2.Margin = new Padding(3, 4, 3, 4);
            txtclave2.Name = "txtclave2";
            txtclave2.PasswordChar = '*';
            txtclave2.Size = new Size(170, 27);
            txtclave2.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkOliveGreen;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(14, 297);
            label6.Name = "label6";
            label6.Size = new Size(156, 20);
            label6.TabIndex = 10;
            label6.Text = "Confirmar Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkOliveGreen;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(14, 356);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 12;
            label2.Text = "Rol:";
            // 
            // cborol
            // 
            cborol.DropDownStyle = ComboBoxStyle.DropDownList;
            cborol.FormattingEnabled = true;
            cborol.Location = new Point(14, 380);
            cborol.Margin = new Padding(3, 4, 3, 4);
            cborol.Name = "cborol";
            cborol.Size = new Size(170, 28);
            cborol.TabIndex = 13;
            // 
            // cboestado
            // 
            cboestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboestado.FormattingEnabled = true;
            cboestado.Location = new Point(14, 439);
            cboestado.Margin = new Padding(3, 4, 3, 4);
            cboestado.Name = "cboestado";
            cboestado.Size = new Size(170, 28);
            cboestado.TabIndex = 15;
            cboestado.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DarkOliveGreen;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(14, 415);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
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
            btnGuardar.Location = new Point(14, 496);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(170, 31);
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
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnEditar.IconColor = Color.White;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 16;
            btnEditar.Location = new Point(14, 535);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(170, 31);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "Limpiar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
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
            btnEliminar.Location = new Point(14, 573);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(170, 31);
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
            label8.BackColor = Color.DarkOliveGreen;
            label8.Font = new Font("Segoe UI", 15F);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(14, 12);
            label8.Name = "label8";
            label8.Size = new Size(185, 35);
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
            dgvdata.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, IdUsuario, Documento, NombreCompleto, Correo, Clave, IdRol, Rol, EstadoValor, Estado });
            dgvdata.Location = new Point(214, 135);
            dgvdata.Margin = new Padding(3, 4, 3, 4);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowHeadersWidth = 51;
            dgvdata.Size = new Size(1040, 431);
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
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(215, 39);
            label9.Name = "label9";
            label9.Padding = new Padding(0, 3, 2, 0);
            label9.Size = new Size(1040, 91);
            label9.TabIndex = 21;
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtid
            // 
            txtid.Location = new Point(138, 52);
            txtid.Margin = new Padding(3, 4, 3, 4);
            txtid.Name = "txtid";
            txtid.Size = new Size(20, 27);
            txtid.TabIndex = 22;
            txtid.Text = "0";
            txtid.Visible = false;
            // 
            // txtindice
            // 
            txtindice.Location = new Point(111, 52);
            txtindice.Margin = new Padding(3, 4, 3, 4);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(20, 27);
            txtindice.TabIndex = 23;
            txtindice.Text = "-1";
            txtindice.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ControlLight;
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(701, 67);
            label10.Name = "label10";
            label10.Size = new Size(80, 20);
            label10.TabIndex = 24;
            label10.Text = "Buscar Por:";
            label10.Click += label10_Click;
            // 
            // cbobusqueda
            // 
            cbobusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(795, 63);
            cbobusqueda.Margin = new Padding(3, 4, 3, 4);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(170, 28);
            cbobusqueda.TabIndex = 25;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(973, 63);
            txtbusqueda.Margin = new Padding(3, 4, 3, 4);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(170, 27);
            txtbusqueda.TabIndex = 26;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = Color.RoyalBlue;
            btnlimpiar.Cursor = Cursors.Hand;
            btnlimpiar.FlatStyle = FlatStyle.Flat;
            btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnlimpiar.IconColor = Color.White;
            btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiar.IconSize = 18;
            btnlimpiar.Location = new Point(1199, 61);
            btnlimpiar.Margin = new Padding(3, 4, 3, 4);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(40, 44);
            btnlimpiar.TabIndex = 28;
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.YellowGreen;
            btnbuscar.Cursor = Cursors.Hand;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscar.IconColor = Color.LightYellow;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 18;
            btnbuscar.Location = new Point(1151, 61);
            btnbuscar.Margin = new Padding(3, 4, 3, 4);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(40, 44);
            btnbuscar.TabIndex = 27;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ControlLight;
            label11.Font = new Font("Segoe UI", 15F);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(229, 67);
            label11.Name = "label11";
            label11.Size = new Size(208, 35);
            label11.TabIndex = 70;
            label11.Text = "Lista de Usuarios:";
            // 
            // btnbackup
            // 
            btnbackup.Location = new Point(1088, 579);
            btnbackup.Name = "btnbackup";
            btnbackup.Size = new Size(167, 29);
            btnbackup.TabIndex = 71;
            btnbackup.Text = "BACKUP DE DATOS";
            btnbackup.UseVisualStyleBackColor = true;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1278, 620);
            Controls.Add(btnbackup);
            Controls.Add(label11);
            Controls.Add(btnlimpiar);
            Controls.Add(btnbuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(cbobusqueda);
            Controls.Add(label10);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label10;
        private ComboBox cbobusqueda;
        private TextBox txtbusqueda;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private Label label11;
        private Button btnbackup;
    }
}