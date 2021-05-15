using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Entidades
{
    public class TablaPagos
    {
        public int Correlativo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Capital { get; set; }
        public decimal Interes { get; set; }
        public decimal Cuota { get; set; }
        public decimal Restante { get; set; }
    }
}
