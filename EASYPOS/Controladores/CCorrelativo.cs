using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Controladores
{
    public class CCorrelativo
    {
        MCorrelativo mCorrelativo = new MCorrelativo();

        //*********************************************************
        public void Insertar(Correlativo correlativo)
        {
            mCorrelativo.Insertar(correlativo);
        }
        public void Actualizar(Correlativo correlativo)
        {
            mCorrelativo.Actualizar(correlativo);
        }
        public void Eliminar(Correlativo correlativo)
        {
            mCorrelativo.Eliminar(correlativo);
        }

        public List<Correlativo> Listado()
        {
            return mCorrelativo.Listado();
        }

        public Correlativo ObtenerUna(int id)
        {
            return mCorrelativo.ObtenerUno(id);
        }
    }
}
