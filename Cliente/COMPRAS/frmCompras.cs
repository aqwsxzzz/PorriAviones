using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using _1.INSUMOS;

namespace _1.COMPRAS
{
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();

            this.Load += frmCompras_Load;

          //  texNuevoFam.KeyPress += new KeyPressEventHandler(texNuevoFam_KeyPress);  //Instancia el evento Keypress para que cuando con un solo enter entre en la ficha.

            this.Cursor = Cursors.Cross;
           // this.Cursor = Cursors.Arrow;
           //  this.Cursor = new Cursor(Properties.Resources.flecha_1.Handle);

            dgvListaMateriales.AutoGenerateColumns = false;

            //Set Columns Count.
            dgvListaMateriales.ColumnCount = 12;

            dgvListaMateriales.Columns[0].Name = "Familia";
            dgvListaMateriales.Columns[0].HeaderText = "Familia";
            dgvListaMateriales.Columns[0].DataPropertyName = "Familia";
            dgvListaMateriales.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvListaMateriales.Columns[1].Name = "Grupo";
            dgvListaMateriales.Columns[1].HeaderText = "Grupo";
            dgvListaMateriales.Columns[1].DataPropertyName = "Grupo";
            dgvListaMateriales.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvListaMateriales.Columns[2].Name = "Caracteristica";
            dgvListaMateriales.Columns[2].HeaderText = "Caracteristica";
            dgvListaMateriales.Columns[2].DataPropertyName = "Caracteristica";
            dgvListaMateriales.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvListaMateriales.Columns[3].Name = "Medidas";
            dgvListaMateriales.Columns[3].HeaderText = "Medidas";
            dgvListaMateriales.Columns[3].DataPropertyName = "Medidas";
            dgvListaMateriales.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvListaMateriales.Columns[4].Name = "Codigo";
            dgvListaMateriales.Columns[4].HeaderText = "Codigo";
            dgvListaMateriales.Columns[4].DataPropertyName = "Codigo";
            dgvListaMateriales.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvListaMateriales.Columns[5].Name = "Fabricante";
            dgvListaMateriales.Columns[5].HeaderText = "  Fabricante";
            dgvListaMateriales.Columns[5].DataPropertyName = "Fabricante";
            dgvListaMateriales.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvListaMateriales.Columns[6].Name = "Estado";
            dgvListaMateriales.Columns[6].HeaderText = "Estado";
            dgvListaMateriales.Columns[6].DataPropertyName = "Estado";
            dgvListaMateriales.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvListaMateriales.Columns[7].Name = "Cantidad";
            dgvListaMateriales.Columns[7].HeaderText = "Cant.";
            dgvListaMateriales.Columns[7].DataPropertyName = "Cantidad";
            dgvListaMateriales.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvListaMateriales.Columns[8].Name = "Disponible";
            dgvListaMateriales.Columns[8].HeaderText ="Dis.";
            dgvListaMateriales.Columns[8].DataPropertyName = "Disponible";
            dgvListaMateriales.Columns[8].Width = 30;
            dgvListaMateriales.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvListaMateriales.Columns[9].Name = "Tipo";
            dgvListaMateriales.Columns[9].HeaderText = "Tipo";
            dgvListaMateriales.Columns[9].DataPropertyName = "Tipo";
            dgvListaMateriales.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvListaMateriales.Columns[10].Name = "Valor";
            dgvListaMateriales.Columns[10].HeaderText = "Valor unitario";
            dgvListaMateriales.Columns[10].DataPropertyName = "Valor";
            dgvListaMateriales.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvListaMateriales.Columns[11].Name = "IdMaterial";
            dgvListaMateriales.Columns[11].HeaderText = " IdMaterial";
            dgvListaMateriales.Columns[11].DataPropertyName = "IdMaterial";
            dgvListaMateriales.Columns[11].Visible = false;
            dgvListaMateriales.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvListaMateriales.Location = new Point(420, 160);
            System.Drawing.Size Tamaño = new System.Drawing.Size(1048, 475);
            dgvListaMateriales.Size = Tamaño;
            dgvListaMateriales.BorderStyle = BorderStyle.None;
            dgvListaMateriales.DefaultCellStyle.Font = new Font("Arial", 11);
            dgvListaMateriales.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

