using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Controladores
{
    public class CContratos
    {
        MContrato mContratos = new MContrato();


        public int Insertar(Contratos contrato)
        {
            if (contrato.IdContrato==0)
            {
                contrato.Restante = contrato.Financiamiento;
                return mContratos.Insertar(contrato);
            }
            else
            {
                return mContratos.Actualizar(contrato);
            }
            
        }

        public void Actualizar(Contratos contrato)
        {
            mContratos.Actualizar(contrato);
        }

        public Contratos uno(int id)
        {
            return mContratos.uno(id);
        }

        public void Eliminar(Contratos contrato)
        {
            mContratos.Eliminar(contrato);
        }

        public List<Contratos> ParaEsteMes()
        {
            return mContratos.ParaEsteMes();
        }

        public List<Contratos> Listado(Boolean cotizaciones)
        {
            return mContratos.Listado(cotizaciones);
        }

        public List<Contratos> Atrasados()
        {
            return mContratos.Atrasados();
        }

        public List<Contratos> Busqueda(string cliente, Boolean atrasados)
        {
            return mContratos.Busqueda(cliente,atrasados);
        }

        internal void ActualizarRestante(Contratos contrato)
        {
            mContratos.ActualizarRestante(contrato);
        }

        internal void ActualizarRestanteBorrado(Contratos contrato)
        {
            mContratos.ActualizarRestanteBorrado(contrato);
        }
    }
}
