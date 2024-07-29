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
using System.Globalization;
using static _1.Insumos.Stock;

namespace _1.INSUMOS
{
    public partial class frmMateriales : Form
    {       
        bool modif = false;
        byte[] imageByte;
       
        bool Buscar = false;

        int rowIndex = 0;

        string NuevoModificacionOEliminacion = "";
        public object MMessageBox { get; private set; }

        public frmMateriales()
        {
            InitializeComponent();

            this.Load += frmMateriales_Load;

            texNuevoFam.KeyPress += new KeyPressEventHandler(texNuevoFam_KeyPress);  //Instancia el evento Keypress para que cuando con un solo enter entre en la ficha.

            this.Cursor = Cursors.Arrow;
             
            dgvMateriales.AutoGenerateColumns = false;

            dgvMateriales.ColumnCount = 13;

            dgvMateriales.Columns[0].Name = "Familia";
            dgvMateriales.Columns[0].HeaderText = "Familia";
            dgvMateriales.Columns[0].DataPropertyName = "Familia";
            dgvMateriales.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMateriales.Columns[1].Name = "Grupo";
            dgvMateriales.Columns[1].HeaderText = "Grupo";
            dgvMateriales.Columns[1].DataPropertyName = "Grupo";

            dgvMateriales.Columns[2].Name = "Caracteristica";
            dgvMateriales.Columns[2].HeaderText = "Caracteristica";
            dgvMateriales.Columns[2].DataPropertyName = "Caracteristica";

            dgvMateriales.Columns[3].Name = "Medidas";
            dgvMateriales.Columns[3].HeaderText = "Medidas";
            dgvMateriales.Columns[3].DataPropertyName = "Medidas";
            dgvMateriales.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMateriales.Columns[4].Name = "Codigo";
            dgvMateriales.Columns[4].HeaderText = "Codigo";
            dgvMateriales.Columns[4].DataPropertyName = "Codigo";

            dgvMateriales.Columns[5].Name = "Fabricante";
            dgvMateriales.Columns[5].HeaderText = "Fabricante";
            dgvMateriales.Columns[5].DataPropertyName = "Fabricante";

            dgvMateriales.Columns[6].Name = "Ubicacion";
            dgvMateriales.Columns[6].HeaderText = "Ubicacion";
            dgvMateriales.Columns[6].DataPropertyName = "Ubicacion";

            dgvMateriales.Columns[7].Name = "Estado";
            dgvMateriales.Columns[7].HeaderText = "Estado";
            dgvMateriales.Columns[7].DataPropertyName = "Estado";

            dgvMateriales.Columns[8].Name = "Cantidad";
            dgvMateriales.Columns[8].HeaderText = "Cant.";
            dgvMateriales.Columns[8].DataPropertyName = "Cantidad";

            dgvMateriales.Columns[9].Name = "Disponible";
            dgvMateriales.Columns[9].HeaderText = "Dispon.";
            dgvMateriales.Columns[9].DataPropertyName = "Disponible";

            dgvMateriales.Columns[10].Name = "Tipo";
            dgvMateriales.Columns[10].HeaderText = "Tipo";
            dgvMateriales.Columns[10].DataPropertyName = "Tipo";

            dgvMateriales.Columns[11].Name = "Valor";
            dgvMateriales.Columns[11].HeaderText = "Valor unitario";
            dgvMateriales.Columns[11].DataPropertyName = "Valor";

            dgvMateriales.Columns[12].Name = "IdMaterial";
            dgvMateriales.Columns[12].HeaderText = " IdMaterial";
            dgvMateriales.Columns[12].DataPropertyName = "IdMaterial";
            dgvMateriales.Columns[12].Visible = false;
            
            dgvMateriales.Location = new Point(365, 295);
            System.Drawing.Size Tamaño = new System.Drawing.Size(1240, 628);
            dgvMateriales.Size = Tamaño;
            dgvMateriales.BorderStyle = BorderStyle.Fixed3D  ;
            dgvMateriales.DefaultCellStyle.Font = new Font("Arial", 11);
            dgvMateriales.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvMateriales.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
         
            labTituloDgv.Location = new Point(1340, 253);

            botIngresarMat.Visible = true;
            botModificarMat.Visible = true;
            botBuscarMat.Visible = true;
            botEliminarMat.Visible = true;
            botListarMat.Visible = true;
            
            picboxTituloDgv.Location = new Point(1314, 237);
            picboxFotoMat.Visible = true;
            picboxFotoMat.Location = new Point(1280, 130);
            System.Drawing.Size Tamaño1 = new System.Drawing.Size(600, 500);
            picboxFotoMat.Size = Tamaño1;

            dgvMaterialesEnExistencia.AutoGenerateColumns = false;
            dgvMaterialesEnExistencia.ColumnCount = 6;

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
            dgvMaterialesEnExistencia.Columns[4].Width = 130;

            dgvMaterialesEnExistencia.Columns[5].Name = "Tipo";
            dgvMaterialesEnExistencia.Columns[5].HeaderText = "      Tipo";
            dgvMaterialesEnExistencia.Columns[5].DataPropertyName = "Tipo";
            dgvMaterialesEnExistencia.Columns[5].Width = 130;
            dgvMaterialesEnExistencia.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMaterialesEnExistencia.BorderStyle = BorderStyle.None;

            int AnchoCant = 60;
            DataGridViewColumn columna8 = dgvMateriales.Columns[7];
            columna8.Width = AnchoCant;

            int AnchoValor = 60;
            DataGridViewColumn columna9 = dgvMateriales.Columns[9];
            columna9.Width = AnchoValor;

            Insumos.Stock objetostock = new Insumos.Stock();
            objetostock.mostrarMateriales(dgvMateriales);
            //listFamiliaMat .Items.Clear();
            //comboxFamiliaMat.Items.Clear();
            objetostock.mostrarFamilia(listFamiliaMat);
            //objetostock.mostrarFamilia(comboxFamiliaMat);
            //objetostock.mostrarFamilia(comboxColumnas);
        }
         
