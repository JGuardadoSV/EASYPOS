using System;

namespace EASYPOS.Entidades
{
    public class TablaPagosExtendidos
    {
        public int Correlativo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Capital { get; set; }
        public decimal Interes { get; set; }
        public decimal Cuota { get; set; }
        public decimal Restante { get; set; }
        public DateTime FechaPago { get; set; }
    }
}
