using EASYPOS.Entidades;
using EASYPOS.Modelos;
using System;

namespace EASYPOS
{
    public class CConfiguracion
    {
        MConfiguracion mConfiguracion = new MConfiguracion();
        public Configuracion ObtenerConfiguracion()
        {

            return mConfiguracion.ObtenerUna();
        }

        public  Configuracion Autenticacion(string usuario, string clave)
        {
            return mConfiguracion.Autenticacion(usuario,clave);
        }

        public void Guardar(Configuracion config)
        {
            mConfiguracion.Guardar(config);
        }
    }
}