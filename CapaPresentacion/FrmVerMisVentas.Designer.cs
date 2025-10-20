﻿namespace CapaPresentacion
{
    partial class FrmVerMisVentas
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
            Nombre = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            DetalleVenta = new DataGridViewButtonColumn();
            label2 = new Label();
            dtfin = new DateTimePicker();
            label4 = new Label();
            dtinicio = new DateTimePicker();
            label3 = new Label();
            button1 = new Button();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            dataGridView2 = new DataGridView();
            Descripcion = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            dataGridView3 = new DataGridView();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btnbuscarventa = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            Cliente = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            FechaVenta = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            textBox1 = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, DNI, Telefono, Correo, DetalleVenta });
            dataGridView1.Location = new Point(364, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(798, 443);
            dataGridView1.TabIndex = 36;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.MinimumWidth = 6;
            DNI.Name = "DNI";
            DNI.Width = 125;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.Width = 125;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.Width = 125;
            // 
            // DetalleVenta
            // 
            DetalleVenta.HeaderText = "Detalle de Venta";
            DetalleVenta.MinimumWidth = 6;
            DetalleVenta.Name = "DetalleVenta";
            DetalleVenta.Text = "[Ver más]";
            DetalleVenta.Width = 102;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(364, 26);
            label2.Name = "label2";
            label2.Size = new Size(130, 31);
            label2.TabIndex = 35;
            label2.Text = "Mis Ventas";
            // 
            // dtfin
            // 
            dtfin.CustomFormat = "dd/MM/yyyy";
            dtfin.Format = DateTimePickerFormat.Short;
            dtfin.Location = new Point(836, 34);
            dtfin.Name = "dtfin";
            dtfin.Size = new Size(110, 27);
            dtfin.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(759, 38);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 39;
            label4.Text = "Fecha fin:";
            // 
            // dtinicio
            // 
            dtinicio.CustomFormat = "dd/MM/yyyy";
            dtinicio.Format = DateTimePickerFormat.Short;
            dtinicio.Location = new Point(633, 34);
            dtinicio.Name = "dtinicio";
            dtinicio.Size = new Size(110, 27);
            dtinicio.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(537, 36);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 37;
            label3.Text = "Fecha inicio:";
            // 
            // button1
            // 
            button1.Location = new Point(1377, 76);
            button1.Name = "button1";
            button1.Size = new Size(202, 29);
            button1.TabIndex = 54;
            button1.Text = "Imprimir Detalle";
            button1.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 15;
            iconButton1.Location = new Point(990, 77);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(64, 28);
            iconButton1.TabIndex = 53;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(723, 55);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 52;
            label1.Text = "Hasta:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(453, 55);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 51;
            label5.Text = "Desde:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(723, 78);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 50;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(453, 78);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 49;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Descripcion, PrecioUnitario, Cantidad, Subtotal });
            dataGridView2.Location = new Point(791, 134);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(788, 443);
            dataGridView2.TabIndex = 48;
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
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Cliente, dataGridViewTextBoxColumn1, FechaVenta, MontoTotal, dataGridViewButtonColumn1 });
            dataGridView3.Location = new Point(21, 134);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(742, 443);
            dataGridView3.TabIndex = 47;
            // 
            // btnlimpiar
            // 
            btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnlimpiar.IconColor = Color.Black;
            btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiar.IconSize = 20;
            btnlimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnlimpiar.Location = new Point(311, 80);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(91, 28);
            btnlimpiar.TabIndex = 46;
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
            btnbuscarventa.Location = new Point(240, 80);
            btnbuscarventa.Name = "btnbuscarventa";
            btnbuscarventa.Size = new Size(64, 28);
            btnbuscarventa.TabIndex = 45;
            btnbuscarventa.UseVisualStyleBackColor = true;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(-288, 69);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(158, 27);
            txtbusqueda.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLight;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(-329, 46);
            label6.Name = "label6";
            label6.Size = new Size(215, 20);
            label6.TabIndex = 43;
            label6.Text = "Numero Documento vendedor:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlLight;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(62, 23);
            label7.Name = "label7";
            label7.Size = new Size(241, 31);
            label7.TabIndex = 42;
            label7.Text = "Detalle de mis ventas";
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ControlLight;
            label8.Location = new Point(4, 20);
            label8.Name = "label8";
            label8.Size = new Size(1606, 582);
            label8.TabIndex = 41;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "DNI";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
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
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.HeaderText = "Detalle de Venta";
            dataGridViewButtonColumn1.MinimumWidth = 6;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.Text = "[Ver más]";
            dataGridViewButtonColumn1.Width = 102;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 27);
            textBox1.TabIndex = 55;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(47, 58);
            label9.Name = "label9";
            label9.Size = new Size(88, 20);
            label9.TabIndex = 56;
            label9.Text = "DNI Cliente:";
            // 
            // FrmVerMisVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1634, 600);
            Controls.Add(label9);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(iconButton1);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView3);
            Controls.Add(btnlimpiar);
            Controls.Add(btnbuscarventa);
            Controls.Add(txtbusqueda);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(dtfin);
            Controls.Add(label4);
            Controls.Add(dtinicio);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmVerMisVentas";
            Text = "FrmVerMisVentas";
            Load += FrmVerMisVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewButtonColumn DetalleVenta;
        private Label label2;
        private DateTimePicker dtfin;
        private Label label4;
        private DateTimePicker dtinicio;
        private Label label3;
        private Button button1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label1;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn FechaVenta;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnbuscarventa;
        private TextBox txtbusqueda;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private Label label9;
    }
}