using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Controladores
{
    public class CPresentacion
    {
        MPresentacion mPresentacion = new MPresentacion();

        //*********************************************************
        public void Insertar(Presentacion presentacion)
        {
            mPresentacion.Insertar(presentacion);
        }
        public void Actualizar(Presentacion presentacion)
        {
            mPresentacion.Actualizar(presentacion);
        }
        public void Eliminar(Presentacion presentacion)
        {
            mPresentacion.Eliminar(presentacion);
        }

        public List<Presentacion> Listado()
        {
            return mPresentacion.Listado();
        }

        public Presentacion ObtenerUna(int id)
        {
            return mPresentacion.ObtenerUno(id);
        }
    }
}
