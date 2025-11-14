
namespace CapaPresentacion
{
    partial class FrmReportesEstadisticos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            chartProductosVendidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblTituloPrincipal = new Label();
            panelVentasHoy = new Panel();
            lblValorVentasHoy = new Label();
            lblTituloVentasHoy = new Label();
            chartVentasCategoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblTituloClientesNuevos = new Label();
            lblValorClientesNuevos = new Label();
            panelClientesNuevos = new Panel();
            lblFechaInicio = new Label();
            dtpFechaInicio = new DateTimePicker();
            lblFechaFin = new Label();
            dtpFechaFin = new DateTimePicker();
            btnFiltrar = new Button();
            ((System.ComponentModel.ISupportInitialize)chartProductosVendidos).BeginInit();
            panelVentasHoy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartVentasCategoria).BeginInit();
            panelClientesNuevos.SuspendLayout();
            SuspendLayout();
            // 
            // chartProductosVendidos
            // 
            chartProductosVendidos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartProductosVendidos.BackColor = Color.FromArgb(250, 250, 250);
            chartProductosVendidos.BorderlineColor = Color.Gainsboro;
            chartProductosVendidos.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.BackColor = Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartProductosVendidos.ChartAreas.Add(chartArea1);
            legend1.BackColor = Color.Transparent;
            legend1.Name = "Legend1";
            chartProductosVendidos.Legends.Add(legend1);
            chartProductosVendidos.Location = new Point(28, 240);
            chartProductosVendidos.Name = "chartProductosVendidos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartProductosVendidos.Series.Add(series1);
            chartProductosVendidos.Size = new Size(650, 390);
            chartProductosVendidos.TabIndex = 0;
            title1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Top 5 Productos Más Vendidos";
            chartProductosVendidos.Titles.Add(title1);
            chartProductosVendidos.Click += chartProductosVendidos_Click;
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPrincipal.ForeColor = Color.Black;
            lblTituloPrincipal.Location = new Point(21, 20);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(338, 41);
            lblTituloPrincipal.TabIndex = 1;
            lblTituloPrincipal.Text = "Reportes y Estadísticas";
            // 
            // panelVentasHoy
            // 
            panelVentasHoy.BackColor = Color.FromArgb(232, 245, 233);
            panelVentasHoy.BorderStyle = BorderStyle.FixedSingle;
            panelVentasHoy.Controls.Add(lblValorVentasHoy);
            panelVentasHoy.Controls.Add(lblTituloVentasHoy);
            panelVentasHoy.Location = new Point(28, 140);
            panelVentasHoy.Name = "panelVentasHoy";
            panelVentasHoy.Size = new Size(250, 80);
            panelVentasHoy.TabIndex = 2;
            // 
            // lblValorVentasHoy
            // 
            lblValorVentasHoy.AutoSize = true;
            lblValorVentasHoy.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblValorVentasHoy.ForeColor = Color.FromArgb(27, 94, 32);
            lblValorVentasHoy.Location = new Point(13, 35);
            lblValorVentasHoy.Name = "lblValorVentasHoy";
            lblValorVentasHoy.Size = new Size(77, 32);
            lblValorVentasHoy.TabIndex = 1;
            lblValorVentasHoy.Text = "$0.00";
            // 
            // lblTituloVentasHoy
            // 
            lblTituloVentasHoy.AutoSize = true;
            lblTituloVentasHoy.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTituloVentasHoy.ForeColor = Color.FromArgb(67, 160, 71);
            lblTituloVentasHoy.Location = new Point(14, 10);
            lblTituloVentasHoy.Name = "lblTituloVentasHoy";
            lblTituloVentasHoy.Size = new Size(102, 23);
            lblTituloVentasHoy.TabIndex = 0;
            lblTituloVentasHoy.Text = "Total Ventas";
            // 
            // chartVentasCategoria
            // 
            chartVentasCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            chartVentasCategoria.BackColor = Color.FromArgb(250, 250, 250);
            chartVentasCategoria.BorderlineColor = Color.Gainsboro;
            chartVentasCategoria.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.BackColor = Color.Transparent;
            chartArea2.Name = "ChartArea1";
            chartVentasCategoria.ChartAreas.Add(chartArea2);
            legend2.BackColor = Color.Transparent;
            legend2.Name = "Legend1";
            chartVentasCategoria.Legends.Add(legend2);
            chartVentasCategoria.Location = new Point(700, 240);
            chartVentasCategoria.Name = "chartVentasCategoria";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartVentasCategoria.Series.Add(series2);
            chartVentasCategoria.Size = new Size(450, 390);
            chartVentasCategoria.TabIndex = 5;
            title2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            title2.Name = "Title1";
            title2.Text = "Ventas por Categoría";
            chartVentasCategoria.Titles.Add(title2);
            // 
            // lblTituloClientesNuevos
            // 
            lblTituloClientesNuevos.AutoSize = true;
            lblTituloClientesNuevos.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTituloClientesNuevos.ForeColor = Color.FromArgb(67, 160, 71);
            lblTituloClientesNuevos.Location = new Point(14, 10);
            lblTituloClientesNuevos.Name = "lblTituloClientesNuevos";
            lblTituloClientesNuevos.Size = new Size(133, 23);
            lblTituloClientesNuevos.TabIndex = 0;
            lblTituloClientesNuevos.Text = "Nuevos Clientes";
            // 
            // lblValorClientesNuevos
            // 
            lblValorClientesNuevos.AutoSize = true;
            lblValorClientesNuevos.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblValorClientesNuevos.ForeColor = Color.FromArgb(27, 94, 32);
            lblValorClientesNuevos.Location = new Point(13, 35);
            lblValorClientesNuevos.Name = "lblValorClientesNuevos";
            lblValorClientesNuevos.Size = new Size(28, 32);
            lblValorClientesNuevos.TabIndex = 1;
            lblValorClientesNuevos.Text = "0";
            // 
            // panelClientesNuevos
            // 
            panelClientesNuevos.BackColor = Color.FromArgb(232, 245, 233);
            panelClientesNuevos.BorderStyle = BorderStyle.FixedSingle;
            panelClientesNuevos.Controls.Add(lblValorClientesNuevos);
            panelClientesNuevos.Controls.Add(lblTituloClientesNuevos);
            panelClientesNuevos.Location = new Point(300, 140);
            panelClientesNuevos.Name = "panelClientesNuevos";
            panelClientesNuevos.Size = new Size(250, 80);
            panelClientesNuevos.TabIndex = 3;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Segoe UI", 10F);
            lblFechaInicio.Location = new Point(24, 80);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(61, 23);
            lblFechaInicio.TabIndex = 6;
            lblFechaInicio.Text = "Desde:";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Font = new Font("Segoe UI", 10F);
            dtpFechaInicio.Location = new Point(92, 77);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(300, 30);
            dtpFechaInicio.TabIndex = 7;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Font = new Font("Segoe UI", 10F);
            lblFechaFin.Location = new Point(410, 80);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(57, 23);
            lblFechaFin.TabIndex = 8;
            lblFechaFin.Text = "Hasta:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Font = new Font("Segoe UI", 10F);
            dtpFechaFin.Location = new Point(474, 77);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(300, 30);
            dtpFechaFin.TabIndex = 9;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.FromArgb(76, 175, 80);
            btnFiltrar.FlatAppearance.BorderSize = 0;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFiltrar.ForeColor = Color.White;
            btnFiltrar.Location = new Point(790, 77);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(120, 30);
            btnFiltrar.TabIndex = 10;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // FrmReportesEstadisticos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1182, 653);
            Controls.Add(btnFiltrar);
            Controls.Add(dtpFechaFin);
            Controls.Add(lblFechaFin);
            Controls.Add(dtpFechaInicio);
            Controls.Add(lblFechaInicio);
            Controls.Add(chartVentasCategoria);
            Controls.Add(panelClientesNuevos);
            Controls.Add(panelVentasHoy);
            Controls.Add(lblTituloPrincipal);
            Controls.Add(chartProductosVendidos);
            Name = "FrmReportesEstadisticos";
            Text = "Reportes Estadísticos";
            Load += FrmReportesEstadisticos_Load;
            ((System.ComponentModel.ISupportInitialize)chartProductosVendidos).EndInit();
            panelVentasHoy.ResumeLayout(false);
            panelVentasHoy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartVentasCategoria).EndInit();
            panelClientesNuevos.ResumeLayout(false);
            panelClientesNuevos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductosVendidos;
        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Panel panelVentasHoy;
        private System.Windows.Forms.Label lblValorVentasHoy;
        private System.Windows.Forms.Label lblTituloVentasHoy;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentasCategoria;
        private System.Windows.Forms.Label lblTituloClientesNuevos;
        private System.Windows.Forms.Label lblValorClientesNuevos;
        private System.Windows.Forms.Panel panelClientesNuevos;
        // --- NUEVOS CONTROLES ---
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button btnFiltrar;
    }
}