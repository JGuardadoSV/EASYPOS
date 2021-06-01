using EASYPOS.Entidades;
using EASYPOS.Herramientas;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Modelos
{
    public class MProducto
    {
        readonly IDbConnection cn = Conexion.conectar();


        public void Insertar(Producto producto, int existencias, int idinventario=1)
        {

            string consulta = "insert into Productos values (@NombreProducto,@TieneVariasPresentaciones,@IdCategoria_FK,@IdProveedor_FK,@InformacionAdicional,@PrincipioActivo,@Precio,@Codigo,@Consignacion)";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@NombreProducto", producto.NombreProducto, DbType.String);
            parametros.Add("@TieneVariasPresentaciones", producto.TieneVariasPresentaciones, DbType.Int32);
            parametros.Add("@IdCategoria_FK", producto.IdCategoria_FK, DbType.Int32);
            parametros.Add("@IdProveedor_FK", producto.IdProveedor_FK, DbType.Int32);
            parametros.Add("@InformacionAdicional", producto.InformacionAdicional, DbType.String);
            parametros.Add("@PrincipioActivo", producto.PrincipioActivo, DbType.String);
            parametros.Add("@Precio", producto.Precio, DbType.Decimal);
            parametros.Add("@Codigo", producto.Codigo, DbType.String);
            parametros.Add("@Consignacion", producto.Consignacion, DbType.Int32);
            

            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();


            //registrar en inventario cuando sea una sola sucursal
            consulta = "Select max(IdProducto) id from Productos";
            int id;
            cn.Open();
            id=cn.QuerySingle<int>(consulta,  commandType: CommandType.Text);
            cn.Close();

            MDetallesInventario mDetallesInventario = new MDetallesInventario();
            DetallesInventario det = new DetallesInventario();
            det.Existencias = 0;
            det.IdInventario_FK = idinventario;
            det.IdProducto_FK = id;
            det.Existencias = existencias;
            mDetallesInventario.Insertar(det);

        }
        public void Actualizar(Producto producto)
        {

            string consulta = "Update Productos set NombreProducto=@NombreProducto,TieneVariasPresentaciones=@TieneVariasPresentaciones,IdCategoria_FK=@IdCategoria_FK,IdProveedor_FK=@IdProveedor_FK,InformacionAdicional=@InformacionAdicional,PrincipioActivo=@PrincipioActivo,Precio=@Precio, Codigo=@Codigo,Consignacion=@Consignacion where IdProducto=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@NombreProducto", producto.NombreProducto, DbType.String);
            parametros.Add("@TieneVariasPresentaciones", producto.TieneVariasPresentaciones, DbType.Int32);
            parametros.Add("@IdCategoria_FK", producto.IdCategoria_FK, DbType.Int32);
            parametros.Add("@IdProveedor_FK", producto.IdProveedor_FK, DbType.Int32);
            parametros.Add("@InformacionAdicional", producto.InformacionAdicional, DbType.String);
            parametros.Add("@PrincipioActivo", producto.PrincipioActivo, DbType.String);
            parametros.Add("@Precio", producto.Precio, DbType.Decimal);
            parametros.Add("@id", producto.IdProducto, DbType.Int32);
            parametros.Add("@Codigo", producto.Codigo, DbType.String);
            parametros.Add("@Consignacion", producto.Consignacion, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Eliminar(Producto producto)
        {
            string consulta = "Delete from Productos where IdProducto=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@id", producto.IdProducto, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<Producto> Listado()
        {
            string consulta = "SELECT * FROM Productos";
            List<Producto> listado = new List<Producto>();

            cn.Open();
            listado = cn.Query<Producto>(consulta).ToList();
            cn.Close();
            return listado;
        }

        public Producto ObtenerUno(int id)
        {
            string consulta = "SELECT * FROM Productos where IdProducto=@id";
            DynamicParameters parametros = new DynamicParameters();
            Producto producto = new Producto();

            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            producto = cn.QuerySingle<Producto>(consulta, parametros);
            cn.Close();

            return producto;
        }

        public int MaximoId()
        {
            string consulta = "SELECT max(IdProducto) FROM Productos";
            cn.Open();
            int maximo = cn.QuerySingle<int>(consulta);
            cn.Close();

            return maximo;

        }
    }
}
