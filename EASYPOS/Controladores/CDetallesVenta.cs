using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Controladores
{
   public  class CDetallesVenta
    {
        MDetallesVenta mDetallesVenta = new MDetallesVenta();

        //*********************************************************
        public void Insertar(DetallesVenta detallesVenta)
        {
            mDetallesVenta.Insertar(detallesVenta);
        }
        public void Actualizar(DetallesVenta detallesVenta)
        {
            mDetallesVenta.Actualizar(detallesVenta);
        }
        public void Eliminar(DetallesVenta detallesVenta)
        {
            mDetallesVenta.Eliminar(detallesVenta);
        }

        public List<DetallesVenta> Listado()
        {
            return mDetallesVenta.Listado();
        }

        public DetallesVenta ObtenerUna(int id)
        {
            return mDetallesVenta.ObtenerUno(id);
        }
    }
}
