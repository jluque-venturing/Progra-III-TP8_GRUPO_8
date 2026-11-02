using System.Data;
using Dao;
using Entidades;


namespace Negocio
{
    public class NegocioSucursal
    {
        public DataTable getTabla()
        {
            DaoSucursal dao = new DaoSucursal();
            return dao.getTablaSucursales();
        }

        public bool eliminarSucursal(int id)
        {
            Sucursal sucursal = new Sucursal();

            sucursal.setIdSucursal(id);

            DaoSucursal dao = new DaoSucursal();

            int filasAfectadas = dao.eliminarSucursal(sucursal);

            if (filasAfectadas == 1)
            {
                return true;

            }

            else
            {

                return false;
            }

        }
        public DataTable getTablaFiltrada(int id)
        {
            Sucursal suc = new Sucursal();
            suc.setIdSucursal(id);

            DaoSucursal dao = new DaoSucursal();

            return dao.getTablaSucursal(suc);
        }
    }
}
