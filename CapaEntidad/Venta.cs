namespace CapaEntidad
{
    public class Venta
    {
        public int ID_venta { get; set; }
        public Usuario oUsuario { get; set; }
        public string tipo_documento { get; set; }
        public string dni_cliente { get; set; }
        public string DocumentoCliente { get; set; }
        public string nombre_cliente { get; set; }
        public decimal monto_pago { get; set; }
        public decimal monto_cambio { get; set; }
        public decimal monto_total { get; set; }
        public List<Detalle_Venta> oDetalle_Venta { get; set; }
        public string fecha_creacion { get; set; }
    }
}
