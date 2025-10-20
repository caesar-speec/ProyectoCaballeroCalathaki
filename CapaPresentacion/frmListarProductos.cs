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
            // Obtener todos los productos
            List<Producto> listaProducto = new CN_Producto().Listar();

            // 🔹 Filtrar solo los productos activos y con stock disponible
            var productosFiltrados = listaProducto
                .Where(p => p.Estado == true && p.Stock > 0)
                .ToList();

            // 🔹 Mostrar productos filtrados en el DataGridView
            foreach (Producto item in productosFiltrados)
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
            item.Estado == true ? 1 : 0,
            item.Estado == true ? "Activo" : "Inactivo"
        });
            }

            // 🔹 Cargar opciones de búsqueda
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
