using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _1.MODELOS
{ 

    public partial class frmEstadoAviones : Form
    {
        private string Dato;
        private frmModelos frmModelos;

        public frmEstadoAviones (frmModelos principal)
        {
            InitializeComponent();
            frmModelos = principal;

            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;

            radbotActivoEst.Visible = true;
            radbotReparacionEst.Visible = true;
            radbotConstruccionEst.Visible = true;
            radbotInactivoEst.Visible = true;

            botEstadoEst.Visible = true;
            frmModelos.botIngresarMod.Visible = false;
        }

        public void EstadoAviones_Load(object sender,  EventArgs e)
        {
            if (radbotActivoEst.Checked)
            {
                texEstadoEst.Text = "Activo";
            }
        }

        public string DevolverDato
        {
            get { return Dato; }
            set { Dato = value; }
        }

        private void botCancelaEst_Click(object sender, EventArgs e)
        {
            frmModelos.botCancelarMod.Visible = true;
            frmModelos.botIngresarMaterialMod.Visible = true;
            frmModelos.botIngresarMaterialMod.Location = new Point(1191, 295);
            frmModelos.botCargarFotoMod.Visible = true;
            frmModelos.dgvMaterialesenModificacion.Visible = true; 

            this.Close();
        }

        public void botEstadoEst_Click(object sender, EventArgs e)
        {
            if (frmModelos.NuevoOModificacion == "Nuevo")
            {
                frmModelos.labAliasMod.BackColor = Color .Tan ;
                frmModelos.labEstadoMod.Visible = true;
                frmModelos.labDesdeMod.Visible = true;
                frmModelos.labEstadoMod.Location = new Point(533, 738);
                frmModelos.labDesdeMod.Location = new Point(764,738);
                frmModelos.labEstadoMod.BackColor = Color.Tan;
                frmModelos.labDesdeMod.BackColor = Color.Tan;

                frmModelos.texEstadoMod.Text = texEstadoEst.Text;
                frmModelos.texEstadoMod.Visible = true;
                frmModelos.texEstadoMod.Location = new Point(595, 735);
                frmModelos.texEstadoMod.BackColor = Color.Tan;
                frmModelos.texDesdeMod.BackColor = Color.Tan;
                frmModelos.texDesdeMod.Location = new Point(855,681);

                frmModelos.botIngresarMaterialMod.Visible = true ;
                frmModelos.botIngresarMaterialMod.Location = new Point(953,295);
                frmModelos.botSalirMod.Visible = false;
                frmModelos.botCancelarMod.Visible = true;
                frmModelos.botCancelarMod.Location = new Point(953, 855);
                frmModelos.botCargarFotoMod.Visible = true;
                frmModelos.botCargarFotoMod.Location = new Point(750, 855);
                frmModelos.botGuardarMod.Visible = true;
                frmModelos.botGuardarMod.Location = new Point(400, 850);
                

                frmModelos.picboxRecuaMod3.Height = 570;
                frmModelos.picboxRecuaEstadoFecha.Visible = true;
                frmModelos.picboxRecuaEstadoFecha.Location = new Point(505,715);
                frmModelos.picboxRecuaEstadoFecha.Width = 470;
                frmModelos.picboxRecuaEstadoFecha.BackColor = Color.Tan;

                frmModelos.dgvDatosSelecciondos.Visible = true;
                frmModelos.dgvDatosSelecciondos.BorderStyle = BorderStyle.None;
                frmModelos.dgvDatosSelecciondos.BackgroundColor = Color.Tan;
                frmModelos.dgvDatosSelecciondos.Location = new Point(385, 370);
                frmModelos.dgvDatosSelecciondos.Width = 750;

                frmModelos.dgvMaterialesenModificacion.Visible = false;

                frmModelos.dattimFechaMod.Focus();
                frmModelos.dattimFechaMod.Visible = true;
                frmModelos.dattimFechaMod.Location = new Point(850, 735);

            } else if (frmModelos.NuevoOModificacion == "Modificacion")
            {
                frmModelos.texEstadoMod.Text = texEstadoEst.Text;
                frmModelos.texEstadoMod.BackColor = Color.Tan;
                frmModelos.botIngresarMaterialMod.Focus();
                
                frmModelos.dgvMaterialesenModificacion.Visible = true;
            }
            frmModelos.botCancelarMod.Visible = true;
            frmModelos.botGuardarMod . Focus();
            this.Close ();
        }

        private void radbotActivoEst_CheckedChanged(object sender, EventArgs e)
        {
            if (radbotActivoEst.Checked)
            {
                texEstadoEst.Text = "Activo";
            }
        }

        private void radbotReparacionEst_CheckedChanged(object sender, EventArgs e)
        {
            if (radbotReparacionEst.Checked == true)
            {
                texEstadoEst.Text = "En reparación";
            }
        }

        private void radbotConstruccionEst_CheckedChanged(object sender, EventArgs e)
        {
            if (radbotConstruccionEst.Checked == true)
            {
                texEstadoEst.Text = "En construcción";
            }
        }

        private void radbotInactivoEst_CheckedChanged(object sender, EventArgs e)
        {
            if (radbotInactivoEst.Checked == true)
            {
                texEstadoEst.Text = "Inactivo";
            }
        }
   
        private void radbotReparacionEst_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radbotReparacionEst.Checked == true)
            {
                texEstadoEst.Text = "En reparación";
            }
        }

        private void radbotConstruccionEst_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radbotConstruccionEst.Checked == true)
            {
                texEstadoEst.Text = "En construcción";
            }
        }

        private void radbotInactivoEst_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radbotInactivoEst.Checked == true)
            {
                texEstadoEst.Text = "Inactivo";
            }
        }

        private void radbotActivoEst_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radbotActivoEst.Checked)
            {
                texEstadoEst.Text = "Activo";
            }
        }
    }
}