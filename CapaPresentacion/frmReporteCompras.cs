using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmReporteCompras : Form
    {
        public frmReporteCompras()
        {
            InitializeComponent();
        }

        private void frmReporteCompras_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarReponedores(); // Corregido
            CargarProveedores();

            // Configurar fechas por defecto
            dtinicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtfin.Value = DateTime.Now;

            // Cargar datos iniciales
            BuscarCompras();
        }

        // Corregido: CargarReponedores
        private void CargarReponedores()
        {
            cboRepositor.Items.Clear();
            cboRepositor.DisplayMember = "NombreCompleto";
            cboRepositor.ValueMember = "IdUsuario";

            // Corregido: ListarReponedores
            List<Usuario> listaReponedores = new CN_Usuario().ListarReponedores();

            // Corregido: "Todos los Reponedores"
            cboRepositor.Items.Add(new Usuario() { IdUsuario = 0, NombreCompleto = "Todos los Reponedores" });

            if (listaReponedores != null)
            {
                cboRepositor.Items.AddRange(listaReponedores.ToArray());
            }
            cboRepositor.SelectedIndex = 0;
        }

        private void CargarProveedores()
        {
            cboProveedor.Items.Clear();
            cboProveedor.DisplayMember = "RazonSocial";
            cboProveedor.ValueMember = "IdProveedor";

            List<Proveedor> listaProveedores = new CN_Proveedor().Listar();

            cboProveedor.Items.Add(new Proveedor() { IdProveedor = 0, RazonSocial = "Todos los Proveedores" });

            if (listaProveedores != null)
            {
                cboProveedor.Items.AddRange(listaProveedores.ToArray());
            }
            cboProveedor.SelectedIndex = 0;
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

            IdCompra.DataPropertyName = "IdCompra";
            TipoDocumento.DataPropertyName = "TipoDocumento";
            NumeroDocumento.DataPropertyName = "NumeroDocumento";
            RazonSocial.DataPropertyName = "RazonSocial";
            UsuarioRegistro.DataPropertyName = "UsuarioRegistro"; // Alias del SP
            MontoTotal.DataPropertyName = "MontoTotal";
            FechaRegistro.DataPropertyName = "FechaRegistro";

            MontoTotal.DefaultCellStyle.Format = "C2";
            DetalleCompra.UseColumnTextForButtonValue = true;
        }

        private void BuscarCompras()
        {
            DateTime fechaInicio = dtinicio.Value.Date;
            DateTime fechaFin = dtfin.Value.Date;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Corregido: idReponedor
            int idReponedor = 0;
            if (cboRepositor.SelectedItem != null && cboRepositor.SelectedIndex > -1)
            {
                idReponedor = ((Usuario)cboRepositor.SelectedItem).IdUsuario;
            }

            int idProveedor = 0;
            if (cboProveedor.SelectedItem != null && cboProveedor.SelectedIndex > -1)
            {
                idProveedor = ((Proveedor)cboProveedor.SelectedItem).IdProveedor;
            }

            // Corregido: idReponedor
            DataTable dtCompras = new CN_ReporteCompras().ReporteCompras(fechaInicio, fechaFin, idProveedor, idReponedor);
            dataGridView1.DataSource = dtCompras;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarCompras();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "DetalleCompra")
            {
                int idCompra = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdCompra"].Value);
                frmDetalleCompra modal = new frmDetalleCompra(idCompra);
                modal.ShowDialog();
            }
        }

        private void btnbuscarproveedor_Click(object sender, EventArgs e) { }
    }
}
