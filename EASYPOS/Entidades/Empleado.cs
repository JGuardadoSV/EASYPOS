using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Entidades
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string NombresEmpleado { get; set; }
        public string ApellidosEmpleado { get; set; }
        public int IdRol_FK { get; set; }
        public string DUI { get; set; }
        public string NIT { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int IdSucursal_FK { get; set; }
    }
}
