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
        MProducto_Presentacion mProveedor = new MProducto_Presentacion();

        //*********************************************************
        public void Insertar(Producto_Presentacion producto_Presentacion)
        {
            mProveedor.Insertar(producto_Presentacion);
        }
       
        public void Eliminar(Producto_Presentacion producto_Presentacion)
        {
            mProveedor.Eliminar(producto_Presentacion);
        }

        

        
    }
}
