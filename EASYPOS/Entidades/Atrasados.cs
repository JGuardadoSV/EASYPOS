using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Entidades
{
   public  class Atrasados
    {
        public int IdContrato_FK { get; set; }
        public string fechapago { get; set; }
        public int Meses { get; set; }
    }
}