        private void frmMateriales_Load(object sender, EventArgs e)
        {
            // Obtener el área de trabajo del escritorio (excluyendo la barra de tareas)
            Rectangle areaDeTrabajo = Screen.GetWorkingArea(this);

            // Establecer la posición y el tamaño del formulario para que ocupe toda el área de trabajo
            this.Location = areaDeTrabajo.Location;
            this.Size = areaDeTrabajo.Size;

            dgvMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMateriales.MultiSelect = false;

            dgvMateriales.Columns[0].Width = 135;  //Familia
           
            dgvMateriales.Columns[1].Width = 155;  //Grupo
          
            dgvMateriales.Columns[2].Width = 165;  //Caracteristica
          
            dgvMateriales.Columns[3].Width = 120;  //Medidas
          
            dgvMateriales.Columns[4].Width = 120;  //Fabricante

            dgvMateriales.Columns[5].Width = 120;  //´Codigo

            dgvMateriales.Columns[6].Width = 120;  //Ubicacion 
            dgvMateriales.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMateriales.Columns[7].Width = 42;  //Estado
            dgvMateriales.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMateriales.Columns[8].Width = 50;  //Cantidad
            dgvMateriales.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;

            dgvMateriales.Columns[9].Width = 50;  //Disponible
            dgvMateriales.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;

            dgvMateriales.Columns[10].Width = 70;  //Tipo

            dgvMateriales.Columns[11].Width = 70;  //Valor
            dgvMateriales.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;

            botCancelarIngresoMat.Visible = false;
            botSalirMat.Visible = true;
            botIngresarMat.Visible = true;
            botIngresarMat.Location = new Point(364, 940);
            botModificarMat.Visible = true;
            botModificarMat.Enabled = false;
            botModificarMat.Font = new Font(botModificarMat.Font, FontStyle.Regular);
            botModificarMat.Location = new Point(528, 940);
            botBuscarMat.Visible = true;
            botBuscarMat.Location = new Point(692, 940);
            botEliminarMat.Visible = true;
            botEliminarMat.Enabled = false;
            botEliminarMat.Font = new Font(botEliminarMat.Font, FontStyle.Regular);
            botEliminarMat.Location = new Point(856, 940);
            botListarMat.Visible = true;
            botListarMat.Location = new Point(1020, 940);
        }

