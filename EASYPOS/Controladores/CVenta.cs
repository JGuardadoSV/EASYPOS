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
        public int Insertar(Venta venta, List<ProductoPOS> detalles)
        {
            return mVenta.Insertar(venta,detalles);
        }
        public void Actualizar(Venta venta)
        {
            mVenta.Actualizar(venta);
        }
        public void Eliminar(Venta venta)
        {
            mVenta.Eliminar(venta);
        }

        public List<Venta> Listado(DateTime f1, DateTime f2)
        {
            return mVenta.Listado(f1,f2);
        }

        public Venta ObtenerUna(int id)
        {
            return mVenta.ObtenerUno(id);
        }

        public List<ReporteVentas> Reporte(DateTime f1, DateTime f2)
        {
            return mVenta.Reporte(f1, f2);
        }

        public List<ProductoPOS> DetallesVenta(int id)
        {
            return mVenta.DetallesVenta(id);
        }
    }
}
