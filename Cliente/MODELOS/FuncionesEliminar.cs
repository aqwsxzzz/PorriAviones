using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing;


namespace _1.MODELOS
{
    class FuncionesEliminar
    {
        public void mostrarMateriales(DataGridView dgvListaMateriales, string IdModelo)
        {
            Conexion objetoConexion = new Conexion();

            try
            {
                dgvListaMateriales.DataSource = null;
                string query = "select F.Familia, M.Grupo, M.Caracteristica, M.Medidas, M.Tipo, M.Codigo, CM.CantidadxModelo, CM.IdMaterialesModelo, CM.IdAcopio from MaterialesModelo CM join " +
                    "Materiales M on CM.IdMaterial = M. IdMaterial join Familiares F on M.idFamilia = F.IdFamilia where CM.IdModelo ='" + IdModelo + "';";
                SqlDataAdapter adapter = new SqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvListaMateriales.DataSource = dt;
                objetoConexion.cerrarconexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró mostrar registros, error:" + ex.ToString());
            }
        }

        public void DevolverStock(string IdAcopio, string CantidadADevolver)
        {
            Conexion objetoConexion = new Conexion();
            string query = "Update Acopio SET Disponible = Disponible + " + CantidadADevolver + " where IdAcopio ='" + IdAcopio + "';";
            SqlCommand comando = new SqlCommand(query, objetoConexion.establecerConexion());
            SqlDataReader reader = comando.ExecuteReader();

            while(reader.Read())
            { }
            reader.Close();
            objetoConexion.cerrarconexion();
        }

        public void ReducirTotalStock(string IdAcopio, string CantidadAReducir)
        {
            Conexion objetoConexion = new Conexion();
            string query = "Update Acopio SET Cantidad = Cantidad - " + CantidadAReducir + " where IdAcopio ='" + IdAcopio + "';";
            SqlCommand comando = new SqlCommand(query, objetoConexion.establecerConexion());
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            { }
            reader.Close();
            objetoConexion.cerrarconexion();

        }

        public void EliminarModelo(string IdModelo)
        {
            Conexion objetoConexion = new Conexion();
            string query = "Delete from MaterialesModelo where IdModelo ='" + IdModelo + "';";
            SqlCommand comando = new SqlCommand(query, objetoConexion.establecerConexion());
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            { }
            reader.Close();
            objetoConexion.cerrarconexion();

            Conexion objetoConexion2 = new Conexion();
            string query2 = "Delete from Modelos where IdModelo = '" + IdModelo + "';";
            SqlCommand comando2 = new SqlCommand(query2, objetoConexion2.establecerConexion());
            SqlDataReader reader2 = comando2.ExecuteReader();

            while (reader2.Read())
            { }
            reader2.Close();
            objetoConexion2.cerrarconexion();

        }
    }
}
