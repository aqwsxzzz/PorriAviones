using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace _1.MODELOS
{
    public partial class frmModelos : Form
    {
        byte[] imageByte;

                                     private PrintDocument printDocument1 = new PrintDocument();  //para imprimir
                                     private PrintDialog printDialog1 = new PrintDialog();   //para imprimir

        private frmListadoMod LisMo;

        private string estadoRecibido = null;
        public string EstadoRecibido
        {
            get { return null; }
            set
            {
                if (estadoRecibido != value)
                {
                    estadoRecibido = value;
                    // Do something when the received text changes
                    DoSomethingWithReceivedText();
                }
            }
        }
        
        private void DoSomethingWithReceivedText()
        {
            texEstadoMod.Text = EstadoRecibido;
        }

        List<string> ColumnasDatosAModificar = new List<string>();
        List<string> DatosAModificar = new List<string>();

        //Id de modelo en modificacion
        public string IdModeloEnModificacion = "";

        //Nuevo Modelo
        public List<string> ListaMateriales = new List<string>();
        public List<string> CantidadDeMaterial = new List<string>();
        public List<string> CantidadDisponibleActualizada = new List<string>();

        //Modificacion de cantidad de material ya usado en un modelo.
        public List<string> NuevaCantidadxModelo = new List<string>();
        public List<string> texCantidadVieja = new List<string>();
        public List<string> IdMaterial = new List<string>();

        //Eliminacion de material reciclable
        public List<string> CantidadUsadaDeMaterialMod = new List<string>();
        public List<string> IdMaterialReciclableAEliminarMod = new List<string>();
        public List<string> IdAcopioDeMaterialReciblableAEliminarMod = new List<string>();


        //Eliminacion de material no reciclable
        public List<string> IdMaterialNoReciclableAEliminarMod = new List<string>();

        public void ActualizarListaIdAcopio(List<string> nuevaLista)
        {
            ListaMateriales = nuevaLista;
        }

        public string NuevoOModificacion = "";

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CantidadDeMaterial[0].ToString(), (CantidadDeMaterial[1].ToString() + CantidadDeMaterial[2].ToString()));
        }

        public frmModelos()
        {
            InitializeComponent();
           
            this.Load += frmModelos_Load;
            picboxFotoMod.BorderStyle = BorderStyle.None;

            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);  // Asociar el evento PrintPage con el controlador de eventos
            this.botImprimirMod.Click += new System.EventHandler(this.botImprimirMod_Click);

            dgvModelos1.AutoGenerateColumns = false;

            dgvModelos1.ColumnCount = 5;
            dgvModelos1.Columns[0].Name = "Modelo";
            dgvModelos1.Columns[0].HeaderText = "          Modelo";
            dgvModelos1.Columns[0].DataPropertyName = "Modelo";

            dgvModelos1.Columns[1].Name = "Alias";
            dgvModelos1.Columns[1].HeaderText = "          Alias";
            dgvModelos1.Columns[1].DataPropertyName = "Alias";

            dgvModelos1.Columns[2].Name = "Estado";
            dgvModelos1.Columns[2].HeaderText = "        Estado";
            dgvModelos1.Columns[2].DataPropertyName = "Estado";

            dgvModelos1.Columns[3].Name = "Desde";
            dgvModelos1.Columns[3].HeaderText = "          Desde   ";
            dgvModelos1.Columns[3].DataPropertyName = "Desde";
            dgvModelos1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;

            dgvModelos1.Columns[4].Name = "IdModelo";
            dgvModelos1.Columns[4].HeaderText = "          IdModelo   ";
            dgvModelos1.Columns[4].DataPropertyName = "IdModelo";
            dgvModelos1.Columns[4].Visible = false;

            dgvModelos1.BackgroundColor = Color.Bisque;  //  Color del fondo del dgv
            dgvModelos1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128); //  Color de las cabeceras de las columnas
            dgvModelos1.DefaultCellStyle.SelectionBackColor = Color.IndianRed;
            dgvModelos1.ClearSelection();
           // dgvModelos1.CellClick += DgvModelos1_CellClick;
            dgvModelos1.Location = new Point(740, 300);

            dgvDatosSelecciondos.ColumnCount = 10;

            dgvDatosSelecciondos.Columns[0].Name = "Familia";
            dgvDatosSelecciondos.Columns[0].HeaderText = "          Familia";
            dgvDatosSelecciondos.Columns[0].DataPropertyName = "Familia";

            dgvDatosSelecciondos.Columns[1].Name = "Grupo";
            dgvDatosSelecciondos.Columns[1].HeaderText = "          Grupo";
            dgvDatosSelecciondos.Columns[1].DataPropertyName = "Grupo";

            dgvDatosSelecciondos.Columns[2].Name = "Caracteristica";
            dgvDatosSelecciondos.Columns[2].HeaderText = " Caracteristica";
            dgvDatosSelecciondos.Columns[2].DataPropertyName = " Caracteristica";

            dgvDatosSelecciondos.Columns[3].Name = "Medidas";
            dgvDatosSelecciondos.Columns[3].HeaderText = "        Medidas";
            dgvDatosSelecciondos.Columns[3].DataPropertyName = "Medidas";

            dgvDatosSelecciondos.Columns[4].Name = "Codigo";
            dgvDatosSelecciondos.Columns[4].HeaderText = "          Codigo";
            dgvDatosSelecciondos.Columns[4].DataPropertyName = "Codigo";

            dgvDatosSelecciondos.Columns[5].Name = "Fabricante";
            dgvDatosSelecciondos.Columns[5].HeaderText = "      Fabricante";
            dgvDatosSelecciondos.Columns[5].DataPropertyName = "Fabricante";

            dgvDatosSelecciondos.Columns[6].Name = "CantidadSeleccionada";
            dgvDatosSelecciondos.Columns[6].HeaderText = "Cant.Sel";
            dgvDatosSelecciondos.Columns[6].DataPropertyName = "CantidadSeleccionada";
            dgvDatosSelecciondos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;

            dgvDatosSelecciondos.Columns[7].Name = "Cantidad";
            dgvDatosSelecciondos.Columns[7].HeaderText = " Cantidad";
            dgvDatosSelecciondos.Columns[7].DataPropertyName = "Cantidad";
            dgvDatosSelecciondos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;

            dgvDatosSelecciondos.Columns[8].Name = "Tipo";
            dgvDatosSelecciondos.Columns[8].HeaderText = "     Tipo";
            dgvDatosSelecciondos.Columns[8].DataPropertyName = "Tipo";

            dgvDatosSelecciondos.Columns[9].Name = "IdAcopio";
            dgvDatosSelecciondos.Columns[9].HeaderText = "        IdAcopio";
            dgvDatosSelecciondos.Columns[9].DataPropertyName = "IdAcopio";
            dgvDatosSelecciondos.Columns[9].Visible = false;
 
            int AnchoCant1 = 60;
            DataGridViewColumn columna7 = dgvDatosSelecciondos.Columns[4];
            columna7.Width = AnchoCant1;

            dgvDatosSelecciondos.AllowUserToAddRows = false;
            dgvDatosSelecciondos.Width = 750;
            dgvDatosSelecciondos.Height = 320;
            dgvDatosSelecciondos.Location = new Point(335, 500);

            Modelos.Aeronaves aeronaves = new Modelos.Aeronaves();
            aeronaves.mostrarModelos(dgvModelos1);

            dgvMaterialesenModificacion.AutoGenerateColumns = false;
            dgvMaterialesenModificacion.ColumnCount = 11;

            dgvMaterialesenModificacion.Columns[0].Name = "Familia";
            dgvMaterialesenModificacion.Columns[0].HeaderText = "          Familia";
            dgvMaterialesenModificacion.Columns[0].DataPropertyName = "Familia";

            dgvMaterialesenModificacion.Columns[1].Name = "Grupo";
            dgvMaterialesenModificacion.Columns[1].HeaderText = "         Grupo";
            dgvMaterialesenModificacion.Columns[1].DataPropertyName = "Grupo";

            dgvMaterialesenModificacion.Columns[2].Name = "Caracteristica";
            dgvMaterialesenModificacion.Columns[2].HeaderText = " Caracteristica";
            dgvMaterialesenModificacion.Columns[2].DataPropertyName = "Caracteristica";

            dgvMaterialesenModificacion.Columns[3].Name = "Medidas";
            dgvMaterialesenModificacion.Columns[3].HeaderText = "       Medidas";
            dgvMaterialesenModificacion.Columns[3].DataPropertyName = "Medidas";

            dgvMaterialesenModificacion.Columns[4].Name = "Codigo";
            dgvMaterialesenModificacion.Columns[4].HeaderText = "        Codigo";
            dgvMaterialesenModificacion.Columns[4].DataPropertyName = "Codigo";

            dgvMaterialesenModificacion.Columns[5].Name = "Fabricante";
            dgvMaterialesenModificacion.Columns[5].HeaderText = "     Fabricante";
            dgvMaterialesenModificacion.Columns[5].DataPropertyName = "Fabricante";
            dgvMaterialesenModificacion.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMaterialesenModificacion.Columns[6].Name = "CantidadxModelo";
            dgvMaterialesenModificacion.Columns[6].HeaderText = "CantxMod";
            dgvMaterialesenModificacion.Columns[6].DataPropertyName = "CantidadxModelo";
            dgvMaterialesenModificacion.Columns[6].Width = 60;
            dgvMaterialesenModificacion.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight ;
            
            dgvMaterialesenModificacion.Columns[7].Name = "Tipo";
            dgvMaterialesenModificacion.Columns[7].HeaderText = "      Tipo";
            dgvMaterialesenModificacion.Columns[7].DataPropertyName = "Tipo";
            dgvMaterialesenModificacion.Columns[7].Width = 70;
    
            dgvMaterialesenModificacion.Columns[8].Name = "IdMaterial";
            dgvMaterialesenModificacion.Columns[8].HeaderText = "IdMaterial";
            dgvMaterialesenModificacion.Columns[8].DataPropertyName = "IdMaterial";
            //dgvMaterialesenModificacion.Columns[8].Visible = false;

            dgvMaterialesenModificacion.Columns[9].Name = "IdMaterialesModelo";
            dgvMaterialesenModificacion.Columns[9].HeaderText = "IdMaterialesModelo";
            dgvMaterialesenModificacion.Columns[9].DataPropertyName = "IdMaterialesModelo";
            //dgvMaterialesenModificacion.Columns[9].Visible = false;

            dgvMaterialesenModificacion.Columns[10].Name = "IdAcopio";
            dgvMaterialesenModificacion.Columns[10].HeaderText = "IdAcopio";
            dgvMaterialesenModificacion.Columns[10].DataPropertyName = "IdAcopio";
            //dgvMaterialesenModificacion.Columns[10].Visible = false;


            // dgvMaterialesenModificacion.BackgroundColor = Color.Blue;

            botModificarMod.Enabled = false;
            botEliminarMod.Enabled = false;
        }
                
        private void dgvModelos1_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada y si es la primera fila
            if (dgvModelos1.SelectedRows.Count > 0 && dgvModelos1.SelectedRows[0].Index == 0)
            {
                // Desseleccionar la primera fila
                dgvModelos1.ClearSelection();
            }
        }

        private void botSalirMod_Click(object sender, EventArgs e)
        {
            MODELOS.frmEstadoAviones Est = new MODELOS.frmEstadoAviones(this);
            Est.Close();
           
            this.Close();
        }

        private void botRecuaCancelarMod_Click(object sender, EventArgs e)
        {
            labIngresoMod.Visible = false;
            labModificaMod.Visible = false;
            labEliminaMod.Visible = false;
            labBajaMod.Visible = false;
            labModeloMod.Visible = false;
            labAliasMod.Visible = false;
            labEstadoMod.Visible = false;
            labDesdeMod.Visible = false;
            labRecuaMotoresMod.Visible = false;

            texModeloMod.Focus();
            texModeloMod.Text = "";
            texAliasMod.Text = "";
            texModeloMod.Text = "";
            texEstadoMod.Text = "";
            texDesdeMod.Text = "";
            texModeloMod.Visible = false;
            texAliasMod.Visible = false;
            texEstadoMod.Visible = false;
            texDesdeMod.Visible = false;
            texModelodgv.Visible = false;
            texAliasdgv.Visible = false;

            picboxRecuaMod3.Visible = false;
            picboxRecuaMod4.Visible = false;
            picboxRecuaMotoresMod.Visible = false;

            botCargarFotoMod.Visible = false;
            botGuardarMod.Visible = false;
            botCancelarMod.Visible = false;
            botIngresarMaterialMod.Visible = false;
            botSalirMod.Visible = true;
            botIngresarMod.Visible = true;
            botModificarMod.Visible = true;
            botModificarMod.Enabled = false;
            botEliminarMod.Visible = true;
            botEliminarMod.Enabled = false;
            botListadoMod.Visible = true;
            botImprimirMod.Visible =false;
            
            dgvDatosSelecciondos.Visible = false;
            dgvModelos1.Visible = true;
            dgvModelos1.ClearSelection();
            dgvModelos1.Location = new Point(700, 400);
            dgvMaterialesenModificacion.Visible = false;
            
            picboxRecuaEstadoFecha.Visible = false;
            picboxRecuaModeloAlias.Visible = false;
            picboxFotoMod.Visible = false;
            picboxRecuaIngreso.Visible = false;
           
            dattimFechaMod.Visible = false;
        }
        private void botIngresarMod_Click(object sender, EventArgs e)
        {
            labIngresoMod.Visible = true;
            labModificaMod.Visible = false;
            labEliminaMod.Visible = false;
   
            botIngresarMaterialMod.Text = "AGREGAR MATERIAL";
            botIngresarMaterialMod.Font = new Font(botIngresarMaterialMod.Font, FontStyle.Bold);
            botIngresarMaterialMod.Font = new Font(botIngresarMaterialMod.Font.FontFamily, 9);

            labIngresoMod.Location = new Point(1119, 374);
            labIngresoMod.BackColor = Color.Tan;
            labModeloMod.Visible = true;
            labModeloMod.Location = new Point(630, 428);
            labModeloMod.BackColor = Color.Tan ;
            labAliasMod.Location = new Point(880, 428);
            labAliasMod.BackColor = Color.Tan ;
            
            texModeloMod.Text = "";
            texAliasMod.Text = "";
            texModeloMod.Text = "";
            texEstadoMod.Text = "";
            texDesdeMod.Text = "";

            texModeloMod.Visible = true;
            texModeloMod.Focus();
            texModelodgv.Visible = false;
            texModeloMod.BackColor = Color.AntiqueWhite;
            texModeloMod.Location = new Point(630, 450);
            texModeloMod.ForeColor = Color.Black;
            texModeloMod.BorderStyle = BorderStyle.Fixed3D;
            texAliasMod.BackColor = Color.AntiqueWhite;
            texAliasMod.Location = new Point(880, 450);
            texAliasMod.ForeColor = Color.Black;
            texAliasMod.BorderStyle = BorderStyle.Fixed3D;

            botCancelarMod.Visible = true;
            botCancelarMod.Location = new Point(1310, 650);
            botSalirMod.Visible = false;
            botModificarMod.Visible = false;
            botEliminarMod.Visible = false;
            botListadoMod.Visible = false;
            botIngresarMod.Visible = false;
            botIngresarMaterialMod.Location = new Point(1150, 447);

            picboxRecuaMod3.Visible = true;
            picboxRecuaMod3.BackColor = Color.Tan ;
            picboxRecuaMod3.Location = new Point(580, 406);
            picboxRecuaMod3.Size = new System.Drawing.Size(751, 123);
            picboxFotoMod.Visible = false;
            picboxRecuaMod4.Visible = true;
            picboxRecuaMod4.Location = new Point(1078, 362);
            picboxRecuaMod4.BackColor = Color.Tan;
            picboxRecuaIngreso.Visible = true;
            picboxRecuaIngreso.Location = new Point(480, 320);
            picboxRecuaIngreso.Width = 965;
            picboxRecuaIngreso.Height = 300;
                
   
            dgvModelos1.Visible = false;
            dgvModelos1.Location = new Point(478, 285);

            NuevoOModificacion = "Nuevo";
            dgvDatosSelecciondos.Rows.Clear();
        }

        private void botModificarMod_Click(object sender, EventArgs e)
        {
            labModificaMod.Visible = true;
            labIngresoMod.Visible = false;
            labEliminaMod.Visible = false;
            labModeloMod.Visible = true;
            labModeloMod.BackColor = Color.Tan ;
            labModeloMod.Location = new Point(534, 286);
            labAliasMod.Visible = true;
            labAliasMod.BackColor = Color.Tan;
            labAliasMod.Location = new Point(760, 286);
            labEstadoMod.Visible = true;
            labEstadoMod.BackColor = Color.Tan;
            labDesdeMod.Visible = true;
            labDesdeMod.BackColor = Color.Tan;

            texModeloMod.Text = "";
            texAliasMod.Text = "";
            texModeloMod.Text = "";
            texEstadoMod.Text = "";
            texDesdeMod.Text = "";
            texModeloMod.Visible = true;
            texModeloMod.BackColor = Color.Tan;
            texModeloMod.Location = new Point (534, 305);
            texAliasMod.Visible = true;
            texAliasMod.BackColor = Color.Tan;
            texAliasMod.Location = new Point(760, 305);
            texEstadoMod.Visible = true;
            texModeloMod.Focus();

            botSalirMod.Visible = false;
            botCargarFotoMod.Visible = false;
            botIngresarMaterialMod.Text = "Modificar Material";

            picboxRecuaMod4.Visible = true;

            if (dgvModelos1.Rows.Count <= 0)
            {
                labModeloMod.Visible = false;
                labAliasMod.Visible = false;
                labEstadoMod.Visible = false;
                labDesdeMod.Visible = false;

                texModeloMod.Visible = false;
                texAliasMod.Visible = false;
                texEstadoMod.Visible = false;
                texDesdeMod.Visible = false;

                MessageBox.Show("No hay datos para mostrar");
               
                botIngresarMod.Visible = false;
                botEliminarMod.Visible = false;
                botListadoMod.Visible = false;
            }
            else
            {
                texModeloMod.Text = dgvModelos1.CurrentRow.Cells[0].Value.ToString();
                texModeloMod.BorderStyle = BorderStyle.None;
                texAliasMod.Text = dgvModelos1.CurrentRow.Cells[1].Value.ToString();
                texAliasMod.BorderStyle = BorderStyle.None;
                texEstadoMod.Text = dgvModelos1.CurrentRow.Cells[2].Value.ToString();
                texDesdeMod.Text = dgvModelos1.CurrentRow.Cells[3].Value.ToString();
                texDesdeMod.Visible = true;
                texDesdeMod.Location = new Point(910, 724);
                texDesdeMod.BorderStyle = BorderStyle.None;
                texDesdeMod.BackColor = Color.Tan ;
                texDesdeMod.Font = new Font(texDesdeMod.Font.FontFamily, 18);

                picboxRecuaMod3.Visible = true;
                picboxRecuaMod4.Visible = true;
                picboxRecuaMod4.Location = new Point(908, 213);
                picboxRecuaMod4.BackColor = Color.Bisque;

                botIngresarMod.Visible = false;
                botEliminarMod.Visible = false;
                botListadoMod.Visible = false;

                dgvModelos1.Visible = false;

                MODELOS.FuncListadoMateriales FuncListMat = new MODELOS.FuncListadoMateriales();
                FuncListMat.mostrarMaterialesxModeloSinTotal(dgvMaterialesenModificacion, dgvModelos1.CurrentRow.Cells[4].Value.ToString());

                dgvMaterialesenModificacion.Location = new Point(437, 370);
                dgvMaterialesenModificacion.Visible = true;
                dgvMaterialesenModificacion.Width =757;
                dgvMaterialesenModificacion.Height = 332;
                dgvMaterialesenModificacion.ClearSelection();
                dgvMaterialesenModificacion.CurrentCell = null;
                dgvMaterialesenModificacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvMaterialesenModificacion.MultiSelect = false;

                picboxRecuaModeloAlias.Visible = true;
                picboxRecuaModeloAlias.Height = 72;
                picboxRecuaModeloAlias.Location = new Point(498,280);
                picboxRecuaModeloAlias.Width = 460;
                picboxRecuaModeloAlias.BackColor = Color.Tan;
                picboxRecuaMod3.Location = new Point(402, 257);
                picboxRecuaMod3 .Width=810;
                picboxRecuaMod3.Height = 550;
                picboxRecuaMod3.BackColor = Color.Tan;
                picboxRecuaMod4.Location = new Point(959,213);
                picboxRecuaEstadoFecha.Visible = true;
                picboxRecuaEstadoFecha.Location = new Point(561, 707);
                picboxRecuaEstadoFecha.Width = 490; 
                picboxRecuaEstadoFecha.BackColor = Color.Tan;

                labEstadoMod.Visible = true;
                labEstadoMod.Location = new Point(593, 730);
                labDesdeMod.Visible = true;
                labDesdeMod.Location = new Point(834, 730);

                texEstadoMod.Location = new Point(665, 729);
                texEstadoMod.BackColor = Color.Tan;
                
                dattimFechaMod.Location = new Point(910, 727);
                dattimFechaMod.BringToFront();

                botIngresarMaterialMod.Visible = true;
                botIngresarMaterialMod.Location = new Point(1021, 298);
                botCancelarMod.Location = new Point(1079, 829);
                botCancelarMod.Visible = true;
                botCargarFotoMod.Visible = true;
                botCargarFotoMod.Location = new Point(401, 830);
                botCargarFotoMod.Text = "MODIFICAR FOTO";
                botGuardarMod.Visible = true;
                botGuardarMod.Location = new Point(900, 830);                
            }
                NuevoOModificacion = "Modificacion";
                IdModeloEnModificacion = dgvModelos1.CurrentRow.Cells[4].Value.ToString();
                botModificarMod.Visible = false;
                botGuardarMod.Text = "GUARDAR CAMBIOS";
                botGuardarMod.Visible = false;
        }

        private void botEliminarMod_Click(object sender, EventArgs e)
        {
            NuevoOModificacion = "Eliminacion";
            frmEliminar frmEliminar = new frmEliminar(this);
            FuncionesEliminar FuncionesEliminar = new FuncionesEliminar();

            FuncionesEliminar.mostrarMateriales(frmEliminar.dgvListaMateriales, dgvModelos1.CurrentRow.Cells[4].Value.ToString());

            frmEliminar.Show();
            frmEliminar . Location = new Point(160, 300);
            botSalirMod.Visible = false;
            botIngresarMod.Visible = false;
            botModificarMod.Visible = false;
            botEliminarMod.Visible = false;
            botListadoMod.Visible = false;
        }

        private void texModeloMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                texModeloMod.BackColor = Color.Tan ;
                texModeloMod.ForeColor = Color.Black;
                texModeloMod.BorderStyle = BorderStyle.None;

                labAliasMod.Visible = true;
                texAliasMod.Visible = true;
                texAliasMod.Focus();
                texAliasMod.BorderStyle = BorderStyle.FixedSingle;
                texAliasMod.ForeColor = Color.Black;
            }
        }

        private void texAliasMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                texAliasMod.BackColor = Color.Tan ;
                texAliasMod.BorderStyle = BorderStyle.None;

                botIngresarMaterialMod.Visible = true;

                botIngresarMaterialMod.Focus();
            }
        }

        private void texEstadoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            texEstadoMod.Focus();
        }

        SqlConnection conexion = new SqlConnection();

        private void botRecuaGuardarMod_Click(object sender, EventArgs e)
        {
            if (NuevoOModificacion == "Nuevo")
            {
                string[] acopiosArray = ListaMateriales.ToArray();
                string[] cantidadArray = CantidadDeMaterial.ToArray();
                string[] cantidadDisponibleActualizadaArray = CantidadDisponibleActualizada.ToArray();
                Modelos.Aeronaves objetostock = new Modelos.Aeronaves();
                objetostock.GuardarModelos(texModeloMod, texAliasMod, texEstadoMod, texDesdeMod, imageByte, acopiosArray, cantidadArray, cantidadDisponibleActualizadaArray);
                objetostock.mostrarModelos(dgvModelos1);

                botIngresarMod.Visible = true;
                botModificarMod.Visible = true;
                botModificarMod.Enabled = false;
                botEliminarMod.Visible = true;
                botEliminarMod.Enabled = false;
                botListadoMod.Visible = true;
                botSalirMod.Visible = true;
            }
            else if (NuevoOModificacion == "Modificacion")
            {
                if (texModeloMod.Text != dgvModelos1.CurrentRow.Cells[0].Value.ToString())
                {
                    ColumnasDatosAModificar.Add(labModeloMod.Text);
                    DatosAModificar.Add(texModeloMod.Text);
                }
                if (texAliasMod.Text != dgvModelos1.CurrentRow.Cells[1].Value.ToString())
                {
                    ColumnasDatosAModificar.Add(labAliasMod.Text);
                    DatosAModificar.Add(texAliasMod.Text);
                }
                if (texEstadoMod.Text != dgvModelos1.CurrentRow.Cells[2].Value.ToString())
                {
                    ColumnasDatosAModificar.Add(labEstadoMod.Text);
                    DatosAModificar.Add(texEstadoMod.Text);
                }
                if (texDesdeMod.Text != dgvModelos1.CurrentRow.Cells[3].Value.ToString())
                {
                    ColumnasDatosAModificar.Add("Desde");
                    DatosAModificar.Add(texDesdeMod.Text);
                }
                string[] Columnas = ColumnasDatosAModificar.ToArray();
                string[] Datos = DatosAModificar.ToArray();
                Modelos.Aeronaves Aeronaves = new Modelos.Aeronaves();
                Aeronaves.ModificarModelo(Columnas, Datos, dgvModelos1.CurrentRow.Cells[4].Value.ToString(), imageByte);
                if (ListaMateriales.Count > 0)
                {
                    Aeronaves.GuardarMaterialesXModeloEnModificacion(ListaMateriales, CantidadDeMaterial, CantidadDisponibleActualizada, IdModeloEnModificacion);
                }
                botIngresarMod.Visible = true;
                botModificarMod.Visible = true;
                botModificarMod.Enabled = false;
                botEliminarMod.Visible = true;
                botEliminarMod.Enabled = false;
                botListadoMod.Visible = true;

                if (IdMaterialReciclableAEliminarMod.Count > 0)
                {
                    for (int i = 0; i < IdMaterialReciclableAEliminarMod.Count; i++)
                    {
                        Aeronaves.DevolverMaterialReciclable(IdMaterialReciclableAEliminarMod[i], CantidadUsadaDeMaterialMod[i], IdAcopioDeMaterialReciblableAEliminarMod[i]);
                    }
                }
                if (IdMaterialNoReciclableAEliminarMod.Count > 0)
                {
                    for (int i = 0; i < IdMaterialNoReciclableAEliminarMod.Count; i++)
                    {
                        string Cantidad = "0";
                        string IdAcopio = "No Reciclable";
                        Aeronaves.DevolverMaterialReciclable(IdMaterialNoReciclableAEliminarMod[i], Cantidad, IdAcopio);
                    }

                }
            }
            labIngresoMod.Visible = false;
            labModificaMod.Visible = false;
            labEliminaMod.Visible = false;

            labModeloMod.Visible = false;
            labAliasMod.Visible = false;
            labEstadoMod.Visible = false;
            labDesdeMod.Visible = false;
            labRecuaMotoresMod.Visible = false;

            texModeloMod.Focus();

            texModeloMod.Text = "";
            texAliasMod.Text = "";
            texModeloMod.Text = "";
            texEstadoMod.Text = "";
            texDesdeMod.Text = "";

            texModeloMod.Visible = false;
            texAliasMod.Visible = false;
            texEstadoMod.Visible = false;
            texDesdeMod.Visible = false;

            botCargarFotoMod.Visible = false;
            botGuardarMod.Visible = false;
            botCancelarMod.Visible = false;
            botIngresarMaterialMod.Visible = false;
            botSalirMod.Visible = true;

            picboxRecuaMod3.Visible = false;
            picboxRecuaMod4.Visible = false;
            picboxRecuaMotoresMod.Visible = false;
            picboxRecuaModeloAlias.Visible = false;
            picboxRecuaEstadoFecha.Visible = false;
            picboxFotoMod.Visible = false;
          
            dattimFechaMod.Visible = false;
            
            dgvModelos1.Visible = true;
            dgvModelos1.Location = new Point(740, 300);
            dgvModelos1.ClearSelection();
            dgvModelos1.CurrentCell = null;
            dgvModelos1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvModelos1.MultiSelect = false;
            dgvDatosSelecciondos.Visible = false;
            dgvMaterialesenModificacion.Visible = false;
           
            Modelos.Aeronaves aeronaves = new Modelos.Aeronaves();
            aeronaves.mostrarModelos(dgvModelos1);

            dgvModelos1.ClearSelection();
            dgvModelos1.CurrentCell = null;
            dgvModelos1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvModelos1.MultiSelect = false;

        }

        private void botIngresarMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                texModeloMod.Focus();
            }
        }

        private void dgvModelos1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Modelos.Aeronaves aero = new Modelos.Aeronaves();

            botModificarMod.Enabled = true ;
            botModificarMod.BackColor = SystemColors.ControlLightLight;
            botModificarMod.ForeColor  = Color.Black;
            botModificarMod.FlatStyle = FlatStyle.Popup;
            botEliminarMod.Enabled = true ;
            botEliminarMod .BackColor = SystemColors.ControlLightLight;
            botEliminarMod.ForeColor = Color.Black;
            botEliminarMod.FlatStyle = FlatStyle.Popup;

            picboxFotoMod.Visible = true;
            string IdModelo = dgvModelos1.CurrentRow.Cells[4].Value.ToString();
            aero.BuscarFotoPorIdModelo(IdModelo, picboxFotoMod);
        }

        private void botIngresarMaterialMod_Click(object sender, EventArgs e)
        {
            MODELOS.SeleccionMaterialMod SeleccionMat = new MODELOS.SeleccionMaterialMod(this);
            labTituloMod.Location = new Point(872,50);
                                
            botSalirMod.Visible = false;
            botIngresarMod.Visible = false;
            botCargarFotoMod.Visible = false;
            botCancelarMod.Visible = false;
            SeleccionMat.botSalirSel.Visible = true;
            SeleccionMat.botSalirSel.Location = new Point(805, 835);
            SeleccionMat.botAceptarSel.Focus();

            picboxRecuaMod3.Visible = false;
            picboxRecuaMod4.Location = new Point(1023,114);
            picboxRecuaMod4.BackColor = Color.Bisque;
            picboxRecuaIngreso.Visible = false;

            dgvModelos1.Visible = false;
            dgvMaterialesenModificacion.Visible = false;
            SeleccionMat.dgvMaterialesSeleccionadosSel.Visible = false;
            if (NuevoOModificacion == "Nuevo")
            {
                labIngresoMod.Visible = true;
                labIngresoMod.Location = new Point(1065, 125);
                labIngresoMod.BackColor = Color.Bisque;

                if (dgvDatosSelecciondos.Rows.Count > 0)
                {
                // Copia los datos de dataGridView1 a dataGridView2
                foreach (DataGridViewRow row in dgvDatosSelecciondos.Rows)
                {
                    if (!row.IsNewRow) // Asegúrate de no copiar la fila de edición si está habilitada
                    {
                        int rowIndex = SeleccionMat.dgvMaterialesSeleccionadosSel.Rows.Add();
                        for (int columnIndex = 0; columnIndex < dgvDatosSelecciondos.Columns.Count; columnIndex++)
                        {
                            SeleccionMat.dgvMaterialesSeleccionadosSel.Rows[rowIndex].Cells[columnIndex].Value = row.Cells[columnIndex].Value;
                        }
                    }
                }
                SeleccionMat.dgvMaterialesSeleccionadosSel.Visible = true;
                SeleccionMat.dgvMaterialesSeleccionadosSel.ClearSelection();
                SeleccionMat.dgvMaterialesSeleccionadosSel.CurrentCell = null;
                SeleccionMat.dgvMaterialesSeleccionadosSel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                SeleccionMat.dgvMaterialesSeleccionadosSel.MultiSelect = false;
                }
                botIngresarMaterialMod.Visible = false;
            }
            else if (NuevoOModificacion == "Modificacion")
            {
                labModificaMod.Visible = true;
                labModificaMod .Location = new Point(1040, 125);
                // Copia los datos de dataGridView1 a dataGridView2
                foreach (DataGridViewRow row in dgvMaterialesenModificacion.Rows)
                {
                    if (!row.IsNewRow) // Asegúrate de no copiar la fila de edición si está habilitada
                    {
                        int rowIndex = SeleccionMat.dgvMaterialesSeleccionadosSel.Rows.Add();
                        for (int columnIndex = 0; columnIndex < dgvMaterialesenModificacion.Columns.Count; columnIndex++)
                        {
                            SeleccionMat.dgvMaterialesSeleccionadosSel.Rows[rowIndex].Cells[columnIndex].Value = row.Cells[columnIndex].Value;
                        }
                    }
                }
                SeleccionMat.dgvMaterialesSeleccionadosSel.Visible = true;
                SeleccionMat.dgvMaterialesSeleccionadosSel.ClearSelection();
                SeleccionMat.dgvMaterialesSeleccionadosSel.CurrentCell = null;
                SeleccionMat.dgvMaterialesSeleccionadosSel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                SeleccionMat.dgvMaterialesSeleccionadosSel.MultiSelect = false;
            }
        SeleccionMat.ShowDialog();
        picboxFotoMod.BringToFront();
        }

        // Manejar la información recibida del formulario secundario
        private void ActualizarInformacion(string nuevaInformacion)
        {
            ListaMateriales.Add(nuevaInformacion);
        }

        private void dattimFechaMod_ValueChanged(object sender, EventArgs e)
        {
            botCargarFotoMod.Visible = true;
            botGuardarMod.Visible = true;
            texModeloMod.BorderStyle = BorderStyle.None;

            string textoACortar = dattimFechaMod.Value.Date.ToString();
            int indiceEspacio = textoACortar.IndexOf(' ');

            texDesdeMod.Location = new Point(910,724);
            texDesdeMod.BorderStyle = BorderStyle.None;
            texDesdeMod.Font = new Font(texDesdeMod.Font.FontFamily, 16);

            if (indiceEspacio != -1)
            {
                // Utiliza el método Substring para obtener la parte del texto antes del primer espacio
                string textoCortado = textoACortar.Substring(0, indiceEspacio);
                texDesdeMod.Text = textoCortado;
                texDesdeMod.Visible = true;
                dattimFechaMod.Visible = false;
            }
        }

        private void botRecuaCargarFotoMod_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialogo = new OpenFileDialog();
            DialogResult resultado = Dialogo.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                picboxFotoMod.Image = Image.FromStream(Dialogo.OpenFile());
                MemoryStream memoria = new MemoryStream();
                picboxFotoMod.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageByte = memoria.ToArray();
                botGuardarMod.Visible = true;
                botGuardarMod.Focus();
                picboxFotoMod.Visible = true;
            }
            botGuardarMod.Focus();
        }

        private void botRecuaCargarFotoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

            }
        }

        private void dgvModelos1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MODELOS.ListadoMateriales ListadoMateriales = new MODELOS.ListadoMateriales();

            MODELOS.FuncListadoMateriales FuncListMat = new MODELOS.FuncListadoMateriales();
            FuncListMat.mostrarMaterialesxModelo(ListadoMateriales.dgvListadoMaterialesLis, dgvModelos1.CurrentRow.Cells[4].Value.ToString(), ListadoMateriales.texTotal);
            ListadoMateriales.Location = new Point(430, 350);
            ListadoMateriales.Show();

            botIngresarMod.Visible = false;
            botModificarMod.Visible = false;
            botEliminarMod.Visible = false;
            botListadoMod.Visible = false;
            botSalirMod.Visible = true;
            botImprimirMod.Visible = true;
            botImprimirMod.Location = new Point(850, 950);
                  
            // Verificar si se hizo clic en una celda válida
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener el valor de la celda seleccionada
                object valorCelda = dgvModelos1.Rows[e.RowIndex].Cells[0].Value;
                // Obtener el valor de la segunda celda seleccionada (columna 1)
                object valorCeldaAlias = dgvModelos1.Rows[e.RowIndex].Cells[1].Value;

                // Asignar el valor al TextBox
                texModelodgv.Text = valorCelda?.ToString();
                texAliasdgv.Text = valorCeldaAlias?.ToString();

                texModelodgv.Visible = true;
                texModelodgv.Location = new Point(620, 250);
                texModelodgv.Size = new Size(200, 40);
                texModelodgv.Font = new Font(texModelodgv.Font.FontFamily, 25);
                texModelodgv.BackColor = Color.Tan ;
                texAliasdgv.Visible = true;
                texAliasdgv.Location = new Point(820, 250);
                texAliasdgv.Size = new Size(200, 40);
                texAliasdgv.Font = new Font(texModelodgv.Font.FontFamily, 25);
                texAliasdgv.BackColor = Color.Tan;

                dgvModelos1.Visible = false;

                picboxRecuaModeloAlias.Visible = true;
                picboxRecuaModeloAlias.Location = new Point(520, 230);
                picboxRecuaModeloAlias.Size = new Size(530, 80);

                botCancelarMod.Visible = true;
                if (botCancelarMod.Text == "CANCELAR")
                {
                    botCancelarMod.Text = "SALIR";
                }
                botCancelarMod.Location = new Point(995,950);
                botSalirMod.Visible = false;
            }

        }
        private void frmModelos_Load(object sender, EventArgs e)
        {
            // Obtener el área de trabajo del escritorio (excluyendo la barra de tareas)
            Rectangle areaDeTrabajo = Screen.GetWorkingArea(this);

            // Establecer la posición y el tamaño del formulario para que ocupe toda el área de trabajo
            this.Location = areaDeTrabajo.Location;
            this.Size = areaDeTrabajo.Size;

            dgvModelos1.ClearSelection();
        }

        private void texModeloMod_Click(object sender, EventArgs e)
        {
            texModeloMod.BackColor = Color.Linen ;
            texModeloMod.BorderStyle = BorderStyle.Fixed3D;
            texAliasMod.ForeColor = Color.Black;
            texAliasMod.BorderStyle = BorderStyle.None;
        }
 
        private void texAliasMod_Click(object sender, EventArgs e)
        {
            texAliasMod.BackColor = Color.Linen;
            texAliasMod.BorderStyle = BorderStyle.Fixed3D;
            texAliasMod.Focus();

            texModeloMod.BackColor = Color.Tan;
            texModeloMod.ForeColor = Color.Black;
            texModeloMod.BorderStyle = BorderStyle.None;
        }

        private void texEstadoMod_Click(object sender, EventArgs e)
        {
            texModeloMod.BorderStyle = BorderStyle.None;
            MODELOS.frmEstadoAviones frmEstadoAviones = new MODELOS.frmEstadoAviones(this);
            frmEstadoAviones.Show();
            //frmModelos.texEstadoMod.BorderStyle = System.Windows.Forms.BorderStyle.None ;
            texAliasMod.BorderStyle = BorderStyle.None;
            botCancelarMod.Visible = false;
            botSalirMod.Visible = false;
            dgvMaterialesenModificacion.Visible = false;
            frmEstadoAviones.Location = new Point(500, 470);
            botCargarFotoMod.Visible = false;
        }
        private void texDesdeMod_Click(object sender, EventArgs e)
        {
            texDesdeMod.Visible = false;
            texAliasMod.BorderStyle = BorderStyle.None;
            dattimFechaMod.Visible = true;
            dattimFechaMod.Focus();
        }

        private void botListadoMod_Click(object sender, EventArgs e)
        {
            frmListadoMod frmListadoMod = new frmListadoMod(this);
            frmListadoMod.StartPosition = FormStartPosition.Manual;
            frmListadoMod.Location = new Point(500, 300);
            
            botSalirMod.Visible = false;
            botIngresarMod.Visible = false;
            botModificarMod.Visible = false;
            botEliminarMod.Visible = false;
            botListadoMod.Visible = false;

            dgvModelos1.Visible = false;

            frmListadoMod.ShowDialog();
        }

        private void botImprimirMod_Click(object sender, EventArgs e)
        {
            // Mostrar el cuadro de diálogo de impresión
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Lógica de impresión
          //  PrintDataGridView(dgvListadoMaterialesLis, e);
        }
        private void PrintDataGridView(DataGridView dgv, PrintPageEventArgs e)
        {
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            int cellHeight = 0;

            // Estilo de fuente
            Font font = new Font("Arial", 10);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Imprimir encabezados de columnas
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                e.Graphics.DrawString(col.HeaderText, font, brush, x, y);
                x += col.Width;
            }

            y += font.Height;
            x = e.MarginBounds.Left;

            // Imprimir filas
            foreach (DataGridViewRow row in dgv.Rows)
            {
                cellHeight = row.Height;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    e.Graphics.DrawString(Convert.ToString(cell.Value), font, brush, x, y);
                    x += cell.OwningColumn.Width;
                }
                x = e.MarginBounds.Left;
                y += cellHeight;
            }
        }

        private void botImprimirMod_Click_1(object sender, EventArgs e)
        {
            this.botImprimirMod.Click += new System.EventHandler(this.botImprimirMod_Click);
        }
    }
}
