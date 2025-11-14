using CapaEntidad;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Venta
    {
        public int ObtenerCorrelativo()
        {
            int idcorrelativo = 0;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from VENTA");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    oConexion.Open();
                    idcorrelativo = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    idcorrelativo = 0;
                }
            }

            return idcorrelativo;
        }


        //Actualiza el stock del producto restando la cantidad vendida
        public bool RestarStock(int idproducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update producto set stock = stock - @cantidad where idproducto = @idproducto");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idproducto", idproducto);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        //Actualiza el stock del producto sumando la cantidad devuelta
        public bool SumarStock(int idproducto, int cantidad)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update producto set stock = stock + @cantidad where idproducto = @idproducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idproducto", idproducto);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }


        public bool Registrar(Venta obj, DataTable DetalleVenta, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarVenta", oconexion);
                    cmd.Parameters.AddWithValue("IdUsuario", obj.oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("TipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.AddWithValue("NumeroDocumento", obj.NumeroDocumento);
                    cmd.Parameters.AddWithValue("DocumentoCliente", obj.DocumentoCliente);
                    cmd.Parameters.AddWithValue("NombreCliente", obj.NombreCliente);
                    cmd.Parameters.AddWithValue("MontoPago", obj.MontoPago);
                    cmd.Parameters.AddWithValue("MontoCambio", obj.MontoCambio);
                    cmd.Parameters.AddWithValue("MontoTotal", obj.MontoTotal);
                    cmd.Parameters.AddWithValue("DetalleVenta", DetalleVenta);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }

            return Respuesta;
        }
        public List<Venta> Listar()
        {
            List<Venta> lista = new List<Venta>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT");
                    query.AppendLine(" v.ID_venta,");
                    query.AppendLine(" v.IdUsuario,");
                    query.AppendLine(" u.NombreCompleto AS UsuarioNombre,");
                    query.AppendLine(" v.TipoDocumento,");
                    query.AppendLine(" v.NumeroDocumento,");
                    query.AppendLine(" v.DocumentoCliente,");
                    query.AppendLine(" v.NombreCliente,");
                    query.AppendLine(" v.MontoPago,");
                    query.AppendLine(" v.MontoCambio,");
                    query.AppendLine(" v.MontoTotal,");
                    query.AppendLine(" v.fecha_creacion");
                    query.AppendLine("FROM VENTA v");
                    query.AppendLine("INNER JOIN USUARIO u ON u.IdUsuario = v.IdUsuario");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Venta()
                            {
                                ID_venta = Convert.ToInt32(dr["ID_venta"]),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                DocumentoCliente = dr["DocumentoCliente"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                MontoPago = Convert.ToDecimal(dr["MontoPago"]),
                                MontoCambio = Convert.ToDecimal(dr["MontoCambio"]),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"]),
                                fecha_creacion = dr["fecha_creacion"].ToString(),

                                oUsuario = new Usuario()
                                {
                                    IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                    NombreCompleto = dr["UsuarioNombre"].ToString()
                                },

                                oDetalle_Venta = new List<Detalle_Venta>() // si después querés agregarlo, me avisás
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Venta>();
                }
            }

            return lista;
        }




    }

}
