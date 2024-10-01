namespace CapaPresentacion
{
    partial class frmCompras
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
            groupBox1 = new GroupBox();
            cbotipodocumento = new ComboBox();
            txtfecha = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            txtidproveedor = new TextBox();
            btnbuscarproveedor = new FontAwesome.Sharp.IconButton();
            txtnombreproveedor = new TextBox();
            txtdocproveedor = new TextBox();
            label5 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            txtidproducto = new TextBox();
            txtcantidad = new NumericUpDown();
            label10 = new Label();
            label11 = new Label();
            label9 = new Label();
            txtprecioventa = new TextBox();
            txtpreciocompra = new TextBox();
            btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            txtproducto = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            idProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btneliminar = new DataGridViewButtonColumn();
            btnagregarproducto = new FontAwesome.Sharp.IconButton();
            label12 = new Label();
            txttotalpagar = new TextBox();
            btnregistrar = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            label1.Location = new Point(39, 14);
            label1.Name = "label1";
            label1.Size = new Size(928, 439);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 47);
            label2.Name = "label2";
            label2.Size = new Size(163, 24);
            label2.TabIndex = 1;
            label2.Text = "Registrar Compra";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(cbotipodocumento);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(64, 70);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(381, 70);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Compra";
            // 
            // cbotipodocumento
            // 
            cbotipodocumento.FormattingEnabled = true;
            cbotipodocumento.Location = new Point(163, 37);
            cbotipodocumento.Margin = new Padding(3, 2, 3, 2);
            cbotipodocumento.Name = "cbotipodocumento";
            cbotipodocumento.Size = new Size(168, 23);
            cbotipodocumento.TabIndex = 3;
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
            label4.Location = new Point(163, 20);
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
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(txtidproveedor);
            groupBox2.Controls.Add(btnbuscarproveedor);
            groupBox2.Controls.Add(txtnombreproveedor);
            groupBox2.Controls.Add(txtdocproveedor);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(493, 70);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(450, 70);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Proveedor";
            // 
            // txtidproveedor
            // 
            txtidproveedor.Location = new Point(340, 13);
            txtidproveedor.Margin = new Padding(3, 2, 3, 2);
            txtidproveedor.Name = "txtidproveedor";
            txtidproveedor.Size = new Size(30, 23);
            txtidproveedor.TabIndex = 4;
            txtidproveedor.Visible = false;
            // 
            // btnbuscarproveedor
            // 
            btnbuscarproveedor.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscarproveedor.IconColor = Color.Black;
            btnbuscarproveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarproveedor.IconSize = 15;
            btnbuscarproveedor.Location = new Point(150, 37);
            btnbuscarproveedor.Margin = new Padding(3, 2, 3, 2);
            btnbuscarproveedor.Name = "btnbuscarproveedor";
            btnbuscarproveedor.Size = new Size(46, 21);
            btnbuscarproveedor.TabIndex = 4;
            btnbuscarproveedor.UseVisualStyleBackColor = true;
            btnbuscarproveedor.Click += btnbuscarproveedor_Click;
            // 
            // txtnombreproveedor
            // 
            txtnombreproveedor.Location = new Point(209, 38);
            txtnombreproveedor.Margin = new Padding(3, 2, 3, 2);
            txtnombreproveedor.Name = "txtnombreproveedor";
            txtnombreproveedor.Size = new Size(161, 23);
            txtnombreproveedor.TabIndex = 3;
            // 
            // txtdocproveedor
            // 
            txtdocproveedor.Location = new Point(6, 37);
            txtdocproveedor.Margin = new Padding(3, 2, 3, 2);
            txtdocproveedor.Name = "txtdocproveedor";
            txtdocproveedor.Size = new Size(139, 23);
            txtdocproveedor.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 20);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 1;
            label5.Text = "Razon Social:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 20);
            label6.Name = "label6";
            label6.Size = new Size(120, 15);
            label6.TabIndex = 0;
            label6.Text = "Numero Documento:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlLight;
            groupBox3.Controls.Add(txtidproducto);
            groupBox3.Controls.Add(txtcantidad);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtprecioventa);
            groupBox3.Controls.Add(txtpreciocompra);
            groupBox3.Controls.Add(btnbuscarproducto);
            groupBox3.Controls.Add(txtproducto);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(64, 155);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(785, 70);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion Proveedor";
            // 
            // txtidproducto
            // 
            txtidproducto.Location = new Point(148, 11);
            txtidproducto.Margin = new Padding(3, 2, 3, 2);
            txtidproducto.Name = "txtidproducto";
            txtidproducto.Size = new Size(30, 23);
            txtidproducto.TabIndex = 10;
            txtidproducto.Visible = false;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(688, 37);
            txtcantidad.Margin = new Padding(3, 2, 3, 2);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(74, 23);
            txtcantidad.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(559, 17);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 7;
            label10.Text = "Precio Venta:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(688, 18);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 8;
            label11.Text = "Cantidad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(438, 16);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 6;
            label9.Text = "Precio compra:";
            // 
            // txtprecioventa
            // 
            txtprecioventa.Location = new Point(559, 37);
            txtprecioventa.Margin = new Padding(3, 2, 3, 2);
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.Size = new Size(102, 23);
            txtprecioventa.TabIndex = 5;
            txtprecioventa.TextChanged += textBox4_TextChanged;
            // 
            // txtpreciocompra
            // 
            txtpreciocompra.Location = new Point(438, 37);
            txtpreciocompra.Margin = new Padding(3, 2, 3, 2);
            txtpreciocompra.Name = "txtpreciocompra";
            txtpreciocompra.Size = new Size(107, 23);
            txtpreciocompra.TabIndex = 4;
            // 
            // btnbuscarproducto
            // 
            btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscarproducto.IconColor = Color.Black;
            btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarproducto.IconSize = 15;
            btnbuscarproducto.Location = new Point(183, 37);
            btnbuscarproducto.Margin = new Padding(3, 2, 3, 2);
            btnbuscarproducto.Name = "btnbuscarproducto";
            btnbuscarproducto.Size = new Size(46, 21);
            btnbuscarproducto.TabIndex = 4;
            btnbuscarproducto.UseVisualStyleBackColor = true;
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(256, 36);
            txtproducto.Margin = new Padding(3, 2, 3, 2);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(161, 23);
            txtproducto.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 37);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 23);
            textBox3.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(256, 18);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 1;
            label7.Text = "Producto:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 20);
            label8.Name = "label8";
            label8.Size = new Size(120, 15);
            label8.TabIndex = 0;
            label8.Text = "Numero Documento:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idProducto, Producto, PrecioCompra, PrecioVenta, Cantidad, SubTotal, btneliminar });
            dataGridView1.Location = new Point(64, 238);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(785, 194);
            dataGridView1.TabIndex = 5;
            // 
            // idProducto
            // 
            idProducto.HeaderText = "id_Producto";
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
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra:";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.Width = 125;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.Visible = false;
            PrecioVenta.Width = 125;
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
            // btnagregarproducto
            // 
            btnagregarproducto.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnagregarproducto.IconColor = Color.Green;
            btnagregarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnagregarproducto.Location = new Point(860, 166);
            btnagregarproducto.Margin = new Padding(3, 2, 3, 2);
            btnagregarproducto.Name = "btnagregarproducto";
            btnagregarproducto.Size = new Size(82, 56);
            btnagregarproducto.TabIndex = 6;
            btnagregarproducto.Text = "Agregar";
            btnagregarproducto.TextImageRelation = TextImageRelation.ImageAboveText;
            btnagregarproducto.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ControlLight;
            label12.Location = new Point(866, 350);
            label12.Name = "label12";
            label12.Size = new Size(77, 15);
            label12.TabIndex = 9;
            label12.Text = "Total a Pagar:";
            // 
            // txttotalpagar
            // 
            txttotalpagar.Location = new Point(860, 368);
            txttotalpagar.Margin = new Padding(3, 2, 3, 2);
            txttotalpagar.Name = "txttotalpagar";
            txttotalpagar.Size = new Size(102, 23);
            txttotalpagar.TabIndex = 8;
            // 
            // btnregistrar
            // 
            btnregistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnregistrar.IconColor = Color.ForestGreen;
            btnregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnregistrar.IconSize = 30;
            btnregistrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnregistrar.Location = new Point(860, 392);
            btnregistrar.Margin = new Padding(3, 2, 3, 2);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(102, 40);
            btnregistrar.TabIndex = 10;
            btnregistrar.Text = "Registrar";
            btnregistrar.TextAlign = ContentAlignment.MiddleRight;
            btnregistrar.UseVisualStyleBackColor = true;
            // 
            // frmCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1008, 467);
            Controls.Add(btnregistrar);
            Controls.Add(label12);
            Controls.Add(txttotalpagar);
            Controls.Add(btnagregarproducto);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCompras";
            Text = "Registro de Compra";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtcantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private ComboBox cbotipodocumento;
        private TextBox txtfecha;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox txtnombreproveedor;
        private TextBox txtdocproveedor;
        private Label label5;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnbuscarproveedor;
        private TextBox txtidproveedor;
        private GroupBox groupBox3;
        private Label label10;
        private Label label11;
        private Label label9;
        private TextBox txtprecioventa;
        private TextBox txtpreciocompra;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private TextBox txtproducto;
        private TextBox textBox3;
        private Label label7;
        private Label label8;
        private NumericUpDown txtcantidad;
        private TextBox txtidproducto;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewButtonColumn btneliminar;
        private FontAwesome.Sharp.IconButton btnagregarproducto;
        private Label label12;
        private TextBox txttotalpagar;
        private FontAwesome.Sharp.IconButton btnregistrar;
    }
}