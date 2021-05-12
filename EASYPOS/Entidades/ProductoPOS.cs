using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Entidades
{
    public class ProductoPOS
    {
        public int IdProducto { get; set; }
        public int IdDetalleInventario { get; set; }
        public int IdInventario { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public int Numero { get; set; }

    }
}
