using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmDetalleVenta : Form
    {
        // Variable para guardar el ID que viene de frmListarVentas
        private int _IdVenta;

        // *** CONSTRUCTOR MODIFICADO ***
        // Acepta el ID (con valor opcional para que el diseñador no falle)
        public frmDetalleVenta(int idVenta = 0)
        {
            InitializeComponent();
            _IdVenta = idVenta; // Guardamos el ID
        }

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            // --- Adaptación a tu Designer ---
            // Como el IdVenta ya viene de frmListarVentas,
            // ponemos el ID en el textbox y deshabilitamos la búsqueda interna.
            txtbusqueda.Text = _IdVenta.ToString();
            txtbusqueda.ReadOnly = true;
            //btnbuscarventa.Enabled = false;
           // btnlimpiar.Enabled = false; // Tampoco tiene sentido limpiar

            // --- Configuración del DataGridView ---
            // Usamos 'dataGridView1' (el nombre de tu designer)
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

            // --- Mapeo de Columnas (usando los nombres de TU designer) ---
            // Mapeamos los datos del SP a los nombres de columna de TU designer
            Producto.DataPropertyName = "NombreProducto";
            Precio.DataPropertyName = "PrecioVenta"; // Mapea "PrecioVenta" del SP a tu columna "Precio"
            Cantidad.DataPropertyName = "Cantidad";
            SubTotal.DataPropertyName = "SubTotal";
            // La columna IdVenta de la grilla no la necesitamos poblar, la ocultamos.
            IdVenta.Visible = false;

            // Formato de moneda para las columnas de tu grilla
            Precio.DefaultCellStyle.Format = "C2";
            SubTotal.DefaultCellStyle.Format = "C2";

            // --- Buscar la Venta ---
            // (Esto usa la lógica de CN_Venta y CD_Venta que ya modificamos)
            Venta oVenta = new CN_Venta().ObtenerVenta(_IdVenta);

            if (oVenta != null && oVenta.ID_venta != 0)
            {
                // Rellenar campos de Info Venta
                txtfecha.Text = oVenta.fecha_creacion;
                txttipodocumento.Text = oVenta.TipoDocumento;
                txtusuario.Text = oVenta.oUsuario.NombreCompleto;

                // Rellenar campos de Info Cliente
                txtdoccliente.Text = oVenta.oCliente.Documento;
                txtnombrecliente.Text = oVenta.oCliente.NombreCompleto;

                // Rellenar el DataGridView
                dataGridView1.DataSource = oVenta.oDetalle_Venta;

                // Rellenar Totales
                txtmontototal.Text = String.Format("{0:C2}", oVenta.MontoTotal);
                txtmontopago.Text = String.Format("{0:C2}", oVenta.MontoPago);
                txtmontocambio.Text = String.Format("{0:C2}", oVenta.MontoCambio);
            }
            else
            {
                MessageBox.Show("No se pudo encontrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Cerramos el modal si no se encontró la venta
            }
        }

        // --- Eventos vacíos que ya tenías ---
        private void label1_Click(object sender, EventArgs e) { }
        private void txtpagacon_TextChanged(object sender, EventArgs e) { }
        private void txtcambio_TextChanged(object sender, EventArgs e) { }
    }
}
