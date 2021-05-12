using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Controladores
{
    public class CDetallesInventario
    {
        MDetallesInventario mDetallesInventario = new MDetallesInventario();

        //*********************************************************
        public void Insertar(DetallesInventario detallesInventario)
        {
            mDetallesInventario.Insertar(detallesInventario);
        }
        public void Actualizar(DetallesInventario detallesInventario)
        {
            mDetallesInventario.Actualizar(detallesInventario);
        }
        public void Eliminar(DetallesInventario detallesInventario)
        {
            mDetallesInventario.Eliminar(detallesInventario);
        }

        public List<DetallesInventario> Listado(int id)
        {
            return mDetallesInventario.Listado(id);
        }

        internal void actualizarExistencias(int idactual, string existencias)
        {
            
            mDetallesInventario.ActualizarExistencias(idactual, existencias);
        }
        /*
public DetallesInventario ObtenerUna(int id)
{
 //  return mDetallesInventario.ObtenerUno(id);
}*/
    }
}
