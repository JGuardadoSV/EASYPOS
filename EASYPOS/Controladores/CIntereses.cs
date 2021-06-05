using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Controladores
{
    public class CIntereses
    {
        MIntereses mIntereses = new MIntereses();

        //*********************************************************
        public List<intereses> Obtener()
        {
                return mIntereses.Listado();

        }
       
    }
}
