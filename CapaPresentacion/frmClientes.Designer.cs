namespace CapaPresentacion
{
    partial class frmClientes
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
            txtid = new TextBox();
            label9 = new Label();
            dgvdata = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label8 = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            cboestado = new ComboBox();
            label7 = new Label();
            txttelefono = new TextBox();
            label5 = new Label();
            txtcorreo = new TextBox();
            label4 = new Label();
            txtnombrecompleto = new TextBox();
            label3 = new Label();
            txtdocumento = new TextBox();
            DNI = new Label();
            label1 = new Label();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            cbobusqueda = new ComboBox();
            label10 = new Label();
            btnEditar = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            txtindice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // txtid
            // 
            txtid.Location = new Point(131, 39);
            txtid.Name = "txtid";
            txtid.Size = new Size(18, 23);
            txtid.TabIndex = 44;
            txtid.Text = "0";
            txtid.Visible = false;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ControlLight;
            label9.Font = new Font("Segoe UI", 15F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(198, 40);
            label9.Name = "label9";
            label9.Size = new Size(910, 46);
            label9.TabIndex = 43;
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, Id, Documento, NombreCompleto, Correo, Telefono, EstadoValor, Estado });
            dgvdata.Location = new Point(186, 100);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowHeadersWidth = 51;
            dgvdata.Size = new Size(910, 323);
            dgvdata.TabIndex = 42;
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
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
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
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 125;
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
            Estado.Visible = false;
            Estado.Width = 125;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkOliveGreen;
            label8.Font = new Font("Segoe UI", 15F);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(10, 10);
            label8.Name = "label8";
            label8.Size = new Size(142, 28);
            label8.TabIndex = 41;
            label8.Text = "Detalle Cliente:";
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
            btnEliminar.Location = new Point(23, 356);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(149, 23);
            btnEliminar.TabIndex = 40;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
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
            btnGuardar.Location = new Point(23, 298);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(149, 23);
            btnGuardar.TabIndex = 38;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cboestado
            // 
            cboestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboestado.FormattingEnabled = true;
            cboestado.Location = new Point(23, 238);
            cboestado.Name = "cboestado";
            cboestado.Size = new Size(149, 23);
            cboestado.TabIndex = 37;
            cboestado.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DarkOliveGreen;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(23, 220);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 36;
            label7.Text = "Estado:";
            label7.Visible = false;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(23, 197);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(149, 23);
            txttelefono.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkOliveGreen;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(23, 179);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 30;
            label5.Text = "Telefono:";
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(23, 153);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(149, 23);
            txtcorreo.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkOliveGreen;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(23, 135);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 28;
            label4.Text = "Correo:";
            // 
            // txtnombrecompleto
            // 
            txtnombrecompleto.Location = new Point(23, 109);
            txtnombrecompleto.Name = "txtnombrecompleto";
            txtnombrecompleto.Size = new Size(149, 23);
            txtnombrecompleto.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkOliveGreen;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(23, 91);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 26;
            label3.Text = "Nombre Completo:";
            // 
            // txtdocumento
            // 
            txtdocumento.Location = new Point(23, 65);
            txtdocumento.Name = "txtdocumento";
            txtdocumento.Size = new Size(149, 23);
            txtdocumento.TabIndex = 25;
            // 
            // DNI
            // 
            DNI.AutoSize = true;
            DNI.BackColor = Color.DarkOliveGreen;
            DNI.ForeColor = SystemColors.ControlLightLight;
            DNI.Location = new Point(23, 47);
            DNI.Name = "DNI";
            DNI.Size = new Size(30, 15);
            DNI.TabIndex = 24;
            DNI.Text = "DNI:";
            // 
            // label1
            // 
            label1.BackColor = Color.DarkOliveGreen;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 465);
            label1.TabIndex = 23;
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
            btnlimpiar.Location = new Point(1061, 46);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(35, 33);
            btnlimpiar.TabIndex = 49;
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
            btnbuscar.Location = new Point(1019, 46);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(35, 33);
            btnbuscar.TabIndex = 48;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(864, 47);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(149, 23);
            txtbusqueda.TabIndex = 47;
            // 
            // cbobusqueda
            // 
            cbobusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(709, 47);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(149, 23);
            cbobusqueda.TabIndex = 46;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ControlLight;
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(626, 50);
            label10.Name = "label10";
            label10.Size = new Size(66, 15);
            label10.TabIndex = 45;
            label10.Text = "Buscar Por:";
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
            btnEditar.Location = new Point(23, 327);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(149, 23);
            btnEditar.TabIndex = 50;
            btnEditar.Text = "Limpiar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(211, 50);
            label2.Name = "label2";
            label2.Size = new Size(155, 28);
            label2.TabIndex = 70;
            label2.Text = "Lista de Clientes:";
            // 
            // txtindice
            // 
            txtindice.Location = new Point(101, 40);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(18, 23);
            txtindice.TabIndex = 71;
            txtindice.Text = "-1";
            txtindice.Visible = false;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1118, 465);
            Controls.Add(txtindice);
            Controls.Add(label2);
            Controls.Add(btnEditar);
            Controls.Add(btnlimpiar);
            Controls.Add(btnbuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(cbobusqueda);
            Controls.Add(label10);
            Controls.Add(txtid);
            Controls.Add(label9);
            Controls.Add(dgvdata);
            Controls.Add(label8);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(cboestado);
            Controls.Add(label7);
            Controls.Add(txttelefono);
            Controls.Add(label5);
            Controls.Add(txtcorreo);
            Controls.Add(label4);
            Controls.Add(txtnombrecompleto);
            Controls.Add(label3);
            Controls.Add(txtdocumento);
            Controls.Add(DNI);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmClientes";
            Text = "frmClientes";
            Load += frmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtid;
        private Label label9;
        private DataGridView dgvdata;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private ComboBox cboestado;
        private Label label7;
        private TextBox txttelefono;
        private Label label5;
        private TextBox txtcorreo;
        private Label label4;
        private TextBox txtnombrecompleto;
        private Label label3;
        private TextBox txtdocumento;
        private Label DNI;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private TextBox txtbusqueda;
        private ComboBox cbobusqueda;
        private Label label10;
        private FontAwesome.Sharp.IconButton btnEditar;
        private Label label2;
        private TextBox txtindice;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}