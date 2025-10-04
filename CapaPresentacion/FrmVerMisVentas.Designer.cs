namespace CapaPresentacion
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, DNI, Telefono, Correo, DetalleVenta });
            dataGridView1.Location = new Point(12, 50);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(698, 332);
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
            label2.Location = new Point(12, 11);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 35;
            label2.Text = "Mis Ventas";
            // 
            // dtfin
            // 
            dtfin.CustomFormat = "dd/MM/yyyy";
            dtfin.Format = DateTimePickerFormat.Short;
            dtfin.Location = new Point(425, 17);
            dtfin.Margin = new Padding(3, 2, 3, 2);
            dtfin.Name = "dtfin";
            dtfin.Size = new Size(97, 23);
            dtfin.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(358, 20);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 39;
            label4.Text = "Fecha fin:";
            // 
            // dtinicio
            // 
            dtinicio.CustomFormat = "dd/MM/yyyy";
            dtinicio.Format = DateTimePickerFormat.Short;
            dtinicio.Location = new Point(248, 17);
            dtinicio.Margin = new Padding(3, 2, 3, 2);
            dtinicio.Name = "dtinicio";
            dtinicio.Size = new Size(97, 23);
            dtinicio.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(164, 19);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 37;
            label3.Text = "Fecha inicio:";
            // 
            // FrmVerMisVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtfin);
            Controls.Add(label4);
            Controls.Add(dtinicio);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Name = "FrmVerMisVentas";
            Text = "FrmVerMisVentas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}