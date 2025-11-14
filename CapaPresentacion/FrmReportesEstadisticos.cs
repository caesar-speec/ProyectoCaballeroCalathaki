using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CapaNegocio;
using System.Data;
using System.Collections.Generic;

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
            // Establecer fechas por defecto al cargar
            // Por ejemplo, el primer día del mes actual hasta hoy
            dtpFechaInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpFechaFin.Value = DateTime.Now;

            // Cargar los datos iniciales con el rango por defecto
            CargarDatosDashboard();
        }

        // --- ESTE ES EL MÉTODO QUE SOLUCIONA TU ERROR ---
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            // El botón "Filtrar" simplemente vuelve a cargar todo con las nuevas fechas
            CargarDatosDashboard();
        }

        /// <summary>
        /// Método central que carga todos los componentes del dashboard
        /// </summary>
        private void CargarDatosDashboard()
        {
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;

            // Validación de fechas
            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha de fin.", "Error de Fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- Cargar Datos Reales con el rango de fechas ---
            CargarDatosKPIs(fechaInicio, fechaFin);
            CargarGraficoProductosMasVendidos(fechaInicio, fechaFin);
            CargarGraficoVentasPorCategoria(fechaInicio, fechaFin);
        }

        /// <summary>
        /// Carga los datos reales en las tarjetas de indicadores (KPIs).
        /// </summary>
        private void CargarDatosKPIs(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                CN_Reporte cnReporte = new CN_Reporte();
                // Pasa las fechas a la capa de negocio
                Dictionary<string, object> kpis = cnReporte.ObtenerKPIsDashboard(fechaInicio, fechaFin);

                lblValorVentasHoy.Text = Convert.ToDecimal(kpis["TotalVentasHoy"]).ToString("C2");
                lblValorClientesNuevos.Text = kpis["ClientesNuevosHoy"].ToString();
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
        private void CargarGraficoProductosMasVendidos(DateTime fechaInicio, DateTime fechaFin)
        {
            chartProductosVendidos.Series.Clear();
            chartProductosVendidos.Titles[0].Text = "Producto Más Vendido"; // Resetear título

            Series seriesProductos = new Series("Unidades Vendidas")
            {
                ChartType = SeriesChartType.Bar
            };

            try
            {
                CN_Reporte cnReporte = new CN_Reporte();
                // Pasa las fechas a la capa de negocio
                DataTable dtProductos = cnReporte.ObtenerTop5Productos(fechaInicio, fechaFin);

                if (dtProductos.Rows.Count == 0)
                {
                    chartProductosVendidos.Titles[0].Text = "Top Productos (No hay datos)";
                    return;
                }

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

            // Estilos del Gráfico
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
        private void CargarGraficoVentasPorCategoria(DateTime fechaInicio, DateTime fechaFin)
        {
            chartVentasCategoria.Series.Clear();
            chartVentasCategoria.Titles[0].Text = "Ventas por Categoría"; // Resetear título

            Series seriesCategorias = new Series("Ventas")
            {
                ChartType = SeriesChartType.Doughnut
            };

            try
            {
                CN_Reporte cnReporte = new CN_Reporte();
                // Pasa las fechas a la capa de negocio
                DataTable dtCategorias = cnReporte.ObtenerVentasPorCategoria(fechaInicio, fechaFin);

                if (dtCategorias.Rows.Count == 0)
                {
                    chartVentasCategoria.Titles[0].Text = "Ventas por Categoría (No hay datos)";
                    return;
                }

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

            // Estilos del Gráfico
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

        private void chartProductosVendidos_Click(object sender, EventArgs e)
        {

        }
    }
}
