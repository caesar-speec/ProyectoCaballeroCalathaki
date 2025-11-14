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
            usuarioActual = usuario; // 🔥 GUARDA el usuario logueado
        }

        private void FrmVerMisVentas_Load(object sender, EventArgs e)
        {
            CargarMisVentas();
        }

        private void CargarMisVentas()
        {
            if (usuarioActual == null)
            {
                MessageBox.Show("No hay usuario en sesión.");
                return;
            }

            dataGridView3.Rows.Clear();

            List<Venta> listaVentas = new CN_Venta().Listar();

            var ventasFiltradas = listaVentas
                .Where(v => v.oUsuario.IdUsuario == usuarioActual.IdUsuario)
                .ToList();

            foreach (var venta in ventasFiltradas)
            {
                dataGridView3.Rows.Add(
                    venta.NombreCliente,
                    venta.DocumentoCliente,
                    venta.fecha_creacion,
                    venta.MontoTotal,
                    "Ver detalle"
                );
            }
        }
    }
}
