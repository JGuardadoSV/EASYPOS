using EASYPOS.Entidades;
using EASYPOS.Herramientas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace EASYPOS.Modelos
{
    public class MIntereses
    {
        readonly IDbConnection cn = Conexion.conectar();


        public List<intereses> Listado()
        {
            string consulta = "SELECT * FROM Intereses";
            List<intereses> listado = new List<intereses>();

            cn.Open();
            listado = cn.Query<intereses>(consulta).ToList();
            cn.Close();
            return listado;
        }

        
    }
}
