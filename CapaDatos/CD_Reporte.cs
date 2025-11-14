using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic; // Necesario para Dictionary
using Microsoft.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class CD_Reporte
    {
        // Método para obtener KPIs (ahora con fechas)
        public Dictionary<string, object> ObtenerKPIsDashboard(DateTime fechaInicio, DateTime fechaFin)
        {
            var kpis = new Dictionary<string, object>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();

                    // 1. Obtener Ventas
                    using (SqlCommand cmdVentas = new SqlCommand("sp_ReporteDashboard_VentasHoy", oconexion))
                    {
                        cmdVentas.CommandType = CommandType.StoredProcedure;
                        cmdVentas.Parameters.AddWithValue("@FechaInicio", fechaInicio.Date);
                        cmdVentas.Parameters.AddWithValue("@FechaFin", fechaFin.Date);
                        kpis["TotalVentasHoy"] = Convert.ToDecimal(cmdVentas.ExecuteScalar());
                    }

                    // 2. Obtener Clientes Nuevos
                    using (SqlCommand cmdClientes = new SqlCommand("sp_ReporteDashboard_ClientesNuevosHoy", oconexion))
                    {
                        cmdClientes.CommandType = CommandType.StoredProcedure;
                        cmdClientes.Parameters.AddWithValue("@FechaInicio", fechaInicio.Date);
                        cmdClientes.Parameters.AddWithValue("@FechaFin", fechaFin.Date);
                        kpis["ClientesNuevosHoy"] = Convert.ToInt32(cmdClientes.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    kpis["TotalVentasHoy"] = 0m;
                    kpis["ClientesNuevosHoy"] = 0;
                }
            }
            return kpis;
        }

        // Método para obtener Top 5 Productos (ahora con fechas)
        public DataTable ObtenerTop5Productos(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dt = new DataTable();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ReporteDashboard_Top5Productos", oconexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio.Date);
                        cmd.Parameters.AddWithValue("@FechaFin", fechaFin.Date);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    dt = new DataTable();
                }
            }
            return dt;
        }

        // Método para obtener Ventas por Categoría (ahora con fechas)
        public DataTable ObtenerVentasPorCategoria(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dt = new DataTable();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ReporteDashboard_VentasPorCategoria", oconexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio.Date);
                        cmd.Parameters.AddWithValue("@FechaFin", fechaFin.Date);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    dt = new DataTable();
                }
            }
            return dt;
        }
    }
}