using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Entidades
{
    public class DetallesInventario
    {
        public int IdDetalle { get; set; }
        public int IdInventario_FK { get; set; }
        public int IdProducto_FK { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Existencias { get; set; }
    }
}
