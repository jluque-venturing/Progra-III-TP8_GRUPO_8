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
    }
}
