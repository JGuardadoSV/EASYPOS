using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Entidades
{
    public class Pagos
    {
        public int IdPago { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
        public decimal Recibido { get; set; }
        public decimal Cambio { get; set; }
        public decimal ACapital { get; set; }
        public decimal AIntereses { get; set; }
        public decimal AMora { get; set; }
        public decimal ACApitalExtra { get; set; }
        public decimal CapitalRestante { get; set; }
        public string Comentario { get; set; }
        public int Correlativo { get; set; }
        public int IdCorrelativo_FK { get; set; }
        public int IdCuota_FK { get; set; }
    }

}
