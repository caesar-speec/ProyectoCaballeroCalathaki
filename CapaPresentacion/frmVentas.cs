using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmVentas : Form
    {
        private Usuario _Usuario;
        private string _DireccionCliente = ""; // Variable para guardar la dirección del cliente

        // Plantilla HTML para Venta
        string PlantillaHtml = @"
        <html>
            <head>
                <style>
                    table.border { border-collapse: collapse; width: 100%; }
                    table.border th { padding: 5px; border: 1px solid black; }
                    table.border td { padding: 5px; border: 1px solid black; }
                </style>
            </head>
            <body>
                <table border='0' style='width:100%'>
                    <tr>
                        <td style='width:100%'>
                            <table border='0' style='width:100%'>
                                <tr>
                                    <td align='center' valign='top'>
                                        <h2>P&A Plantas S.A.</h2>
                                        <h3>RUC: 20123456789</h3>
                                        <span>Junin 1090, Corrientes</span><br>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td align='center'>
                            <strong>@tipodocumento</strong><br>
                            <strong>Nro: @numerodocumento</strong><br>
                            Fecha: @fecharegistro
                        </td>
                    </tr>
                </table>
                <hr>
                <table border='0' style='width:100%'>
                    <tr>
                        <td><strong>Cliente:</strong> @nombrecliente</td>
                        <td><strong>Doc. Cliente:</strong> @doccliente</td>
                    </tr>
                    <tr>
                        <td colspan='2'><strong>Dirección:</strong> @direccliente</td>
                    </tr>
                </table>
                <hr>
                <table class='border'>
                    <thead>
                        <tr>
                            <th>Producto</th>
                            <th>Precio</th>
                            <th>Cantidad</th>
                            <th>Total</th>
                        </tr>
                    </thead>
                    <tbody>
                        @filas
                    </tbody>
                </table>
                <hr>
                <table border='0' style='width:100%'>
                    <tr>
                        <td align='right'><strong>Total a Pagar:</strong> @montototal</td>
                    </tr>
                    <tr>
                        <td align='right'><strong>Pago con:</strong> @pagocon</td>
                    </tr>
                    <tr>
                        <td align='right'><strong>Cambio:</strong> @cambio</td>
                    </tr>
                </table>
            </body>
        </html>";

        public frmVentas(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
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
                    _DireccionCliente = modal._Cliente.Domicilio;
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
           //if (string.IsNullOrWhiteSpace(txtcodproducto.Text) || !txtcodproducto.Text.All(char.IsDigit))
           // {
           //    MessageBox.Show("El campo Código de Producto es obligatorio y solo debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           //   return;
           //}
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
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

            if (string.IsNullOrWhiteSpace(txtpagacon.Text))
            {
                MessageBox.Show("Debe ingresar el monto con el que paga", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpagacon.Select();
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
                var result = MessageBox.Show("Número de Venta generada: " + numerodocumento + "\n\n¿Desea imprimir el comprobante?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    string Texto_Html = PlantillaHtml;

                    // Reemplazo de datos en la plantilla
                    Texto_Html = Texto_Html.Replace("@tipodocumento", oVenta.TipoDocumento.ToUpper());
                    Texto_Html = Texto_Html.Replace("@numerodocumento", oVenta.NumeroDocumento);
                    Texto_Html = Texto_Html.Replace("@fecharegistro", DateTime.Now.ToString("dd/MM/yyyy"));
                    Texto_Html = Texto_Html.Replace("@doccliente", oVenta.DocumentoCliente);
                    Texto_Html = Texto_Html.Replace("@nombrecliente", oVenta.NombreCliente);
                    Texto_Html = Texto_Html.Replace("@direccliente", _DireccionCliente);

                    string filas = string.Empty;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        filas += "<tr>";
                        filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["PrecioVenta"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                        filas += "</tr>";
                    }
                    Texto_Html = Texto_Html.Replace("@filas", filas);

                    Texto_Html = Texto_Html.Replace("@montototal", txttotalpagar.Text);
                    Texto_Html = Texto_Html.Replace("@pagocon", txtpagacon.Text);
                    Texto_Html = Texto_Html.Replace("@cambio", txtcambio.Text);

                    // Abrir modal de impresión
                    mdComprobante modal = new mdComprobante(Texto_Html);
                    modal.ShowDialog();
                }

                txtdocumentocliente.Text = "";
                txtnombrecliente.Text = "";
                dataGridView1.Rows.Clear();
                calcularTotal();
                txtpagacon.Text = "";
                txtcambio.Text = "";
                _DireccionCliente = ""; // Limpiar dirección
            }
            else
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
            if (txttotalpagar.Text.Trim() == "") return;

            decimal pagocon;
            decimal total = Convert.ToDecimal(txttotalpagar.Text);

            if (txtpagacon.Text.Trim() == "") txtpagacon.Text = "0";

            if (decimal.TryParse(txtpagacon.Text.Trim(), out pagocon))
            {
                if (pagocon < total)
                    txtcambio.Text = "0.00";
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
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dataGridView1.Columns["btnEliminar"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var icon = Properties.Resources.deleteicono;
                if (icon != null)
                {
                    int iconSize = (int)(e.CellBounds.Height * 0.6);
                    int x = e.CellBounds.Left + (e.CellBounds.Width - iconSize) / 2;
                    int y = e.CellBounds.Top + (e.CellBounds.Height - iconSize) / 2;
                    e.Graphics.DrawImage(icon, new Rectangle(x, y, iconSize, iconSize));
                }
                e.Handled = true;
            }
        }

        private void txtpagacon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                decimal pagocon = 0;
                decimal totalpagar = 0;
                decimal vuelto = 0;
                if (decimal.TryParse(txtpagacon.Text, out pagocon))
                {
                    totalpagar = Convert.ToDecimal(txttotalpagar.Text);
                    if (pagocon >= totalpagar)
                    {
                        vuelto = pagocon - totalpagar;
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
                if (index >= 0)
                {
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

        // Eventos vacíos
        private void label13_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void txtpagacon_TextChanged(object sender, EventArgs e) { }
    }
}