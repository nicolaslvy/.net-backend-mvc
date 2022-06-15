using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wSpunto_de_venta.Models.Request
{
    public class ClienteRequest
    {
        public long IdCliente { get; set; }
        public long? Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
