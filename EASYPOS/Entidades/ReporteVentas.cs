using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Entidades
{
    public class ReporteVentas
    {
        public string fecha { get; set; }
        public string cliente { get; set; }
        public int ticket { get; set; }
        public decimal total { get; set; }
    }
}
