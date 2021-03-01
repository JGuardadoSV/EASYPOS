using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Controladores
{
   public  class CSucursal
    {
        MSucursal mSucursal = new MSucursal();

        //*********************************************************
        public void Insertar(Sucursal sucursal)
        {
            mSucursal.Insertar(sucursal);
        }
        public void Actualizar(Sucursal sucursal)
        {
            mSucursal.Actualizar(sucursal);
        }
        public void Eliminar(Sucursal sucursal)
        {
            mSucursal.Eliminar(sucursal);
        }

        public List<Sucursal> Listado()
        {
            return mSucursal.Listado();
        }

        public Sucursal ObtenerUna(int id)
        {
            return mSucursal.ObtenerUno(id);
        }
    }
}
