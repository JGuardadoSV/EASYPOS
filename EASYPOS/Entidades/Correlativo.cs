using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Entidades
{
    public class Correlativo
    {
        public int IdCorrelativo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? Inicio { get; set; }
        public long? Fin { get; set; }
        public string Autorizacion { get; set; }
        public int? TipoDeDocumento { get; set; }
        public DateTime? FechaDeAutorizacion { get; set; }
        public long? ValorActual { get; set; }
        public int IdSucursal_FK { get; set; }
    }
}
