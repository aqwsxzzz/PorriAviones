using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.Load += frmPrincipal_Load;

            
        }

       

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            labTituloPrinc.BackColor = Color.FromArgb(230, 226, 255);
            // Obtener el área de trabajo del escritorio (excluyendo la barra de tareas)
            Rectangle areaDeTrabajo = Screen.GetWorkingArea(this);

            // Establecer la posición y el tamaño del formulario para que ocupe toda el área de trabajo
            this.Location = areaDeTrabajo.Location;
            this.Size = areaDeTrabajo.Size;
        }

       private void picboxFotoPrinc_Click(object sender, EventArgs e)
        {
        }

        private void botInsumosPrinc_Click(object sender, EventArgs e)
        {
            INSUMOS.frmMateriales MaIngreso = new INSUMOS.frmMateriales();
            MaIngreso .ShowDialog ();
        }

        private void botModelosPrinc_Click(object sender, EventArgs e)
        {
            MODELOS.frmModelos MoIngreso = new MODELOS.frmModelos();
            MoIngreso.ShowDialog();
        }

        private void botComprasPrinc_Click(object sender, EventArgs e)
        {
            COMPRAS.frmCompras CoIngreso = new COMPRAS.frmCompras();
            CoIngreso.ShowDialog();
        }

        private void botSalirPrinc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
