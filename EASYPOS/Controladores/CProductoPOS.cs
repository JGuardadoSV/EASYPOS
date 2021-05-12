using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Controladores
{
   public  class CProductoPOS
    {
        MProductoPOS mProductoPOS = new MProductoPOS();

        //*********************************************************
       
        public List<ProductoPOS> Listado(int id)
        {
            return mProductoPOS.Listado(id);
        }

        public ProductoPOS ObtenerUna(int id)
        {
            return mProductoPOS.ObtenerUno(id);
        }
    }
}
