namespace CapaPresentacion
{
    partial class frmDetalleVenta
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
            txtbusqueda = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            txttipodocumento = new TextBox();
            txtusuario = new TextBox();
            label5 = new Label();
            txtfecha = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label10 = new Label();
            txtnombrecliente = new TextBox();
            txtdoccliente = new TextBox();
            label8 = new Label();
            label12 = new Label();
            txtmontototal = new TextBox();
            dataGridView1 = new DataGridView();
            IdVenta = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            txtmontocambio = new TextBox();
            txtmontopago = new TextBox();
            label14 = new Label();
            label13 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLight;
            label1.Location = new Point(41, 15);
            label1.Name = "label1";
            label1.Size = new Size(818, 601);
            label1.TabIndex = 1;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(664, 46);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.ReadOnly = true;
            txtbusqueda.Size = new Size(158, 27);
            txtbusqueda.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLight;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(664, 23);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 11;
            label6.Text = "ID de la Venta:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(txttipodocumento);
            groupBox1.Controls.Add(txtusuario);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(85, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(721, 104);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Venta";
            // 
            // txttipodocumento
            // 
            txttipodocumento.Location = new Point(210, 51);
            txttipodocumento.Name = "txttipodocumento";
            txttipodocumento.ReadOnly = true;
            txttipodocumento.Size = new Size(190, 27);
            txttipodocumento.TabIndex = 6;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(446, 51);
            txtusuario.Name = "txtusuario";
            txtusuario.ReadOnly = true;
            txtusuario.Size = new Size(205, 27);
            txtusuario.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(446, 27);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 4;
            label5.Text = "Usuario:";
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(7, 49);
            txtfecha.Name = "txtfecha";
            txtfecha.ReadOnly = true;
            txtfecha.Size = new Size(158, 27);
            txtfecha.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(210, 27);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 1;
            label4.Text = "Tipo Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(7, 27);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 0;
            label3.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(85, 23);
            label2.Name = "label2";
            label2.Size = new Size(214, 31);
            label2.TabIndex = 9;
            label2.Text = "Detalle de la Venta";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtnombrecliente);
            groupBox2.Controls.Add(txtdoccliente);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(85, 195);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(721, 100);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Cliente";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ControlLight;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(7, 27);
            label10.Name = "label10";
            label10.Size = new Size(148, 20);
            label10.TabIndex = 7;
            label10.Text = "Numero Documento:";
            // 
            // txtnombrecliente
            // 
            txtnombrecliente.Location = new Point(210, 51);
            txtnombrecliente.Name = "txtnombrecliente";
            txtnombrecliente.ReadOnly = true;
            txtnombrecliente.Size = new Size(190, 27);
            txtnombrecliente.TabIndex = 6;
            // 
            // txtdoccliente
            // 
            txtdoccliente.Location = new Point(7, 49);
            txtdoccliente.Name = "txtdoccliente";
            txtdoccliente.ReadOnly = true;
            txtdoccliente.Size = new Size(158, 27);
            txtdoccliente.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(210, 27);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 1;
            label8.Text = "Nombre:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ControlLight;
            label12.ForeColor = Color.Black;
            label12.Location = new Point(61, 584);
            label12.Name = "label12";
            label12.Size = new Size(93, 20);
            label12.TabIndex = 18;
            label12.Text = "Monto Total:";
            // 
            // txtmontototal
            // 
            txtmontototal.Location = new Point(160, 581);
            txtmontototal.Name = "txtmontototal";
            txtmontototal.ReadOnly = true;
            txtmontototal.Size = new Size(74, 27);
            txtmontototal.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdVenta, Producto, Precio, Cantidad, SubTotal });
            dataGridView1.Location = new Point(61, 313);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(778, 241);
            dataGridView1.TabIndex = 16;
            // 
            // IdVenta
            // 
            IdVenta.HeaderText = "ID de la Venta:";
            IdVenta.MinimumWidth = 6;
            IdVenta.Name = "IdVenta";
            IdVenta.Width = 125;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto:";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio:";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad:";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Sub-Total:";
            SubTotal.MinimumWidth = 6;
            SubTotal.Name = "SubTotal";
            SubTotal.Width = 125;
            // 
            // txtmontocambio
            // 
            txtmontocambio.Location = new Point(567, 581);
            txtmontocambio.Name = "txtmontocambio";
            txtmontocambio.ReadOnly = true;
            txtmontocambio.Size = new Size(74, 27);
            txtmontocambio.TabIndex = 23;
            txtmontocambio.TextChanged += txtcambio_TextChanged;
            // 
            // txtmontopago
            // 
            txtmontopago.Location = new Point(352, 581);
            txtmontopago.Name = "txtmontopago";
            txtmontopago.ReadOnly = true;
            txtmontopago.Size = new Size(74, 27);
            txtmontopago.TabIndex = 22;
            txtmontopago.TextChanged += txtpagacon_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ControlLight;
            label14.ForeColor = Color.Black;
            label14.Location = new Point(449, 584);
            label14.Name = "label14";
            label14.Size = new Size(112, 20);
            label14.TabIndex = 21;
            label14.Text = "Monto Cambio:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ControlLight;
            label13.ForeColor = Color.Black;
            label13.Location = new Point(253, 585);
            label13.Name = "label13";
            label13.Size = new Size(93, 20);
            label13.TabIndex = 20;
            label13.Text = "Monto Pago:";
            // 
            // frmDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(894, 629);
            Controls.Add(txtmontocambio);
            Controls.Add(txtmontopago);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txtmontototal);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(txtbusqueda);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "frmDetalleVenta";
            Text = "frmDetalleVenta";
            Load += frmDetalleVenta_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtbusqueda;
        private Label label6;
        private GroupBox groupBox1;
        private TextBox txttipodocumento;
        private TextBox txtusuario;
        private Label label5;
        private TextBox txtfecha;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Label label10;
        private TextBox txtnombrecliente;
        private TextBox txtdoccliente;
        private Label label8;
        private Label label12;
        private TextBox txtmontototal;
        private DataGridView dataGridView1;
        private TextBox txtmontocambio;
        private TextBox txtmontopago;
        private Label label14;
        private Label label13;
        private DataGridViewTextBoxColumn IdVenta;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
    }
}