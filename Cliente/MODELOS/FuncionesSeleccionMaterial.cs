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
using System;

namespace _1.MODELOS
{
    class FuncionesSeleccionMaterial
    {

        public void mostrarFamilias(ComboBox comboxFamiliasSel)
        {
            Conexion objetoConexion = new Conexion();

            try
            {
                string query = "SELECT Familia FROM Familiares";
                SqlCommand command = new SqlCommand(query, objetoConexion.establecerConexion());

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboxFamiliasSel.Items.Add(reader["Familia"].ToString());
                }
                reader.Close();

                objetoConexion.cerrarconexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró mostrar registros, error:" + ex.ToString());
            }
        }

        public void llenarDGVSeleccionStock(DataGridView dgvSeleccionstockSel, TextBox texFamiliaSel)
        {
            Conexion objetoConexion = new Conexion();
            dgvSeleccionstockSel.Visible = true;
                dgvSeleccionstockSel.DataSource = null;
                string query = "Select IdFamilia from Familiares where Familia ='" + texFamiliaSel.Text + "';";
                SqlCommand command = new SqlCommand(query, objetoConexion.establecerConexion());
                string FamId = null;
                SqlDataReader myreader = command.ExecuteReader();
                while (myreader.Read())
                {
                    FamId = myreader["idFamilia"].ToString();
                }
                objetoConexion.cerrarconexion();
                myreader.Close();

                string query2 = "select F.Familia, M.Grupo, M.Caracteristica, M.Medidas, M.Codigo, M.Tipo, A.Ubicacion, M.Estado, A.Cantidad, A.Fabricante, A.Disponible, A.Valor, A.IdAcopio, M.IdMaterial" +
                    " from Materiales M join Acopio A on M.IdMaterial = A.IdMaterial join Familiares F on M.idFamilia = F.IdFamilia where M.idFamilia ='" + FamId + "';";
                SqlDataAdapter adapter = new SqlDataAdapter(query2, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dt.DefaultView.Sort = "Grupo ASC, Caracteristica ASC, Medidas ASC";
                dgvSeleccionstockSel.DataSource = dt;
                objetoConexion.cerrarconexion();
        }

        public void llenarDGVMaterialesSeleccionados(DataGridView dgvMaterialesSeleccionados, TextBox texFamiliaSel)
        {
            Conexion objetoConexion = new Conexion();
            try
            {
                string query = "Select IdFamilia from Familiares where Familia ='" + texFamiliaSel.Text + "';";
                SqlCommand command = new SqlCommand(query, objetoConexion.establecerConexion());
                string FamId = null;
                SqlDataReader myreader = command.ExecuteReader();
                while (myreader.Read())
                {
                    FamId = myreader["idFamilia"].ToString();
                }
                objetoConexion.cerrarconexion();
                myreader.Close();

                string query2 = "select M.Grupo, M.Caracteristica, M.Medidas, M.Codigo, M.Tipo, A.Fabricante, A.Cantidad, A.IdAcopio" +
                    " from Materiales M join Inter I on M.IdMaterial =  I.MaterialId join Acopio A on I.AcopioId = A.IdAcopio where M.idFamilia ='" + FamId + "';";
                SqlDataAdapter adapter = new SqlDataAdapter(query2, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvMaterialesSeleccionados.DataSource = dt;

                objetoConexion.cerrarconexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró mostrar registros, error:" + ex.ToString());
            }
        }

        public string DisponibleMaterialSeleccion(string idAcopio)
        {
            Conexion objetoConexion = new Conexion();
            string queryDisponible = "SELECT Disponible from Acopio where IdAcopio='" + idAcopio + "'";
            SqlCommand comDisponible = new SqlCommand(queryDisponible, objetoConexion.establecerConexion());
            SqlDataReader newReaderDisponible = comDisponible.ExecuteReader();

            string variable = "";

            while (newReaderDisponible.Read())
            {
                variable = newReaderDisponible["Disponible"].ToString();
            }

            return variable;
        }


    }
}
