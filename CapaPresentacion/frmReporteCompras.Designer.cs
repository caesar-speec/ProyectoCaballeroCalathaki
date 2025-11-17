namespace CapaPresentacion
{
    partial class frmReporteCompras
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
            label3 = new Label();
            label2 = new Label();
            dtinicio = new DateTimePicker();
            dtfin = new DateTimePicker();
            label4 = new Label();
            cboProveedor = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            IdCompra = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            UsuarioRegistro = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            DetalleCompra = new DataGridViewButtonColumn();
            label7 = new Label();
            cboRepositor = new ComboBox();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLight;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(1161, 97);
            label1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(29, 61);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 3;
            label3.Text = "Fecha inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(21, 19);
            label2.Name = "label2";
            label2.Size = new Size(266, 31);
            label2.TabIndex = 10;
            label2.Text = "Reporte de las Compras";
            // 
            // dtinicio
            // 
            dtinicio.CustomFormat = "dd/MM/yyyy";
            dtinicio.Format = DateTimePickerFormat.Short;
            dtinicio.Location = new Point(125, 63);
            dtinicio.Name = "dtinicio";
            dtinicio.Size = new Size(110, 27);
            dtinicio.TabIndex = 11;
            // 
            // dtfin
            // 
            dtfin.CustomFormat = "dd/MM/yyyy";
            dtfin.Format = DateTimePickerFormat.Short;
            dtfin.Location = new Point(327, 62);
            dtfin.Name = "dtfin";
            dtfin.Size = new Size(110, 27);
            dtfin.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(250, 62);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 12;
            label4.Text = "Fecha fin:";
            // 
            // cboProveedor
            // 
            cboProveedor.FormattingEnabled = true;
            cboProveedor.Location = new Point(446, 62);
            cboProveedor.Name = "cboProveedor";
            cboProveedor.Size = new Size(191, 28);
            cboProveedor.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLight;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(446, 39);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 15;
            label5.Text = "Proveedor:";
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ControlLight;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(11, 128);
            label6.Name = "label6";
            label6.Size = new Size(1161, 441);
            label6.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdCompra, TipoDocumento, NumeroDocumento, RazonSocial, UsuarioRegistro, MontoTotal, FechaRegistro, DetalleCompra });
            dataGridView1.Location = new Point(21, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1141, 368);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IdCompra
            // 
            IdCompra.HeaderText = "ID de Compra";
            IdCompra.MinimumWidth = 6;
            IdCompra.Name = "IdCompra";
            IdCompra.Width = 125;
            // 
            // TipoDocumento
            // 
            TipoDocumento.HeaderText = "Tipo Documento";
            TipoDocumento.MinimumWidth = 6;
            TipoDocumento.Name = "TipoDocumento";
            TipoDocumento.Width = 125;
            // 
            // NumeroDocumento
            // 
            NumeroDocumento.HeaderText = "Numero Documento";
            NumeroDocumento.MinimumWidth = 6;
            NumeroDocumento.Name = "NumeroDocumento";
            NumeroDocumento.Width = 125;
            // 
            // RazonSocial
            // 
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.MinimumWidth = 6;
            RazonSocial.Name = "RazonSocial";
            RazonSocial.Width = 125;
            // 
            // UsuarioRegistro
            // 
            UsuarioRegistro.HeaderText = "UsuarioRegistro";
            UsuarioRegistro.MinimumWidth = 6;
            UsuarioRegistro.Name = "UsuarioRegistro";
            UsuarioRegistro.Width = 125;
            // 
            // MontoTotal
            // 
            MontoTotal.HeaderText = "Monto Total";
            MontoTotal.MinimumWidth = 6;
            MontoTotal.Name = "MontoTotal";
            MontoTotal.Width = 125;
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "Fecha Registro";
            FechaRegistro.MinimumWidth = 6;
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.Width = 125;
            // 
            // DetalleCompra
            // 
            DetalleCompra.HeaderText = "Detalle de la Compra";
            DetalleCompra.MinimumWidth = 6;
            DetalleCompra.Name = "DetalleCompra";
            DetalleCompra.Text = "[Ver Detalle]";
            DetalleCompra.Width = 125;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlLight;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(643, 39);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 22;
            label7.Text = "Repositor:";
            // 
            // cboRepositor
            // 
            cboRepositor.FormattingEnabled = true;
            cboRepositor.Location = new Point(643, 62);
            cboRepositor.Name = "cboRepositor";
            cboRepositor.Size = new Size(191, 28);
            cboRepositor.TabIndex = 21;
            // 
            // btnbuscar
            // 
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 15;
            btnbuscar.Location = new Point(840, 61);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(53, 28);
            btnbuscar.TabIndex = 24;
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlLight;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(21, 143);
            label8.Name = "label8";
            label8.Size = new Size(234, 28);
            label8.TabIndex = 25;
            label8.Text = "Listado de las Compras:";
            // 
            // frmReporteCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1187, 579);
            Controls.Add(label8);
            Controls.Add(btnbuscar);
            Controls.Add(label7);
            Controls.Add(cboRepositor);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cboProveedor);
            Controls.Add(dtfin);
            Controls.Add(label4);
            Controls.Add(dtinicio);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "frmReporteCompras";
            Text = "Reporte de Compras";
            Load += frmReporteCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label3;
        private Label label2;
        private DateTimePicker dtinicio;
        private DateTimePicker dtfin;
        private Label label4;
        private ComboBox cboProveedor;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private Label label7;
        private ComboBox cboRepositor;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private DataGridViewTextBoxColumn IdCompra;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn UsuarioRegistro;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewButtonColumn DetalleCompra;
        private Label label8;
    }
}