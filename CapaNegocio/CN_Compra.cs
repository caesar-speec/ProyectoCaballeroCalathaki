using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Compra
    {
        private CD_Compra objcd_compra = new CD_Compra();

        public int ObtenerCorrelativo()
        {
            return objcd_compra.ObtenerCorrelativo();
        }

        // Único método para registrar. Recibe el objeto Compra y el DataTable del detalle.
        public bool Registrar(Compra obj, DataTable DetalleCompra, out string Mensaje)
        {
            // Aquí podrías agregar reglas de negocio.
            // Ejemplo: if(obj.MontoTotal > 10000) { Mensaje = "Las compras no pueden exceder los 10000"; return false; }

            return objcd_compra.Registrar(obj, DetalleCompra, out Mensaje);
        }
    }
}


