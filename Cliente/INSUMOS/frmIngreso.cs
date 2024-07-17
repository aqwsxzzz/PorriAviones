using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _1.INSUMOS
{
    public partial class frmIngreso : Form
    {
        private frmMateriales frmMateriales;
        string[] arrayTextBoxes = new string[] { "texGrupo", "texCaracteristica", "texMedidas", "texCodigo",  "texFabricante", "gruboxEstado", "texUbicacion", "texCantidad", "texTipo", "texValor" };

        byte[] imageByte;

        public frmIngreso(frmMateriales principal)
        {
            InitializeComponent();
            frmMateriales = principal;

            this.Cursor = Cursors.Cross;
                                                  
            INSUMOS.frmMateriales mate = new INSUMOS.frmMateriales();

            dgvMaterialesEnExistencia.AutoGenerateColumns = false;

            dgvMaterialesEnExistencia.ColumnCount = 8;

            dgvMaterialesEnExistencia.Columns[0].Name = "Grupo";
            dgvMaterialesEnExistencia.Columns[0].HeaderText = "         Grupo";
            dgvMaterialesEnExistencia.Columns[0].DataPropertyName = "Grupo";
            dgvMaterialesEnExistencia.Columns[0].Width = 130;

            dgvMaterialesEnExistencia.Columns[1].Name = "Caracteristica";
            dgvMaterialesEnExistencia.Columns[1].HeaderText = " Caracteristica";
            dgvMaterialesEnExistencia.Columns[1].DataPropertyName = "Caracteristica";
            dgvMaterialesEnExistencia.Columns[1].Width = 130;

            dgvMaterialesEnExistencia.Columns[2].Name = "Medidas";
            dgvMaterialesEnExistencia.Columns[2].HeaderText = "       Medidas";
            dgvMaterialesEnExistencia.Columns[2].DataPropertyName = "Medidas";
            dgvMaterialesEnExistencia.Columns[2].Width = 130;

            dgvMaterialesEnExistencia.Columns[3].Name = "Codigo";
            dgvMaterialesEnExistencia.Columns[3].HeaderText = "        Codigo";
            dgvMaterialesEnExistencia.Columns[3].DataPropertyName = "Codigo";
            dgvMaterialesEnExistencia.Columns[3].Width = 130;

            dgvMaterialesEnExistencia.Columns[4].Name = "Fabricante";
            dgvMaterialesEnExistencia.Columns[4].HeaderText = "          Fabricante";
            dgvMaterialesEnExistencia.Columns[4].DataPropertyName = "Fabricante";
            dgvMaterialesEnExistencia.Columns[4].Width = 110;

            dgvMaterialesEnExistencia.Columns[5].Name = "Estado";
            dgvMaterialesEnExistencia.Columns[5].HeaderText = "Estado";
            dgvMaterialesEnExistencia.Columns[5].DataPropertyName = "Estado";
            dgvMaterialesEnExistencia.Columns[5].Width = 30;
            dgvMaterialesEnExistencia.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMaterialesEnExistencia.Columns[6].Name = "Ubicacion";
            dgvMaterialesEnExistencia.Columns[6].HeaderText = "Ubicacion";
            dgvMaterialesEnExistencia.Columns[6].DataPropertyName = "Ubicacion";
            dgvMaterialesEnExistencia.Columns[6].Width = 70;

            dgvMaterialesEnExistencia.Columns[7].Name = "Tipo";
            dgvMaterialesEnExistencia.Columns[7].HeaderText = "      Tipo";
            dgvMaterialesEnExistencia.Columns[7].DataPropertyName = "Tipo";
            dgvMaterialesEnExistencia.Columns[7].Width = 95;
            dgvMaterialesEnExistencia.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMaterialesEnExistencia.BorderStyle = BorderStyle.None;
                      
         

            this.Location = new Point(365, 200);
            this.FormBorderStyle = FormBorderStyle.None;

            texFamilia.BorderStyle = BorderStyle.None;

            this.Shown += new EventHandler(frmIngreso_Shown);

            // Asociar el mismo manejador de eventos a varios TextBox
            AsociarEventosTextBox(texGrupo, texMedidas, texValor, texCantidad, texCaracteristica, texTipo, texUbicacion, texFabricante, texCodigo, texEstado);

            Insumos.Stock stock = new Insumos.Stock();
            stock.MaterialesEnExistencia(dgvMaterialesEnExistencia, frmMateriales.listFamiliaMat.Text);

            texGrupo.KeyPress += TextBox_KeyPress;
            texCaracteristica.KeyPress += TextBox_KeyPress;
            texMedidas.KeyPress += TextBox_KeyPress;
            texCodigo.KeyPress += TextBox_KeyPress;
            texEstado.KeyPress += TextBox_KeyPress;
            texFabricante.KeyPress += TextBox_KeyPress;
            texUbicacion.KeyPress += TextBox_KeyPress;
            texCantidad.KeyPress += TextBox_KeyPress;
            texTipo.KeyPress += TextBox_KeyPress;
            texValor.KeyPress += TextBox_KeyPress;

            texGrupo.Height = 33;
        }

        private void botCancelar_Click(object sender, EventArgs e)
        {
            frmMateriales.labTituloMat.Location = new Point(870, 152);
            frmMateriales.labIngresoMat.Location = new Point(843,215);
            
            frmMateriales.botIngresarFam.Visible = true;
            frmMateriales.botCancelarMat.Visible = true;

            frmMateriales.picboxFotoMat.Visible = false;
            frmMateriales.picboxRecuaMat1.Location = new Point(683, 396);
            frmMateriales.picboxRecuadroGrande.Visible = true;

            frmMateriales.dgvMaterialesEnExistencia.Visible = false;
                     
            frmMateriales.listFamiliaMat.Visible = true;
                      
            this.Close();
        }

        private void botCargarFoto_Click(object sender, EventArgs e)
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
                    frmMateriales.picboxRecuadroGrande.Visible = false;

                    frmMateriales .dgvMaterialesEnExistencia.Location = new Point(500, 339);
                }
                botAceptar.Focus();
                this.Location = new Point(360, 200);
            }
        }

        private void botAceptar_Click(object sender, EventArgs e)
        {
            Insumos.Stock objetostock = new Insumos.Stock();
            objetostock.guardarMateriales  (texFamilia, texGrupo, texCaracteristica, texMedidas,
                texCodigo, texTipo, texUbicacion, texFabricante, texCantidad, texValor, texEstado, imageByte);
            objetostock.mostrarMateriales(frmMateriales.dgvMateriales);
       
            frmMateriales.picboxFotoMat.Visible = false;
           
            frmMateriales.listFamiliaMat.Visible = true;
            frmMateriales.listFamiliaMat.Focus();

            frmMateriales.botCancelarMat.Visible = true;
            frmMateriales.botIngresarFam.Visible = true;

            this.Close();
        }

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
            // Acciones a realizar cuando un TextBox pierde el foco
            TextBox textBox = sender as TextBox;
            textBox.BackColor = System.Drawing.Color.LightSteelBlue;
                   }

        private void dgvMaterialesEnExistencia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           // dgvMaterialesEnExistencia.Location = new Point(400, 409);
            string texBoxSinCorregir = "tex" + dgvMaterialesEnExistencia.Columns[e.ColumnIndex].HeaderText;
            string texBoxAEncontrar = texBoxSinCorregir.Replace(" ", "");
            string dato = dgvMaterialesEnExistencia.CurrentCell.Value.ToString();
            TextBox foundTextBox = Controls.Find(texBoxAEncontrar, true).FirstOrDefault() as TextBox;
            foundTextBox.Text = dato;

            string[] texBoxNames = { "texCaracteristica", "texMedidas", "texCodigo", "texFabricante", "texEstado", "texUbicacion", "texCantidad", "texValor" };
            int column = e.ColumnIndex;
            string textToFocus = texBoxNames[column];
            TextBox textFocus = Controls.Find(textToFocus, true).FirstOrDefault() as TextBox;
            textFocus.Focus();

        }

        private void dgvMaterialesEnExistencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // dgvMaterialesEnExistencia.Location = new Point(400, 409);
            string texBoxSinCorregir = "tex" + dgvMaterialesEnExistencia.Columns[e.ColumnIndex].HeaderText;
            string texBoxAEncontrar = texBoxSinCorregir.Replace(" ", "");
            string dato = dgvMaterialesEnExistencia.CurrentCell.Value.ToString();
            TextBox foundTextBox = Controls.Find(texBoxAEncontrar, true).FirstOrDefault() as TextBox;
            foundTextBox.Text = dato;

            string[] texBoxNames = { "texCaracteristica", "texMedidas", "texCodigo", "texFabricante", "texEstado", "texUbicacion", "texCantidad", "texValor" };
            int column = e.ColumnIndex;
            string textToFocus = texBoxNames[column];
            TextBox textFocus = Controls.Find(textToFocus, true).FirstOrDefault() as TextBox;
            textFocus.Focus();

        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            // Verifica si el carácter presionado no es una letra.
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
               for (int i = 0; i < arrayTextBoxes.Length; i++)
                {
                    if (textBox.Name == arrayTextBoxes[i] && textBox.Name != "texValor" && textBox.Name != "texFabricante")
                    {
                        string nextTextBoxName = arrayTextBoxes[i + 1];
                        TextBox textBoxToFOcus = Controls.Find(nextTextBoxName, true).FirstOrDefault() as TextBox;
                        textBoxToFOcus.Focus();
                    }
                    else if (textBox.Name == "texValor")
                    {
                        botCargarFoto.Focus();
                    }
                    else if (textBox.Name == "texFabricante") radbotNuevo.Focus();

                }
            }
        }

        private void frmIngreso_Load(object sender, EventArgs e)
        {
        }

        private void gruboxEstado_Enter(object sender, EventArgs e)
        {

        }

        private void texEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void texValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void texTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void texCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void texUbicacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void texFabricante_TextChanged(object sender, EventArgs e)
        {

        }

        private void texCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void texMedidas_TextChanged(object sender, EventArgs e)
        {

        }

        private void texCaracteristica_TextChanged(object sender, EventArgs e)
        {

        }

        private void texGrupo_TextChanged(object sender, EventArgs e)
        {

        }

        private void labFabricante_Click(object sender, EventArgs e)
        {

        }

        private void labEstado_Click(object sender, EventArgs e)
        {

        }

        private void labValor_Click(object sender, EventArgs e)
        {

        }

        private void labTipo_Click(object sender, EventArgs e)
        {

        }

        private void labCantidad_Click(object sender, EventArgs e)
        {

        }

        private void labUbicacion_Click(object sender, EventArgs e)
        {

        }

        private void labCodigo_Click(object sender, EventArgs e)
        {

        }

        private void labMedidas_Click(object sender, EventArgs e)
        {

        }

        private void labCaracteristica_Click(object sender, EventArgs e)
        {

        }

        private void labGrupo_Click(object sender, EventArgs e)
        {

        }

        private void picboxRecuaIngreso1_Click(object sender, EventArgs e)
        {

        }

        private void picboxRecuaIngreso2_Click(object sender, EventArgs e)
        {

        }

        private void radbotNuevo_Click(object sender, EventArgs e)
        {
            //gruboxEstado.Visible = false;

            texEstado.Text = "N";
            texUbicacion.Focus();
            texEstado.Visible = true;
            texEstado .Location =new Point (835, 496);
            texEstado.BorderStyle = BorderStyle.None;
        }

        private void radbotUsado_Click(object sender, EventArgs e)
        {
            //gruboxEstado.Visible = false;

            texEstado.Text = "U";
            texUbicacion.Focus();
            texEstado.Visible = true;
            texEstado.Location = new Point(835, 496);
        }

        private void frmIngreso_Shown(object sender, EventArgs e)
        {
            dgvMaterialesEnExistencia.ClearSelection();
            dgvMaterialesEnExistencia.CurrentCell = null;
        }

        private void dgvMaterialesEnExistencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
