using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Entidades
{
    public class Producto_Presentacion
    {
        public int IdProducto_FK { get; set; }
        public int? IdPresentacion_FK { get; set; }
    }
}
