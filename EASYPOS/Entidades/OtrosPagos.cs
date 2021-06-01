using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Entidades
{
    public class OtrosPagos
    {
        public int IdPago { get; set; }
        public DateTime? fecha { get; set; }
        public decimal? monto { get; set; }
        public string comentario { get; set; }
        public decimal? efectivo { get; set; }
        public decimal? cambio { get; set; }
        public int IdContrato_FK { get; set; }
    }

}
