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
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class frmListarProductos : Form
    {
        public frmListarProductos()
        {
            InitializeComponent();
        }

        private void frmListarProductos_Load(object sender, EventArgs e)
        {
            // Mostrar productos activos con stock disponible
            List<Producto> listaProducto = new CN_Producto().Listar();

            foreach (Producto item in listaProducto)
            {
                // Mostrar solo productos activos y con stock > 0
                if (item.Estado == true && item.Stock > 0)
                {
                    dgvdata.Rows.Add(new object[] {
                "",
                item.IdProducto,
                item.Codigo,
                item.Nombre,
                item.Descripcion,
                item.oCategoria.IdCategoria,
                item.oCategoria.Descripcion,
                item.Stock,
                item.PrecioCompra,
                item.PrecioVenta,
                1,              // EstadoValor = Activo
                "Activo"        // Estado texto
            });
                }
            }

            // Cargar opciones de búsqueda
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;
        }


        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
