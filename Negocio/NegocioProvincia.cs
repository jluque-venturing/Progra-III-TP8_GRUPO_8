using System.Data;
using Dao;

namespace Negocio
{
    public class NegocioProvincia
    {
        public DataTable getTabla()
        {
            DaoProvincia dao = new DaoProvincia();
            return dao.getTablaProvincias();
        }
    }
}
