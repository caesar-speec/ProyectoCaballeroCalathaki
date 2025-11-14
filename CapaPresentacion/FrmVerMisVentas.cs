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
        public FrmVerMisVentas()
        {
            InitializeComponent();
        }

        private void FrmVerMisVentas_Load(object sender, EventArgs e)
        {
        
        }
    }

private void CargarGridVentas()
        {
            // Limpia las filas actuales
            dataGridView3.Rows.Clear();

            // Obtiene todas las ventas (tu capa de negocio)
            List<Venta> listaVentas = new CN_Venta().Listar();

            // Filtra por usuario logueado
            var ventasFiltradas = listaVentas
                .Where(v => v.oUsuario.IdUsuario == UsuarioLogueado.IdUsuario)
                .ToList();

            // Insertar cada venta en el grid
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
