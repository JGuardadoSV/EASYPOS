using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Entidades
{
    public class DetallesVenta
    {
        public int IdDetalleVenta { get; set; }
        public int IdDetalleInventario_FK { get; set; }
        public int? Cantidad { get; set; }
        public int? IdPresentacion_FK { get; set; }
        public int? IdVenta_FK { get; set; }
        public decimal? DecuentoAplicado { get; set; }
        public decimal? PrecioVenta { get; set; }
    }
}
