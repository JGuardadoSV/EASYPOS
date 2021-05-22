using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Controladores
{
    public class CContratos
    {
        MContrato mContratos = new MContrato();


        public int Insertar(Contratos contrato)
        {
            if (contrato.IdContrato==0)
            {
                return mContratos.Insertar(contrato);
            }
            else
            {
                return mContratos.Actualizar(contrato);
            }
            
        }

        public void Actualizar(Contratos contrato)
        {
            mContratos.Actualizar(contrato);
        }

        public void Eliminar(Contratos contrato)
        {
            mContratos.Eliminar(contrato);
        }

        public List<Contratos> Listado()
        {
            return mContratos.Listado();
        }
    }
}
