using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using CapaDatos;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    // *** CLASE RENOMBRADA ***
    public class CD_ReporteVentas
    {
        /// <summary>
        /// Ejecuta el Stored Procedure SP_REPORTEVENTAS en la base de datos.
        /// </summary>
        /// <param name="fechaInicio"></param>
        /// <param name="fechaFin"></param>
        /// <param name="idUsuario">0 para todos, o un ID específico</param>
        /// <returns>Un DataTable con los resultados.</returns>
        public DataTable ReporteVentas(DateTime fechaInicio, DateTime fechaFin, int idUsuario)
        {
            DataTable dt = new DataTable();

            // Usar la cadena de conexión de la clase Conexion
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();

                    // Comando para ejecutar el Stored Procedure
                    SqlCommand cmd = new SqlCommand("SP_REPORTEVENTAS", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Añadir parámetros
                    cmd.Parameters.AddWithValue("FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("FechaFin", fechaFin);
                    cmd.Parameters.AddWithValue("IdUsuario", idUsuario);

                    // Llenar el DataTable con los resultados
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    // En caso de error, el DataTable estará vacío
                    Console.WriteLine("Error al generar reporte: " + ex.Message);
                    dt = new DataTable();
                }
            }
            return dt;
        }
    }
}
