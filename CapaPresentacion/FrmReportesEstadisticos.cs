using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CapaNegocio; // Importante: Usar la capa de negocio
using System.Data;    // Importante: Usar para DataTable
using System.Collections.Generic; // Importante: Usar para Dictionary

namespace CapaPresentacion
{
    public partial class FrmReportesEstadisticos : Form
    {
        public FrmReportesEstadisticos()
        {
            InitializeComponent();
        }

        private void FrmReportesEstadisticos_Load(object sender, EventArgs e)
        {
            // --- Cargar Datos Reales ---
            CargarDatosKPIs();
            CargarGraficoProductosMasVendidos();
            CargarGraficoVentasPorCategoria();
        }

        /// <summary>
        /// Carga los datos reales en las tarjetas de indicadores (KPIs).
        /// </summary>
        private void CargarDatosKPIs()
        {
            try
            {
                CN_Reporte cnReporte = new CN_Reporte();
                Dictionary<string, object> kpis = cnReporte.ObtenerKPIsDashboard();

                // Asignar valores a los labels
                lblValorVentasHoy.Text = Convert.ToDecimal(kpis["TotalVentasHoy"]).ToString("C2"); // "C2" = Formato Moneda
                lblValorClientesNuevos.Text = kpis["ClientesNuevosHoy"].ToString();

                // lblValorTotalProductos.Text = ... (Si decides añadirlo)
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar KPIs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblValorVentasHoy.Text = "$0.00";
                lblValorClientesNuevos.Text = "0";
            }
        }

        /// <summary>
        /// Carga y configura el gráfico de barras con datos reales.
        /// </summary>
        private void CargarGraficoProductosMasVendidos()
        {
            chartProductosVendidos.Series.Clear();

            Series seriesProductos = new Series("Unidades Vendidas")
            {
                ChartType = SeriesChartType.Bar
            };

            try
            {
                CN_Reporte cnReporte = new CN_Reporte();
                DataTable dtProductos = cnReporte.ObtenerTop5Productos();

                if (dtProductos.Rows.Count == 0)
                {
                    // No hay datos, mostrar un mensaje en el gráfico
                    chartProductosVendidos.Titles[0].Text = "Top Productos (No hay datos)";
                    return;
                }

                // Agregar los datos reales a la serie
                foreach (DataRow row in dtProductos.Rows)
                {
                    string nombreProducto = row["NombreProducto"].ToString();
                    int cantidad = Convert.ToInt32(row["TotalVendido"]);
                    seriesProductos.Points.AddXY(nombreProducto, cantidad);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar gráfico de productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            chartProductosVendidos.Series.Add(seriesProductos);

            // --- Estilos del Gráfico (Tu código de estilos) ---
            chartProductosVendidos.Titles[0].ForeColor = Color.FromArgb(46, 125, 50);

            chartProductosVendidos.Palette = ChartColorPalette.None;
            chartProductosVendidos.PaletteCustomColors = new Color[] {
                Color.FromArgb(129, 199, 132), Color.FromArgb(165, 214, 167),
                Color.FromArgb(197, 225, 165), Color.FromArgb(220, 231, 117),
                Color.FromArgb(212, 225, 87)
            };

            seriesProductos.IsValueShownAsLabel = true;
            seriesProductos.LabelForeColor = Color.FromArgb(27, 94, 32);
            seriesProductos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            chartProductosVendidos.Legends[0].Enabled = false;

            chartProductosVendidos.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartProductosVendidos.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartProductosVendidos.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 8F);
            chartProductosVendidos.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 8F);
        }

        /// <summary>
        /// Carga y configura el gráfico de pastel con datos reales.
        /// </summary>
        private void CargarGraficoVentasPorCategoria()
        {
            chartVentasCategoria.Series.Clear();

            Series seriesCategorias = new Series("Ventas")
            {
                ChartType = SeriesChartType.Doughnut
            };

            try
            {
                CN_Reporte cnReporte = new CN_Reporte();
                DataTable dtCategorias = cnReporte.ObtenerVentasPorCategoria();

                if (dtCategorias.Rows.Count == 0)
                {
                    // No hay datos, mostrar un mensaje
                    chartVentasCategoria.Titles[0].Text = "Ventas por Categoría (No hay datos)";
                    return;
                }

                // Agregar datos reales a la serie
                foreach (DataRow row in dtCategorias.Rows)
                {
                    string nombreCategoria = row["NombreCategoria"].ToString();
                    decimal totalVendido = Convert.ToDecimal(row["TotalVendido"]);
                    seriesCategorias.Points.AddXY(nombreCategoria, totalVendido);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar gráfico de categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            chartVentasCategoria.Series.Add(seriesCategorias);

            // --- Estilos del Gráfico (Tu código de estilos) ---
            chartVentasCategoria.Titles[0].ForeColor = Color.FromArgb(46, 125, 50);
            chartVentasCategoria.Palette = ChartColorPalette.Pastel;

            seriesCategorias["PieLabelStyle"] = "Outside";
            seriesCategorias.Label = "#VALX (#PERCENT{P0})";
            seriesCategorias.Font = new Font("Segoe UI", 9F);
            seriesCategorias.LegendText = "#VALX";

            chartVentasCategoria.Legends[0].Alignment = StringAlignment.Center;
            chartVentasCategoria.Legends[0].Docking = Docking.Bottom;
            chartVentasCategoria.Legends[0].Font = new Font("Segoe UI", 9F);
        }
    }
}
