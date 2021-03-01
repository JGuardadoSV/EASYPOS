using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Entidades
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IdCliente_FK { get; set; }
        public int? IdEmpleado_FK { get; set; }
        public int? TipoDocumento { get; set; }
        public long? Correlativo { get; set; }
        public int IdCorrelativo_FK { get; set; }


        public List<DetallesVenta> Detalles { get; set; }
    }
}
