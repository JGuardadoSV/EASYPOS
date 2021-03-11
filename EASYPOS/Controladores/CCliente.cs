using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Controladores
{
    public class CCliente
    {

        MCliente mCliente = new MCliente();

        //*********************************************************
        public void Insertar(Cliente cliente)
        {
            if (cliente.IdCliente==0)
            {
                mCliente.Insertar(cliente);
            }
            else{
                this.Actualizar(cliente);
            }
            
        }
        public void Actualizar(Cliente cliente)
        {
            mCliente.Actualizar(cliente);
        }
        public void Eliminar(Cliente cliente)
        {
            mCliente.Eliminar(cliente);
        }

        public List<Cliente> Listado()
        {
            return mCliente.Listado();
        }

        public Cliente ObtenerUna(int id)
        {
            return mCliente.ObtenerUno(id);
        }
    }
}
