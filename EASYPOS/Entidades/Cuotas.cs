using System;

namespace EASYPOS.Entidades
{
    public class Cuotas
    {
        public int IdCuota { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? Monto { get; set; }
        public int IdContrato_FK { get; set; }
        public int? Correlativo { get; set; }
        public int IdCorrelativo_FK { get; set; }
    }
}
