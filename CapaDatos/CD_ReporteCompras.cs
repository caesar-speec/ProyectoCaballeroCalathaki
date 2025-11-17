using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CD_ReporteCompras
    {
        // Corregido: idReponedor
        public DataTable ReporteCompras(DateTime fechaInicio, DateTime fechaFin, int idProveedor, int idReponedor)
        {
            DataTable dt = new DataTable();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();
                    // Corregido: SP_REPORTECOMPRAS
                    SqlCommand cmd = new SqlCommand("SP_REPORTECOMPRAS", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("FechaFin", fechaFin);
                    cmd.Parameters.AddWithValue("IdProveedor", idProveedor);
                    // Corregido: @IdReponedor
                    cmd.Parameters.AddWithValue("IdReponedor", idReponedor);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al generar reporte compras: " + ex.Message);
                    dt = new DataTable();
                }
            }
            return dt;
        }
    }
}