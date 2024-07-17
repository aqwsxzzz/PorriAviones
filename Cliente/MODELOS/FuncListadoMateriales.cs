using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.MODELOS
{
    class FuncListadoMateriales
    {
        public void mostrarMaterialesxModelo(DataGridView dgvListadoMaterialesLis, string IdModelo, TextBox texTotal)
        {
            Conexion objetoConexion = new Conexion();

            try
            {
                dgvListadoMaterialesLis.DataSource = null;

                string query = "select Fam.Familia, Mat.Grupo, Mat.Caracteristica, Mat.Medidas, Mat.Codigo, MatMod.CantidadxModelo, Mat.Tipo, Mat.IdMaterial, " +
                               "MatMod.IdMaterialesModelo, Acopio.valor ,Acopio.Fabricante" +
                               "from MaterialesModelo MatMod " +
                               "join Materiales Mat on MatMod.IdMaterial = Mat.IdMaterial " +
                               "join Familiares Fam on Mat.idFamilia = Fam.IdFamilia " +
                               "join Acopio on Mat.IdMaterial = Acopio.IdMaterial " +
                               "where MatMod.IdModelo ='" + IdModelo + "';";

                using (SqlConnection connection = objetoConexion.establecerConexion())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvListadoMaterialesLis.DataSource = dt;

                        // Sum the values in the "valor" column
                        decimal total = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            if (row["valor"] != DBNull.Value)
                            {
                                total += (Convert.ToDecimal(row["valor"]) * Convert.ToDecimal(row["CantidadxModelo"]));
                            }
                        }

                        texTotal.Text = total.ToString("N2"); // Format the total as a decimal with two decimal places
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró mostrar registros, error: " + ex.ToString());
            }
        }

        public void mostrarMaterialesxModeloSinTotal(DataGridView dgvListadoMaterialesLis, string IdModelo)
        {
            Conexion objetoConexion = new Conexion();

            try
            {
                dgvListadoMaterialesLis.DataSource = null;

                string query = "select Fam.Familia, Mat.Grupo, Mat.Caracteristica, Mat.Medidas, Mat.Codigo, MatMod.CantidadxModelo, Mat.Tipo, Mat.IdMaterial, " +
                               "MatMod.IdMaterialesModelo " +
                               "from MaterialesModelo MatMod " +
                               "join Materiales Mat on MatMod.IdMaterial = Mat.IdMaterial " +
                               "join Familiares Fam on Mat.idFamilia = Fam.IdFamilia " +
                               "join Acopio A on Mat.IdMaterial = A.IdMaterial " +
                               "where MatMod.IdModelo = '" + IdModelo + "';";

                using (SqlConnection connection = objetoConexion.establecerConexion())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvListadoMaterialesLis.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró mostrar registros, error: " + ex.ToString());
            }
        }

    }
}
