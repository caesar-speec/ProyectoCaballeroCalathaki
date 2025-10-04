namespace CapaPresentacion
{
    partial class frmReporteVentas
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
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            btnbuscarfecha = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            idVenta = new DataGridViewTextBoxColumn();
            UsuarioRegistro = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            DocumentoCliente = new DataGridViewTextBoxColumn();
            NombreCliente = new DataGridViewTextBoxColumn();
            MontoPago = new DataGridViewTextBoxColumn();
            MontoCambio = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            DetalleVenta = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLight;
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(1161, 97);
            label1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(31, 72);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 4;
            label2.Text = "Desde";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(210, 72);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 5;
            label3.Text = "Hasta";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(87, 67);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(114, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(263, 67);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(114, 27);
            dateTimePicker2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(31, 18);
            label4.Name = "label4";
            label4.Size = new Size(224, 31);
            label4.TabIndex = 8;
            label4.Text = "Detalle de la Ventas";
            // 
            // btnbuscarfecha
            // 
            btnbuscarfecha.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscarfecha.IconColor = Color.Black;
            btnbuscarfecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarfecha.IconSize = 25;
            btnbuscarfecha.Location = new Point(396, 65);
            btnbuscarfecha.Name = "btnbuscarfecha";
            btnbuscarfecha.Size = new Size(64, 34);
            btnbuscarfecha.TabIndex = 9;
            btnbuscarfecha.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ControlLight;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 129);
            label6.Name = "label6";
            label6.Size = new Size(1161, 441);
            label6.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idVenta, UsuarioRegistro, TipoDocumento, NumeroDocumento, DocumentoCliente, NombreCliente, MontoPago, MontoCambio, MontoTotal, FechaRegistro, DetalleVenta });
            dataGridView1.Location = new Point(31, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1119, 403);
            dataGridView1.TabIndex = 19;
            // 
            // idVenta
            // 
            idVenta.HeaderText = "Id Venta";
            idVenta.MinimumWidth = 6;
            idVenta.Name = "idVenta";
            idVenta.Visible = false;
            idVenta.Width = 125;
            // 
            // UsuarioRegistro
            // 
            UsuarioRegistro.HeaderText = "Usuario Registro";
            UsuarioRegistro.MinimumWidth = 6;
            UsuarioRegistro.Name = "UsuarioRegistro";
            UsuarioRegistro.Width = 125;
            // 
            // TipoDocumento
            // 
            TipoDocumento.HeaderText = "TipoDocumento";
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
            // DocumentoCliente
            // 
            DocumentoCliente.HeaderText = "Documento Cliente";
            DocumentoCliente.MinimumWidth = 6;
            DocumentoCliente.Name = "DocumentoCliente";
            DocumentoCliente.Width = 125;
            // 
            // NombreCliente
            // 
            NombreCliente.HeaderText = "Nombre Cliente";
            NombreCliente.MinimumWidth = 6;
            NombreCliente.Name = "NombreCliente";
            NombreCliente.Width = 125;
            // 
            // MontoPago
            // 
            MontoPago.HeaderText = "MontoPago";
            MontoPago.MinimumWidth = 6;
            MontoPago.Name = "MontoPago";
            MontoPago.Visible = false;
            MontoPago.Width = 125;
            // 
            // MontoCambio
            // 
            MontoCambio.HeaderText = "MontoCambio";
            MontoCambio.MinimumWidth = 6;
            MontoCambio.Name = "MontoCambio";
            MontoCambio.Visible = false;
            MontoCambio.Width = 125;
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
            // DetalleVenta
            // 
            DetalleVenta.HeaderText = "Ver Detalle";
            DetalleVenta.MinimumWidth = 6;
            DetalleVenta.Name = "DetalleVenta";
            DetalleVenta.Width = 125;
            // 
            // frmReporteVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1187, 579);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(btnbuscarfecha);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmReporteVentas";
            Text = "frmReporteVentas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnbuscarfecha;
        private Label label6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idVenta;
        private DataGridViewTextBoxColumn UsuarioRegistro;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn DocumentoCliente;
        private DataGridViewTextBoxColumn NombreCliente;
        private DataGridViewTextBoxColumn MontoPago;
        private DataGridViewTextBoxColumn MontoCambio;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewButtonColumn DetalleVenta;
    }
}