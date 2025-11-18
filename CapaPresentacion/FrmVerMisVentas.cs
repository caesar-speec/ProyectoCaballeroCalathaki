using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmVerMisVentas : Form
    {
        private Usuario usuarioActual;

        public FrmVerMisVentas(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void FrmVerMisVentas_Load(object sender, EventArgs e)
        {
            // Establecer fechas por defecto (inicio de mes y hoy)
            dtinicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtfin.Value = DateTime.Now;

            CargarMisVentas();
        }

        private void CargarMisVentas()
        {
            if (usuarioActual == null) return;

            DateTime fechaInicio = dtinicio.Value.Date;
            DateTime fechaFin = dtfin.Value.Date;

            // 1. Obtener reporte filtrado por fechas y por el ID del usuario actual
            // Usamos CN_ReporteVentas que ya tiene la lógica de SQL optimizada
            DataTable dt = new CN_ReporteVentas().ReporteVentas(fechaInicio, fechaFin, usuarioActual.IdUsuario);

            dataGridView3.Rows.Clear();

            // 2. Aplicar filtro adicional por DNI Cliente (textBox1) si se escribió algo
            string filtroDni = textBox1.Text.Trim();

            foreach (DataRow row in dt.Rows)
            {
                string docCliente = row["DocumentoCliente"].ToString();

                // Si hay filtro de DNI y no coincide, saltamos esta fila
                if (!string.IsNullOrEmpty(filtroDni) && !docCliente.Contains(filtroDni))
                {
                    continue;
                }

                dataGridView3.Rows.Add(
                    row["IdVenta"],          // Columna oculta para el ID
                    row["Cliente"],          // NombreCliente
                    docCliente,              // DocumentoCliente
                    row["FechaRegistro"],    // Fecha
                    row["MontoTotal"]        // Monto
                                             // El botón se dibuja solo
                );
            }
        }

        private void btnbuscarventa_Click(object sender, EventArgs e)
        {
            CargarMisVentas();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            dtinicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtfin.Value = DateTime.Now;
            textBox1.Text = "";
            CargarMisVentas();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en el botón "Ver detalle"
            if (e.RowIndex >= 0 && dataGridView3.Columns[e.ColumnIndex].Name == "dataGridViewButtonColumn1")
            {
                // Obtener el ID de la venta de la columna oculta "IdVenta"
                // Asegúrate de que "IdVenta" sea el nombre correcto de la columna en el designer (indice 0)
                int idVenta = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells["IdVenta"].Value);

                // Abrir el modal de detalle
                frmDetalleVenta modal = new frmDetalleVenta(idVenta);
                modal.ShowDialog();
            }
        }
    }
}