            dgvCompras1.AutoGenerateColumns = false;

            FuncionesListadoCompras funcListado = new FuncionesListadoCompras();
            funcListado.mostrarMateriales(dgvListaMateriales);

            //Set Columns Count.
            dgvCompras1.ColumnCount = 11;

            dgvCompras1.Columns[0].Name = "Fechacompra";
            dgvCompras1.Columns[0].HeaderText = "     Fecha de         compra";
            dgvCompras1.Columns[0].DataPropertyName = "Fechacompra";

            dgvCompras1.Columns[1].Name = "Familia";
            dgvCompras1.Columns[1].HeaderText = "          Familia";
            dgvCompras1.Columns[1].DataPropertyName = "Familia";

            dgvCompras1.Columns[2].Name = "Grupo";
            dgvCompras1.Columns[2].HeaderText = "         Grupo";
            dgvCompras1.Columns[2].DataPropertyName = "Grupo";

            dgvCompras1.Columns[3].Name = "Caracteristica";
            dgvCompras1.Columns[3].HeaderText = "Caracteristica";
            dgvCompras1.Columns[3].DataPropertyName = "Caracteristica";

            dgvCompras1.Columns[4].Name = "Medidas";
            dgvCompras1.Columns[4].HeaderText = "       Medidas";
            dgvCompras1.Columns[4].DataPropertyName = "Medidas";

            dgvCompras1.Columns[5].Name = "Codigo";
            dgvCompras1.Columns[5].HeaderText = "        Codigo";
            dgvCompras1.Columns[5].DataPropertyName = "Codigo";

            dgvCompras1.Columns[6].Name = "Tipo";
            dgvCompras1.Columns[6].HeaderText = "         Tipo";
            dgvCompras1.Columns[6].DataPropertyName = "Tipo";

            dgvCompras1.Columns[7].Name = "Fabricante";
            dgvCompras1.Columns[7].HeaderText = "      Fabricante";
            dgvCompras1.Columns[7].DataPropertyName = "Fabricante";

            dgvCompras1.Columns[8].Name = "Proveedor";
            dgvCompras1.Columns[8].HeaderText = "     Proveedor";
            dgvCompras1.Columns[8].DataPropertyName = "Proveedor";

            dgvCompras1.Columns[9].Name = "Cantidadcomprada";
            dgvCompras1.Columns[9].HeaderText = "      Cantidad         comprada";
            dgvCompras1.Columns[9].DataPropertyName = "Cantidadcomprada";

            dgvCompras1.Columns[10].Name = "Valorcompra";
            dgvCompras1.Columns[10].HeaderText = "          Valor";
            dgvCompras1.Columns[10].DataPropertyName = "Valorcompra";

            dgvCompras1.Location = new Point(390, 650);
            System.Drawing.Size Tamaños = new System.Drawing.Size(1120, 325);
            dgvCompras1.Size = Tamaños;
            dgvCompras1.BorderStyle = BorderStyle.None;
            dgvCompras1.BackgroundColor = System.Drawing.Color.Gray;             //   DarkKhaki;
            dgvCompras1.ColumnHeadersDefaultCellStyle.BackColor = Color.OliveDrab;

            COMPRAS.Adquicisiones objetoadqui = new COMPRAS.Adquicisiones();
            objetoadqui.mostrarCompras(dgvCompras1);

            dgvCompras2.AutoGenerateColumns = false;

            //Set Columns Count.
            dgvCompras2.ColumnCount = 11;

            dgvCompras2.Columns[0].Name = "Familia";
            dgvCompras2.Columns[0].HeaderText = "          Familia";
            dgvCompras2.Columns[0].DataPropertyName = "Familia";

