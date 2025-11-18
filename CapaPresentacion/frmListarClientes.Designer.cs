namespace CapaPresentacion
{
    partial class frmListarClientes
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label9 = new Label();
            dgvdata = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Domicilio = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label11 = new Label();
            cboBusqueda = new ComboBox();
            txtBusqueda = new TextBox();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            btnCambiarEstado = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1232, 94);
            label1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 29);
            label9.Name = "label9";
            label9.Size = new Size(315, 29);
            label9.TabIndex = 47;
            label9.Text = "Administración de Clientes";
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { Id, Documento, NombreCompleto, Correo, Telefono, Domicilio, EstadoValor, Estado });
            dgvdata.Location = new Point(12, 115);
            dgvdata.Margin = new Padding(3, 4, 3, 4);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 28;
            dgvdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvdata.Size = new Size(1140, 496);
            dgvdata.TabIndex = 48;
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
            Correo.Width = 150;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 125;
            // 
            // Domicilio
            // 
            Domicilio.HeaderText = "Domicilio";
            Domicilio.MinimumWidth = 6;
            Domicilio.Name = "Domicilio";
            Domicilio.ReadOnly = true;
            Domicilio.Width = 180;
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
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(393, 37);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 55;
            label11.Text = "Buscar por:";
            // 
            // cboBusqueda
            // 
            cboBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBusqueda.FormattingEnabled = true;
            cboBusqueda.Location = new Point(481, 34);
            cboBusqueda.Margin = new Padding(3, 4, 3, 4);
            cboBusqueda.Name = "cboBusqueda";
            cboBusqueda.Size = new Size(142, 28);
            cboBusqueda.TabIndex = 56;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(629, 35);
            txtBusqueda.Margin = new Padding(3, 4, 3, 4);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(189, 27);
            txtBusqueda.TabIndex = 57;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = Color.Black;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 16;
            btnBuscar.Location = new Point(835, 34);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(60, 32);
            btnBuscar.TabIndex = 58;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiarBuscador
            // 
            btnLimpiarBuscador.BackColor = Color.White;
            btnLimpiarBuscador.Cursor = Cursors.Hand;
            btnLimpiarBuscador.FlatAppearance.BorderColor = Color.Black;
            btnLimpiarBuscador.FlatStyle = FlatStyle.Flat;
            btnLimpiarBuscador.ForeColor = Color.Black;
            btnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnLimpiarBuscador.IconColor = Color.Black;
            btnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiarBuscador.IconSize = 16;
            btnLimpiarBuscador.Location = new Point(902, 34);
            btnLimpiarBuscador.Margin = new Padding(3, 4, 3, 4);
            btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            btnLimpiarBuscador.Size = new Size(60, 32);
            btnLimpiarBuscador.TabIndex = 59;
            btnLimpiarBuscador.UseVisualStyleBackColor = false;
            btnLimpiarBuscador.Click += btnLimpiarBuscador_Click;
            // 
            // btnCambiarEstado
            // 
            btnCambiarEstado.BackColor = Color.RoyalBlue;
            btnCambiarEstado.Cursor = Cursors.Hand;
            btnCambiarEstado.FlatStyle = FlatStyle.Flat;
            btnCambiarEstado.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCambiarEstado.ForeColor = Color.White;
            btnCambiarEstado.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            btnCambiarEstado.IconColor = Color.White;
            btnCambiarEstado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCambiarEstado.IconSize = 25;
            btnCambiarEstado.Location = new Point(968, 21);
            btnCambiarEstado.Margin = new Padding(3, 4, 3, 4);
            btnCambiarEstado.Name = "btnCambiarEstado";
            btnCambiarEstado.Size = new Size(250, 55);
            btnCambiarEstado.TabIndex = 60;
            btnCambiarEstado.Text = "Cambiar Estado (Act/Des)";
            btnCambiarEstado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCambiarEstado.UseVisualStyleBackColor = false;
            btnCambiarEstado.Click += btnCambiarEstado_Click;
            // 
            // frmListarClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1232, 642);
            Controls.Add(btnCambiarEstado);
            Controls.Add(btnLimpiarBuscador);
            Controls.Add(btnBuscar);
            Controls.Add(txtBusqueda);
            Controls.Add(cboBusqueda);
            Controls.Add(label11);
            Controls.Add(dgvdata);
            Controls.Add(label9);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmListarClientes";
            Text = "frmListarClientes";
            Load += frmListarClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private FontAwesome.Sharp.IconButton btnCambiarEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}