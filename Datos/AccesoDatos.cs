using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dao
{
    internal class AccesoDatos
    {
        private string RutaBD = @"Data Source=localhost\sqlexpress;Initial Catalog=BDSucursales;Integrated Security=True";

        public SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(RutaBD);

            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public SqlDataAdapter ObtenerAdaptador(string consultaSql, SqlConnection cn)
        {
            SqlDataAdapter adaptador;

            try
            {
                adaptador = new SqlDataAdapter(consultaSql, cn);
                return adaptador;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable ObtenerTabla(string NombreTabla, string Sql)
        {
            DataSet ds = new DataSet();

            SqlConnection cn = ObtenerConexion();

            SqlDataAdapter ad = ObtenerAdaptador(Sql, cn);

            ad.Fill(ds, NombreTabla);

            cn.Close();

            return ds.Tables[NombreTabla];
        }

        public int EjecutarProcedimientoAlmacenado(SqlCommand Comando, string NombreSP)
        {
            SqlConnection cn = ObtenerConexion();

            int FilasAfectadas;

            Comando.Connection = cn;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = NombreSP;

            FilasAfectadas = Comando.ExecuteNonQuery();

            cn.Close();

            return FilasAfectadas;
        }

    }
}
