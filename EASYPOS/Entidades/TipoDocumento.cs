using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Entidades
{
    public class TipoDocumento
    {
        public int numero { get; set; }
        public string nombre { get; set; }

        public List<TipoDocumento> listado()
        {
            return new List<TipoDocumento> { new TipoDocumento { numero = 1, nombre = "C. Final" }, new TipoDocumento { numero = 2, nombre = "C.C. Fiscal" }, new TipoDocumento { numero = 3, nombre = "Ticket" } };
        }
    }
}