            dgvCompras2.Columns[1].Name = "Grupo";
            dgvCompras2.Columns[1].HeaderText = "         Grupo";
            dgvCompras2.Columns[1].DataPropertyName = "Grupo";

            dgvCompras2.Columns[2].Name = "Caracteristica";
            dgvCompras2.Columns[2].HeaderText = "Caracteristica";
            dgvCompras2.Columns[2].DataPropertyName = "Caracteristica";

            dgvCompras2.Columns[3].Name = "Medidas";
            dgvCompras2.Columns[3].HeaderText = "       Medidas";
            dgvCompras2.Columns[3].DataPropertyName = "Medidas";

            dgvCompras2.Columns[4].Name = "Codigo";
            dgvCompras2.Columns[4].HeaderText = "        Codigo";
            dgvCompras2.Columns[4].DataPropertyName = "Codigo";

            dgvCompras2.Columns[5].Name = "Tipo";
            dgvCompras2.Columns[5].HeaderText = "         Tipo";
            dgvCompras2.Columns[5].DataPropertyName = "Tipo";

            dgvCompras2.Columns[6].Name = "Fabricante";
            dgvCompras2.Columns[6].HeaderText = "      Fabricante";
            dgvCompras2.Columns[6].DataPropertyName = "Fabricante";

            dgvCompras2.Columns[7].Name = "Proveedor";
            dgvCompras2.Columns[7].HeaderText = "     Proveedor";
            dgvCompras2.Columns[7].DataPropertyName = "Proveedor";
                        
            dgvCompras2.Columns[8].Name = "Cantidadcomprada";
            dgvCompras2.Columns[8].HeaderText = "      Cantidad       comprada";
            dgvCompras2.Columns[8].DataPropertyName = "Cantidadcomprada";

            dgvCompras2.Columns[9].Name = "Valorcompra";
            dgvCompras2.Columns[9].HeaderText = "          Valor";
            dgvCompras2.Columns[9].DataPropertyName = "Valorcompra";

            dgvCompras2.Columns[10].Name = "Fechacompra";
            dgvCompras2.Columns[10].HeaderText = " Fecha    de compra";
            dgvCompras2.Columns[10].DataPropertyName = "Fechacompra";

            labComprasRealizadas.Location = new Point(1257, 551);
            
            COMPRAS.Adquicisiones  objetoadqui1 = new COMPRAS .Adquicisiones ();
            objetoadqui.mostrarCompras(dgvCompras2);

            picboxPrincipal.Location = new Point(770, 353);

