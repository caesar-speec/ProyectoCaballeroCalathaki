
namespace CapaPresentacion
{
    partial class FrmReportesEstadisticos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            chartProductosVendidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblTituloPrincipal = new Label();
            panelVentasHoy = new Panel();
            lblValorVentasHoy = new Label();
            lblTituloVentasHoy = new Label();
            chartVentasCategoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblTituloClientesNuevos = new Label();
            lblValorClientesNuevos = new Label();
            panelClientesNuevos = new Panel();
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
            chartArea3.BackColor = Color.Transparent;
            chartArea3.Name = "ChartArea1";
            chartProductosVendidos.ChartAreas.Add(chartArea3);
            legend3.BackColor = Color.Transparent;
            legend3.Name = "Legend1";
            chartProductosVendidos.Legends.Add(legend3);
            chartProductosVendidos.Location = new Point(28, 180);
            chartProductosVendidos.Name = "chartProductosVendidos";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartProductosVendidos.Series.Add(series3);
            chartProductosVendidos.Size = new Size(650, 450);
            chartProductosVendidos.TabIndex = 0;
            chartProductosVendidos.Text = "chart1";
            title3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            title3.Name = "Title1";
            title3.Text = "Top 5 Productos Más Vendidos";
            chartProductosVendidos.Titles.Add(title3);
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
            panelVentasHoy.Location = new Point(28, 80);
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
            lblTituloVentasHoy.Size = new Size(119, 23);
            lblTituloVentasHoy.TabIndex = 0;
            lblTituloVentasHoy.Text = "Ventas del Día";
            // 
            // chartVentasCategoria
            // 
            chartVentasCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            chartVentasCategoria.BackColor = Color.FromArgb(250, 250, 250);
            chartVentasCategoria.BorderlineColor = Color.Gainsboro;
            chartVentasCategoria.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.BackColor = Color.Transparent;
            chartArea4.Name = "ChartArea1";
            chartVentasCategoria.ChartAreas.Add(chartArea4);
            legend4.BackColor = Color.Transparent;
            legend4.Name = "Legend1";
            chartVentasCategoria.Legends.Add(legend4);
            chartVentasCategoria.Location = new Point(700, 180);
            chartVentasCategoria.Name = "chartVentasCategoria";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartVentasCategoria.Series.Add(series4);
            chartVentasCategoria.Size = new Size(450, 450);
            chartVentasCategoria.TabIndex = 5;
            chartVentasCategoria.Text = "chart2";
            title4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            title4.Name = "Title1";
            title4.Text = "Ventas por Categoría";
            chartVentasCategoria.Titles.Add(title4);
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
            panelClientesNuevos.Location = new Point(300, 80);
            panelClientesNuevos.Name = "panelClientesNuevos";
            panelClientesNuevos.Size = new Size(250, 80);
            panelClientesNuevos.TabIndex = 3;
            // 
            // FrmReportesEstadisticos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1182, 653);
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

        // Remove the following method from the Designer file to avoid duplicate method definitions.
        // The event handler should only be defined in the code-behind (.cs) file, not in the Designer file.



        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductosVendidos;
        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Panel panelVentasHoy;
        private System.Windows.Forms.Label lblValorVentasHoy;
        private System.Windows.Forms.Label lblTituloVentasHoy;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentasCategoria;
        private Label lblTituloClientesNuevos;
        private Label lblValorClientesNuevos;
        private Panel panelClientesNuevos;
    }
}