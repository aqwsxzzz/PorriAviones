using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.COMPRAS
{
    class Adquicisiones
    {
        public void mostrarCompras(DataGridView tablaCompras)
        {
            Conexion objetoConexion = new Conexion();

            try
            {
                tablaCompras.DataSource = null;
                SqlDataAdapter adapter = new SqlDataAdapter("Select Fa.Familia ,Ma.Grupo , Ma.Caracteristica," +
                    " Ma.Medidas, Ma.Codigo,Ma.Tipo , Ac.Fabricante,Co.Proveedor ,Co.Fechacompra ,Co.Cantidadcomprada ," +
                    "Co.Valorcompra  from Familiares Fa inner Join Materiales Ma on Fa.IdFamilia =Ma.idFamilia" +
                    " Inner Join Acopio Ac on Ma.IdMaterial =Ac.IdMaterial Inner Join Inter En on Ma.IdMaterial =" +
                    " En.MaterialId Inner Join Compras Co on Co.IdCompras = En.ComprasId; " + " ", objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaCompras.DataSource = dt;
                objetoConexion.cerrarconexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró mostrar registros, error:" + ex.ToString());
            }
            objetoConexion.cerrarconexion();
        }

        public void MostrarFamiliaCo(ComboBox comBox)
        {
            Conexion objetoConexion = new Conexion();

            try
            {
                string query = "SELECT Familia FROM Familiares";
                SqlCommand command = new SqlCommand(query, objetoConexion.establecerConexion());

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comBox.Items.Add(reader["Familia"].ToString());
                }
                reader.Close();

                objetoConexion.cerrarconexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró mostrar registros, error:" + ex.ToString());
            }
        }

        public void mostrarGrupo(ComboBox comBox, string nombreFamilia)
        {
            Conexion objetoConexion = new Conexion();
            comBox.Items.Clear();

            try
            {
                string idFamiliaSearch = "SELECT idFamilia from Familiares where Familia='" + nombreFamilia + "'";
                SqlCommand cmd = new SqlCommand(idFamiliaSearch, objetoConexion.establecerConexion());
                SqlDataReader myreader = cmd.ExecuteReader();
                string idFamiliaStr = null;
                while(myreader.Read())
                {
                    idFamiliaStr = myreader["idFamilia"].ToString();
                }
                objetoConexion.cerrarconexion();
                myreader.Close();

                string query = "SELECT Grupo FROM Materiales Where idFamilia ='" + idFamiliaStr + "'";
                SqlCommand command = new SqlCommand(query, objetoConexion.establecerConexion());

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comBox.Items.Add(reader["Grupo"].ToString());
                }
                reader.Close();

                objetoConexion.cerrarconexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró mostrar registros, error:" + ex.ToString());
            }
        }

        public void mostrarCaracteris(ComboBox combo, string nombreFamilia)
        {
            Conexion objetoConexion = new Conexion();
            combo.Items.Clear();

            try
            {
                string idFamiliaSearch = "SELECT idFamilia from Familiares where Familia='" + nombreFamilia + "'";
                SqlCommand cmd = new SqlCommand(idFamiliaSearch, objetoConexion.establecerConexion());
                SqlDataReader myreader = cmd.ExecuteReader();
                string idFamiliaStr = null;
                while (myreader.Read())
                {
                    idFamiliaStr = myreader["idFamilia"].ToString();
                }
                objetoConexion.cerrarconexion();
                myreader.Close();

                string query = "SELECT Caracteristica FROM Materiales Where idFamilia ='" + idFamiliaStr + "'";
                SqlCommand command = new SqlCommand(query, objetoConexion.establecerConexion());

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    combo.Items.Add(reader["Caracteristica"].ToString());
                }
                reader.Close();

                objetoConexion.cerrarconexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró mostrar registros, error:" + ex.ToString());
            }
        }

        /*public void Cargar_datos()
            {
                Conexion objetoConexion = new Conexion();
                SqlCommand cmd = new SqlCommand("Select IdFamilia,Familia from Familiares", objetoConexion.establecerConexion());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                

                comboxFamiliaCom.ValueMember = "IdFamilia";
                comboxFamiliaCom.DisplayMember = "familia";
                comboxFamiliaCom.DataSource = dt;
            
                objetoConexion.cerrarconexion();
            }
    
        public void carga_grupo(string IdFamilia)
        {
                Conexion objetoConexion = new Conexion();
                SqlCommand cmd = new SqlCommand("Select IdFamilia,Grupo from Materiales where IdFamilia=@IdFamilia", objetoConexion.establecerConexion());
                cmd.Parameters.AddWithValue("IdFamilia", IdFamilia);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboxGrupoCom.ValueMember = "IdFamilia";
                comboxGrupoCom.DisplayMember = "Nombre";
                comboxGrupoCom.DataSource = dt;

                objetoConexion.cerrarconexion();
        }

        public void carga_caracteris(string IdFamilia)
        {
                Conexion objetoConexion = new Conexion();
                SqlCommand cmd = new SqlCommand("Select IdFamilia,Caracteristica from Materiales where IdFamilia=@IdFamilia", objetoConexion.establecerConexion());
                cmd.Parameters.AddWithValue("IdFamilia", IdFamilia);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboxCaracterisCom.ValueMember = "IdFamilia";
                comboxCaracterisCom.DisplayMember = "Nombre";
                comboxCaracterisCom.DataSource = dt;

                objetoConexion.cerrarconexion();
        }*/
    }
}
