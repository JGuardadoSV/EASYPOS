using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Entidades
{
   public  class Cuentas
    {
        public int IdCuenta { get; set; }
        public DateTime FechaApertura { get; set; }
        public string Numero { get; set; }
        public string Banco { get; set; }
        public int Tipo { get; set; }
        public decimal MontoInicial { get; set; }
        public decimal MontoDisponible { get; set; }
         
	}
}