            botMenuCom.Visible = false;
            botDisponibleMod.Location = new Point(850, 390);
            botListadoMateriales.Location = new Point(850, 480);
            botComprasAnteriores.Location = new Point(850,570);
        }

        private void botMenuCom_Click(object sender, EventArgs e)
        {
            labTituloIngresoCom.Visible = false;
            labModificaCom.Visible = false;
            labTituloEliminaCom.Visible = false;

            botIngresarCom.Visible = true;
            botIngresarCom.Location = new Point(391,923);

            botModificarCom.Visible = true;
            botEliminarCom.Visible = true;
        }
      
        private void botRecuaCancelarCom_Click_1(object sender, EventArgs e)
        {
            labTituloIngresoCom.Visible = false;
            labModificaCom.Visible = false;
            labTituloEliminaCom.Visible = false;
            labComprasRealizadas.Visible = true ;

            labFamiliaCom.Visible = false;
            labGrupoCom.Visible = false;
            labCaracterisCom.Visible = false;
            labMedidasCom.Visible = false;
            labCodigoCom.Visible = false;
            labTipoCom.Visible = false;
            labFabricanteCom.Visible = false;
            labProveedorCom.Visible = false;
            labCantidadCom.Visible = false;
            labValorCom.Visible = false;
            labFechaCompraCom.Visible = false;

            texFamiliaCom.Text = "";
            texGrupoCom.Text = "";
            texCaracterisCom.Text = "";
            texCodigoCom.Text = "";
            texTipoCom.Text = "";
            texFabricanteCom.Text = "";
            texProveedorCom.Text = "";
            texFechaCompraCom.Text = "";
            texCantidadCom.Text = "";
            texValorCom.Text = "";

            comboxFamiliaCom.Visible = false;
            comboxGrupoCom.Visible = false;
            comboxCaracterisCom.Visible = false;
            comboxMedidasCom.Visible = false;
            comboxCodigoCom.Visible = false;
            comboxTipoCom.Visible = false; ;
            comboxFabricanteCom.Visible = false;
            comboxProveedorCom.Visible = false;

            texFamiliaCom.Visible = false;
            texGrupoCom.Visible = false;
            texCaracterisCom.Visible = false;
            texMedidasCom.Visible = false;
            texCodigoCom.Visible = false;
            texTipoCom.Visible = false;
            texFabricanteCom.Visible = false;
            texProveedorCom.Visible = false;
            texFechaCompraCom.Visible = false;
            texCantidadCom.Visible = false;
            texValorCom.Visible = false;

            picboxRecuaCom3.Visible = false;
            picboxRecuaCom2.Visible = false;
            picboxRecuaCom1.Visible = false;
            picboxRecuaTituloCom.Visible = false;
            picboxRecuaCom.Visible = true ;

            botRecuaCargarFotoCom.Visible = false;
            botRecuaGuardarCom.Visible = false;
            botRecuaCancelarCom.Visible = false;

            botMenuCom.Visible = true;
            botIngresarCom.Visible = false;
            botModificarCom.Visible = false;
            botEliminarCom.Visible = false;
                        
            dgvCompras1.Visible = true;
            dgvCompras2.Visible = false;
        }
        
        public  void botIngresarCom_Click_1(object sender, EventArgs e)
        {
            labTituloIngresoCom.Visible = true;
            labModificaCom.Visible = false;
            labTituloEliminaCom.Visible = false;
            labTituloCom.Location = new Point(866, 45);

           // picboxRecuaCom.Visible = true;

            //picboxRecuaTituloCom.Visible = false;
            
          
            labTituloIngresoCom.Location = new Point(755,160);
            labTituloIngresoCom.Font = new Font(labTituloIngresoCom.Font.FontFamily, 20);
            labTituloIngresoCom.Font = new Font(labTituloIngresoCom.Font, labTituloIngresoCom.Font.Style | FontStyle.Underline);


            /*  labFamiliaCom.Visible = true;
              labGrupoCom.Visible = true;
              labCaracterisCom.Visible = true;
              labMedidasCom.Visible = true;
              labCodigoCom.Visible = true;
              labTipoCom.Visible = true;
              labFabricanteCom.Visible = true;
              labProveedorCom.Visible = true;
              labCantidadCom.Visible = true;
              labValorCom.Visible = true;

              texFamiliaCom.Text = "";
              texGrupoCom.Text = "";
              texCaracterisCom.Text = "";
              texCodigoCom.Text = "";
              texTipoCom.Text = "";
              texFabricanteCom.Text = "";
              texProveedorCom.Text = "";
              texFechaCompraCom.Text = "";
              texCantidadCom.Text = "";
              texValorCom.Text = "";

              texFamiliaCom.Visible = true;
              texFamiliaCom.Location = new Point(576,377);

              texGrupoCom.Visible = true;
              texGrupoCom.Location = new Point(576, 411);

              texCaracterisCom.Visible = true;
              texCaracterisCom.Location = new Point(576, 445);

              texMedidasCom.Visible = true;
              texMedidasCom.Location = new Point(576, 479);

              texCodigoCom.Visible = true;
              texCodigoCom.Location = new Point(576, 515);

              texTipoCom.Visible = true ;
              texTipoCom.Location = new Point(860, 377);

              texFabricanteCom.Visible = true;
              texFabricanteCom.Location = new Point(860, 411);

              texProveedorCom.Visible = true;
              texProveedorCom.Location  = new Point(860, 445);

              texCantidadCom.Visible = true;
              texValorCom.Visible = true;

              picboxRecuaCom3.Visible = true;
              picboxRecuaCom2.Visible = true;
              picboxRecuaCom1.Visible = true;
              picboxRecuaTituloCom.Visible = true;
              picboxDGV1Com.Visible = false;

              botRecuaCargarFotoCom.Visible = false;
              botRecuaGuardarCom.Visible = false;
              botRecuaCancelarCom.Visible = true;

              botIngresarCom.Location = new Point(450,923);

              botModificarCom.Visible = false;
              botEliminarCom.Visible = false;
              botMenuCom.Visible = false;

              dgvCompras1.Visible = false;
              dgvCompras2.Visible = true;

              dgvCompras2.Size = new Size (1003,300);
              dgvCompras2.Location = new Point (428,585);*/
        }

        private void botModificarCom_Click_1(object sender, EventArgs e)
        {
            labTituloIngresoCom.Visible = false;
            labModificaCom.Visible = true;
            labTituloEliminaCom.Visible = false;

            labModificaCom.Visible = true;

            labFamiliaCom.Visible = true;
            labGrupoCom.Visible = true;
            labCaracterisCom.Visible = true;
            labMedidasCom.Visible = true;
            labCodigoCom.Visible = true;
            labTipoCom.Visible = true;
            labFabricanteCom.Visible = true;
            labProveedorCom.Visible = true;
            labCantidadCom.Visible = true;
            labValorCom.Visible = true;
            labFechaCompraCom.Visible = true;

            texFamiliaCom.Text = "";
            texGrupoCom.Text = "";
            texCaracterisCom.Text = "";
            texCodigoCom.Text = "";
            texTipoCom.Text = "";
            texFabricanteCom.Text = "";
            texProveedorCom.Text = "";
           // texFechaCompraCom.Text = "";
            texCantidadCom.Text = "";
            texValorCom.Text = "";

            texFamiliaCom.Visible = true;
            texFamiliaCom.Location = new Point(576, 377);

            texGrupoCom.Visible = true;
            texGrupoCom.Location = new Point(576, 411);

            texCaracterisCom.Visible = true;
            texCaracterisCom.Location = new Point(576, 446);

            texMedidasCom.Visible = true;
            texMedidasCom.Location = new Point(576, 481);

            texCodigoCom.Visible = true;
            texCodigoCom.Location = new Point(576, 515);

            texTipoCom.Visible = true;
            texTipoCom.Location = new Point(860, 377);

            texFabricanteCom.Visible = true;
            texFabricanteCom.Location = new Point(860, 411);

            texProveedorCom.Visible = true;
            texProveedorCom.Location = new Point(860, 446);

            texFechaCompraCom.Visible = true;

            texCantidadCom.Visible = true;
            texCantidadCom.Location = new Point(860, 480);

            texValorCom.Visible = true;

            comboxFamiliaCom.Visible = false ;
            comboxGrupoCom.Visible = false ;
            comboxCaracterisCom.Visible = false ;
            comboxMedidasCom.Visible = false ;
            comboxCodigoCom.Visible = false ;
            comboxTipoCom.Visible = false ;
            comboxFabricanteCom.Visible = false ;
            comboxProveedorCom.Visible = false ;

            picboxRecuaCom3.Visible = true;
            picboxRecuaCom2.Visible = true;
            picboxRecuaCom1.Visible = true;
            picboxRecuaTituloCom.Visible = true;

            botRecuaCancelarCom.Visible = true;

            botMenuCom.Visible = false;
            botIngresarCom.Visible = false;
            botEliminarCom.Visible = false;
        }

        private void botEliminarCom_Click_1(object sender, EventArgs e)
        {
            labTituloIngresoCom.Visible = false;
            labModificaCom.Visible = false;
            labTituloEliminaCom.Visible = true;

            labTituloEliminaCom.Visible = true;
            labTituloEliminaCom.Location = new Point(975,301);

            labFamiliaCom.Visible = true;
            labGrupoCom.Visible = true;
            labCaracterisCom.Visible = true;
            labMedidasCom.Visible = true;
            labCodigoCom.Visible = true;
            labTipoCom.Visible = true;
            labFabricanteCom.Visible = true;
            labProveedorCom.Visible = true;
            labCantidadCom.Visible = true;
            labValorCom.Visible = true;
            labFechaCompraCom.Visible = true;

            texFamiliaCom.Text = "";
            texGrupoCom.Text = "";
            texCaracterisCom.Text = "";
            texCodigoCom.Text = "";
            texTipoCom.Text = "";
            texFabricanteCom.Text = "";
            texProveedorCom.Text = "";
            texFechaCompraCom.Text = "";
            texCantidadCom.Text = "";
            texValorCom.Text = "";

            texFamiliaCom.Visible = true;
            texFamiliaCom.Location = new Point(576, 377);

            texGrupoCom.Visible = true;
            texGrupoCom.Location = new Point(576, 411);

            texCaracterisCom.Visible = true;
            texCaracterisCom.Location = new Point(576, 446);

            texMedidasCom.Visible = true;
            texMedidasCom.Location = new Point(576, 481);

            texCodigoCom.Visible = true ;
            texCodigoCom.Location = new Point(576, 515);

            texTipoCom.Visible = true;
            texTipoCom.Location = new Point(860, 377);

            texFabricanteCom.Visible = true;
            texFabricanteCom.Location = new Point(860, 411);

            texProveedorCom.Visible = true;
            texProveedorCom.Location = new Point(860, 446);

            texFechaCompraCom.Visible = true;
            
            texCantidadCom.Visible = true;
            texCantidadCom.Location = new Point(860, 480);

            texValorCom.Visible = true;

            comboxFamiliaCom.Visible = false;
            comboxGrupoCom.Visible = false;
            comboxCaracterisCom.Visible = false;
            comboxMedidasCom.Visible = false;
            comboxCodigoCom.Visible = false;
            comboxTipoCom.Visible = false;
            comboxFabricanteCom.Visible = false;
            comboxProveedorCom.Visible = false;

            picboxRecuaCom3.Visible = true;
            picboxRecuaCom2.Visible = true;
            picboxRecuaCom1.Visible = true;
            picboxRecuaTituloCom.Visible = true;

            botRecuaCancelarCom.Visible = true;

            botMenuCom.Visible = false;
            botIngresarCom.Visible = false;
            botModificarCom.Visible = false;
        }
        private void botSalirCom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botRecuaGuardarCom_Click(object sender, EventArgs e)
        {
            dgvCompras2.Visible = true;
        }

        private void comboxFamiliaCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            COMPRAS.Adquicisiones objetoAdquisiciones = new COMPRAS.Adquicisiones();
            objetoAdquisiciones.mostrarGrupo(comboxGrupoCom, comboxFamiliaCom.Text);
        }

        private void comboxGrupoCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            COMPRAS.Adquicisiones objeAdqui = new COMPRAS.Adquicisiones();
            objeAdqui.mostrarCaracteris (comboxCaracterisCom, comboxGrupoCom.Text);
        }

        private void texFamiliaCom_Click(object sender, EventArgs e)
        {
            comboxFamiliaCom.Visible = true;
            texFamiliaCom.Visible = false;
        }

        private void texGrupoCom_Click(object sender, EventArgs e)
        {
            comboxGrupoCom.Visible = true;
            texGrupoCom.Visible = false;
        }

        private void texCaracterisCom_Click(object sender, EventArgs e)
        {
            comboxCaracterisCom.Visible = true;
            texCaracterisCom.Visible = false;
        }

        private void texMedidasCom_Click(object sender, EventArgs e)
        {
            comboxMedidasCom.Visible = true;
            texMedidasCom.Visible = false;
        }

        private void texCodigoCom_Click(object sender, EventArgs e)
        {
            comboxCodigoCom.Visible = true;
            texCodigoCom.Visible = false;
        }

        private void texTipoCom_Click(object sender, EventArgs e)
        {
            comboxTipoCom.Visible = true;
            texTipoCom.Visible = false;
        }

        private void texFabricanteCom_Click(object sender, EventArgs e)
        {
            comboxFabricanteCom.Visible = true;
            texFabricanteCom.Visible = false;
        }

        private void texProveedorCom_Click(object sender, EventArgs e)
        {
            comboxProveedorCom.Visible = true;
            texProveedorCom.Visible = false;
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            // Obtener el área de trabajo del escritorio (excluyendo la barra de tareas)
            Rectangle areaDeTrabajo = Screen.GetWorkingArea(this);

            // Establecer la posición y el tamaño del formulario para que ocupe toda el área de trabajo
            this.Location = areaDeTrabajo.Location;
            this.Size = areaDeTrabajo.Size;

            {
              /*ES PARA TRAER DGVMATERIALES A COMPRAS


                // Inicializar el formulario de materiales
             //   frmMateriales = new frmMateriales();

                // Mostrar el formulario de materiales de forma invisible para acceder a su DataGridView
                _frmMateriales.Visible = false;

                // Obtener el DataGridView del formulario de materiales
                DataGridView dgvMateriales = _frmMateriales.dgvMateriales;

                // Ajustar la posición y tamaño del DataGridView según tus necesidades
                dgvMateriales.Location = new Point(10, 10); // Cambia esto según tus necesidades
                dgvMateriales.Size = new Size(400, 200); // Cambia esto según tus necesidades

                // Añadir el DataGridView al formulario de compras
                this.Controls.Add(dgvMateriales);*/
            }
        }

        private void botListadoMateriales_Click(object sender, EventArgs e)
        {
            labTituloCom.Location = new Point(866,55);

            botIngresarCom.Visible = true;
            botListadoMateriales.Visible = false;
            botDisponibleMod.Visible = false;
            botComprasAnteriores.Visible = false;
            botCancelarCom.Visible = true;
            botSalirCom.Visible = false;

            picboxPrincipal.Visible = false;

            dgvListaMateriales.Visible = true;
            dgvCompras1.Visible = true;
        }

        private void botDisponibleMod_Click(object sender, EventArgs e)
        {
            FuncionesListadoCompras funcListado = new FuncionesListadoCompras();
            funcListado.mostrarMaterialesStockBajo(dgvListaMateriales);

            labTituloCom.Location = new Point(866, 55);

            botIngresarCom.Visible = true;
            botListadoMateriales.Visible = false;
            botDisponibleMod.Visible = false;
            botComprasAnteriores.Visible = false;
            botCancelarCom.Visible = true;
            botSalirCom.Visible = false;

            picboxPrincipal.Visible = false;

            dgvListaMateriales.Visible = true;
        }

        private void botCancelarCom_Click(object sender, EventArgs e)
        {
            labTituloCom.Location = new Point(866, 155);

            botIngresarCom.Visible = false;
            botDisponibleMod.Visible = true;
            botListadoMateriales.Visible = true;
            botComprasAnteriores.Visible = true;
            botCancelarCom.Visible = false ;
            botSalirCom.Visible = true;

            picboxPrincipal.Visible = true;

            dgvListaMateriales.Visible = false;
            dgvCompras1.Visible = false ;
            dgvCompras2.Visible = false;
        }

        private void botComprasAnteriores_Click(object sender, EventArgs e)
        {
            picboxPrincipal.Visible = false;
            botComprasAnteriores.Visible = false;
            botDisponibleMod.Visible = false;
            botListadoMateriales.Visible = false;
            botCancelarCom.Visible = true;
            botSalirCom.Visible = false;

            dgvCompras2.Visible = true;
            dgvCompras2.Location = new Point(450, 300);
            dgvCompras2.Width = 1104;
            dgvCompras2.Height = 600;
        }

        private void dgvListaMateriales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
