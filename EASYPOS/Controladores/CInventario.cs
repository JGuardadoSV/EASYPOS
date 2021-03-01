using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Controladores
{
    public class CInventario
    {
        MInventario mInventario = new MInventario();

        //*********************************************************
        public void Insertar(Inventario inventario)
        {
            mInventario.Insertar(inventario);
        }
        public void Actualizar(Inventario inventario)
        {
            mInventario.Actualizar(inventario);
        }
        public void Eliminar(Inventario inventario)
        {
            mInventario.Eliminar(inventario);
        }

        public List<Inventario> Listado()
        {
            return mInventario.Listado();
        }

        public Inventario ObtenerUna(int id)
        {
            return mInventario.ObtenerUno(id);
        }
    }
}
