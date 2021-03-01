using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Entidades
{
    public class Caja
    {
        public int IdCaja { get; set; }
        public DateTime? FechaApertura { get; set; }
        public DateTime? FechaCierre { get; set; }
        public int? IdEmpleadoApertura_FK { get; set; }
        public decimal? MontoInicial { get; set; }
        public decimal? SumaEntradas { get; set; }
        public decimal? SumaSalidas { get; set; }
        public decimal? Faltante { get; set; }
        public decimal? Sobrante { get; set; }
        public string Observaciones { get; set; }
        public int IdEmpleadoCierre_FK { get; set; }
        public int? IdSucursal_FK { get; set; }
        public byte? Estado { get; set; }
    }
}
