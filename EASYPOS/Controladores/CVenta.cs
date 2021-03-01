using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Controladores
{
   public  class CVenta
    {
        MVenta mVenta = new MVenta();

        //*********************************************************
        public void Insertar(Venta venta)
        {
            mVenta.Insertar(venta);
        }
        public void Actualizar(Venta venta)
        {
            mVenta.Actualizar(venta);
        }
        public void Eliminar(Venta venta)
        {
            mVenta.Eliminar(venta);
        }

        public List<Venta> Listado()
        {
            return mVenta.Listado();
        }

        public Venta ObtenerUna(int id)
        {
            return mVenta.ObtenerUno(id);
        }
    }
}