        private void botIngresarMat_Click(object sender, EventArgs e)
        {
            Buscar = false;

            labFamiliaMat.Visible = true;
            labTituloDgv.Visible = false;
            labIngresoMat.Visible = true;
            labIngresoMat.Location = new Point(843, 215);
            labIngresoMat.Font = new Font(labIngresoMat.Font.FontFamily, 20, FontStyle.Underline);

            texFamiliaMat.Focus();
            texIdMat.Text = "";
            texFamiliaMat.Text = "";
            texFamiliaBuscar.Visible = false;

            botIngresarMat.Visible = false;
            botIngresarMat.Location = new Point(364, 940);
            botModificarMat.Visible = false;
            botModificarMat.Location = new Point(528, 940);
            botBuscarMat.Visible = false;
            botBuscarMat.Location = new Point(692, 940);
            botEliminarMat.Visible = false;
            botEliminarMat.Location = new Point(856, 940);
            botListarMat.Visible = false;
            botListarMat.Location = new Point(1020, 940);
            botCancelarMat.Visible = true;
            botCancelarMat.Location = new Point(1051, 620);
            botCancelarMat.Height = 42;
            System.Drawing.Size Tam = new System.Drawing.Size(109, 20);
            botIngresarFam.Visible = true;
            botIngresarFam.Location = new Point(719, 620);
            botSalirMat.Visible = false;

            picboxFotoMat.Visible = false;
            picboxTituloDgv.Visible = false;
            picboxRecuadroGrande.Visible = true;
            picboxRecuadroGrande.Height = 300;
            picboxRecuadroGrande.Width = 460;
            picboxRecuadroGrande.Location = new Point(720, 302);
            picboxRecuaBuscar.Visible = false;

            listFamiliaMat.Visible = true;
            listFamiliaMat.Location = new Point(978, 304);
            listFamiliaMat.Width = 200;
            listFamiliaMat.Height = 184;

            dgvMateriales.Visible = false;

            NuevoModificacionOEliminacion = "Nuevo";

                dgvMateriales.ClearSelection();
                dgvMateriales.Rows[rowIndex].Selected = true;
                dgvMateriales.CurrentCell = dgvMateriales.Rows[rowIndex].Cells[0];

                picboxRecuaMat1_AutoSize();
        }

        private void botModificarMat_Click(object sender, EventArgs e)
        {
            Buscar = false;
            if (dgvMateriales.SelectedRows.Count > 0)
            {
                NuevoModificacionOEliminacion = "Modificacion";

                dgvMateriales.Visible = false;
                labTituloDgv.Visible = false;
                picboxTituloDgv.Visible = false;

                botIngresarMat.Visible = false;
                botModificarMat.Visible = false;
                botEliminarMat.Visible = false;
                botListarMat.Visible = false;
                botBuscarMat.Visible = false;
                botSalirMat.Visible = false;
                botCancelarIngresoMat.Visible = false;

                picboxRecuaBuscar.Visible = false;

                frmModificacion Modifica = new frmModificacion(this);

                Insumos.Stock objetostock = new Insumos.Stock();

                Modifica.texGrupo.Text = dgvMateriales.CurrentRow.Cells[1].Value.ToString();
                Modifica.texCaracteristica.Text = dgvMateriales.CurrentRow.Cells[2].Value.ToString();
                Modifica.texMedidas.Text = dgvMateriales.CurrentRow.Cells[3].Value.ToString();
                Modifica.texCodigo.Text = dgvMateriales.CurrentRow.Cells[4].Value.ToString();
                Modifica.texFabricante.Text = dgvMateriales.CurrentRow.Cells[5].Value.ToString();
                Modifica.texUbicacion.Text = dgvMateriales.CurrentRow.Cells[6].Value.ToString();
                Modifica.texCantidad.Text = dgvMateriales.CurrentRow.Cells[8].Value.ToString();
                Modifica.texTipo.Text = dgvMateriales.CurrentRow.Cells[10].Value.ToString();
                Modifica.texValor.Text = dgvMateriales.CurrentRow.Cells[11].Value.ToString();
                Modifica.texFamilia.Text = dgvMateriales.CurrentRow.Cells[0].Value.ToString();
                Modifica.texEstado.Text = dgvMateriales.CurrentRow.Cells[7].Value.ToString();
                Modifica.botGuardar.Visible = false;
                Modifica.cantOriginal = dgvMateriales.CurrentRow.Cells[8].Value.ToString();

                Modifica.ShowDialog();

                modif = true;
            }
            else MessageBox.Show("Por favor selecciona un material para modificar.");
        }

