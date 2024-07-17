using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;


namespace _1.Insumos
{
   public class Stock
    {

        public void mostrarFamilia(ListBox listBox)
        {
            Conexion objetoConexion = new Conexion();
            listBox .Items.Clear();
          //  comBox.Items.Clear();
            try
            {
                string query = "SELECT Familia FROM Familiares";
                SqlCommand command = new SqlCommand(query, objetoConexion.establecerConexion());

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listBox.Items.Add(reader["Familia"].ToString());
                    //comBox.Items.Add(reader["Familia"].ToString());
                }
                reader.Close();

                objetoConexion.cerrarconexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró mostrar registros, error:" + ex.ToString());
            }
        }

        public void GuardarFamilia(TextBox paraFam)
        {
            Conexion objetoConexion = new Conexion();
            try
            {
                string queryNuevaFam = "INSERT into Familiares (Familia) values ('" + paraFam.Text + "')";
                SqlCommand myComando = new SqlCommand(queryNuevaFam, objetoConexion.establecerConexion());
                SqlDataReader myReader;
                myReader = myComando.ExecuteReader();

                while (myReader.Read())
                {

                }
                objetoConexion.cerrarconexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró mostrar registros, error:" + ex.ToString());
            }
        }

        public void mostrarMateriales(DataGridView tablaMateriales)
        {
            Conexion objetoConexion = new Conexion();
            try
            {
                tablaMateriales.DataSource = null;
                SqlDataAdapter adapter = new SqlDataAdapter("select F.Familia ,M.Grupo ,M.Caracteristica ,M.Medidas ,M.Codigo , A.Disponible ,M.Tipo ,A.Ubicacion, M.Estado ,A.Fabricante " +
                ",A.Cantidad ,A.Valor, M.IdMaterial from Familiares F Inner Join Materiales M on F.IdFamilia =M.idFamilia Inner join Acopio A on M.IdMaterial = A.IdMaterial ;" +
                " ", objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dt.Columns.Add("SortOrder", typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    if (row["Grupo"].ToString() == "Helice")
                    {
                        row["SortOrder"] = row["Medidas"].ToString();
                    }
                    else
                    {
                        row["SortOrder"] = row["Caracteristica"].ToString();
                    }
                }


                dt.DefaultView.Sort = "Familia ASC, Grupo ASC, SortOrder ASC";
                tablaMateriales.DataSource = dt;
                objetoConexion.cerrarconexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró mostrar registros, error:" + ex.ToString());
            }
        }

        public void SeleccionaMateriales(DataGridView tablaMateriales, TextBox paraId, TextBox paraFamilia,
          TextBox paraGrupo, TextBox paraCaracteristica, TextBox paraMedidas, TextBox paraCodigo, TextBox paraTipo, PictureBox paraFoto)
        {
            try
            {
                paraId.Text = tablaMateriales.CurrentRow.Cells[0].Value.ToString();
                paraFamilia.Text = tablaMateriales.CurrentRow.Cells[1].Value.ToString();
                paraGrupo.Text = tablaMateriales.CurrentRow.Cells[2].Value.ToString();
                paraCaracteristica.Text = tablaMateriales.CurrentRow.Cells[3].Value.ToString();
                paraMedidas.Text = tablaMateriales.CurrentRow.Cells[4].Value.ToString();
                paraCodigo.Text = tablaMateriales.CurrentRow.Cells[5].Value.ToString();
                paraTipo.Text = tablaMateriales.CurrentRow.Cells[6].Value.ToString();

                if (tablaMateriales.CurrentRow.Cells[7].Value.ToString() != "")
                {

                    byte[] imageBytes = (byte[])tablaMateriales.CurrentRow.Cells[7].Value;

                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        paraFoto.Visible = true;
                        Image image = Image.FromStream(ms);
                        paraFoto.Image = image;
                    }
                }
                else
                {
                    paraFoto.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se logró seleccionar los registros, error:" + ex.ToString());
            }
        }

        public void ModificaMateriales(TextBox paraId, TextBox paraFamilia, TextBox paraGrupo,
                TextBox paraCaracteristica, TextBox paraMedidas, TextBox paraCodigo, TextBox paraTipo)
        {
            {
                Conexion objetoConexion = new Conexion();
                try
                {
                    string Query = "UPDATE Materiales SET Materiales.Familia='" +
                     paraFamilia.Text + "', Materiales.Grupo='" + paraGrupo.Text + "', Materiales.Caracteristica='"
                     + paraCaracteristica.Text + "', Materiales.Medidas='" + paraMedidas.Text + "', Materiales.Codigo ='"
                     + paraCodigo.Text + "', Materiales.Tipo ='" + paraTipo.Text + "' WHERE Materiales.IdMaterial= '" + paraId.Text + "';";

                    SqlCommand myComando = new SqlCommand(Query, objetoConexion.establecerConexion());
                    SqlDataReader myReader = myComando.ExecuteReader();

                    while (myReader.Read())
                    {

                    }
                    objetoConexion.cerrarconexion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se logró mostrar registros, error:" + ex.ToString());
                }
            }
        }

        public void guardarMateriales(TextBox paraFamilia, TextBox paraGrupo, TextBox paraCaracteristica, TextBox paraMedidas,
            TextBox paraCodigo, TextBox paraTipo, TextBox paraUbicacion, TextBox paraFabricante, TextBox paraCantidad,
            TextBox paraValor, TextBox paraEstado, byte[] paraImagen)
        {
            {
                Conexion objetoConexion = new Conexion();
                string query = "SELECT IdFamilia from Familiares where Familia ='" + paraFamilia.Text + "';";
                SqlCommand comando = new SqlCommand(query, objetoConexion.establecerConexion());
                SqlDataReader reader = comando.ExecuteReader();
                string IdFamilia = "";
                while (reader.Read())
                {
                    IdFamilia = reader["IdFamilia"].ToString();
                }
                reader.Close();
                objetoConexion.cerrarconexion();

                string query2;
                if (paraImagen != null)
                {
                    query2 = "insert into Materiales (idFamilia, Grupo, Caracteristica, Medidas, Codigo, Tipo, Estado, ImageData) values (@idFamilia, @Grupo, @Caracteristica, @Medidas, @Codigo, @Tipo, @Estado, @ImageData);";
                } else
                {
                    query2 = "insert into Materiales (idFamilia, Grupo, Caracteristica, Medidas, Codigo, Tipo, Estado) values (@idFamilia, @Grupo, @Caracteristica, @Medidas, @Codigo, @Tipo, @Estado);";
                }

                using (SqlCommand elComando = new SqlCommand(query2, objetoConexion.establecerConexion()))
                {
                    elComando.Parameters.AddWithValue("@idFamilia", IdFamilia);
                    elComando.Parameters.AddWithValue("@Grupo", paraGrupo.Text);
                    elComando.Parameters.AddWithValue("@Caracteristica", paraCaracteristica.Text);
                    elComando.Parameters.AddWithValue("@Medidas", paraMedidas.Text);
                    elComando.Parameters.AddWithValue("@Codigo", paraCodigo.Text);
                    elComando.Parameters.AddWithValue("@Tipo", paraTipo.Text);
                    elComando.Parameters.AddWithValue("@Estado", paraEstado.Text);

                    if (paraImagen != null)
                    {
                        elComando.Parameters.AddWithValue("@ImageData", paraImagen);
                    }
                    SqlDataReader tworeader = elComando.ExecuteReader();

                    while (tworeader.Read())
                    {
                    }
                    tworeader.Close();
                }

                objetoConexion.cerrarconexion();

                string query3 = "SELECT MAX(IdMaterial) FROM Materiales";
                SqlCommand comando2 = new SqlCommand(query3, objetoConexion.establecerConexion());
                SqlDataReader reader2 = comando2.ExecuteReader();
                string IdMaterial = "";
                while (reader2.Read())
                {
                    IdMaterial = reader2[0].ToString();
                }
                reader2.Close();
                objetoConexion.cerrarconexion();

                string query4 = "insert into Acopio (IdMaterial, Ubicacion, Fabricante, Cantidad, Valor, Disponible) values ('" + IdMaterial + "','" + paraUbicacion.Text + "','" + paraFabricante.Text + "','"
                    + paraCantidad.Text + "','" + paraValor.Text + "','" + paraCantidad.Text + "');";
                SqlCommand comando3 = new SqlCommand(query4, objetoConexion.establecerConexion());
                SqlDataReader reader3 = comando3.ExecuteReader();
                while (reader3.Read())
                {
                }
                reader3.Close();
                objetoConexion.cerrarconexion();

            }
        }

        public void MaterialesEnExistencia(DataGridView dgvMaterialesEnExistencia, string nombreFamilia)
        {
            Conexion objetoConexion = new Conexion();

            string query = "SELECT IdFamilia from Familiares where Familia ='" + nombreFamilia + "';";
            SqlCommand comando = new SqlCommand(query, objetoConexion.establecerConexion());
            SqlDataReader reader = comando.ExecuteReader();
            string IdFamilia = "";
            while (reader.Read())
            {
                IdFamilia = reader["IdFamilia"].ToString();
            }
            reader.Close();
            objetoConexion.cerrarconexion();

            dgvMaterialesEnExistencia.DataSource = null;
            string query2 = "SELECT M.Grupo, M.Caracteristica, M.Medidas, M.Codigo, A.Fabricante, M.Estado, A.Ubicacion, A.Cantidad, M.Tipo, A.Valor, " +
                "A.IdAcopio from Materiales M join Acopio A on M.IdMaterial = A.IdMaterial where M.idFamilia ='"
                + IdFamilia + "';";
            SqlDataAdapter adapter = new SqlDataAdapter(query2, objetoConexion.establecerConexion());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dt.DefaultView.Sort = "Grupo ASC, Caracteristica ASC";
            dgvMaterialesEnExistencia.DataSource = dt;
            objetoConexion.cerrarconexion();

        }

        public void BuscarFotoPorIdMaterial(string IdMaterial, PictureBox picBox)
        {
            Conexion objetoConexion = new Conexion();
            object bytesDeImagenDesdeBD;
            byte[] bytesDeImagen;
            Image imagen;
            string query = "select ImageData from Materiales where IdMaterial='" + IdMaterial + "';";
            SqlCommand comando = new SqlCommand(query, objetoConexion.establecerConexion());
            SqlDataReader newReader = comando.ExecuteReader();
            Image ConvertirBytesAImagen(byte[] bytesDI)
            {
                using (MemoryStream ms = new MemoryStream(bytesDI))
                {
                    return Image.FromStream(ms);
                }
            }

            while (newReader.Read())
            {
                if (newReader["ImageData"].ToString() != "")
                {

                    bytesDeImagenDesdeBD = newReader["ImageData"];
                    bytesDeImagen = (byte[])bytesDeImagenDesdeBD;
                    imagen = ConvertirBytesAImagen(bytesDeImagen);
                    picBox.Image = imagen;
                }
                else picBox.Image = null;
            }
        }

        public void ModificarMaterial(string MaterialId, string[] ListaNombreColumnasAcopio, string[] ListaNuevoValorAcopio, string[] ListaNombreColumnasMats, string[] ListaNuevoValorMats, string disponible, byte[] paraImagen)
        {
            Conexion objetoConexion = new Conexion();
            string datosMateriales = "";
            string datosAcopio = "";

            if (ListaNombreColumnasAcopio.Count() > 0)
            {
                for (int i = 0; i < ListaNombreColumnasAcopio.Count(); i++)
                {
                    if (i == (ListaNombreColumnasAcopio.Length -1)) {
                        datosAcopio += ListaNombreColumnasAcopio[i] + " = '" + ListaNuevoValorAcopio[i] + "'";
                     } else
                    {
                        datosAcopio += ListaNombreColumnasAcopio[i] + " = '" + ListaNuevoValorAcopio[i] + "',";
                    }
                }
            }

            if (ListaNombreColumnasMats.Count() > 0)
            {
                for (int i = 0; i < ListaNombreColumnasMats.Count(); i++)
                {
                    if (i == (ListaNombreColumnasMats.Length - 1))
                    {
                        datosMateriales += ListaNombreColumnasMats[i] + " = '" + ListaNuevoValorMats[i] + "'";
                    }
                    else
                    {
                        datosMateriales += ListaNombreColumnasMats[i] + " = '" + ListaNuevoValorMats[i] + "',";
                    }
                }
            }

            if (datosMateriales != "")
                {
                    string queryMateriales = "Update Materiales SET " + datosMateriales + " where IdMaterial = '" + MaterialId + "';";

                    SqlCommand updateCommand = new SqlCommand(queryMateriales, objetoConexion.establecerConexion());
                    SqlDataReader ModificacionReader = updateCommand.ExecuteReader();

                    while (ModificacionReader.Read())
                    {

                    }
                    ModificacionReader.Close();
                    objetoConexion.cerrarconexion();

                }
                if (datosAcopio != "")
                {
                    string queryAcopio = "Update Acopio SET " + datosAcopio + " where IdMaterial = '" + MaterialId + "';";
                    SqlCommand updateCommand = new SqlCommand(queryAcopio, objetoConexion.establecerConexion());
                    SqlDataReader ModificacionReader = updateCommand.ExecuteReader();

                    while (ModificacionReader.Read())
                    {

                    }
                    ModificacionReader.Close();
                    objetoConexion.cerrarconexion();

                }
            for (int i = 0; i < ListaNombreColumnasAcopio.Count(); i++) {
                if(ListaNombreColumnasAcopio[i] == "Cantidad")
                {
                    if(disponible != "")
                    {
                        string queryDisponible = "update acopio set disponible += '" + disponible + "' where IdMaterial = '" + MaterialId + "';";
                        SqlCommand updateDisponible = new SqlCommand(queryDisponible, objetoConexion.establecerConexion());
                        SqlDataReader disponibleReader = updateDisponible.ExecuteReader();

                        while (disponibleReader.Read())
                        {

                        }
                        disponibleReader.Close();
                        objetoConexion.cerrarconexion();
                    }
                }
            }
            if (paraImagen != null)
            {
                Conexion objetoConexion2 = new Conexion();
                string queryImagen = "UPDATE Materiales SET ImageData = @ImageData WHERE IdMaterial = '" + MaterialId + "';";
                using (SqlCommand elComando = new SqlCommand(queryImagen, objetoConexion2.establecerConexion()))
                {
                    elComando.Parameters.AddWithValue("@ImageData", paraImagen);
                    SqlDataReader tworeader = elComando.ExecuteReader();

                    while (tworeader.Read())
                    {
                    }
                    tworeader.Close();
                }
                objetoConexion2.cerrarconexion();
            }

        }

        public void EliminarMaterial(string IdMaterial)
        {
            Conexion objetoConexion = new Conexion();
            string query = "DELETE from Materiales WHERE IdMAterial ='" + IdMaterial + "';";
            SqlCommand myComando = new SqlCommand(query, objetoConexion.establecerConexion());
            SqlDataReader myReader =  myComando.ExecuteReader();

            while (myReader.Read())
            {

            }
            objetoConexion.cerrarconexion();

        }

    }
}
