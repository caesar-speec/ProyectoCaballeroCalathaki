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

        // +++ AGREGA ESTE MÉTODO AL FINAL DE LA CLASE +++
        public Compra ObtenerCompra(int idCompra)
        {
            // Asumo que ya tienes la instancia:
            // private CD_Compra objcd_compra = new CD_Compra();

            Compra oCompra = objcd_compra.ObtenerCompra(idCompra);

            if (oCompra != null && oCompra.IdCompra != 0)
            {
                // Si encontramos la compra, buscamos sus detalles (productos)
                oCompra.oDetalleCompra = objcd_compra.ObtenerDetalleCompra(idCompra);
            }
            return oCompra;
        }

    }
}