        private void botEliminarMat_Click(object sender, EventArgs e)
        {
            botCancelarIngresoMat.Visible = false;
            Buscar = false;
            frmEliminar frmEliminar = new frmEliminar(this);
            frmEliminar.ShowDialog();

            using (frmEliminar formEliminar = new frmEliminar(this))
            {
                formEliminar.EliminarAccion = () =>
                {
                    Insumos.Stock funcStock = new Insumos.Stock();

                    if (dgvMateriales.CurrentRow.Cells[8].Value.ToString() == dgvMateriales.CurrentRow.Cells[9].Value.ToString())
                    {
                        funcStock.EliminarMaterial(dgvMateriales.CurrentRow.Cells[12].Value.ToString());
                        funcStock.mostrarMateriales(dgvMateriales);
                    }
                    else
                    {
                        MessageBox.Show("Verifique que el material no esté siendo utilizado en algún modelo.");
                    }
                    botIngresarMat.Visible = true;
                    botIngresarMat.Location = new Point(364, 940);
                    botBuscarMat.Visible = true;
                    botBuscarMat.Location = new Point(528, 940);
                    botEliminarMat.Visible = true;
                    botEliminarMat.Location = new Point(692, 940);
                    botListarMat.Location = new Point(856, 940);
                };
             }
        }

        private void dgvMateriales_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (modif)
            {
                labTituloDgv.Visible = false;

                picboxTituloDgv.Visible = false;

                dgvMateriales.Visible = false;
            }
        }

        private void botRecuaCancelarMat_Click(object sender, EventArgs e)
        {
            labIngresoMat.Visible = false;
            labModificaMat.Visible = false;
            labEliminaMat.Visible = false;
            labFamiliaMat.Visible = false;
            labTituloDgv.Visible = true;

            listFamiliaMat.Visible = false;

            picboxRecuaMat1.Visible = false;
            picboxRecuaTituloMat.Visible = false;
            picboxFotoMat.Visible = false;
            picboxTituloDgv.Visible = true;
            picboxRecuadroGrande.Visible = false;

            botCancelarIngresoMat.Visible = false;
            botSalirMat.Visible = true;
            botIngresarMat.Visible = true;
            botIngresarMat.Location = new Point(364, 940);
            botModificarMat.Visible = true;
            botModificarMat.Enabled = false;
            botModificarMat.Font = new Font(botModificarMat.Font, FontStyle.Regular);
            botModificarMat.Location = new Point(528, 940);
            botBuscarMat.Visible = true;
            botBuscarMat.Location = new Point(692, 940);
            botEliminarMat.Visible = true;
            botEliminarMat.Enabled = false;
            botEliminarMat.Font = new Font(botEliminarMat.Font, FontStyle.Regular);
            botEliminarMat.Location = new Point(856, 940);
            botListarMat.Visible = true;
            botListarMat.Location = new Point(1020, 940);

            dgvMateriales.Visible = true;
            dgvMateriales.Location = new Point(365, 295);
            dgvMateriales.Columns[0].Visible = true;
            dgvMateriales.Width = 1215;

            dgvMateriales.ClearSelection();
            dgvMateriales.CurrentCell = null;
            dgvMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMateriales.MultiSelect = false;

            modif = false;
                        
             labIngresoMat.Font = new Font("Arial", 10, FontStyle.Regular);
        }

