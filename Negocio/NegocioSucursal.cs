using Dao;
using Entidades;


namespace Negocio
{
    public class NegocioSucursal
    {
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

    }
}
