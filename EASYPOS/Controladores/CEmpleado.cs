using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EASYPOS.Controladores
{
    public class CEmpleado
    {

        MEmpleado mEmpleado = new MEmpleado();

        //*********************************************************
        public void Insertar(Empleado empleado)
        {
            mEmpleado.Insertar(empleado);
        }
        public void Actualizar(Empleado empleado)
        {
            mEmpleado.Actualizar(empleado);
        }
        public void Eliminar(Empleado empleado)
        {
            mEmpleado.Eliminar(empleado);
        }

        public List<Empleado> Listado()
        {
            return mEmpleado.Listado();
        }

        public Empleado ObtenerUna(int id)
        {
            return mEmpleado.ObtenerUno(id);
        }
    }
}
