using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Entidades
{
    public class DetallesListaDePrecio
    {
        public int IdDetalleLista { get; set; }
        public int? IdLista_FK { get; set; }
        public int? IdDetalleInventario_FK { get; set; }
    }
}
