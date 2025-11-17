namespace CapaEntidad
{
    public class Venta
    {
        public int ID_venta { get; set; }
        public Usuario oUsuario { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string DocumentoCliente { get; set; }
        public Cliente oCliente { get; set; }
        public string NombreCliente { get; set; }
        public decimal MontoPago { get; set; }
        public decimal MontoCambio { get; set; }
        public decimal MontoTotal { get; set; }
        public string fecha_creacion { get; set; }
        public List<Detalle_Venta> oDetalle_Venta { get; set; }
    }
}
