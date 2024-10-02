namespace CapaPresentacion
{
    partial class frmDetalleCompra
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
            txttipodocumento = new TextBox();
            txtusuario = new TextBox();
            label5 = new Label();
            txtfecha = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnbuscarproveedor = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            label6 = new Label();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            groupBox2 = new GroupBox();
            txtnumerodocumento = new TextBox();
            label10 = new Label();
            txtnombreproveedor = new TextBox();
            txtdocproveedor = new TextBox();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            label12 = new Label();
            txtmontototal = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlDark;
            label1.Location = new Point(65, 20);
            label1.Name = "label1";
            label1.Size = new Size(759, 601);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDark;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 29);
            label2.Name = "label2";
            label2.Size = new Size(237, 31);
            label2.TabIndex = 1;
            label2.Text = "Detalle de la Compra";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDark;
            groupBox1.Controls.Add(txttipodocumento);
            groupBox1.Controls.Add(txtusuario);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(79, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(721, 117);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Compra";
            // 
            // txttipodocumento
            // 
            txttipodocumento.Location = new Point(210, 51);
            txttipodocumento.Name = "txttipodocumento";
            txttipodocumento.Size = new Size(190, 27);
            txttipodocumento.TabIndex = 6;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(446, 51);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(205, 27);
            txtusuario.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlDark;
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
            txtfecha.Size = new Size(158, 27);
            txtfecha.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDark;
            label4.Location = new Point(210, 27);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 1;
            label4.Text = "Tipo Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlDark;
            label3.Location = new Point(7, 27);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 0;
            label3.Text = "Fecha:";
            // 
            // btnbuscarproveedor
            // 
            btnbuscarproveedor.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscarproveedor.IconColor = Color.Black;
            btnbuscarproveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarproveedor.IconSize = 15;
            btnbuscarproveedor.Location = new Point(606, 57);
            btnbuscarproveedor.Name = "btnbuscarproveedor";
            btnbuscarproveedor.Size = new Size(64, 28);
            btnbuscarproveedor.TabIndex = 7;
            btnbuscarproveedor.UseVisualStyleBackColor = true;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(442, 59);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(158, 27);
            txtbusqueda.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlDark;
            label6.Location = new Point(442, 35);
            label6.Name = "label6";
            label6.Size = new Size(148, 20);
            label6.TabIndex = 5;
            label6.Text = "Numero Documento:";
            // 
            // btnlimpiar
            // 
            btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnlimpiar.IconColor = Color.Black;
            btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiar.IconSize = 20;
            btnlimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnlimpiar.Location = new Point(677, 57);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(91, 28);
            btnlimpiar.TabIndex = 8;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlDark;
            groupBox2.Controls.Add(txtnumerodocumento);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtnombreproveedor);
            groupBox2.Controls.Add(txtdocproveedor);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(79, 213);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(721, 117);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Proveedor";
            // 
            // txtnumerodocumento
            // 
            txtnumerodocumento.Location = new Point(590, 51);
            txtnumerodocumento.Name = "txtnumerodocumento";
            txtnumerodocumento.Size = new Size(98, 27);
            txtnumerodocumento.TabIndex = 10;
            txtnumerodocumento.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ControlDark;
            label10.Location = new Point(7, 27);
            label10.Name = "label10";
            label10.Size = new Size(148, 20);
            label10.TabIndex = 7;
            label10.Text = "Numero Documento:";
            // 
            // txtnombreproveedor
            // 
            txtnombreproveedor.Location = new Point(210, 51);
            txtnombreproveedor.Name = "txtnombreproveedor";
            txtnombreproveedor.Size = new Size(190, 27);
            txtnombreproveedor.TabIndex = 6;
            // 
            // txtdocproveedor
            // 
            txtdocproveedor.Location = new Point(7, 49);
            txtdocproveedor.Name = "txtdocproveedor";
            txtdocproveedor.Size = new Size(158, 27);
            txtdocproveedor.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlDark;
            label8.Location = new Point(210, 27);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 1;
            label8.Text = "Razon Social:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Producto, PrecioCompra, Cantidad, SubTotal });
            dataGridView1.Location = new Point(86, 336);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(714, 241);
            dataGridView1.TabIndex = 10;
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
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ControlDark;
            label12.Location = new Point(86, 585);
            label12.Name = "label12";
            label12.Size = new Size(93, 20);
            label12.TabIndex = 12;
            label12.Text = "Monto Total:";
            // 
            // txtmontototal
            // 
            txtmontototal.Location = new Point(185, 581);
            txtmontototal.Name = "txtmontototal";
            txtmontototal.Size = new Size(116, 27);
            txtmontototal.TabIndex = 11;
            // 
            // frmDetalleCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(894, 629);
            Controls.Add(label12);
            Controls.Add(txtmontototal);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(btnlimpiar);
            Controls.Add(btnbuscarproveedor);
            Controls.Add(txtbusqueda);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDetalleCompra";
            Text = "Detalle de Compra";
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
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txttipodocumento;
        private TextBox txtusuario;
        private Label label5;
        private TextBox txtfecha;
        private Label label4;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnbuscarproveedor;
        private TextBox txtbusqueda;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private GroupBox groupBox2;
        private Label label10;
        private TextBox txtnombreproveedor;
        private TextBox txtdocproveedor;
        private Label label8;
        private TextBox txtnumerodocumento;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private Label label12;
        private TextBox txtmontototal;
    }
}