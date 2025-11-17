namespace CapaPresentacion
{
    partial class frmListarVentas
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
            dataGridView1 = new DataGridView();
            IdUsuario = new DataGridViewTextBoxColumn();
            Vendedor = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            FechaVenta = new DataGridViewTextBoxColumn();
            MontoPago = new DataGridViewTextBoxColumn();
            MontoCambio = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            DetalleVenta = new DataGridViewButtonColumn();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            button1 = new Button();
            cboVendedor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdUsuario, Vendedor, Cliente, DNI, FechaVenta, MontoPago, MontoCambio, MontoTotal, DetalleVenta });
            dataGridView1.Location = new Point(14, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1166, 443);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IdUsuario
            // 
            IdUsuario.HeaderText = "ID Vendedor";
            IdUsuario.MinimumWidth = 6;
            IdUsuario.Name = "IdUsuario";
            IdUsuario.Width = 125;
            // 
            // Vendedor
            // 
            Vendedor.HeaderText = "Vendedor";
            Vendedor.MinimumWidth = 6;
            Vendedor.Name = "Vendedor";
            Vendedor.Width = 125;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.Width = 125;
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.MinimumWidth = 6;
            DNI.Name = "DNI";
            DNI.Width = 125;
            // 
            // FechaVenta
            // 
            FechaVenta.HeaderText = "Fecha venta";
            FechaVenta.MinimumWidth = 6;
            FechaVenta.Name = "FechaVenta";
            FechaVenta.Width = 125;
            // 
            // MontoPago
            // 
            MontoPago.HeaderText = "Monto Pago";
            MontoPago.MinimumWidth = 6;
            MontoPago.Name = "MontoPago";
            MontoPago.Width = 125;
            // 
            // MontoCambio
            // 
            MontoCambio.HeaderText = "Monto Cambio";
            MontoCambio.MinimumWidth = 6;
            MontoCambio.Name = "MontoCambio";
            MontoCambio.Width = 125;
            // 
            // MontoTotal
            // 
            MontoTotal.HeaderText = "Monto Total";
            MontoTotal.MinimumWidth = 6;
            MontoTotal.Name = "MontoTotal";
            MontoTotal.Width = 125;
            // 
            // DetalleVenta
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            DetalleVenta.DefaultCellStyle = dataGridViewCellStyle2;
            DetalleVenta.HeaderText = "Detalle de Venta";
            DetalleVenta.MinimumWidth = 6;
            DetalleVenta.Name = "DetalleVenta";
            DetalleVenta.Text = "[Ver Detalle]";
            DetalleVenta.UseColumnTextForButtonValue = true;
            DetalleVenta.Width = 98;
            // 
            // btnlimpiar
            // 
            btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnlimpiar.IconColor = Color.Black;
            btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiar.IconSize = 20;
            btnlimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnlimpiar.Location = new Point(824, 69);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(91, 28);
            btnlimpiar.TabIndex = 30;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLight;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(545, 45);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 27;
            label6.Text = "Vendedor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(14, 12);
            label2.Name = "label2";
            label2.Size = new Size(382, 31);
            label2.TabIndex = 25;
            label2.Text = "Detalle de las ventas por vendedor";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1183, 557);
            label1.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(32, 71);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 34;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(289, 71);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(32, 48);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 36;
            label3.Text = "Desde:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(289, 47);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 37;
            label4.Text = "Hasta:";
            // 
            // btnBuscar
            // 
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 15;
            btnBuscar.Location = new Point(754, 68);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(64, 28);
            btnBuscar.TabIndex = 38;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1385, 65);
            button1.Name = "button1";
            button1.Size = new Size(202, 29);
            button1.TabIndex = 40;
            button1.Text = "Imprimir Detalle";
            button1.UseVisualStyleBackColor = true;
            // 
            // cboVendedor
            // 
            cboVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVendedor.FormattingEnabled = true;
            cboVendedor.Location = new Point(545, 68);
            cboVendedor.Name = "cboVendedor";
            cboVendedor.Size = new Size(203, 28);
            cboVendedor.TabIndex = 41;
            // 
            // frmListarVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1205, 575);
            Controls.Add(cboVendedor);
            Controls.Add(button1);
            Controls.Add(btnBuscar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(btnlimpiar);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmListarVentas";
            Text = "frmListarVentas";
            Load += frmListarVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnbuscarvendedor;
        private TextBox txtbusqueda;
        private Label label6;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private Button button1;
        private ComboBox cboVendedor;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewTextBoxColumn Vendedor;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn FechaVenta;
        private DataGridViewTextBoxColumn MontoPago;
        private DataGridViewTextBoxColumn MontoCambio;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewButtonColumn DetalleVenta;
    }
}