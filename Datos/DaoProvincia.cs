using System.Data;

namespace Dao
{
    public class DaoProvincia
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaProvincias()
        {
            return ds.ObtenerTabla("Provincia", "SELECT Id_Provincia, DescripcionProvincia FROM Provincia");
        }
    }
}
