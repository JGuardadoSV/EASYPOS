using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Entidades
{
    public class Presentacion
    {
        public int IdPresentacion { get; set; }
        public string NombrePresentacion { get; set; }
        public int? PresentacionSuperior { get; set; }
        public int? PresentacionInferior { get; set; }
        public string CantidadPresentacion { get; set; }
    }
}
