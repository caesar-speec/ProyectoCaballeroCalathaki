using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
        public int ID_cliente { get; set; }
        public long dni_cliente { get; set; }
        public string nombre_completo { get; set; }
        public string correo_cliente { get; set; }
        public string telefono { get; set; }
        public bool estado { get; set; }
        public string fecha_creacion { get; set; }
    }
}
