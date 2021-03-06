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
            if (cuota.IdCuota==0)
            {
                return mCuota.Insertar(cuota);
            }
            else
            {
                return mCuota.Actualizar(cuota);
            }
                
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

        public void actualizarCuotasRestantes(int idContrato)
        {
            mCuota.actualizarCuotasRestantes(idContrato);
        }

        public List<Cuotas> ListadoReporte(DateTime f1, DateTime f2)
        {
            return mCuota.ListadoReporte(f1,f2);
        }

        public void EliminarTodas(int idContrato)
        {
            mCuota.EliminarTodas(idContrato);
        }

        public Cuotas CuotaAnterior(int idCuota)
        {
            return mCuota.CuotaAnterior(idCuota);
        }
    }
}
