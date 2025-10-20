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
            dataGridView1 = new DataGridView();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btnbuscarventa = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            Descripcion = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            button1 = new Button();
            Vendedor = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            FechaVenta = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            DetalleVenta = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Vendedor, Cliente, DNI, FechaVenta, MontoTotal, DetalleVenta });
            dataGridView1.Location = new Point(29, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(742, 443);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnlimpiar
            // 
            btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnlimpiar.IconColor = Color.Black;
            btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiar.IconSize = 20;
            btnlimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnlimpiar.Location = new Point(319, 69);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(91, 28);
            btnlimpiar.TabIndex = 30;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // btnbuscarventa
            // 
            btnbuscarventa.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscarventa.IconColor = Color.Black;
            btnbuscarventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarventa.IconSize = 15;
            btnbuscarventa.Location = new Point(248, 69);
            btnbuscarventa.Name = "btnbuscarventa";
            btnbuscarventa.Size = new Size(64, 28);
            btnbuscarventa.TabIndex = 29;
            btnbuscarventa.UseVisualStyleBackColor = true;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(70, 69);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(158, 27);
            txtbusqueda.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLight;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(29, 46);
            label6.Name = "label6";
            label6.Size = new Size(215, 20);
            label6.TabIndex = 27;
            label6.Text = "Numero Documento vendedor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(70, 12);
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
            label1.Size = new Size(1606, 582);
            label1.TabIndex = 24;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Descripcion, PrecioUnitario, Cantidad, Subtotal });
            dataGridView2.Location = new Point(799, 123);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(788, 443);
            dataGridView2.TabIndex = 33;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 125;
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.HeaderText = "Precio Uni.";
            PrecioUnitario.MinimumWidth = 6;
            PrecioUnitario.Name = "PrecioUnitario";
            PrecioUnitario.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 125;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(461, 67);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 34;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(731, 67);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(461, 44);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 36;
            label3.Text = "Desde:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(731, 44);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 37;
            label4.Text = "Hasta:";
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 15;
            iconButton1.Location = new Point(998, 66);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(64, 28);
            iconButton1.TabIndex = 38;
            iconButton1.UseVisualStyleBackColor = true;
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
            // MontoTotal
            // 
            MontoTotal.HeaderText = "Monto Total";
            MontoTotal.MinimumWidth = 6;
            MontoTotal.Name = "MontoTotal";
            MontoTotal.Width = 125;
            // 
            // DetalleVenta
            // 
            DetalleVenta.HeaderText = "Detalle de Venta";
            DetalleVenta.MinimumWidth = 6;
            DetalleVenta.Name = "DetalleVenta";
            DetalleVenta.Text = "[Ver más]";
            DetalleVenta.Width = 102;
            // 
            // frmListarVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(1630, 600);
            Controls.Add(button1);
            Controls.Add(iconButton1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(btnlimpiar);
            Controls.Add(btnbuscarventa);
            Controls.Add(txtbusqueda);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmListarVentas";
            Text = "frmListarVentas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnbuscarventa;
        private TextBox txtbusqueda;
        private Label label6;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Button button1;
        private DataGridViewTextBoxColumn Vendedor;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn FechaVenta;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewButtonColumn DetalleVenta;
    }
}