using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic; // Necesario para Dictionary

namespace CapaDatos
{
    public class CD_Reporte
    {
        // Método para obtener KPIs (Ventas y Clientes)
        public Dictionary<string, object> ObtenerKPIsDashboard()
        {
            var kpis = new Dictionary<string, object>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();

                    // 1. Obtener Ventas de Hoy
                    using (SqlCommand cmdVentas = new SqlCommand("sp_ReporteDashboard_VentasHoy", oconexion))
                    {
                        cmdVentas.CommandType = CommandType.StoredProcedure;
                        kpis["TotalVentasHoy"] = Convert.ToDecimal(cmdVentas.ExecuteScalar());
                    }

                    // 2. Obtener Clientes Nuevos de Hoy
                    using (SqlCommand cmdClientes = new SqlCommand("sp_ReporteDashboard_ClientesNuevosHoy", oconexion))
                    {
                        cmdClientes.CommandType = CommandType.StoredProcedure;
                        kpis["ClientesNuevosHoy"] = Convert.ToInt32(cmdClientes.ExecuteScalar());
                    }

                    // Podrías agregar más KPIs aquí (ej. Total Productos)
                    // ...

                }
                catch (Exception ex)
                {
                    // Manejar la excepción, quizás registrarla
                    // Devolvemos 0 por seguridad
                    kpis["TotalVentasHoy"] = 0m;
                    kpis["ClientesNuevosHoy"] = 0;
                }
            }
            return kpis;
        }

        // Método para obtener Top 5 Productos
        public DataTable ObtenerTop5Productos()
        {
            DataTable dt = new DataTable();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ReporteDashboard_Top5Productos", oconexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción
                    dt = new DataTable(); // Devolver un DataTable vacío en caso de error
                }
            }
            return dt;
        }

        // Método para obtener Ventas por Categoría
        public DataTable ObtenerVentasPorCategoria()
        {
            DataTable dt = new DataTable();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ReporteDashboard_VentasPorCategoria", oconexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción
                    dt = new DataTable(); // Devolver un DataTable vacío en caso de error
                }
            }
            return dt;
        }
    }
}