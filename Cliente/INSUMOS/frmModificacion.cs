using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.INSUMOS
{

    public partial class frmModificacion : Form
    {
        private frmMateriales frmMateriales;
        byte[] imageByte;
        string[] arrayTextBoxes = new string[] { "texGrupo", "texCaracteristica", "texMedidas", "texCodigo", "texFabricante", "texEstado", "texUbicacion", "texCantidad", "texTipo", "texValor" };

        List<string> ListaNuevoValorMats = new List<string>();
        List<string> ListaNombreColumnasMats = new List<string>();
        List<string> ListaNuevoValorAcopio = new List<string>();
        List<string> ListaNombreColumnasAcopio = new List<string>();
        int contador = 0;
        public string cantOriginal = "";

        public frmModificacion(frmMateriales principal)
        {
            InitializeComponent();
            frmMateriales = principal;

            // this.Cursor = Cursors.Cross;
            this.Cursor = Cursors.Arrow;

            texFamilia.BackColor = System.Drawing.Color.LightSteelBlue;
            texFamilia.ForeColor = Color.Green;

            texFamilia.BackColor = System.Drawing.Color.LightSteelBlue;
            texGrupo.BackColor = System.Drawing.Color.LightSteelBlue;
            texCaracteristica.BackColor = System.Drawing.Color.LightSteelBlue;
            texMedidas.BackColor = System.Drawing.Color.LightSteelBlue;
            texCodigo.BackColor = System.Drawing.Color.LightSteelBlue;
            texEstado.BackColor = System.Drawing.Color.LightSteelBlue;
            texFabricante.BackColor = System.Drawing.Color.LightSteelBlue;
            texUbicacion.BackColor = System.Drawing.Color.LightSteelBlue;
            texCantidad.BackColor = System.Drawing.Color.LightSteelBlue;
            texTipo.BackColor = System.Drawing.Color.LightSteelBlue;
            texValor.BackColor = System.Drawing.Color.LightSteelBlue;



            this.Location = new Point(363, 220);

            frmMateriales.labTituloMat.Location = new Point(1000, 100);
            texGrupo.Focus();
            AsociarEventosTextBox(texGrupo, texCaracteristica, texMedidas, texCodigo, texFabricante, texEstado, texUbicacion, texCantidad, texTipo, texValor);
            NextFocusTextBoxes(texGrupo, texCaracteristica, texMedidas, texCodigo, texFabricante, texEstado, texUbicacion, texCantidad, texTipo, texValor);

            ListaNombreColumnasAcopio.Clear();
            ListaNombreColumnasMats.Clear();
            ListaNuevoValorAcopio.Clear();
            ListaNuevoValorMats.Clear();
        }

        private void texFamilia_Click(object sender, EventArgs e)
        {

            frmMateriales.listFamiliaMat.Visible = true;
            frmMateriales.dgvMateriales.Location = new Point(365, 295);
        }

        private void texGrupo_Click(object sender, EventArgs e)
        {
           // texGrupo.BackColor = Color.FromArgb(255, 224, 192);
            //texGrupo.BorderStyle = BorderStyle.Fixed3D;
        }

        private void texCaracteristica_Click(object sender, EventArgs e)
        {
           // texCaracteristica.BackColor = Color.FromArgb(255, 224, 192);
            //texCaracteristica.BorderStyle = BorderStyle.Fixed3D;
        }

        private void texMedidas_Click(object sender, EventArgs e)
        {
            texMedidas.BackColor = Color.FromArgb(255, 224, 192);
            texMedidas.BorderStyle = BorderStyle.Fixed3D;
        }

        private void texCodigo_Click(object sender, EventArgs e)
        {
            texCodigo.BackColor = Color.FromArgb(255, 224, 192);
            texCodigo.BorderStyle = BorderStyle.Fixed3D;
        }

        private void texFabricante_Click(object sender, EventArgs e)
        {
            texFabricante.BackColor = Color.FromArgb(255, 224, 192);
            texFabricante.BorderStyle = BorderStyle.Fixed3D;
        }

        private void texUbicacion_Click(object sender, EventArgs e)
        {
            texUbicacion.BackColor = Color.FromArgb(255, 224, 192);
            texUbicacion.BorderStyle = BorderStyle.Fixed3D;
        }

        private void texCantidad_Click(object sender, EventArgs e)
        {
            texCantidad.BackColor = Color.FromArgb(255, 224, 192);
            texCantidad.BorderStyle = BorderStyle.Fixed3D;
        }

        private void texTipo_Click(object sender, EventArgs e)
        {
            texTipo.BackColor = Color.FromArgb(255, 224, 192);
            texTipo.BorderStyle = BorderStyle.Fixed3D;
        }

        private void texValor_Click(object sender, EventArgs e)
        {
            texValor.BackColor = Color.FromArgb(255, 224, 192);
            texValor.BorderStyle = BorderStyle.Fixed3D;
        }

        private void botSalir_Click(object sender, EventArgs e)
        {
            frmMateriales.botCancelarIngresoMat.Visible = false;
            frmMateriales.botSalirMat.Visible = true;
            frmMateriales.botIngresarMat.Visible = true;
            frmMateriales.botIngresarMat.Location = new Point(364, 940);
            frmMateriales.botModificarMat.Visible = true;
            frmMateriales.botModificarMat.Enabled = false;
            frmMateriales.botModificarMat.Font = new Font(frmMateriales . botModificarMat.Font, FontStyle.Regular);
            frmMateriales.botModificarMat.Location = new Point(528, 940);
            frmMateriales.botBuscarMat.Visible = true;
            frmMateriales.botBuscarMat.Location = new Point(692, 940);
            frmMateriales.botEliminarMat.Visible = true;
            frmMateriales.botEliminarMat.Enabled = false;
            frmMateriales.botEliminarMat.Font = new Font(frmMateriales.botEliminarMat.Font, FontStyle.Regular);
            frmMateriales.botEliminarMat.Location = new Point(856, 940);
            frmMateriales.botListarMat.Visible = true;
            frmMateriales.botListarMat.Location = new Point(1020, 940);
                 
            frmMateriales.dgvMateriales.Location = new Point(365, 295);
            frmMateriales.dgvMateriales.Visible = true;

            frmMateriales.picboxFotoMat.Visible = false;

            frmMateriales.dgvMateriales.ClearSelection();
            frmMateriales.dgvMateriales.CurrentCell = null;
            frmMateriales.dgvMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            frmMateriales.dgvMateriales.MultiSelect = false;

            this.Close();
        }

        private void botFoto_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog Dialogo = new OpenFileDialog();
                DialogResult resultado = Dialogo.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    frmMateriales.picboxFotoMat.Image = Image.FromStream(Dialogo.OpenFile());
                    MemoryStream memoria = new MemoryStream();
                    frmMateriales.picboxFotoMat.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageByte = memoria.ToArray();
                    frmMateriales.picboxFotoMat.Visible = true;
                    botFoto.Visible = false;
                }
                botGuardar.Visible = true;
                this.Location = new Point(263, 220);
            }

        }

        //Eventos personalizados.

        //TextBox Events.
        private void AsociarEventosTextBox(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Enter += TextBox_Enter;
                textBox.Leave += TextBox_Leave;
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            // Acciones a realizar cuando un TextBox obtiene el foco
            TextBox textBox = sender as TextBox;
            textBox.BackColor = Color.White;

        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string texBoxName = textBox.Name;
            string columnName = texBoxName.Substring(3);
            contador = 0;
            if (texBoxName == "texValor")
            {
                int valorI = 0;
                if (ListaNombreColumnasAcopio.Count() > 0)
                {
                    for (int i = 0; i < ListaNombreColumnasAcopio.Count(); i++)
                    {
                        if (ListaNombreColumnasAcopio[i] == columnName)
                        {
                            contador = 1;
                            valorI = i;
                        }
                    }
                }
                if (contador == 1 && frmMateriales.dgvMateriales.CurrentRow.Cells[11].Value.ToString() != textBox.Text)
                {
                    ListaNuevoValorAcopio[valorI] = textBox.Text;
                }
                else
                {
                    if (frmMateriales.dgvMateriales.CurrentRow.Cells[11].Value.ToString() != textBox.Text)
                    {
                        botGuardar.Visible = true;
                        ListaNombreColumnasAcopio.Add(columnName);
                        ListaNuevoValorAcopio.Add(textBox.Text);
                    }

                }
            }
            else if (texBoxName == "texCantidad")
            {
                int valorI = 0;
                if (ListaNombreColumnasAcopio.Count() > 0)
                {
                    for (int i = 0; i < ListaNombreColumnasAcopio.Count(); i++)
                    {
                        if (ListaNombreColumnasAcopio[i] == columnName)
                        {
                            contador = 1;
                            valorI = i;
                        }
                    }
                }
                if (contador == 1 && frmMateriales.dgvMateriales.CurrentRow.Cells[8].Value.ToString() != textBox.Text)
                {
                    ListaNuevoValorAcopio[valorI] = textBox.Text;
                }
                else
                {
                    if (frmMateriales.dgvMateriales.CurrentRow.Cells[8].Value.ToString() != textBox.Text)
                    {
                        botGuardar.Visible = true;
                        ListaNombreColumnasAcopio.Add(columnName);
                        ListaNuevoValorAcopio.Add(textBox.Text);
                    }

                }

            }
            else
            {
                foreach (DataGridViewCell cell in frmMateriales.dgvMateriales.CurrentRow.Cells)
                {
                    int columnIndex = cell.ColumnIndex;
                    if (frmMateriales.dgvMateriales.Columns[columnIndex].HeaderText == columnName)
                    {
                        if (frmMateriales.dgvMateriales.CurrentRow.Cells[columnIndex].Value.ToString() != textBox.Text)
                        {
                            if (columnName == "Ubicacion" || columnName == "Fabricante")
                            {
                                int valorI = 0;
                                if (ListaNombreColumnasAcopio.Count() > 0)
                                {
                                    for (int i = 0; i < ListaNombreColumnasAcopio.Count(); i++)
                                    {
                                        if (ListaNombreColumnasAcopio[i] == columnName)
                                        {
                                            contador = 1;
                                            valorI = i;
                                        }
                                    }
                                }
                                if (contador == 1)
                                {
                                    ListaNuevoValorAcopio[valorI] = textBox.Text;
                                }
                                else
                                {
                                    botGuardar.Visible = true;
                                    ListaNombreColumnasAcopio.Add(columnName);
                                    ListaNuevoValorAcopio.Add(textBox.Text);

                                }
                            }
                            else
                            {
                                int valorI = 0;
                                if (ListaNombreColumnasMats.Count() > 0)
                                {
                                    for (int i = 0; i < ListaNombreColumnasMats.Count(); i++)
                                    {
                                        if (ListaNombreColumnasMats[i] == columnName)
                                        {
                                            contador = 1;
                                            valorI = i;
                                        }
                                    }
                                }
                                if (contador == 1)
                                {
                                    ListaNuevoValorMats[valorI] = textBox.Text;
                                }
                                else
                                {
                                    botGuardar.Visible = true;
                                    ListaNombreColumnasMats.Add(columnName);
                                    ListaNuevoValorMats.Add(textBox.Text);

                                }
                            }
                        }
                    }
                }
            }
            textBox.BackColor = System.Drawing.Color.LightSteelBlue;
        }
        //
        private void NextFocusTextBoxes(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.KeyPress += TextBox_KeyPress;
            }
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            // Verifica si el carácter presionado no es una letra.
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                for (int i = 0; i < arrayTextBoxes.Length; i++)
                {
                    if (textBox.Name == arrayTextBoxes[i] && textBox.Name != "texValor")
                    {
                        string nextTextBoxName = arrayTextBoxes[i + 1];
                        TextBox textBoxToFOcus = Controls.Find(nextTextBoxName, true).FirstOrDefault() as TextBox;
                        textBoxToFOcus.Focus();
                    }
                    else if (textBox.Name == "texValor") botFoto.Focus();
                }
            }
        }


        private void botGuardar_Click(object sender, EventArgs e)
        {
            string[] ListaNombreColumnasAcopioArray = ListaNombreColumnasAcopio.ToArray();
            string[] ListaNuevoValorAcopioArray = ListaNuevoValorAcopio.ToArray();
            string[] ListaNombreColumnasMatsArray = ListaNombreColumnasMats.ToArray();
            string[] ListaNuevoValorMatsArray = ListaNuevoValorMats.ToArray();
            string disponible = "";
            if(cantOriginal != texCantidad.Text)
            {
                disponible = (int.Parse(texCantidad.Text) - int.Parse(cantOriginal)).ToString();
            }

            Insumos.Stock func = new Insumos.Stock();
            func.ModificarMaterial(frmMateriales.dgvMateriales.CurrentRow.Cells[12].Value.ToString(), ListaNombreColumnasAcopioArray, ListaNuevoValorAcopioArray, ListaNombreColumnasMatsArray, ListaNuevoValorMatsArray, disponible, imageByte);
            func.mostrarMateriales(frmMateriales.dgvMateriales);
           
            frmMateriales.labTituloDgv.Visible = true;

            frmMateriales.picboxTituloDgv.Visible = true;
            
            frmMateriales.botIngresarMat.Visible = true;
            frmMateriales.botIngresarMat.Location = new Point(364, 940);
            frmMateriales.botModificarMat.Visible = true;
            frmMateriales.botModificarMat.Location = new Point(528, 940);
            frmMateriales.botBuscarMat.Visible = true;
            frmMateriales.botBuscarMat.Location = new Point(692,940);
            frmMateriales.botEliminarMat.Visible = true;
            frmMateriales.botEliminarMat.Location = new Point(856, 940);
            frmMateriales.botListarMat.Visible = true;
            frmMateriales.botCancelarIngresoMat.Visible = false;
            frmMateriales.botListarMat.Location = new Point(1020, 940);
            frmMateriales.botSalirMat.Visible = true;

            frmMateriales.dgvMateriales.Visible = true;
            frmMateriales.dgvMateriales.Location = new Point(365, 295);

            frmMateriales.dgvMateriales.ClearSelection();
            frmMateriales.dgvMateriales.CurrentCell = null;
            frmMateriales.dgvMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            frmMateriales.dgvMateriales.MultiSelect = false;

            frmMateriales.picboxFotoMat.Visible = false;
                             
            this.Close();
        }

        private void frmModificacion_Load(object sender, EventArgs e)
        {
            texGrupo.Select();
        }

        private void texEstado_Click(object sender, EventArgs e)
        {
            texEstado.Visible = false;
            radbotNuevo.Visible = true;
            radbotUsado.Visible = true;
            gruboxEstado.Visible = true;
            gruboxEstado.Location = new Point(589, 250);
        }

        private void radbotNuevo_Click(object sender, EventArgs e)
        {
            texEstado.Text = "N"; // Asigna "N" al TextBox
            texEstado.Visible = true;
         //  gruboxEstado.Visible = false; // Oculta el GroupBox después de seleccionar una opción
            texUbicacion.Focus();
            if(texEstado.Text != frmMateriales.dgvMateriales.CurrentRow.Cells[7].Value.ToString())
            {
                botGuardar.Visible = true;
                ListaNombreColumnasMats.Add("Estado");
                ListaNuevoValorMats.Add(texEstado.Text);
            }
        }
 
        private void radbotUsado_Click(object sender, EventArgs e)
        {
            texEstado.Text = "U"; // Asigna "U" al TextBox
            texEstado.Visible = true;
         //   gruboxEstado.Visible = false; // Oculta el GroupBox después de seleccionar una opción
            texUbicacion.Focus();
            if (texEstado.Text != frmMateriales.dgvMateriales.CurrentRow.Cells[7].Value.ToString())
            {
                botGuardar.Visible = true;
                ListaNombreColumnasMats.Add("Estado");
                ListaNuevoValorMats.Add(texEstado.Text);
            }

        }
    }
}