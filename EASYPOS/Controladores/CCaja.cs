using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EASYPOS.Controladores
{
    public class CCaja
    {
        MCaja mCaja = new MCaja();

        //*********************************************************
        public void Insertar(Caja caja)
        {
            if (caja.IdCaja==0)
            {
                mCaja.Insertar(caja);
            }
            else
            {
                this.Actualizar(caja);
            }
            
        }
        public void Actualizar(Caja caja)
        {
            mCaja.Actualizar(caja);
        }
        public void Eliminar(Caja caja)
        {
            mCaja.Eliminar(caja);
        }

        public List<Caja> Listado()
        {
            return mCaja.Listado();
        }

        public Caja ObtenerUna(int id)
        {
            return mCaja.ObtenerUna(id);
        }
    }
}
