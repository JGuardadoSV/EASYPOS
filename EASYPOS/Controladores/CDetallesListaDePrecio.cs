using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Controladores
{
    public class CDetallesListaDePrecio
    {
        MDetallesListaDePrecio mDetallesListaDePrecio = new MDetallesListaDePrecio();

        //*********************************************************
        public void Insertar(DetallesListaDePrecio detallesListaDePrecio)
        {
            mDetallesListaDePrecio.Insertar(detallesListaDePrecio);
        }
        public void Actualizar(DetallesListaDePrecio detallesListaDePrecio)
        {
            mDetallesListaDePrecio.Actualizar(detallesListaDePrecio);
        }
        public void Eliminar(DetallesListaDePrecio detallesListaDePrecio)
        {
            mDetallesListaDePrecio.Eliminar(detallesListaDePrecio);
        }

        public List<DetallesListaDePrecio> Listado()
        {
            return mDetallesListaDePrecio.Listado();
        }

        public DetallesListaDePrecio ObtenerUna(int id)
        {
            return mDetallesListaDePrecio.ObtenerUno(id);
        }
    }
}
