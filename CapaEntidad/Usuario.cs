using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int ID_usuario {  get; set; }
        public long dni_usuario { get; set; }
        public string nombre { get; set; }
        public string correo_usuario { get; set; }
        public string clave { get; set; }
        public Rol oRol { get; set; }
        public bool estado { get; set; }
        public string fecha_creacion { get; set; }
    }
}
