using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmListarClientes : Form
    {
        public frmListarClientes()
        {
            InitializeComponent();
        }

        private void frmListarClientes_Load(object sender, EventArgs e)
        {
            // Cargar opciones de búsqueda
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true)
                {
                    cboBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;

            CargarClientes();
        }

        private void CargarClientes()
        {
            dgvdata.Rows.Clear();

            List<Cliente> lista = new CN_Cliente().Listar();

            foreach (Cliente item in lista)
            {
                dgvdata.Rows.Add(new object[] {
                    item.IdCliente,
                    item.Documento,
                    item.NombreCompleto,
                    item.Correo,
                    item.Telefono,
                    item.Domicilio,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo"
                });
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cboBusqueda.SelectedItem).Valor.ToString();
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dgvdata.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvdata.SelectedRows[0];

                int idCliente = Convert.ToInt32(row.Cells["Id"].Value);
                bool estadoActual = Convert.ToInt32(row.Cells["EstadoValor"].Value) == 1;

                // Calculamos el nuevo estado
                bool nuevoEstadoBool = !estadoActual;
                string nuevoEstadoTexto = nuevoEstadoBool ? "Activo" : "No Activo";

                string accion = nuevoEstadoBool ? "Activar" : "Desactivar";

                if (MessageBox.Show($"¿Está seguro que desea {accion} al cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Reconstruimos el objeto Cliente completo para el método Editar
                    // (Es necesario pasar todos los datos para que no se borren)
                    Cliente obj = new Cliente()
                    {
                        IdCliente = idCliente,
                        Documento = row.Cells["Documento"].Value.ToString(),
                        NombreCompleto = row.Cells["NombreCompleto"].Value.ToString(),
                        Correo = row.Cells["Correo"].Value.ToString(),
                        Telefono = row.Cells["Telefono"].Value.ToString(),
                        Domicilio = row.Cells["Domicilio"].Value.ToString(),
                        Estado = nuevoEstadoBool
                    };

                    string mensaje = string.Empty;

                    // Llamamos a la capa de negocio para editar
                    bool resultado = new CN_Cliente().Editar(obj, out mensaje);

                    if (resultado)
                    {
                        MessageBox.Show($"Cliente actualizado a: {nuevoEstadoTexto}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualizamos visualmente la grilla
                        row.Cells["EstadoValor"].Value = nuevoEstadoBool ? 1 : 0;
                        row.Cells["Estado"].Value = nuevoEstadoTexto;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo cambiar el estado: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente de la lista (fila completa).", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}