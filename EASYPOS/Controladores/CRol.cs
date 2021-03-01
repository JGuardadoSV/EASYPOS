using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Controladores
{
    public class CRol
    {
        MRol mRol = new MRol();

        //*********************************************************
        public void Insertar(Rol rol)
        {
            mRol.Insertar(rol);
        }
        public void Actualizar(Rol rol)
        {
            mRol.Actualizar(rol);
        }
        public void Eliminar(Rol rol)
        {
            mRol.Eliminar(rol);
        }

        public List<Rol> Listado()
        {
            return mRol.Listado();
        }

        public Rol ObtenerUna(int id)
        {
            return mRol.ObtenerUno(id);
        }
    }
}
