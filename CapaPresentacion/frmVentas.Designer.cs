namespace CapaPresentacion
{
    partial class frmVentas
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
            groupBox2 = new GroupBox();
            txtidproveedor = new TextBox();
            btnbuscarcliente = new FontAwesome.Sharp.IconButton();
            txtnombrecliente = new TextBox();
            txtdocumentocliente = new TextBox();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            cbotipodocumento = new ComboBox();
            txtfecha = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            txtidproducto = new TextBox();
            txtcantidad = new NumericUpDown();
            label10 = new Label();
            label11 = new Label();
            label9 = new Label();
            txtstock = new TextBox();
            txtprecio = new TextBox();
            btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            txtproducto = new TextBox();
            txtcodproducto = new TextBox();
            label7 = new Label();
            label8 = new Label();
            btnagregarproducto = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            idProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btneliminar = new DataGridViewButtonColumn();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            txttotalpagar = new TextBox();
            txtpagacon = new TextBox();
            txtcambio = new TextBox();
            btnregistrar = new FontAwesome.Sharp.IconButton();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtcantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLight;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(1078, 568);
            label1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(txtidproveedor);
            groupBox2.Controls.Add(btnbuscarcliente);
            groupBox2.Controls.Add(txtnombrecliente);
            groupBox2.Controls.Add(txtdocumentocliente);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(532, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(503, 93);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Cliente";
            // 
            // txtidproveedor
            // 
            txtidproveedor.Location = new Point(388, 17);
            txtidproveedor.Name = "txtidproveedor";
            txtidproveedor.Size = new Size(34, 27);
            txtidproveedor.TabIndex = 4;
            txtidproveedor.Visible = false;
            // 
            // btnbuscarcliente
            // 
            btnbuscarcliente.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscarcliente.IconColor = Color.Black;
            btnbuscarcliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarcliente.IconSize = 26;
            btnbuscarcliente.Location = new Point(171, 49);
            btnbuscarcliente.Name = "btnbuscarcliente";
            btnbuscarcliente.Size = new Size(52, 28);
            btnbuscarcliente.TabIndex = 4;
            btnbuscarcliente.UseVisualStyleBackColor = true;
            // 
            // txtnombrecliente
            // 
            txtnombrecliente.Location = new Point(239, 50);
            txtnombrecliente.Name = "txtnombrecliente";
            txtnombrecliente.Size = new Size(183, 27);
            txtnombrecliente.TabIndex = 3;
            // 
            // txtdocumentocliente
            // 
            txtdocumentocliente.Location = new Point(7, 49);
            txtdocumentocliente.Name = "txtdocumentocliente";
            txtdocumentocliente.Size = new Size(158, 27);
            txtdocumentocliente.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(239, 26);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 1;
            label5.Text = "Nombre Completo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 26);
            label6.Name = "label6";
            label6.Size = new Size(148, 20);
            label6.TabIndex = 0;
            label6.Text = "Numero Documento:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(cbotipodocumento);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(63, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(463, 93);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Venta";
            // 
            // cbotipodocumento
            // 
            cbotipodocumento.FormattingEnabled = true;
            cbotipodocumento.Location = new Point(186, 49);
            cbotipodocumento.Name = "cbotipodocumento";
            cbotipodocumento.Size = new Size(192, 28);
            cbotipodocumento.TabIndex = 3;
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(7, 49);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(158, 27);
            txtfecha.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 26);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 1;
            label4.Text = "Tipo Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 26);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 0;
            label3.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 27);
            label2.Name = "label2";
            label2.Size = new Size(176, 28);
            label2.TabIndex = 6;
            label2.Text = "Registrar Venta";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlLight;
            groupBox3.Controls.Add(txtidproducto);
            groupBox3.Controls.Add(txtcantidad);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtstock);
            groupBox3.Controls.Add(txtprecio);
            groupBox3.Controls.Add(btnbuscarproducto);
            groupBox3.Controls.Add(txtproducto);
            groupBox3.Controls.Add(txtcodproducto);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(63, 169);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(883, 98);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion del Producto";
            // 
            // txtidproducto
            // 
            txtidproducto.Location = new Point(169, 21);
            txtidproducto.Name = "txtidproducto";
            txtidproducto.Size = new Size(34, 27);
            txtidproducto.TabIndex = 10;
            txtidproducto.Visible = false;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(786, 49);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(85, 27);
            txtcantidad.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(639, 23);
            label10.Name = "label10";
            label10.Size = new Size(48, 20);
            label10.TabIndex = 7;
            label10.Text = "Stock:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(786, 24);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 8;
            label11.Text = "Cantidad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(501, 22);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 6;
            label9.Text = "Precio:";
            // 
            // txtstock
            // 
            txtstock.Location = new Point(639, 49);
            txtstock.Name = "txtstock";
            txtstock.Size = new Size(116, 27);
            txtstock.TabIndex = 5;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(501, 49);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(122, 27);
            txtprecio.TabIndex = 4;
            // 
            // btnbuscarproducto
            // 
            btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscarproducto.IconColor = Color.Black;
            btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarproducto.IconSize = 26;
            btnbuscarproducto.Location = new Point(209, 49);
            btnbuscarproducto.Name = "btnbuscarproducto";
            btnbuscarproducto.Size = new Size(52, 28);
            btnbuscarproducto.TabIndex = 4;
            btnbuscarproducto.UseVisualStyleBackColor = true;
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(292, 48);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(183, 27);
            txtproducto.TabIndex = 3;
            // 
            // txtcodproducto
            // 
            txtcodproducto.Location = new Point(7, 49);
            txtcodproducto.Name = "txtcodproducto";
            txtcodproducto.Size = new Size(196, 27);
            txtcodproducto.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(292, 24);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 1;
            label7.Text = "Producto:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 26);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 0;
            label8.Text = "Cod. Producto:";
            // 
            // btnagregarproducto
            // 
            btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnagregarproducto.IconColor = Color.Green;
            btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnagregarproducto.Location = new Point(971, 196);
            btnagregarproducto.Name = "btnagregarproducto";
            btnagregarproducto.Size = new Size(94, 72);
            btnagregarproducto.TabIndex = 8;
            btnagregarproducto.Text = "Agregar";
            btnagregarproducto.TextImageRelation = TextImageRelation.ImageAboveText;
            btnagregarproducto.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idProducto, Producto, Precio, Cantidad, SubTotal, btneliminar });
            dataGridView1.Location = new Point(63, 273);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(883, 287);
            dataGridView1.TabIndex = 9;
            // 
            // idProducto
            // 
            idProducto.HeaderText = "idProducto";
            idProducto.MinimumWidth = 6;
            idProducto.Name = "idProducto";
            idProducto.Visible = false;
            idProducto.Width = 35;
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
            // btneliminar
            // 
            btneliminar.HeaderText = "";
            btneliminar.MinimumWidth = 6;
            btneliminar.Name = "btneliminar";
            btneliminar.Width = 125;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ControlLight;
            label12.Location = new Point(971, 298);
            label12.Name = "label12";
            label12.Size = new Size(98, 20);
            label12.TabIndex = 10;
            label12.Text = "Total a Pagar:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ControlLight;
            label13.Location = new Point(971, 383);
            label13.Name = "label13";
            label13.Size = new Size(72, 20);
            label13.TabIndex = 12;
            label13.Text = "Paga con:";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ControlLight;
            label14.Location = new Point(971, 444);
            label14.Name = "label14";
            label14.Size = new Size(64, 20);
            label14.TabIndex = 14;
            label14.Text = "Cambio:";
            // 
            // txttotalpagar
            // 
            txttotalpagar.Location = new Point(971, 321);
            txttotalpagar.Name = "txttotalpagar";
            txttotalpagar.Size = new Size(98, 27);
            txttotalpagar.TabIndex = 15;
            // 
            // txtpagacon
            // 
            txtpagacon.Location = new Point(971, 406);
            txtpagacon.Name = "txtpagacon";
            txtpagacon.Size = new Size(98, 27);
            txtpagacon.TabIndex = 16;
            // 
            // txtcambio
            // 
            txtcambio.Location = new Point(971, 467);
            txtcambio.Name = "txtcambio";
            txtcambio.Size = new Size(98, 27);
            txtcambio.TabIndex = 17;
            // 
            // btnregistrar
            // 
            btnregistrar.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            btnregistrar.IconColor = Color.ForestGreen;
            btnregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnregistrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnregistrar.Location = new Point(953, 507);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(127, 53);
            btnregistrar.TabIndex = 18;
            btnregistrar.Text = "Realizar Venta";
            btnregistrar.TextAlign = ContentAlignment.MiddleRight;
            btnregistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnregistrar.UseVisualStyleBackColor = true;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1141, 581);
            Controls.Add(btnregistrar);
            Controls.Add(txtcambio);
            Controls.Add(txtpagacon);
            Controls.Add(txttotalpagar);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(dataGridView1);
            Controls.Add(btnagregarproducto);
            Controls.Add(groupBox3);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmVentas";
            Text = "frmVentas";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtcantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtidproveedor;
        private FontAwesome.Sharp.IconButton btnbuscarcliente;
        private TextBox txtnombrecliente;
        private TextBox txtdocumentocliente;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private ComboBox cbotipodocumento;
        private TextBox txtfecha;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox3;
        private TextBox txtidproducto;
        private NumericUpDown txtcantidad;
        private Label label10;
        private Label label11;
        private Label label9;
        private TextBox txtstock;
        private TextBox txtprecio;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private TextBox txtproducto;
        private TextBox txtcodproducto;
        private Label label7;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnagregarproducto;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewButtonColumn btneliminar;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox txttotalpagar;
        private TextBox txtpagacon;
        private TextBox txtcambio;
        private FontAwesome.Sharp.IconButton btnregistrar;
    }
}