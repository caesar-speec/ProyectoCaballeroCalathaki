using CapaEntidad;
using CapaPresentacion.Modales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmVentas : Form
    {

        private Usuario _Usuario;
        //private DataGridView dataGridView1;

        public frmVentas(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {

            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtidcliente.Text = modal._Cliente.IdCliente.ToString();
                    txtdocumentocliente.Text = modal._Cliente.Documento;
                    txtnombrecliente.Text = modal._Cliente.NombreCompleto;
                }
                else
                {
                    txtdocumentocliente.Select();
                }
            }
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Producto.IdProducto.ToString();
                    txtcodproducto.Text = modal._Producto.Codigo;
                    txtproducto.Text = modal._Producto.Nombre;
                    txtprecio.Text = modal._Producto.PrecioVenta.ToString("0.00");
                    txtstock.Text = modal._Producto.Stock.ToString();
                    txtcantidad.Select();
                }
                else
                {
                    txtcodproducto.Select();
                }

            }
            if (string.IsNullOrWhiteSpace(txtcodproducto.Text) || !txtcodproducto.Text.All(char.IsDigit))
            {
                MessageBox.Show("El campo Código de Producto es obligatorio y solo debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {

        }

        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existe = false;

            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtprecio.Text, out precio))
            {
                MessageBox.Show("Precio Compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecio.Select();
                return;
            }


            if (Convert.ToInt32(txtstock.Text) < Convert.ToInt32(txtcantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad a vender no puede ser mayor al stock disponible", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtcantidad.Select();
                return;
            }

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {

                if (fila.Cells["idProducto"].Value.Equals(Convert.ToInt32(txtidproducto.Text)))
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    txtidproducto.Text,
                    txtproducto.Text,
                    precio.ToString("0.00"),
                    txtcantidad.Value.ToString(),
                    (txtcantidad.Value * precio).ToString("0.00")

                    });

                calcularTotal();
                limpiarProducto();
                txtcodproducto.Select();
            }


        }



        private void calcularTotal()
        {
            decimal total = 0;

            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value);
                }
            }
            txttotalpagar.Text = total.ToString("0.00");
        }

        private void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txtcodproducto.Text = "";
            txtproducto.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";
            txtcantidad.Value = 1;
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Cast deleteicon to Image to access Width and Height properties
                var deleteIcon = Properties.Resources.deleteicon as Image;
                if (deleteIcon != null)
                {
                    var w = deleteIcon.Width;
                    var h = deleteIcon.Height;
                    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                    // Draw the icon
                    e.Graphics.DrawImage(deleteIcon, new Rectangle(x, y, w, h));
                }

                e.Handled = true;
            }
        }



        private void txtpagacon_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtpagacon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                decimal pagacon = 0;
                decimal totalpagar = 0;
                decimal vuelto = 0;
                if (decimal.TryParse(txtpagacon.Text, out pagacon))
                {
                    totalpagar = Convert.ToDecimal(txttotalpagar.Text);
                    if (pagacon >= totalpagar)
                    {
                        vuelto = pagacon - totalpagar;
                        txtcambio.Text = vuelto.ToString("0.00");
                    }
                    else
                    {
                        MessageBox.Show("El monto pagado es menor al total a pagar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtpagacon.Select();
                    }
                }
                else
                {
                    MessageBox.Show("Formato de moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtpagacon.Select();
                }

            }
        }

        private void txtcantidad_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown txt = sender as NumericUpDown;
            if (txt == null) return;

            if (txt.Value < 1)
            {
                MessageBox.Show("La cantidad debe ser como mínimo 1.", "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Value = 1;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int index = e.RowIndex;
                if (index < 0) {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    calcularTotal();
                } 
            }



        }
    }
}

