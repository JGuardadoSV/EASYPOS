using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Entidades
{
    public class Inventario
    {
        public int IdInventario { get; set; }
        public int? TipoInventario { get; set; }
        public int IdSucursal_FK { get; set; }

        public List<DetallesInventario> Detalles { get; set; }
    }
}
