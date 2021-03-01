using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Entidades
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string DUI { get; set; }
        public string NIT { get; set; }
        public string Giro { get; set; }
        public string NRC { get; set; }
        public string DireccionCliente { get; set; }
        public string Telefono { get; set; }
    }
}
