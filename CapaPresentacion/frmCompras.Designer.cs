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
            txpreciocompra = new TextBox();
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
            label1.BackColor = SystemColors.ControlLightLight;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 18);
            label1.Name = "label1";
            label1.Size = new Size(1060, 585);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 63);
            label2.Name = "label2";
            label2.Size = new Size(196, 28);
            label2.TabIndex = 1;
            label2.Text = "Registrar Compra";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(cbotipodocumento);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(73, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(435, 93);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Compra";
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
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLightLight;
            groupBox2.Controls.Add(txtidproveedor);
            groupBox2.Controls.Add(btnbuscarproveedor);
            groupBox2.Controls.Add(txtnombreproveedor);
            groupBox2.Controls.Add(txtdocproveedor);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(563, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(514, 93);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Proveedor";
            // 
            // txtidproveedor
            // 
            txtidproveedor.Location = new Point(388, 17);
            txtidproveedor.Name = "txtidproveedor";
            txtidproveedor.Size = new Size(34, 27);
            txtidproveedor.TabIndex = 4;
            txtidproveedor.Visible = false;
            // 
            // btnbuscarproveedor
            // 
            btnbuscarproveedor.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscarproveedor.IconColor = Color.Black;
            btnbuscarproveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarproveedor.IconSize = 26;
            btnbuscarproveedor.Location = new Point(171, 49);
            btnbuscarproveedor.Name = "btnbuscarproveedor";
            btnbuscarproveedor.Size = new Size(52, 28);
            btnbuscarproveedor.TabIndex = 4;
            btnbuscarproveedor.UseVisualStyleBackColor = true;
            btnbuscarproveedor.Click += btnbuscarproveedor_Click;
            // 
            // txtnombreproveedor
            // 
            txtnombreproveedor.Location = new Point(239, 50);
            txtnombreproveedor.Name = "txtnombreproveedor";
            txtnombreproveedor.Size = new Size(183, 27);
            txtnombreproveedor.TabIndex = 3;
            // 
            // txtdocproveedor
            // 
            txtdocproveedor.Location = new Point(7, 49);
            txtdocproveedor.Name = "txtdocproveedor";
            txtdocproveedor.Size = new Size(158, 27);
            txtdocproveedor.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(239, 26);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 1;
            label5.Text = "Razon Social:";
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
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlLightLight;
            groupBox3.Controls.Add(txtidproducto);
            groupBox3.Controls.Add(txtcantidad);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtprecioventa);
            groupBox3.Controls.Add(txpreciocompra);
            groupBox3.Controls.Add(btnbuscarproducto);
            groupBox3.Controls.Add(txtproducto);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(73, 207);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(897, 93);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion Proveedor";
            // 
            // txtidproducto
            // 
            txtidproducto.Location = new Point(169, 15);
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
            label10.Size = new Size(94, 20);
            label10.TabIndex = 7;
            label10.Text = "Precio Venta:";
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
            label9.Size = new Size(108, 20);
            label9.TabIndex = 6;
            label9.Text = "Precio compra:";
            // 
            // txtprecioventa
            // 
            txtprecioventa.Location = new Point(639, 49);
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.Size = new Size(116, 27);
            txtprecioventa.TabIndex = 5;
            txtprecioventa.TextChanged += textBox4_TextChanged;
            // 
            // txpreciocompra
            // 
            txpreciocompra.Location = new Point(501, 49);
            txpreciocompra.Name = "txpreciocompra";
            txpreciocompra.Size = new Size(122, 27);
            txpreciocompra.TabIndex = 4;
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
            // textBox3
            // 
            textBox3.Location = new Point(7, 49);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(196, 27);
            textBox3.TabIndex = 2;
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
            label8.Size = new Size(148, 20);
            label8.TabIndex = 0;
            label8.Text = "Numero Documento:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idProducto, Producto, PrecioCompra, PrecioVenta, Cantidad, SubTotal, btneliminar });
            dataGridView1.Location = new Point(73, 317);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(897, 259);
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
            btnagregarproducto.Location = new Point(983, 222);
            btnagregarproducto.Name = "btnagregarproducto";
            btnagregarproducto.Size = new Size(94, 75);
            btnagregarproducto.TabIndex = 6;
            btnagregarproducto.Text = "Agregar";
            btnagregarproducto.TextImageRelation = TextImageRelation.ImageAboveText;
            btnagregarproducto.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Ivory;
            label12.Location = new Point(990, 467);
            label12.Name = "label12";
            label12.Size = new Size(98, 20);
            label12.TabIndex = 9;
            label12.Text = "Total a Pagar:";
            // 
            // txttotalpagar
            // 
            txttotalpagar.Location = new Point(983, 490);
            txttotalpagar.Name = "txttotalpagar";
            txttotalpagar.Size = new Size(116, 27);
            txttotalpagar.TabIndex = 8;
            // 
            // btnregistrar
            // 
            btnregistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnregistrar.IconColor = Color.ForestGreen;
            btnregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnregistrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnregistrar.Location = new Point(983, 523);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(116, 53);
            btnregistrar.TabIndex = 10;
            btnregistrar.Text = "Registrar";
            btnregistrar.TextAlign = ContentAlignment.MiddleRight;
            btnregistrar.UseVisualStyleBackColor = true;
            // 
            // frmCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1152, 623);
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
        private TextBox txpreciocompra;
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