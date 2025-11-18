using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmDetalleVenta : Form
    {
        private int _IdVenta;
        private Venta _oVenta;

        string PlantillaHtml = @"
        <html>
            <head>
                <style>
                    table.border { border-collapse: collapse; width: 100%; }
                    table.border th { padding: 5px; border: 1px solid black; background-color: #D3D3D3; }
                    table.border td { padding: 5px; border: 1px solid black; }
                    .titulo { font-weight: bold; font-size: 14px; }
                </style>
            </head>
            <body>
                <table border='0' style='width:100%'>
                    <tr>
                        <td style='width:100%'>
                            <table border='0' style='width:100%'>
                                <tr>
                                    <td align='center' valign='top'>
                                        <h2>P&A Pantas S.A.</h2>
                                        <h3>RUC: 20123456789</h3>
                                        <span>Junin 980, Corrientes</span><br>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td align='center'>
                            <br>
                            <span class='titulo'>@tipodocumento - Nro: @numerodocumento</span><br>
                            Fecha: @fecharegistro
                        </td>
                    </tr>
                </table>
                <br>
                <table border='0' style='width:100%'>
                    <tr>
                        <td style='width:15%'><strong>Cliente:</strong></td>
                        <td style='width:35%'>@nombrecliente</td>
                        <td style='width:15%'><strong>Doc. Cliente:</strong></td>
                        <td style='width:35%'>@doccliente</td>
                    </tr>
                    <tr>
                        <td><strong>Dirección:</strong></td>
                        <td colspan='3'>@direccliente</td>
                    </tr>
                    <tr>
                        <td><strong>Vendedor:</strong></td>
                        <td colspan='3'>@nombrevendedor</td>
                    </tr>
                </table>
                <br>
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
                <br>
                <table border='0' style='width:100%'>
                    <tr>
                        <td align='right' style='width:80%'><strong>Total a Pagar:</strong></td>
                        <td align='right' style='width:20%'>@montototal</td>
                    </tr>
                    <tr>
                        <td align='right'><strong>Pago con:</strong></td>
                        <td align='right'>@pagocon</td>
                    </tr>
                    <tr>
                        <td align='right'><strong>Cambio:</strong></td>
                        <td align='right'>@cambio</td>
                    </tr>
                </table>
            </body>
        </html>";

        public frmDetalleVenta(int idVenta = 0)
        {
            InitializeComponent();
            _IdVenta = idVenta;
        }

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            txtbusqueda.Text = _IdVenta.ToString();
            txtbusqueda.ReadOnly = true;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

            Producto.DataPropertyName = "NombreProducto";
            Precio.DataPropertyName = "PrecioVenta";
            Cantidad.DataPropertyName = "Cantidad";
            SubTotal.DataPropertyName = "SubTotal";
            IdVenta.Visible = false;

            Precio.DefaultCellStyle.Format = "C2";
            SubTotal.DefaultCellStyle.Format = "C2";

            _oVenta = new CN_Venta().ObtenerVenta(_IdVenta);

            if (_oVenta != null && _oVenta.ID_venta != 0)
            {
                txtfecha.Text = _oVenta.fecha_creacion;
                txttipodocumento.Text = _oVenta.TipoDocumento;
                txtusuario.Text = _oVenta.oUsuario.NombreCompleto;

                txtdoccliente.Text = _oVenta.oCliente.Documento;
                txtnombrecliente.Text = _oVenta.oCliente.NombreCompleto;

                dataGridView1.DataSource = _oVenta.oDetalle_Venta;

                txtmontototal.Text = String.Format("{0:C2}", _oVenta.MontoTotal);
                txtmontopago.Text = String.Format("{0:C2}", _oVenta.MontoPago);
                txtmontocambio.Text = String.Format("{0:C2}", _oVenta.MontoCambio);
            }
            else
            {
                MessageBox.Show("No se pudo encontrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnDescargarPDF_Click(object sender, EventArgs e)
        {
            if (_oVenta == null)
            {
                MessageBox.Show("No hay datos de venta para imprimir.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string direccionCliente = "";
            try
            {
                var clienteEncontrado = new CN_Cliente().Listar()
                    .FirstOrDefault(c => c.Documento == _oVenta.oCliente.Documento);

                if (clienteEncontrado != null)
                {
                    direccionCliente = clienteEncontrado.Domicilio;
                }
            }
            catch { }

            string Texto_Html = PlantillaHtml;

            Texto_Html = Texto_Html.Replace("@nombrenegocio", "MI NEGOCIO S.A.");
            Texto_Html = Texto_Html.Replace("@docnegocio", "20123456789");
            Texto_Html = Texto_Html.Replace("@direcnegocio", "Av. Siempre Viva 123");

            Texto_Html = Texto_Html.Replace("@tipodocumento", _oVenta.TipoDocumento?.ToUpper() ?? "");
            Texto_Html = Texto_Html.Replace("@numerodocumento", _oVenta.NumeroDocumento ?? _oVenta.ID_venta.ToString());
            Texto_Html = Texto_Html.Replace("@fecharegistro", _oVenta.fecha_creacion ?? "");

            Texto_Html = Texto_Html.Replace("@doccliente", _oVenta.oCliente?.Documento ?? "");
            Texto_Html = Texto_Html.Replace("@nombrecliente", _oVenta.oCliente?.NombreCompleto ?? "");
            Texto_Html = Texto_Html.Replace("@direccliente", direccionCliente ?? "");
            Texto_Html = Texto_Html.Replace("@nombrevendedor", _oVenta.oUsuario?.NombreCompleto ?? "");

            string filas = string.Empty;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // *** CORRECCIÓN AQUÍ: Usamos DataBoundItem para obtener los datos reales del objeto ***
                // Esto evita problemas si la celda de la grilla no tiene el valor o el nombre de columna no coincide.
                Detalle_Venta detalle = row.DataBoundItem as Detalle_Venta;

                if (detalle != null)
                {
                    filas += "<tr>";
                    filas += "<td>" + detalle.NombreProducto + "</td>";
                    filas += "<td>" + detalle.precio_venta.ToString("0.00") + "</td>"; // Leemos la propiedad directamente
                    filas += "<td>" + detalle.cantidad.ToString() + "</td>";
                    filas += "<td>" + detalle.subtotal.ToString("0.00") + "</td>";
                    filas += "</tr>";
                }
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);

            Texto_Html = Texto_Html.Replace("@montototal", txtmontototal.Text);
            Texto_Html = Texto_Html.Replace("@pagocon", txtmontopago.Text);
            Texto_Html = Texto_Html.Replace("@cambio", txtmontocambio.Text);

            mdComprobante modal = new mdComprobante(Texto_Html);
            modal.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void txtpagacon_TextChanged(object sender, EventArgs e) { }
        private void txtcambio_TextChanged(object sender, EventArgs e) { }
    }
}