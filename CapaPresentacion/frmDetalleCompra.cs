using CapaEntidad;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmDetalleCompra : Form
    {
        private int _IdCompra;

        public frmDetalleCompra(int idCompra = 0)
        {
            InitializeComponent();
            _IdCompra = idCompra;
        }

        private void frmDetalleCompra_Load(object sender, EventArgs e)
        {
            txtidcompra.Text = _IdCompra.ToString();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

           
            Producto.DataPropertyName = "NombreProducto";

            PrecioCompra.DataPropertyName = "PrecioCompra";
            Cantidad.DataPropertyName = "Cantidad";
            SubTotal.DataPropertyName = "MontoTotal";

            // Formato de moneda
            PrecioCompra.DefaultCellStyle.Format = "C2";
            SubTotal.DefaultCellStyle.Format = "C2";

            Compra oCompra = new CN_Compra().ObtenerCompra(_IdCompra);

            if (oCompra != null && oCompra.IdCompra != 0)
            {
                txtfecha.Text = oCompra.FechaRegistro.ToString("dd/MM/yyyy HH:mm");
                txttipodocumento.Text = oCompra.TipoDocumento;
                txtusuario.Text = oCompra.oUsuario.NombreCompleto;

                txtdocproveedor.Text = oCompra.oProveedor.Documento;
                txtnombreproveedor.Text = oCompra.oProveedor.RazonSocial;

                dataGridView1.DataSource = oCompra.oDetalleCompra;
                txtmontototal.Text = String.Format("{0:C2}", oCompra.MontoTotal);
            }
            else
            {
                MessageBox.Show("No se pudo encontrar la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
