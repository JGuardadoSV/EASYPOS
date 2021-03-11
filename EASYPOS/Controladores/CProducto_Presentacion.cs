using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Controladores
{
    public class CProducto_Presentacion
    {
        MProducto_Presentacion mProductoPresentacion = new MProducto_Presentacion();

        //*********************************************************
        public void Insertar(Producto_Presentacion producto_Presentacion)
        {
            mProductoPresentacion.Insertar(producto_Presentacion);
        }
       
        public void Eliminar(Producto_Presentacion producto_Presentacion)
        {
            mProductoPresentacion.Eliminar(producto_Presentacion);
        }

        public List<Producto_Presentacion> listado(int id)
        {
            return mProductoPresentacion.Listado(id);
        }

        

        
    }
}
