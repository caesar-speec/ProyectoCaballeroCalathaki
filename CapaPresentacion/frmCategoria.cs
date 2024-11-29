using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtdescripcion.Text = "";
            cboestado.SelectedIndex = 0;
        }

        private void txtnombrecompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Categoria obj = new Categoria()
            {
                IdCategoria = Convert.ToInt32(txtid.Text),
                Descripcion = txtdescripcion.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false
            };

            if (obj.IdCategoria == 0)
            {
                int idgenerado = new CN_Categoria().Registrar(obj, out mensaje);
                if (idgenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] {
                "", idgenerado, txtdescripcion.Text,
                ((OpcionCombo)cboestado.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cboestado.SelectedItem).Texto.ToString()
            });
                    Clear();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new CN_Categoria().Editar(obj, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["id"].Value = txtid.Text;
                    row.Cells["Descripcion"].Value = txtdescripcion.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboestado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboestado.SelectedItem).Texto.ToString();
                    Clear();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }


        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;



            //Mostrar usuarios
            List<Categoria> lista = new CN_Categoria().Listar();
            foreach (Categoria item in lista)
            {
                dgvdata.Rows.Add(new object[] {"", 
                 item.Descripcion,
                 item.Estado == true ? 1 : 0,
                 item.Estado == true ? "Activo" : "Inactivo"
             });
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
