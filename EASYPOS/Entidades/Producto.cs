using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Entidades
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public int? TieneVariasPresentaciones { get; set; }
        public int IdCategoria_FK { get; set; }
        public int IdProveedor_FK { get; set; }
        public string InformacionAdicional { get; set; }
        public string PrincipioActivo { get; set; }
        public decimal? Precio { get; set; }
    }
}