        private void comboxfamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NuevoModificacionOEliminacion == "Nuevo" && listFamiliaMat.SelectedIndex >= 0)
            {
                labIngresoMat.Location = new Point(920, 114);
                labIngresoMat.Font = new Font("Arial", 22, FontStyle.Bold | FontStyle.Underline);
                labTituloMat.Location = new Point(970, 50);

                botIngresarFam.Visible = false;
                botCancelarMat.Visible = false;
                             
                picboxRecuaMat1.Visible = false;
                picboxRecuaTituloMat.Location = new Point(833, 128);

                System.Drawing.Size nuevoTamaño = new System.Drawing.Size(790, 304);
                dgvMaterialesEnExistencia.Size = nuevoTamaño;
                INSUMOS.frmIngreso Ingre = new INSUMOS.frmIngreso(this);
                Ingre.texGrupo.Select();
                Ingre.ShowDialog();
            }
        }

        private void botIngresarFam_Click(object sender, EventArgs e)
        {
            labFamiliaMat.Visible = false;

            texNuevoFam.Text = "";
            texNuevoFam.Visible = true;
            texNuevoFam.Focus();

            botCancelarMat.Visible = false;
            botIngresarFam.Location = new Point(865, 370);
            botIngresarFam.FlatStyle = FlatStyle.Flat;
            botIngresarFam.FlatAppearance.BorderSize = 0;
            botIngresarFam.BackColor = Color.LightSteelBlue;
            botIngresarFam.ForeColor = Color.Black;
            botIngresarFam.Font = new Font(labIngresoMat.Font.FontFamily, 18, FontStyle.Underline);
            botGuardarFam.Visible = true;
            botCancelarFam.Visible = true;

            listFamiliaMat.Visible = false;

            picboxRecuaMat1.Height = 197;
            picboxRecuadroGrande.Height = 290;
        }

        private void botCancelarFam_Click(object sender, EventArgs e)
        {
            labFamiliaMat.Visible = true;

            texNuevoFam.Visible = false;

            botGuardarFam.Visible = false;
            botIngresarFam.Visible = true;
            botIngresarFam.Location = new Point(670, 620);
            botIngresarFam.FlatStyle = FlatStyle.Standard;
            botIngresarFam.FlatAppearance.BorderSize = 0;
            botIngresarFam.BackColor = Color.Azure;
            botIngresarFam.ForeColor = Color.Red ;
            botIngresarFam.Font = new Font(labIngresoMat.Font.FontFamily, 14);
            botIngresarFam.Font = new Font(botIngresarFam.Font, FontStyle.Bold);
            botCancelarMat.Visible = true;
            botCancelarFam.Visible = false;
         
            listFamiliaMat.Visible = true;
          
            picboxRecuaMat1_AutoSize();
        }

        private void botGuardarFam_Click(object sender, EventArgs e)
        {
            Insumos.Stock objetostock = new Insumos.Stock();
            objetostock.GuardarFamilia(texNuevoFam);

            labFamiliaMat.Visible = true;

            texNuevoFam.Visible = false;

            botCancelarMat.Visible = true;
            botGuardarFam.Visible = false;
            botIngresarFam.Location = new Point(670, 620);
            botIngresarFam.FlatStyle = FlatStyle.Standard;
            botIngresarFam.FlatAppearance.BorderSize = 0;
            botIngresarFam.BackColor = Color.Azure;
            botIngresarFam.ForeColor = Color.Red;
            botIngresarFam.Font = new Font(labIngresoMat.Font.FontFamily, 14);
            botIngresarFam.Font = new Font(botIngresarFam.Font, FontStyle.Bold);
            botCancelarFam.Visible = false;

            listFamiliaMat.Visible = true;
         
            picboxRecuaMat1_AutoSize();
        }

        private void botRecuaCargarFotoMat_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog Dialogo = new OpenFileDialog();
                DialogResult resultado = Dialogo.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    picboxFotoMat.Image = Image.FromStream(Dialogo.OpenFile());
                    MemoryStream memoria = new MemoryStream();
                    picboxFotoMat.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageByte = memoria.ToArray();
                    picboxFotoMat.Visible = true;
                    botRecuaCargarFotoMat.Visible = false;
                }
            }
        }

        private void botRecuaGuardarFotoMat_Click(object sender, EventArgs e)
        {
            modif = false;

            labIngresoMat.Visible = false;
            labModificaMat.Visible = false;
            labEliminaMat.Visible = false;
            labFamiliaMat.Visible = false;

            texFamiliaMat.Focus();
            texFamiliaMat.Text = "";

            botIngresarFam.Visible = false;

            picboxRecuaMat1.Visible = false;
            picboxRecuaTituloMat.Visible = false;
            picboxFotoMat.Visible = false;

            listFamiliaMat.Visible = false;

            botCancelarIngresoMat.Visible = false;
            botIngresarMat.Visible = false;
            botModificarMat.Visible = false;
            botEliminarMat.Visible = false;
            botRecuaCargarFotoMat.Visible = false;
            botRecuaGuardarFotoMat.Visible = false;
            botSalirMat.Visible = true;

            dgvMateriales.Visible = true;
        }

        private void dgvMaterialesEnExistencia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMaterialesEnExistencia.Location = new Point(400, 409);
            string texBoxSinCorregir = "tex" + dgvMaterialesEnExistencia.Columns[e.ColumnIndex].HeaderText + "Mat";
            string texBoxAEncontrar = texBoxSinCorregir.Replace(" ", "");
            string dato = dgvMaterialesEnExistencia.CurrentCell.Value.ToString();
            TextBox foundTextBox = Controls.Find(texBoxAEncontrar, true).FirstOrDefault() as TextBox;
            foundTextBox.Text = dato;

            string[] texBoxNames = { "texCaracteristicaMat", "texMedidasMat", "texCodigoMat", "texFabricanteMat", "texUbicacionMat", "texValorMat" };
            int column = e.ColumnIndex;
            string textToFocus = texBoxNames[column];
            TextBox textFocus = Controls.Find(textToFocus, true).FirstOrDefault() as TextBox;
            textFocus.Focus();
        }

        private void botCancelarIngresoMat_Click(object sender, EventArgs e)
        {
            labTituloDgv.Location = new Point(1340, 253);
            labTituloMat.Location = new Point(870, 131);

            texFamiliaBuscar.Visible = false;

            botCancelarIngresoMat.Visible = false;
            botSalirMat.Visible = true;
            botIngresarMat.Visible = true;
            botIngresarMat.Location = new Point(364, 940);
            botModificarMat.Visible = true;
            botModificarMat.Enabled = false;
            botModificarMat.Font = new Font(botModificarMat.Font, FontStyle.Regular);
            botModificarMat.Location = new Point(528, 940);
            botBuscarMat.Visible = true;
            botBuscarMat.Location = new Point(692, 940);
            botBuscarMat.Font = new Font(botBuscarMat.Font, FontStyle.Bold );
            botEliminarMat.Visible = true;
            botEliminarMat.Enabled = false;
            botEliminarMat.Font = new Font(botEliminarMat.Font, FontStyle.Regular);
            botEliminarMat.Location = new Point(856, 940);
            botListarMat.Visible = true;
            botListarMat.Location = new Point(1020, 940);

            picboxFotoMat.Visible = false;
            picboxTituloDgv.Location = new Point(1314, 237);

            dgvMateriales.Location = new Point(365, 295);
            dgvMateriales.ClearSelection();
            dgvMateriales.CurrentCell = null;
            dgvMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMateriales.MultiSelect = false;

            listFamiliaMat.Visible = false;
            dgvMateriales.Columns[0].Visible = true;
        }

        private void botAceptarIngresoMat_Click(object sender, EventArgs e)
        {
            picboxFotoMat.Visible = true;

            botAceptarIngresoMat.Visible = false;
            botRecuaCargarFotoMat.Visible = true;
            botRecuaCargarFotoMat.Location = new Point(900, 903);
            botRecuaGuardarFotoMat.Visible = true;
            botRecuaGuardarFotoMat.Location = new Point(1200, 903);

            dgvMaterialesEnExistencia.Visible = false;
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

        private void dgvMateriales_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Buscar)
            {
            dgvMateriales.Location = new Point(180, 295);

            }
            else dgvMateriales.Location = new Point(40, 295);
            Insumos.Stock stock = new Insumos.Stock();
            string IdMaterial = dgvMateriales.CurrentRow.Cells[12].Value.ToString();
            stock.BuscarFotoPorIdMaterial(IdMaterial, picboxFotoMat);

            labTituloDgv.Location = new Point(392, 253);
            labTituloMat.Location = new Point(670, 152);

            picboxTituloDgv.Location = new Point(365, 237);
            picboxFotoMat.Visible = true;
            picboxRecuaBuscar.Visible = false;

            listFamiliaMat.Visible = false;

            botIngresarMat.Visible = true;
            botIngresarMat.Location = new Point(264, 940);
            botModificarMat.Visible = true;
            botModificarMat.Location = new Point(428, 940);
            botBuscarMat.Visible = true;
            botBuscarMat.Location = new Point(592, 940);
            botEliminarMat.Visible = true;
            botEliminarMat.Location = new Point(756, 940);
            botListarMat.Visible = true;
            botListarMat.Location = new Point(920, 940);
            botCancelarIngresoMat.Visible = true;
            botCancelarIngresoMat.Location = new Point(1687,933);
            botSalirMat.Visible = false;

            texFamiliaBuscar.Location = new Point(0, 314);

            botModificarMat.Enabled = true;
            botModificarMat.Font = new Font(botModificarMat.Font, FontStyle.Bold);
            botModificarMat.BackColor = SystemColors.ControlLight;
            botEliminarMat.Enabled = true;
            botEliminarMat.Font = new Font(botEliminarMat.Font, FontStyle.Bold);
            botEliminarMat.BackColor = SystemColors.ControlLight;
        }

        private void texNuevoFam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (texNuevoFam.Text != "")
                {
                    botGuardarFam.Focus();
                }
            }
        }

        private void botListarMat_Click(object sender, EventArgs e)
        {
            Buscar = false;
            labTituloDgv.Visible = false;

            texFamiliaBuscar.Visible = false;

            botIngresarMat.Visible = false;
            botModificarMat.Visible = false;
            botEliminarMat.Visible = false;
            botListarMat.Visible = false;
            botSalirMat.Visible = false;

            picboxTituloDgv.Visible = false;
            picboxFotoMat.Visible = false;
            picboxRecuaBuscar.Visible = false;
                       
            dgvMateriales.Visible = false;

            listFamiliaMat.Visible = false;

            frmListadosMat ListadoMat = new frmListadosMat(this);
            ListadoMat.Location = new Point(420, 200);
            ListadoMat.botSalirListaMat.Visible = true;
            ListadoMat.botSalirListaMat.Focus();

            ListadoMat.ShowDialog();
        }

        private void botSalirMat_Click(object sender, EventArgs e)
        {
            Buscar = false;
            this.Close();
        }

        private void picboxRecuaMat1_AutoSize()
        {
            // Código para ajustar el tamaño del PictureBox según el ComboBox
            int nuevoLargo = (listFamiliaMat.Items.Count * 18) + 5;
            picboxRecuaMat1.Height = nuevoLargo;
            picboxRecuadroGrande.Height = nuevoLargo;
            listFamiliaMat.Height = nuevoLargo;
            int botIngresarFamNuevoY = picboxRecuaMat1.Location.Y + nuevoLargo - 80;
            botIngresarFam.Location = new Point(botIngresarFam.Location.X, botIngresarFamNuevoY);
            botCancelarMat.Location = new Point(botCancelarMat.Location.X, botIngresarFamNuevoY);
            int heightLabFamiliaMat = 300 + (nuevoLargo / 2) - 12;
            labFamiliaMat.Location = new Point(837, heightLabFamiliaMat);
        }

        private void comboxColumnas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //texFamiliaBuscar.Text = comboxColumnas.Text;
            texFamiliaBuscar.Visible = true;

            picboxRecuaBuscar.Visible = false;

            MODELOS.FuncionesSeleccionMaterial FuncionesSel = new MODELOS.FuncionesSeleccionMaterial();
            FuncionesSel.llenarDGVSeleccionStock(dgvMateriales, texFamiliaBuscar);
        }

        private void botBuscarMat_Click(object sender, EventArgs e)
        {
            Buscar = true;
            labTituloDgv.Location = new Point(1220, 253);

            picboxFotoMat.Visible = false;
            picboxTituloDgv.Location = new Point(1193, 237);

            texFamiliaBuscar.Visible = true;
            texFamiliaBuscar.Location = new Point(135, 300);
            texFamiliaBuscar.Text = "FAMILIA";
            texFamiliaBuscar.BorderStyle = BorderStyle.None;

            botBuscarMat.Font = new Font(botBuscarMat.Font, FontStyle.Regular);
            botCancelarIngresoMat.Visible = true;
            botCancelarIngresoMat.Location = new Point(1687, 933);
            botSalirMat.Visible = false;

            listFamiliaMat.Location = new Point(135, 350);
            listFamiliaMat.Height = 300;
            listFamiliaMat.Width = 180;
            listFamiliaMat.Visible = true;

            dgvMateriales.Location = new Point(365, 295);
            dgvMateriales.Width = 1093;
            dgvMateriales.Columns[0].Visible = false;
            dgvMateriales.ClearSelection();
            dgvMateriales.CurrentCell = null;
            dgvMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMateriales.MultiSelect = false;
        }

        private void onINgresoFormClosed()
        {
            listFamiliaMat.Visible = true;
            listFamiliaMat.SelectedIndex = -1; // Resetea la selección
            picboxRecuaMat1.Visible = true;
            picboxRecuaTituloMat.Location = new Point(0, 0); // Ajusta la ubicación según sea necesario

            dgvMateriales.Location = new Point(465, 295);
        }

        private void listFamiliaMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NuevoModificacionOEliminacion == "Nuevo" && listFamiliaMat.SelectedIndex >= 0 && Buscar == false)
            {
                labIngresoMat.Location = new Point(940, 125);
                labIngresoMat.Font = new Font(labIngresoMat.Font.FontFamily, 20, FontStyle.Underline);
                labTituloMat.Location = new Point(970, 50);
                
                botIngresarFam.Visible = false;
                botCancelarMat.Visible = false;

                listFamiliaMat.Visible = false;

                picboxRecuaMat1.Visible = false;
                picboxRecuaTituloMat.Location = new Point(833, 128);

                System.Drawing.Size nuevoTamaño = new System.Drawing.Size(790, 304);
                dgvMaterialesEnExistencia.Size = nuevoTamaño;
                INSUMOS.frmIngreso Ingre = new INSUMOS.frmIngreso(this);
                Ingre.texFamilia.Text = listFamiliaMat.SelectedItem.ToString();
                Ingre.texGrupo.Select();
                Ingre.ShowDialog();
            } 
            else if (listFamiliaMat.SelectedIndex >= 0 && Buscar == true)
            {
                texFamiliaBuscar.Text = "FAMILIA";
                texFamiliaBuscar.Font = new Font(labFamiliaMat.Font, FontStyle.Underline);

                texFamiliaBuscar.Text = listFamiliaMat.SelectedItem.ToString();
                texFamiliaBuscar.Location = new Point(138,400);
                MODELOS.FuncionesSeleccionMaterial FuncionesSel = new MODELOS.FuncionesSeleccionMaterial();
                FuncionesSel.llenarDGVSeleccionStock(dgvMateriales, texFamiliaBuscar);
            }
            listFamiliaMat.Visible = false;

            dgvMateriales.ClearSelection();
            dgvMateriales.CurrentCell = null;
            dgvMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMateriales.MultiSelect = false;
        }
         
        private void texFamiliaBuscar_Click(object sender, EventArgs e)
        {
            listFamiliaMat.Visible = true;
            picboxFotoMat.Visible = false;
            texFamiliaBuscar.Visible = true ;
            texFamiliaBuscar.Text = "FAMILIA";
            texFamiliaBuscar.Font = new Font(texFamiliaBuscar.Font.FontFamily, 18, FontStyle.Bold | FontStyle.Underline);
            texFamiliaBuscar.Location = new Point(135, 300);

            dgvMateriales.ClearSelection();
            dgvMateriales.CurrentCell = null;
            dgvMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMateriales.MultiSelect = false;
            dgvMateriales.Location = new Point(365, 295);
        }

    }
}

