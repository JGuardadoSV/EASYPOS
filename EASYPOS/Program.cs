using EASYPOS.Formularios;
using EASYPOS.Formularios.Cajas;
using EASYPOS.Formularios.Clientes;
using EASYPOS.Formularios.Correlativos;
using EASYPOS.Formularios.Empleados;
using EASYPOS.Formularios.Presentaciones;
using EASYPOS.Formularios.Productos;
using EASYPOS.Formularios.Proveedores;
using EASYPOS.Formularios.Sucursales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASYPOS
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FPrincipal());
        }
    }
}
