using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Proveedor
    {
        public int ID_proveedor {  get; set; }
        public string razon_social { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public bool estado { get; set; }
        public string fecha_creacion { get; set; }
    }
}
