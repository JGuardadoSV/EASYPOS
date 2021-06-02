using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EASYPOS.Controladores
{
    public class COtrosPagos
    {
        MOtrosPagos mOtros = new MOtrosPagos();

        //*********************************************************
        public void Insertar(OtrosPagos pago)
        {
            if (pago.IdPago==0)
            {
                mOtros.Insertar(pago);
            }
            else
            {
                mOtros.Actualizar(pago);
            }
            
        }
        
       

        public List<OtrosPagos> Listado(int id)
        {
            return mOtros.Listado(id);
        }

        public List<OtrosPagos> ListadoReporte(DateTime f1, DateTime f2)
        {
            return mOtros.ListadoReporte(f1,f2);
        }
    }
}
