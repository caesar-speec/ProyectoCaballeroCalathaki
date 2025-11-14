using CapaDatos;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CN_Reporte
    {
        private CD_Reporte objcd_reporte = new CD_Reporte();

        public Dictionary<string, object> ObtenerKPIsDashboard(DateTime fechaInicio, DateTime fechaFin)
        {
            return objcd_reporte.ObtenerKPIsDashboard(fechaInicio, fechaFin);
        }

        public DataTable ObtenerTop5Productos(DateTime fechaInicio, DateTime fechaFin)
        {
            return objcd_reporte.ObtenerTop5Productos(fechaInicio, fechaFin);
        }

        public DataTable ObtenerVentasPorCategoria(DateTime fechaInicio, DateTime fechaFin)
        {
            return objcd_reporte.ObtenerVentasPorCategoria(fechaInicio, fechaFin);
        }
    }
}
