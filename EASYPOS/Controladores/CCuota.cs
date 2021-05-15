﻿using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EASYPOS.Controladores
{
    public class CCuota
    {
        MCuota mCuota = new MCuota();

        //*********************************************************
        public int Insertar(Cuotas cuota)
        {
                return mCuota.Insertar(cuota);
        }
        
        public void Eliminar(Cuotas cuota)
        {
            mCuota.Eliminar(cuota);
        }

        public List<Cuotas> Listado(int id)
        {
            return mCuota.Listado(id);
        }

        public Cuotas ObtenerUna(int id)
        {
            return mCuota.ObtenerUno(id);
        }
    }
}