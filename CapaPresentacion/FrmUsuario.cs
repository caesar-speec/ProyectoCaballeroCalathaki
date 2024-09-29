using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using CapaPresentacion;
using System.Drawing;
using System.IO;
using System.Reflection;

using Microsoft.VisualBasic.ApplicationServices;

namespace CapaPresentacion
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DNI_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().Listar();
            foreach (Rol item in listaRol)
            {
                cborol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            cborol.DisplayMember = "Texto";
            cborol.ValueMember = "Valor";
            cborol.SelectedIndex = 0;


            //Mostrar usuarios
            List<Usuario> listaUsuario = new CN_Usuario().Listar();
            foreach (Usuario item in listaUsuario)
            {
                dgvdata.Rows.Add(new object[] {"",item.IdUsuario,item.Documento, item.NombreCompleto, item.Correo, item.Clave,
                 item.oRol.IdRol,
                 item.oRol.Descripcion,
                 item.Estado == true ? 1 : 0,
                 item.Estado == true ? "Activo" : "Inactivo"
             });
            }
            cborol.DisplayMember = "Texto";
            cborol.ValueMember = "Valor";
            cborol.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dgvdata.Rows.Add(new object[] {"",txtid.Text,txtdocumento.Text, txtnombrecompleto.Text, txtcorreo.Text, txtclave.Text,
            ((OpcionCombo)cborol.SelectedItem).Valor.ToString(),
            ((OpcionCombo)cborol.SelectedItem).Texto.ToString(),
            ((OpcionCombo)cboestado.SelectedItem).Valor.ToString(),
            ((OpcionCombo)cboestado.SelectedItem).Texto.ToString()
            });
            //limpiar();
        }

        private void Clear()
        {
            txtid.Text = "0";
            txtdocumento.Text = "";
            txtnombrecompleto.Text = "";
            txtcorreo.Text = "";
            txtclave.Text = "";
            txtclave2.Text = "";
            cborol.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;
        }
        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Obtener el ensamblado actual
                var assembly = Assembly.GetExecutingAssembly();

                // Reemplaza el string con el nombre correcto del recurso
                using (Stream stream = assembly.GetManifestResourceStream("CapaPresentacion.Resources.check.png"))
                {
                    if (stream != null)
                    {
                        // Cargar la imagen desde el stream
                        var checkImage = Image.FromStream(stream);

                        // Dimensiones de la celda
                        int cellWidth = e.CellBounds.Width;
                        int cellHeight = e.CellBounds.Height;

                        // Dibujar la imagen en la celda ajustada completamente al tamaño de la celda
                        e.Graphics.DrawImage(checkImage, new Rectangle(e.CellBounds.Left, e.CellBounds.Top, cellWidth, cellHeight));
                    }
                }

                // Marcar el evento como manejado
                e.Handled = true;
            }
        }
    }
}

