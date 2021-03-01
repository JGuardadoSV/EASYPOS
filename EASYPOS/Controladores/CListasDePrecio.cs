using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Controladores
{
    public class CListasDePrecio
    {
        MListasDePrecio mListasDePrecio = new MListasDePrecio();

        //*********************************************************
        public void Insertar(ListasDePrecio listasDePrecio)
        {
            mListasDePrecio.Insertar(listasDePrecio);
        }
        public void Actualizar(ListasDePrecio listasDePrecio)
        {
            mListasDePrecio.Actualizar(listasDePrecio);
        }
        public void Eliminar(ListasDePrecio listasDePrecio)
        {
            mListasDePrecio.Eliminar(listasDePrecio);
        }

        public List<ListasDePrecio> Listado()
        {
            return mListasDePrecio.Listado();
        }

        public ListasDePrecio ObtenerUna(int id)
        {
            return mListasDePrecio.ObtenerUno(id);
        }
    }
}
