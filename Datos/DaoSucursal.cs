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
    }
}
