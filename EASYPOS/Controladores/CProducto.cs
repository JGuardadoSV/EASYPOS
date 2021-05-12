using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Controladores
{
    public class CProducto
    {
        MProducto mProducto = new MProducto();

        //*********************************************************
        public void Insertar(Producto producto,int existencias)
        {
            if (producto.IdProducto == 0)
                mProducto.Insertar(producto, existencias);
            else
                this.Actualizar(producto);
            
        }
        public void Actualizar(Producto producto)
        {
            mProducto.Actualizar(producto);
        }
        public void Eliminar(Producto producto)
        {
            mProducto.Eliminar(producto);
        }

        public List<Producto> Listado()
        {
            return mProducto.Listado();
        }

        public Producto ObtenerUna(int id)
        {
            return mProducto.ObtenerUno(id);
        }

        internal int MaximoId()
        {
            return mProducto.MaximoId();
        }
    }
}
