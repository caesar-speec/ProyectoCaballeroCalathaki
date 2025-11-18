using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;


namespace CapaPresentacion.Modales
{
    public partial class mdComprobante : Form
    {
        public string Texto_Html { get; set; } = string.Empty;

        public mdComprobante(string texto_html = "")
        {
            InitializeComponent();
            Texto_Html = texto_html;
        }

        private void mdComprobante_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("about:blank");
            if (webBrowser1.Document != null)
            {
                webBrowser1.Document.Write(Texto_Html);
                webBrowser1.Document.Title = "Comprobante de Venta";
            }
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }
    }
}