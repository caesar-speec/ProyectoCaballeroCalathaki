using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System;
using System.Data;

namespace CapaNegocio
{
    // *** CLASE RENOMBRADA ***
    public class CN_ReporteVentas
    {
        // *** REFERENCIA ACTUALIZADA a CD_ReporteVentas ***
        private CD_ReporteVentas objcd_reporte = new CD_ReporteVentas();

        /// <summary>
        /// Llama a la capa de datos para obtener el reporte de ventas.
        /// </summary>
        /// <param name="fechaInicio"></param>
        /// <param name="fechaFin"></param>
        /// <param name="idUsuario">0 para todos los usuarios, o un ID específico</param>
        /// <returns>Un DataTable con los resultados.</returns>
        public DataTable ReporteVentas(DateTime fechaInicio, DateTime fechaFin, int idUsuario)
        {
            // *** LLAMADA ACTUALIZADA ***
            return objcd_reporte.ReporteVentas(fechaInicio, fechaFin, idUsuario);
        }
    }
}
