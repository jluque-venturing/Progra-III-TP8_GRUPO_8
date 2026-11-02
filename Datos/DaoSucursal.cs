using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Dao
{
    public class DaoSucursal
    {
        AccesoDatos ds = new AccesoDatos();

        private void ArmarParametrosSucursalEliminar(ref SqlCommand Comando, Sucursal suc)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDSUCURSAL", SqlDbType.Int);
            SqlParametros.Value = suc.getIdSucursal();
        }

        public int eliminarSucursal(Sucursal suc)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosSucursalEliminar(ref comando, suc);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spEliminarSucursal");
        }

        private void ArmarParametrosSucursalAgregar(ref SqlCommand Comando, Sucursal suc)
        {
            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = Comando.Parameters.Add("@NOMBRESUCURSAL", SqlDbType.VarChar);
            SqlParametros.Value = suc.getNombreSucursal();

            SqlParametros = Comando.Parameters.Add("@DESCRIPCIONSUCURSAL", SqlDbType.VarChar);
            SqlParametros.Value = suc.getDescripcionSucursal();

            SqlParametros = Comando.Parameters.Add("@IDPROVINCIASUCURSAL", SqlDbType.Int);
            SqlParametros.Value = suc.getIdProvinciaSucursal();

            SqlParametros = Comando.Parameters.Add("@DIRECCIONSUCURSAL", SqlDbType.VarChar);
            SqlParametros.Value = suc.getDireccionSucursal();
        }

        public int agregarSucursal(Sucursal suc)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosSucursalAgregar(ref comando, suc);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAgregarSucursal");
        }

        public DataTable getTablaSucursales()
        {
            string consulta = "SELECT " +
                "S.Id_Sucursal AS Id_Sucursal, " +
                "S.NombreSucursal AS Nombre, " +
                "S.DescripcionSucursal AS Descripcion, " +
                "P.DescripcionProvincia AS Provincia, " +
                "S.DireccionSucursal AS Direccion " +
                "FROM Sucursal AS S " +
                "INNER JOIN Provincia AS P " +
                "ON S.Id_ProvinciaSucursal = P.Id_Provincia";

            return ds.ObtenerTabla("Sucursal", consulta);
        }

        public DataTable getTablaSucursal(Sucursal suc)
        {
            string consulta = "SELECT " +
                "S.Id_Sucursal AS Id_Sucursal, " +
                "S.NombreSucursal AS Nombre, " +
                "S.DescripcionSucursal AS Descripcion, " +
                "P.DescripcionProvincia AS Provincia, " +
                "S.DireccionSucursal AS Direccion " +
                "FROM Sucursal AS S " +
                "INNER JOIN Provincia AS P " +
                "ON S.Id_ProvinciaSucursal = P.Id_Provincia " +
                "WHERE S.Id_Sucursal = " + suc.getIdSucursal();

            return ds.ObtenerTabla("Sucursal", consulta);
        }
    }
}
