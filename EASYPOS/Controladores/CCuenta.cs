using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Controladores
{
    public class CCuenta
    {
        MCuenta mCuenta = new MCuenta();

        public void Insertar(Cuentas cuenta)
        {
            if (cuenta.IdCuenta==0)
                mCuenta.Insertar(cuenta);
            else
                mCuenta.Actualizar(cuenta);
            
        }

        public  List<Cuentas> Listado()
        {
            return mCuenta.Listado();
        }
    }
}
