using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Entidades
{
    public class ListasDePrecio
    {
        public int IdLista { get; set; }
        public int IdInventario_FK { get; set; }
        public byte? Activa { get; set; }
    }
}
