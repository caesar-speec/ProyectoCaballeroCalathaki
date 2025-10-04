namespace CapaPresentacion
{
    partial class frmVerMisCompras
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
            FechaRegistro = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            dtfin = new DateTimePicker();
            label4 = new Label();
            dtinicio = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FechaRegistro, NumeroDocumento, MontoTotal, CodigoProducto, NombreProducto, Categoria, PrecioCompra, PrecioVenta, Cantidad, SubTotal });
            dataGridView1.Location = new Point(-2, 71);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1292, 268);
            dataGridView1.TabIndex = 19;
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "Fecha Registro";
            FechaRegistro.MinimumWidth = 6;
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.Width = 125;
            // 
            // NumeroDocumento
            // 
            NumeroDocumento.HeaderText = "Numero Documento";
            NumeroDocumento.MinimumWidth = 6;
            NumeroDocumento.Name = "NumeroDocumento";
            NumeroDocumento.Width = 125;
            // 
            // MontoTotal
            // 
            MontoTotal.HeaderText = "Monto Total";
            MontoTotal.MinimumWidth = 6;
            MontoTotal.Name = "MontoTotal";
            MontoTotal.Width = 125;
            // 
            // CodigoProducto
            // 
            CodigoProducto.HeaderText = "Codigo Producto";
            CodigoProducto.MinimumWidth = 6;
            CodigoProducto.Name = "CodigoProducto";
            CodigoProducto.Width = 125;
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Nombre Producto";
            NombreProducto.MinimumWidth = 6;
            NombreProducto.Name = "NombreProducto";
            NombreProducto.Width = 125;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.Width = 125;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.Width = 125;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Sub-Total";
            SubTotal.MinimumWidth = 6;
            SubTotal.Name = "SubTotal";
            SubTotal.Width = 125;
            // 
            // dtfin
            // 
            dtfin.CustomFormat = "dd/MM/yyyy";
            dtfin.Format = DateTimePickerFormat.Short;
            dtfin.Location = new Point(411, 27);
            dtfin.Margin = new Padding(3, 2, 3, 2);
            dtfin.Name = "dtfin";
            dtfin.Size = new Size(97, 23);
            dtfin.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(344, 30);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 44;
            label4.Text = "Fecha fin:";
            // 
            // dtinicio
            // 
            dtinicio.CustomFormat = "dd/MM/yyyy";
            dtinicio.Format = DateTimePickerFormat.Short;
            dtinicio.Location = new Point(234, 27);
            dtinicio.Margin = new Padding(3, 2, 3, 2);
            dtinicio.Name = "dtinicio";
            dtinicio.Size = new Size(97, 23);
            dtinicio.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(150, 29);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 42;
            label3.Text = "Fecha inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(-2, 21);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 41;
            label2.Text = "Mis Compras";
            // 
            // frmVerMisCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 450);
            Controls.Add(dtfin);
            Controls.Add(label4);
            Controls.Add(dtinicio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "frmVerMisCompras";
            Text = "frmVerMisCompras";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DateTimePicker dtfin;
        private Label label4;
        private DateTimePicker dtinicio;
        private Label label3;
        private Label label2;
    }
}