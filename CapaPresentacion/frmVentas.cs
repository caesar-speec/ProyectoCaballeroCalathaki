using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
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
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtidproducto.Text = "0";
            txtpagacon.Text = "";
            txtcambio.Text = "";
            txttotalpagar.Text = "0";
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
            if (txtdocumentocliente.Text == "")
            {
                MessageBox.Show("Debe seleccionar un cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtdocumentocliente.Text == "")
            {
                MessageBox.Show("Debe seleccionar un cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("Debe agregar productos a la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            DataTable detalle_venta = new DataTable();

            detalle_venta.Columns.Add("IdProducto", typeof(int));
            detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_venta.Columns.Add("Cantidad", typeof(int));
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                detalle_venta.Rows.Add(new object[] {
                   row.Cells["idProducto"].Value.ToString(),
                   row.Cells["PrecioVenta"].Value.ToString(),
                   row.Cells["Cantidad"].Value.ToString(),
                   row.Cells["SubTotal"].Value.ToString()
                });
            }


            int idcorrelativo = new CN_Venta().ObtenerCorrelativo();
            string numerodocumento = string.Format("{0:00000000}", idcorrelativo);
            calcularcambio();


            Venta oVenta = new Venta()
            {
                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                TipoDocumento = ((OpcionCombo)cbotipodocumento.SelectedItem).Texto,
                NumeroDocumento = numerodocumento,
                DocumentoCliente = txtdocumentocliente.Text,
                NombreCliente = txtnombrecliente.Text,
                MontoPago = Convert.ToDecimal(txtpagacon.Text),
                MontoCambio = Convert.ToDecimal(txtcambio.Text),
                MontoTotal = Convert.ToDecimal(txttotalpagar.Text)

            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Venta().Registrar(oVenta, detalle_venta, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Número de Venta: " + numerodocumento +
                    "\n¿Desea copiar el número de venta al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numerodocumento);

                txtdocumentocliente.Text = "";
                txtnombrecliente.Text = "";
                dataGridView1.Rows.Clear();
                calcularTotal();
                txtpagacon.Text = "";
                txtcambio.Text = "";
            } else 
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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

                string mensaje = string.Empty;
                bool respuesta = new CN_Venta().RestarStock(
                    Convert.ToInt32(txtidproducto.Text),
                    Convert.ToInt32(txtcantidad.Value.ToString())
                    );

                if (respuesta)
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


        }



        private void calcularcambio()
        {
            if (txttotalpagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagocon;
            decimal total = Convert.ToDecimal(txttotalpagar.Text);

            if (txtpagacon.Text.Trim() == "")
            {
                txtpagacon.Text = "0";
            }

            if (decimal.TryParse(txtpagacon.Text.Trim(), out pagocon))
            {
                if (pagocon < total)
                {
                    txtcambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagocon - total;
                    txtcambio.Text = cambio.ToString("0.00");
                }
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

            if (e.ColumnIndex == dataGridView1.Columns["btnEliminar"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var icon = Properties.Resources.deleteicono;
                if (icon != null)
                {
                    // Calcular tamaño proporcional (por ejemplo, 60% del tamaño de la celda)
                    int iconSize = (int)(e.CellBounds.Height * 0.6);
                    int x = e.CellBounds.Left + (e.CellBounds.Width - iconSize) / 2;
                    int y = e.CellBounds.Top + (e.CellBounds.Height - iconSize) / 2;

                    e.Graphics.DrawImage(icon, new Rectangle(x, y, iconSize, iconSize));
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
                if (index >= 0) {

                    bool respuesta = new CN_Venta().SumarStock(
                        Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idProducto"].Value.ToString()),
                        Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString())
                        );

                    if (respuesta) 
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                        calcularTotal();
                    }
                   
                } 

            }



        }
    }
}

