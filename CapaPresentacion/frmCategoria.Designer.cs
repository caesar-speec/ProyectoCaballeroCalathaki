namespace CapaPresentacion
{
    partial class frmCategoria
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
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            txtid = new TextBox();
            label9 = new Label();
            label8 = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            cboestado = new ComboBox();
            label7 = new Label();
            txtdescripcion = new TextBox();
            DNI = new Label();
            label1 = new Label();
            label3 = new Label();
            label20 = new Label();
            txtindice = new TextBox();
            label2 = new Label();
            cbobusqueda = new ComboBox();
            dgvdata = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
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
            btnEditar.Location = new Point(11, 241);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(170, 31);
            btnEditar.TabIndex = 73;
            btnEditar.Text = "Limpiar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
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
            btnlimpiar.Location = new Point(1013, 61);
            btnlimpiar.Margin = new Padding(3, 4, 3, 4);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(40, 44);
            btnlimpiar.TabIndex = 72;
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
            btnbuscar.Location = new Point(965, 61);
            btnbuscar.Margin = new Padding(3, 4, 3, 4);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(40, 44);
            btnbuscar.TabIndex = 71;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(786, 63);
            txtbusqueda.Margin = new Padding(3, 4, 3, 4);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(170, 27);
            txtbusqueda.TabIndex = 70;
            // 
            // txtid
            // 
            txtid.Location = new Point(155, 52);
            txtid.Margin = new Padding(3, 4, 3, 4);
            txtid.Name = "txtid";
            txtid.Size = new Size(20, 27);
            txtid.TabIndex = 67;
            txtid.Text = "0";
            txtid.Visible = false;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ControlLight;
            label9.Font = new Font("Segoe UI", 15F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(219, 53);
            label9.Name = "label9";
            label9.Size = new Size(842, 61);
            label9.TabIndex = 66;
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkOliveGreen;
            label8.Font = new Font("Segoe UI", 15F);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(0, 13);
            label8.Name = "label8";
            label8.Size = new Size(211, 35);
            label8.TabIndex = 64;
            label8.Text = "Detalle Categoria:";
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
            btnEliminar.Location = new Point(11, 280);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(170, 31);
            btnEliminar.TabIndex = 63;
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
            btnGuardar.Location = new Point(11, 203);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(170, 31);
            btnGuardar.TabIndex = 62;
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
            cboestado.Location = new Point(11, 145);
            cboestado.Margin = new Padding(3, 4, 3, 4);
            cboestado.Name = "cboestado";
            cboestado.Size = new Size(170, 28);
            cboestado.TabIndex = 61;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DarkOliveGreen;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(11, 121);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 60;
            label7.Text = "Estado:";
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(11, 91);
            txtdescripcion.Margin = new Padding(3, 4, 3, 4);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(170, 27);
            txtdescripcion.TabIndex = 55;
            txtdescripcion.TextChanged += txtnombrecompleto_TextChanged;
            // 
            // DNI
            // 
            DNI.AutoSize = true;
            DNI.BackColor = Color.DarkOliveGreen;
            DNI.ForeColor = SystemColors.ControlLightLight;
            DNI.Location = new Point(11, 67);
            DNI.Name = "DNI";
            DNI.Size = new Size(90, 20);
            DNI.TabIndex = 52;
            DNI.Text = "Descripcion:";
            // 
            // label1
            // 
            label1.BackColor = Color.DarkOliveGreen;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(213, 620);
            label1.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkOliveGreen;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(32, 121);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 54;
            label3.Text = "Nombre Completo:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = SystemColors.ControlLight;
            label20.Font = new Font("Segoe UI", 15F);
            label20.ForeColor = SystemColors.ActiveCaptionText;
            label20.Location = new Point(229, 67);
            label20.Name = "label20";
            label20.Size = new Size(230, 35);
            label20.TabIndex = 74;
            label20.Text = "Lista de Categorias:";
            // 
            // txtindice
            // 
            txtindice.Location = new Point(128, 52);
            txtindice.Margin = new Padding(3, 4, 3, 4);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(20, 27);
            txtindice.TabIndex = 75;
            txtindice.Text = "-1";
            txtindice.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(551, 67);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 68;
            label2.Text = "Buscar:";
            // 
            // cbobusqueda
            // 
            cbobusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(609, 61);
            cbobusqueda.Margin = new Padding(3, 4, 3, 4);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(170, 28);
            cbobusqueda.TabIndex = 76;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.AllowUserToDeleteRows = false;
            dgvdata.AllowUserToResizeColumns = false;
            dgvdata.AllowUserToResizeRows = false;
            dgvdata.BackgroundColor = SystemColors.ButtonHighlight;
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, Id, Descripcion, EstadoValor, Estado });
            dgvdata.Location = new Point(259, 131);
            dgvdata.Margin = new Padding(3, 4, 3, 4);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowHeadersWidth = 51;
            dgvdata.Size = new Size(771, 411);
            dgvdata.TabIndex = 77;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
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
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 150;
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
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1080, 620);
            Controls.Add(dgvdata);
            Controls.Add(cbobusqueda);
            Controls.Add(txtindice);
            Controls.Add(label20);
            Controls.Add(btnEditar);
            Controls.Add(btnlimpiar);
            Controls.Add(btnbuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(label2);
            Controls.Add(txtid);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(cboestado);
            Controls.Add(label7);
            Controls.Add(txtdescripcion);
            Controls.Add(DNI);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "frmCategoria";
            Text = "frmCategoria";
            Load += frmCategoria_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private TextBox txtbusqueda;
        private TextBox txtid;
        private Label label9;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private ComboBox cboestado;
        private Label label7;
        private TextBox txtdescripcion;
        private Label DNI;
        private Label label1;
        private Label label3;
        private Label label20;
        private TextBox txtindice;
        private Label label2;
        private ComboBox cbobusqueda;
        private DataGridView dgvdata;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}