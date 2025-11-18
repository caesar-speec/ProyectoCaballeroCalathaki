using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmDetalleCompra : Form
    {
        private int _IdCompra;
        private Compra _oCompra;

        // Plantilla HTML para Compra (igual que en frmCompras)
        string PlantillaHtml = @"
        <html>
            <head>
                <style>
                    table.border { border-collapse: collapse; width: 100%; }
                    table.border th { padding: 5px; border: 1px solid black; background-color: #D3D3D3; }
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
                                        <h2>ORDEN DE COMPRA</h2>
                                        <h3>P&A Plantas S.A.</h3>
                                        <span>Junin 980, Corrientes</span><br>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td align='center'>
                            <br>
                            <strong>@tipodocumento</strong><br>
                            <strong>Nro: @numerodocumento</strong><br>
                            Fecha: @fecharegistro
                        </td>
                    </tr>
                </table>
                <br>
                <table border='0' style='width:100%'>
                    <tr>
                        <td><strong>Proveedor:</strong> @nombreproveedor</td>
                        <td><strong>RUC/DNI:</strong> @docproveedor</td>
                    </tr>
                    <tr>
                        <td colspan='2'><strong>Dirección:</strong> @direcproveedor</td>
                    </tr>
                    <tr>
                        <td colspan='2'><strong>Registrado por:</strong> @usuario</td>
                    </tr>
                </table>
                <br>
                <table class='border'>
                    <thead>
                        <tr>
                            <th>Producto</th>
                            <th>Precio Compra</th>
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
                        <td align='right'><strong>Monto Total:</strong> @montototal</td>
                    </tr>
                </table>
            </body>
        </html>";

        public frmDetalleCompra(int idCompra = 0)
        {
            InitializeComponent();
            _IdCompra = idCompra;
        }

        private void frmDetalleCompra_Load(object sender, EventArgs e)
        {
            txtidcompra.Text = _IdCompra.ToString();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

            // Mapeo correcto (propiedad plana)
            Producto.DataPropertyName = "NombreProducto";

            PrecioCompra.DataPropertyName = "PrecioCompra";
            Cantidad.DataPropertyName = "Cantidad";
            SubTotal.DataPropertyName = "MontoTotal";

            PrecioCompra.DefaultCellStyle.Format = "C2";
            SubTotal.DefaultCellStyle.Format = "C2";

            _oCompra = new CN_Compra().ObtenerCompra(_IdCompra);

            if (_oCompra != null && _oCompra.IdCompra != 0)
            {
                txtfecha.Text = _oCompra.FechaRegistro.ToString("dd/MM/yyyy HH:mm");
                txttipodocumento.Text = _oCompra.TipoDocumento;
                txtusuario.Text = _oCompra.oUsuario.NombreCompleto;

                txtdocproveedor.Text = _oCompra.oProveedor.Documento;
                txtnombreproveedor.Text = _oCompra.oProveedor.RazonSocial;

                dataGridView1.DataSource = _oCompra.oDetalleCompra;
                txtmontototal.Text = String.Format("{0:C2}", _oCompra.MontoTotal);
            }
            else
            {
                MessageBox.Show("No se pudo encontrar la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnDescargarPDF_Click(object sender, EventArgs e)
        {
            if (_oCompra == null)
            {
                MessageBox.Show("No hay datos de compra para imprimir.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Intentar buscar dirección del proveedor
            string direccionProveedor = "";
            try
            {
                var proveedor = new CN_Proveedor().Listar()
                    .FirstOrDefault(p => p.Documento == _oCompra.oProveedor.Documento);
                if (proveedor != null)
                {
                    direccionProveedor = proveedor.Domicilio;
                }
            }
            catch { }

            string Texto_Html = PlantillaHtml;

            Texto_Html = Texto_Html.Replace("@tipodocumento", _oCompra.TipoDocumento.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", _oCompra.NumeroDocumento);
            Texto_Html = Texto_Html.Replace("@fecharegistro", _oCompra.FechaRegistro.ToString("dd/MM/yyyy"));

            Texto_Html = Texto_Html.Replace("@nombreproveedor", _oCompra.oProveedor.RazonSocial);
            Texto_Html = Texto_Html.Replace("@docproveedor", _oCompra.oProveedor.Documento);
            Texto_Html = Texto_Html.Replace("@direcproveedor", direccionProveedor);
            Texto_Html = Texto_Html.Replace("@usuario", _oCompra.oUsuario.NombreCompleto);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Usar DataBoundItem para seguridad
                Detalle_Compra detalle = row.DataBoundItem as Detalle_Compra;
                if (detalle != null)
                {
                    filas += "<tr>";
                    filas += "<td>" + detalle.NombreProducto + "</td>";
                    filas += "<td>" + detalle.PrecioCompra.ToString("0.00") + "</td>";
                    filas += "<td>" + detalle.Cantidad.ToString() + "</td>";
                    filas += "<td>" + detalle.MontoTotal.ToString("0.00") + "</td>";
                    filas += "</tr>";
                }
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txtmontototal.Text);

            mdComprobante modal = new mdComprobante(Texto_Html);
            modal.ShowDialog();
        }
    }
}