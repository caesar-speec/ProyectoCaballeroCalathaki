using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            // --- Cargar Datos de Ejemplo ---
            // En un caso real, aquí llamarías a tu capa de negocio para obtener los datos reales.
            CargarDatosKPIs();
            CargarGraficoProductosMasVendidos();
            CargarGraficoVentasPorCategoria();
        }

        /// <summary>
        /// Carga datos de ejemplo en las tarjetas de indicadores (KPIs).
        /// </summary>
        private void CargarDatosKPIs()
        {
            // Simulación de datos obtenidos de la base de datos
            lblValorVentasHoy.Text = "$1,250.50";
            lblValorClientesNuevos.Text = "15";
            //lblValorTotalProductos.Text = "278";
        }

        /// <summary>
        /// Carga y configura el gráfico de barras para los productos más vendidos.
        /// </summary>
        private void CargarGraficoProductosMasVendidos()
        {
            // Limpiar series existentes
            chartProductosVendidos.Series.Clear();

            // Crear la serie del gráfico
            Series seriesProductos = new Series("Unidades Vendidas")
            {
                ChartType = SeriesChartType.Bar // Gráfico de barras
            };

            // Datos de ejemplo (Producto, Cantidad)
            var productos = new[] {
                new { Nombre = "Monstera Deliciosa", Cantidad = 85 },
                new { Nombre = "Ficus Lyrata", Cantidad = 72 },
                new { Nombre = "Sansevieria", Cantidad = 65 },
                new { Nombre = "Pilea Peperomioides", Cantidad = 51 },
                new { Nombre = "Sustrato Premium 20L", Cantidad = 45 }
            };

            // Agregar los datos a la serie
            foreach (var producto in productos)
            {
                seriesProductos.Points.AddXY(producto.Nombre, producto.Cantidad);
            }

            // Añadir la serie al gráfico
            chartProductosVendidos.Series.Add(seriesProductos);

            // --- Estilos del Gráfico de Barras ---
            // Título
            chartProductosVendidos.Titles[0].ForeColor = Color.FromArgb(46, 125, 50); // Verde oscuro

            // Paleta de colores personalizada
            chartProductosVendidos.Palette = ChartColorPalette.None;
            chartProductosVendidos.PaletteCustomColors = new Color[] {
                Color.FromArgb(129, 199, 132), // Verde claro
                Color.FromArgb(165, 214, 167),
                Color.FromArgb(197, 225, 165),
                Color.FromArgb(220, 231, 117),
                Color.FromArgb(212, 225, 87)
            };

            // Estilo de las barras
            seriesProductos.IsValueShownAsLabel = true; // Mostrar valor en la barra
            seriesProductos.LabelForeColor = Color.FromArgb(27, 94, 32); // Verde muy oscuro
            seriesProductos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            // Ocultar leyenda
            chartProductosVendidos.Legends[0].Enabled = false;

            // Estilo de los ejes
            chartProductosVendidos.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartProductosVendidos.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartProductosVendidos.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 8F);
            chartProductosVendidos.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 8F);
        }

        /// <summary>
        /// Carga y configura el gráfico de pastel para las ventas por categoría.
        /// </summary>
        private void CargarGraficoVentasPorCategoria()
        {
            // Limpiar series
            chartVentasCategoria.Series.Clear();

            // Crear la serie
            Series seriesCategorias = new Series("Ventas")
            {
                ChartType = SeriesChartType.Doughnut // Gráfico de dona (o Pie)
            };

            // Datos de ejemplo (Categoría, Porcentaje/Valor)
            var categorias = new[] {
                new { Nombre = "Plantas Interior", Valor = 45 },
                new { Nombre = "Macetas", Valor = 25 },
                new { Nombre = "Sustratos", Valor = 18 },
                new { Nombre = "Herramientas", Valor = 12 }
            };

            // Agregar datos a la serie
            foreach (var categoria in categorias)
            {
                seriesCategorias.Points.AddXY(categoria.Nombre, categoria.Valor);
            }

            // Añadir la serie al gráfico
            chartVentasCategoria.Series.Add(seriesCategorias);

            // --- Estilos del Gráfico de Pastel ---
            // Título
            chartVentasCategoria.Titles[0].ForeColor = Color.FromArgb(46, 125, 50); // Verde oscuro

            // Paleta de colores
            chartVentasCategoria.Palette = ChartColorPalette.Pastel;

            // Estilo de las etiquetass
            seriesCategorias["PieLabelStyle"] = "Outside";
            seriesCategorias.Label = "#VALX (#PERCENT{P0})"; // Muestra "Nombre (Porcentaje%)"
            seriesCategorias.Font = new Font("Segoe UI", 9F);
            seriesCategorias.LegendText = "#VALX";

            // Estilo de la leyenda
            chartVentasCategoria.Legends[0].Alignment = StringAlignment.Center;
            chartVentasCategoria.Legends[0].Docking = Docking.Bottom;
            chartVentasCategoria.Legends[0].Font = new Font("Segoe UI", 9F);
        }
    }
}
