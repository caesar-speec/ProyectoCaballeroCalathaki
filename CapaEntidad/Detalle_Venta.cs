namespace CapaEntidad
{
    public class Detalle_Venta
    {
        public int ID_detalle_venta { get; set; }
        public Producto oProducto { get; set; }
        public decimal precio_enta { get; set; }
        public int cantidad { get; set; }
        public decimal subtotal { get; set; }
        public string fecha_creacion { get; set; }
    }
}
