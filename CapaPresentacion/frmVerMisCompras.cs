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
    public partial class frmVerMisCompras : Form
    {
        private Usuario usuarioActual;

        public frmVerMisCompras(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void frmVerMisCompras_Load(object sender, EventArgs e)
        {
            dtinicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtfin.Value = DateTime.Now;

            CargarMisCompras();
        }

        private void CargarMisCompras()
        {
            if (usuarioActual == null) return;

            DateTime fechaInicio = dtinicio.Value.Date;
            DateTime fechaFin = dtfin.Value.Date;

            // Usamos ReporteCompras, filtrando por el usuario actual (IdReponedor)
            // El parámetro idProveedor = 0 significa "Todos los proveedores"
            DataTable dt = new CN_ReporteCompras().ReporteCompras(fechaInicio, fechaFin, 0, usuarioActual.IdUsuario);

            dgvdata.Rows.Clear();

            string filtro = txtbusqueda.Text.Trim().ToUpper();

            foreach (DataRow row in dt.Rows)
            {
                string proveedor = row["RazonSocial"].ToString();

                // Filtro simple en memoria por Proveedor
                if (!string.IsNullOrEmpty(filtro) && !proveedor.ToUpper().Contains(filtro))
                {
                    continue;
                }

                dgvdata.Rows.Add(
                    row["IdCompra"],
                    row["FechaRegistro"],
                    row["TipoDocumento"],
                    row["NumeroDocumento"],
                    row["MontoTotal"],
                    proveedor
                );
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            CargarMisCompras();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            dtinicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtfin.Value = DateTime.Now;
            txtbusqueda.Text = "";
            CargarMisCompras();
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            // Opcional: Cargar mientras escribe, o esperar al botón
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvdata.Columns[e.ColumnIndex].Name == "btnDetalle")
            {
                int idCompra = Convert.ToInt32(dgvdata.Rows[e.RowIndex].Cells["IdCompra"].Value);
                frmDetalleCompra modal = new frmDetalleCompra(idCompra);
                modal.ShowDialog();
            }
        }
    }
}