using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Controladores
{
    public class CPagos
    {
        MPagos mPagos = new MPagos();

        //*********************************************************
        public void Insertar(Pagos pago)
        {
                mPagos.Insertar(pago);

        }

        public List<Pagos> Listado(int idContrato)
        {
            return mPagos.Listado(idContrato);
        }

        public decimal extra(int idContrato)
        {
            return mPagos.extra(idContrato);
        }

        public  List<Pagos> ListadoReporte(DateTime f1, DateTime f2)
        {
            return mPagos.ListadoReporte(f1,f2);
        }
    }
}
