using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class dclientes
    {
        public int idCliente { get; set; }
        public string Nombre_del_cliente { get; set; }
        public int Precio { get; set; }
        public int Celular { get; set; }
        public string Solicitud { get; set; }
        public string Soporte { get; set; }
        public string Respuesta { get; set; }
        public DateTime Fecha { get; set; }
    }

}
