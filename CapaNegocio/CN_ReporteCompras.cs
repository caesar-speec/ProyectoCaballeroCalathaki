using CapaDatos;
using System;
using System.Data;

namespace CapaNegocio
{
    public class CN_ReporteCompras
    {
        private CD_ReporteCompras objcd_reporte = new CD_ReporteCompras();

        // Corregido: idReponedor
        public DataTable ReporteCompras(DateTime fechaInicio, DateTime fechaFin, int idProveedor, int idReponedor)
        {
            return objcd_reporte.ReporteCompras(fechaInicio, fechaFin, idProveedor, idReponedor);
        }
    }
}