using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1
{
    class Conexion
    {
        SqlConnection con = new SqlConnection();
        string Cadenaconexion = "Data Source=localhost;user id=sa;password=828;" +
            "Initial Catalog=Aviones;Persist Security Info=True";

        public SqlConnection establecerConexion()
        {
            try
            {
                con.ConnectionString = Cadenaconexion;
                con.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No conectado, error:" + ex.ToString());
            }
            return con;
        }
        public void cerrarconexion()
        {
            con.Close();
        }
    }
}
