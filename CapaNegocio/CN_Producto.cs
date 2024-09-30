using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private CN_Producto objcd_producto = new CN_Producto();
        public List<Producto> Listar()
        {

            return objcd_producto.Listar();
        }
    }
}
