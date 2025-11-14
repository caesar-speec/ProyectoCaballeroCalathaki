using CapaDatos;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CN_Reporte
    {
        private CD_Reporte objcd_reporte = new CD_Reporte();

        public Dictionary<string, object> ObtenerKPIsDashboard()
        {
            return objcd_reporte.ObtenerKPIsDashboard();
        }

        public DataTable ObtenerTop5Productos()
        {
            return objcd_reporte.ObtenerTop5Productos();
        }

        public DataTable ObtenerVentasPorCategoria()
        {
            return objcd_reporte.ObtenerVentasPorCategoria();
        }
    }
}
