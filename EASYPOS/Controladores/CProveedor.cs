using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Controladores
{
    public class CProveedor
    {
        MProveedor mProveedor = new MProveedor();

        //*********************************************************
        public void Insertar(Proveedor proveedor)
        {
            mProveedor.Insertar(proveedor);
        }
        public void Actualizar(Proveedor proveedor)
        {
            mProveedor.Actualizar(proveedor);
        }
        public void Eliminar(Proveedor proveedor)
        {
            mProveedor.Eliminar(proveedor);
        }

        public List<Proveedor> Listado()
        {
            return mProveedor.Listado();
        }

        public Proveedor ObtenerUna(int id)
        {
            return mProveedor.ObtenerUno(id);
        }

    }
}
