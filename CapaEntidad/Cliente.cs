namespace CapaEntidad
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public String Documento { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Domicilio { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
    }
}
