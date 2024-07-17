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
    public class FuncionesListadoCompras
    {
        public void mostrarMateriales(DataGridView tablaMateriales)
        {
            Conexion objetoConexion = new Conexion();
            try
            {
                tablaMateriales.DataSource = null;

                SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT F.Familia, M.Grupo, M.Caracteristica, M.Medidas, M.Codigo, " +
                    "A.Disponible, M.Tipo, A.Ubicacion, M.Estado, A.Fabricante, A.Cantidad, A.Valor, M.IdMaterial " +
                    "FROM Familiares F " +
                    "INNER JOIN Materiales M ON F.IdFamilia = M.idFamilia " +
                    "INNER JOIN Acopio A ON M.IdMaterial = A.IdMaterial;",
                    objetoConexion.establecerConexion()
                );

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dt.DefaultView.Sort = "Familia ASC, Grupo ASC, Caracteristica ASC";
                tablaMateriales.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró mostrar registros, error: " + ex.ToString());
            }
            finally
            {
                objetoConexion.cerrarconexion();
            }
        }
        public void mostrarMaterialesStockBajo(DataGridView tablaMateriales)
        {
            Conexion objetoConexion = new Conexion();
            try
            {
                tablaMateriales.DataSource = null;

                SqlDataAdapter adapter = new SqlDataAdapter
            (

                "SELECT F.Familia, M.Grupo, M.Caracteristica, M.Medidas, M.Codigo, " +
                "A.Disponible, M.Tipo, A.Ubicacion, M.Estado, A.Fabricante, A.Cantidad, A.Valor, M.IdMaterial " +
                "FROM Familiares F " +
                "INNER JOIN Materiales M ON F.IdFamilia = M.idFamilia " +
                "INNER JOIN Acopio A ON M.IdMaterial = A.IdMaterial " +
                "WHERE A.Disponible < 2 AND F.Familia <> 'Aeronaves';",

                objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dt.DefaultView.Sort = "Familia ASC, Grupo ASC, Caracteristica ASC";
                tablaMateriales.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró mostrar registros, error: " + ex.ToString());
            }
            finally
            {
                objetoConexion.cerrarconexion();
            }
        }
    }
}
