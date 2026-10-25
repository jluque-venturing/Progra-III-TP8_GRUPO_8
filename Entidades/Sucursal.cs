namespace Entidades
{
    public class Sucursal
    {
        private int IdSucursal;
        private string NombreSucursal;
        private string DescripcionSucursal;
        private int IdProvinciaSucursal;
        private string DireccionSucursal;

        public Sucursal()
        {
        }

        public int getIdSucursal()
        {
            return IdSucursal;
        }

        public void setIdSucursal(int valor)
        {
            IdSucursal = valor;
        }

        public string getNombreSucursal()
        {
            return NombreSucursal;
        }

        public void setNombreSucursal(string valor)
        {
            NombreSucursal = valor;
        }

        public string getDescripcionSucursal()
        {
            return DescripcionSucursal;
        }

        public void setDescripcionSucursal(string valor)
        {
            DescripcionSucursal = valor;
        }

        public int getIdProvinciaSucursal()
        {
            return IdProvinciaSucursal;
        }

        public void setIdProvinciaSucursal(int valor)
        {
            IdProvinciaSucursal = valor;
        }

        public string getDireccionSucursal()
        {
            return DireccionSucursal;
        }

        public void setDireccionSucursal(string valor)
        {
            DireccionSucursal = valor;
        }
    }
}