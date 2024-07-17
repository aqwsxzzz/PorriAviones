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

namespace _1.Modelos
{
    class Aeronaves
    {
        public void mostrarModelos(DataGridView tablaModelos)
        {
            Conexion objetoConexion = new Conexion();

            try
            {
                tablaModelos.DataSource = null;
                string query = "select IdModelo, Modelo, Alias, Estado, Desde from Modelos";
                SqlDataAdapter adapter = new SqlDataAdapter( query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dt.DefaultView.Sort = "Modelo ASC";
                tablaModelos.DataSource = dt;
                objetoConexion.cerrarconexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró mostrar registros, error:" + ex.ToString());
            }
        }
        public void mostrarMotores(DataGridView tablaMotores)
        {
            Conexion objetoConexion = new Conexion();

            try
            {
                tablaMotores.DataSource = null;
                SqlDataAdapter adapter = new SqlDataAdapter("select A.Fabricante , M.Grupo ,M.Caracteristica ," +
                    "M.Medidas, M.IdMaterial, A.IdAcopio  from Familiares F inner join Materiales M on F.IdFamilia =M.idFamilia" +
                    " inner join acopio A on m.IdMaterial = a.IdMaterial  where F.Familia = 'Motores' ; " + " "
                    , objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaMotores.DataSource = dt;
                objetoConexion.cerrarconexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró mostrar registros, error:" + ex.ToString());
            }
        }

        public void GuardarModelos(TextBox paraModelo, TextBox paraAlias, TextBox paraEstado, TextBox paraDesde, byte[] paraImagen, string[] acopiosArray, string[] cantidadArray, string[] cantidadDisponibleActualizada)
        {
           Conexion objetoConexion = new Conexion();
            string Query;
            if (paraImagen != null)
            {
            Query = "insert into Modelos (Modelo,Alias, Estado, Desde, Foto)  values  (@Modelo,@Alias, @Estado, @Desde, @Foto);";

            } else
            {
                Query = "insert into Modelos (Modelo,Alias, Estado, Desde)  values  (@Modelo,@Alias, @Estado, @Desde);";
            } 

            using (SqlCommand elComando = new SqlCommand(Query, objetoConexion.establecerConexion())) {
            elComando.Parameters.AddWithValue("@Modelo", paraModelo.Text);
            elComando.Parameters.AddWithValue("@Alias", paraAlias.Text);
            elComando.Parameters.AddWithValue("@Estado", paraEstado.Text);
            elComando.Parameters.AddWithValue("@Desde", paraDesde.Text);
                if (paraImagen != null)
                {
            elComando.Parameters.AddWithValue("@Foto", paraImagen);
                }
                SqlDataReader tworeader = elComando.ExecuteReader();

            while (tworeader.Read())
            {
            }
            tworeader.Close();
            }
            
            objetoConexion.cerrarconexion();

            string queryIdModelo = "SELECT idModelo FROM Modelos WHERE idModelo = (SELECT MAX(idModelo) FROM Modelos)";
            SqlCommand com = new SqlCommand(queryIdModelo, objetoConexion.establecerConexion());
            string ModId = null;
            SqlDataReader myreader = com.ExecuteReader();
            while (myreader.Read())
            {
                ModId = myreader["idModelo"].ToString();
            }
            objetoConexion.cerrarconexion();
            myreader.Close();

            for (int i = 0; i < acopiosArray.Length; i++)
            {
                string cantidadxModelo = cantidadArray[i];
                string queryMaterialId = "select IdMaterial from Acopio where IdAcopio = '" + acopiosArray[i] + "';";
                SqlCommand comandoMaterial = new SqlCommand(queryMaterialId, objetoConexion.establecerConexion());
                string MatId = null;
                SqlDataReader myreaderMatId = comandoMaterial.ExecuteReader();
                while (myreaderMatId.Read())
                {
                   MatId = myreaderMatId["IdMaterial"].ToString();
                }
                objetoConexion.cerrarconexion();
                myreaderMatId.Close();

                string queryInter = "insert into MaterialesModelo ( IdModelo, IdAcopio, IdMaterial, CantidadxModelo) values ('" + ModId + "','" + acopiosArray[i] + "','" + MatId + "','" + cantidadArray[i] +  "');";
                SqlCommand cmdInter = new SqlCommand(queryInter, objetoConexion.establecerConexion());
                SqlDataReader myReaderInter;
                myReaderInter = cmdInter.ExecuteReader();

                while (myReaderInter.Read())
                {

                }
                myReaderInter.Close();
                objetoConexion.cerrarconexion();

                string queryActualizacionDisponible = "update Acopio set Disponible = '" + cantidadDisponibleActualizada[i] + "' where IdAcopio ='" + acopiosArray[i] + "';";
                SqlCommand cmdDispobible = new SqlCommand(queryActualizacionDisponible, objetoConexion.establecerConexion());
                SqlDataReader myReaderDisponible;
                myReaderDisponible = cmdDispobible.ExecuteReader();

                while (myReaderDisponible.Read())
                {

                }
                myReaderDisponible.Close();
                objetoConexion.cerrarconexion();
            }


        }

        public void BuscarFotoPorIdModelo(string IdModelo, PictureBox picBox)
        {
            Conexion objetoConexion = new Conexion();
            object bytesDeImagenDesdeBD;
            byte[] bytesDeImagen;
            Image imagen;
            string query = "select Foto from Modelos where IdModelo='" + IdModelo + "';";
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
                if (newReader["Foto"].ToString() != "")
                {

                    bytesDeImagenDesdeBD = newReader["Foto"];
                    bytesDeImagen = (byte[])bytesDeImagenDesdeBD;
                    imagen = ConvertirBytesAImagen(bytesDeImagen);
                    picBox.Image = imagen;
                }
                else picBox.Image = null;
            }
        }

        public void ModificarModelo(string[] ColumnasDatosAModificar, string[] DatosAModificar, string ModeloId, byte[] paraImagen)
        {
            if(ColumnasDatosAModificar.Length > 0)
            {
                string datos = "";
                for(int i = 0; i < ColumnasDatosAModificar.Length; i++)
                {
                    if(i == (ColumnasDatosAModificar.Length - 1))
                    {
                    datos += ColumnasDatosAModificar[i] + " = '" + DatosAModificar[i] + "'";
                    }else datos += ColumnasDatosAModificar[i] + " = '" + DatosAModificar[i] + "',";
                }
                Conexion objetoConexion = new Conexion();
                string queryModificacion = "UPDATE Modelos SET " + datos + "where IdModelo ='" + ModeloId + "';";

                SqlCommand updateCommand = new SqlCommand(queryModificacion, objetoConexion.establecerConexion());
                SqlDataReader ModificacionReader = updateCommand.ExecuteReader();

                while (ModificacionReader.Read())
                {

                }
                ModificacionReader.Close();
                objetoConexion.cerrarconexion();

                if (paraImagen != null)
                {
                    Conexion objetoConexion2 = new Conexion();
                    string queryImagen = "UPDATE Modelos SET Foto = @Foto WHERE IdModelo = '" + ModeloId + "';";
                    using (SqlCommand elComando = new SqlCommand(queryImagen, objetoConexion2.establecerConexion()))
                    {
                        elComando.Parameters.AddWithValue("@Foto", paraImagen);
                    SqlDataReader tworeader = elComando.ExecuteReader();

                    while (tworeader.Read())
                    {
                    }
                    tworeader.Close();
                    }
                objetoConexion2.cerrarconexion();
                }
            }
            else if (ColumnasDatosAModificar.Length == 0 && paraImagen != null)
            {
                Conexion objetoConexion3 = new Conexion();
                string queryImagen = "UPDATE Modelos SET Foto = @Foto WHERE IdModelo = '" + ModeloId + "';";
                using (SqlCommand elComando = new SqlCommand(queryImagen, objetoConexion3.establecerConexion()))
                {
                    elComando.Parameters.AddWithValue("@Foto", paraImagen);
                    SqlDataReader tworeader = elComando.ExecuteReader();

                    while (tworeader.Read())
                    {
                    }
                    tworeader.Close();
                }
                objetoConexion3.cerrarconexion();

            }
        }

        public void SelectGenericoInfo(string variableParaInfo, string query, string columna)
        {
            Conexion objetoConexion = new Conexion();
            SqlCommand comando = new SqlCommand(query, objetoConexion.establecerConexion());
            SqlDataReader newReader = comando.ExecuteReader();

            while(newReader.Read())
            {
                variableParaInfo = newReader[columna].ToString();
            }
        }

        public void GuardarMaterialesXModeloEnModificacion(List<String> ListaMaterialesPorAcopio, List<String> CantidadDeMaterial, List<String> CantidadDisponiActualizada, string IdModeloEnModificacion)
        {
            for(int i = 0; i < ListaMaterialesPorAcopio.Count; i++)
            {

            Conexion objetoConexion = new Conexion();
            string query = "Select IdMaterial from Acopio where IdAcopio='" + ListaMaterialesPorAcopio[i] + "';";

            SqlCommand comando8 = new SqlCommand(query, objetoConexion.establecerConexion());
            SqlDataReader newReader8 = comando8.ExecuteReader();
            string IdMaterialUsado = "";

            while(newReader8.Read())
            {
                IdMaterialUsado = newReader8["IdMaterial"].ToString();
            }
            newReader8.Close();
                objetoConexion.cerrarconexion();
                Conexion objetoConexion2 = new Conexion();

                string query2 = "Insert into MaterialesModelo ( IdModelo, IdAcopio, IdMaterial, CantidadxModelo) values ('" + IdModeloEnModificacion + "','" + ListaMaterialesPorAcopio[i] + "','" + IdMaterialUsado + "','" + CantidadDeMaterial[i] + "');";
                SqlCommand comando9 = new SqlCommand(query2, objetoConexion2.establecerConexion());
                SqlDataReader newReader9 = comando9.ExecuteReader();
                while(newReader9.Read())
                { }
                newReader9.Close();
                objetoConexion2.cerrarconexion();
                Conexion objetoConexion3 = new Conexion();

                string query3 = "Update Acopio Set Disponible ='" + CantidadDisponiActualizada[i] + "' where IdAcopio ='" + ListaMaterialesPorAcopio[i] + "';";
                SqlCommand comando10 = new SqlCommand(query3, objetoConexion3.establecerConexion());
                SqlDataReader newReader10 = comando10.ExecuteReader();
                while(newReader10.Read()) 
                { }
                newReader10.Close();
                objetoConexion3.cerrarconexion();
            }
        }


    }
}
