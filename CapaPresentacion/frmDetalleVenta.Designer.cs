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
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btnbuscarventa = new FontAwesome.Sharp.IconButton();
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
            txtnumerodocumento = new TextBox();
            label10 = new Label();
            txtnombrecliente = new TextBox();
            txtdoccliente = new TextBox();
            label8 = new Label();
            label12 = new Label();
            txtmontototal = new TextBox();
            dataGridView1 = new DataGridView();
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
            label1.Location = new Point(36, 11);
            label1.Name = "label1";
            label1.Size = new Size(716, 451);
            label1.TabIndex = 1;
            // 
            // btnlimpiar
            // 
            btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnlimpiar.IconColor = Color.Black;
            btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiar.IconSize = 20;
            btnlimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnlimpiar.Location = new Point(596, 38);
            btnlimpiar.Margin = new Padding(3, 2, 3, 2);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(80, 21);
            btnlimpiar.TabIndex = 14;
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
            btnbuscarventa.Location = new Point(535, 38);
            btnbuscarventa.Margin = new Padding(3, 2, 3, 2);
            btnbuscarventa.Name = "btnbuscarventa";
            btnbuscarventa.Size = new Size(56, 21);
            btnbuscarventa.TabIndex = 13;
            btnbuscarventa.UseVisualStyleBackColor = true;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(391, 38);
            txtbusqueda.Margin = new Padding(3, 2, 3, 2);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(139, 23);
            txtbusqueda.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLight;
            label6.Location = new Point(391, 21);
            label6.Name = "label6";
            label6.Size = new Size(120, 15);
            label6.TabIndex = 11;
            label6.Text = "Numero Documento:";
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
            groupBox1.Location = new Point(74, 63);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(631, 78);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Venta";
            // 
            // txttipodocumento
            // 
            txttipodocumento.Location = new Point(184, 38);
            txttipodocumento.Margin = new Padding(3, 2, 3, 2);
            txttipodocumento.Name = "txttipodocumento";
            txttipodocumento.Size = new Size(167, 23);
            txttipodocumento.TabIndex = 6;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(390, 38);
            txtusuario.Margin = new Padding(3, 2, 3, 2);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(180, 23);
            txtusuario.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(390, 20);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 4;
            label5.Text = "Usuario:";
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(6, 37);
            txtfecha.Margin = new Padding(3, 2, 3, 2);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(139, 23);
            txtfecha.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 20);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 1;
            label4.Text = "Tipo Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 20);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 0;
            label3.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 17);
            label2.Name = "label2";
            label2.Size = new Size(176, 25);
            label2.TabIndex = 9;
            label2.Text = "Detalle de la Venta";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(txtnumerodocumento);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtnombrecliente);
            groupBox2.Controls.Add(txtdoccliente);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(74, 146);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(631, 75);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Cliente";
            // 
            // txtnumerodocumento
            // 
            txtnumerodocumento.Location = new Point(516, 38);
            txtnumerodocumento.Margin = new Padding(3, 2, 3, 2);
            txtnumerodocumento.Name = "txtnumerodocumento";
            txtnumerodocumento.Size = new Size(86, 23);
            txtnumerodocumento.TabIndex = 10;
            txtnumerodocumento.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ControlLight;
            label10.Location = new Point(6, 20);
            label10.Name = "label10";
            label10.Size = new Size(120, 15);
            label10.TabIndex = 7;
            label10.Text = "Numero Documento:";
            // 
            // txtnombrecliente
            // 
            txtnombrecliente.Location = new Point(184, 38);
            txtnombrecliente.Margin = new Padding(3, 2, 3, 2);
            txtnombrecliente.Name = "txtnombrecliente";
            txtnombrecliente.Size = new Size(167, 23);
            txtnombrecliente.TabIndex = 6;
            // 
            // txtdoccliente
            // 
            txtdoccliente.Location = new Point(6, 37);
            txtdoccliente.Margin = new Padding(3, 2, 3, 2);
            txtdoccliente.Name = "txtdoccliente";
            txtdoccliente.Size = new Size(139, 23);
            txtdoccliente.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(184, 20);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 1;
            label8.Text = "Nombre:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ControlLight;
            label12.Location = new Point(53, 438);
            label12.Name = "label12";
            label12.Size = new Size(74, 15);
            label12.TabIndex = 18;
            label12.Text = "Monto Total:";
            // 
            // txtmontototal
            // 
            txtmontototal.Location = new Point(140, 436);
            txtmontototal.Margin = new Padding(3, 2, 3, 2);
            txtmontototal.Name = "txtmontototal";
            txtmontototal.Size = new Size(65, 23);
            txtmontototal.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Producto, Precio, Cantidad, SubTotal });
            dataGridView1.Location = new Point(53, 235);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(681, 181);
            dataGridView1.TabIndex = 16;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
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
            txtmontocambio.Location = new Point(496, 436);
            txtmontocambio.Margin = new Padding(3, 2, 3, 2);
            txtmontocambio.Name = "txtmontocambio";
            txtmontocambio.Size = new Size(65, 23);
            txtmontocambio.TabIndex = 23;
            txtmontocambio.TextChanged += txtcambio_TextChanged;
            // 
            // txtmontopago
            // 
            txtmontopago.Location = new Point(308, 436);
            txtmontopago.Margin = new Padding(3, 2, 3, 2);
            txtmontopago.Name = "txtmontopago";
            txtmontopago.Size = new Size(65, 23);
            txtmontopago.TabIndex = 22;
            txtmontopago.TextChanged += txtpagacon_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ControlLight;
            label14.Location = new Point(393, 438);
            label14.Name = "label14";
            label14.Size = new Size(91, 15);
            label14.TabIndex = 21;
            label14.Text = "Monto Cambio:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ControlLight;
            label13.Location = new Point(221, 439);
            label13.Name = "label13";
            label13.Size = new Size(76, 15);
            label13.TabIndex = 20;
            label13.Text = "Monto Pago:";
            // 
            // frmDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(782, 472);
            Controls.Add(txtmontocambio);
            Controls.Add(txtmontopago);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txtmontototal);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(btnlimpiar);
            Controls.Add(btnbuscarventa);
            Controls.Add(txtbusqueda);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmDetalleVenta";
            Text = "frmDetalleVenta";
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
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnbuscarventa;
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
        private TextBox txtnumerodocumento;
        private Label label10;
        private TextBox txtnombrecliente;
        private TextBox txtdoccliente;
        private Label label8;
        private Label label12;
        private TextBox txtmontototal;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private TextBox txtmontocambio;
        private TextBox txtmontopago;
        private Label label14;
        private Label label13;
    }
}