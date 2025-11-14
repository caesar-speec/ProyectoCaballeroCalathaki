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

            // 1️⃣ Guardar usuario primero
            usuarioActual = usuario;

            // 2️⃣ Mostrar el nombre del usuario
            textBox1.Text = usuarioActual.NombreCompleto;

            // 3️⃣ Cargar ventas del usuario
            CargarMisVentas();
        }

        private void FrmVerMisVentas_Load(object sender, EventArgs e)
        {
            // ❗ NO LLAMES DE NUEVO A CargarMisVentas()
            // Eso duplicaba y además se ejecutaba antes del usuario en muchos casos
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

            // Filtrar ventas del usuario logueado
            var ventasFiltradas = listaVentas
                .Where(v => v.oUsuario.IdUsuario == usuarioActual.IdUsuario)
                .ToList();

            foreach (var venta in ventasFiltradas)
            {
                dataGridView3.Rows.Add(
                    venta.NombreCliente,
                    venta.DocumentoCliente,
                    venta.fecha_creacion,   // ahora DateTime
                    venta.MontoTotal,
                    "Ver detalle"
                );
            }
        }
    }
}
