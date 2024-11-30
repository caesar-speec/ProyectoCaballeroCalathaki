using CapaDatos;
using CapaEntidad;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private CD_Producto objcd_Producto = new CD_Producto();
        public List<Producto> Listar()
        {

            return objcd_Producto.Listar();
        }
        public int Registrar(Producto obj, out string Mensaje)
        {

            return objcd_Producto.Registrar(obj, out Mensaje);
        }

        public bool Editar(Producto obj, out string Mensaje)
        {

            return objcd_Producto.Editar(obj, out Mensaje);
        }
        public bool Eliminar(Producto obj, out string Mensaje)
        {

            return objcd_Producto.Eliminar(obj, out Mensaje);
        }
    }
}
