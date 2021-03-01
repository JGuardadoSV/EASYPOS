using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Controladores
{
    public class CCategoria
    {
        MCategoria mCategoria = new MCategoria();

        //*********************************************************
        public void Insertar(Categoria categoria) {
            mCategoria.Insertar(categoria);
        }
        public void Actualizar(Categoria categoria) {
            mCategoria.Actualizar(categoria);
        }
        public void Eliminar(Categoria categoria) {
            mCategoria.Eliminar(categoria);
        }

        public List<Categoria> Listado()
        {
            return mCategoria.Listado();
        }

        public Categoria ObtenerUna(int id)
        {
            return mCategoria.ObtenerUna(id);
        }

    }
}
