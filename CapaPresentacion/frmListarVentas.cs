using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
// Asegúrate de tener esta utilidad si la usas para cargar ComboBox,
// aunque para este caso que carga Usuarios, no es estrictamente necesaria.
// using CapaPresentacion.Utilidades; 

namespace CapaPresentacion
{
    public partial class frmListarVentas : Form
    {
        public frmListarVentas()
        {
            InitializeComponent();
        }

        private void frmListarVentas_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarVendedores(); // Ahora usará el control del diseñador

            // Configurar fechas por defecto (ej. inicio del mes actual)
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePicker2.Value = DateTime.Now;

            // Cargar datos iniciales
            BuscarVentas();
        }

        private void CargarVendedores()
        {
            // Esta es la versión limpia.
            // Asume que 'cboVendedor' ya existe gracias al diseñador.
            cboVendedor.Items.Clear();
            cboVendedor.DisplayMember = "NombreCompleto";
            cboVendedor.ValueMember = "IdUsuario";

            // Obtenemos la lista de usuarios que son vendedores
            List<Usuario> listaVendedores = new CN_Usuario().ListarVendedores();

            // Añadir opción "Todos" al principio
            cboVendedor.Items.Add(new Usuario() { IdUsuario = 0, NombreCompleto = "Todos los Vendedores" });

            // Añadir el resto de vendedores
            if (listaVendedores != null)
            {
                cboVendedor.Items.AddRange(listaVendedores.ToArray());
            }

            cboVendedor.SelectedIndex = 0; // Seleccionar "Todos" por defecto
        }


        private void ConfigurarDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

            // Mapear las columnas del DataGridView a los nombres que devuelve el SP
            // Usamos la columna 'IdUsuario' del DGV para almacenar 'Idventa'
            IdUsuario.DataPropertyName = "Idventa";
            IdUsuario.HeaderText = "Nro. Venta"; // Cambiamos el título

            Vendedor.DataPropertyName = "Vendedor";
            Cliente.DataPropertyName = "Cliente";
            DNI.DataPropertyName = "DocumentoCliente";
            FechaVenta.DataPropertyName = "FechaRegistro";
            MontoPago.DataPropertyName = "MontoPago";
            MontoCambio.DataPropertyName = "MontoCambio";
            MontoTotal.DataPropertyName = "MontoTotal";

            // Formato de moneda
            MontoPago.DefaultCellStyle.Format = "C2";
            MontoCambio.DefaultCellStyle.Format = "C2";
            MontoTotal.DefaultCellStyle.Format = "C2";
        }

        private void BuscarVentas()
        {
            DateTime fechaInicio = dateTimePicker1.Value.Date;
            DateTime fechaFin = dateTimePicker2.Value.Date;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el IdUsuario del ComboBox (versión corregida)
            int idUsuario = 0;
            if (cboVendedor.SelectedItem != null && cboVendedor.SelectedIndex > -1)
            {
                // Obtenemos el IdUsuario del item seleccionado
                idUsuario = ((Usuario)cboVendedor.SelectedItem).IdUsuario;
            }

            // Llamamos al reporte
            DataTable dtVentas = new CN_ReporteVentas().ReporteVentas(fechaInicio, fechaFin, idUsuario);
            dataGridView1.DataSource = dtVentas;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegurarse de que el clic fue en la columna del botón "DetalleVenta"
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "DetalleVenta")
            {
                // Obtener el IdVenta de la fila. Lo guardamos en la columna "IdUsuario" (mapeada a Idventa)
                int idVenta = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdUsuario"].Value);

                // Abrir el formulario modal
                // Pasamos el IdVenta al constructor del modal
                // Asegúrate de que frmDetalleVenta tenga un constructor que acepte un int
                frmDetalleVenta modal = new frmDetalleVenta(idVenta);
                modal.ShowDialog();
            }
        }

        // --- EVENTOS DE BOTONES ---

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // El botón buscar simplemente llama a la lógica de búsqueda
            BuscarVentas();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar filtros y recargar (versión corregida)
            cboVendedor.SelectedIndex = 0; // Usamos cboVendedor directamente
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePicker2.Value = DateTime.Now;
            BuscarVentas(); // Recargamos la lista con los filtros limpios
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Evento vacío, no hay problema
        }
    }
}