using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.MODELOS
{
    public partial class frmListadoMod : Form
    {
        private frmModelos frmModelos;
        public frmListadoMod(frmModelos principal)
        {
            InitializeComponent();
            frmModelos = principal;
        }

        private void botCancelaMod_Click(object sender, EventArgs e)
        {
            frmModelos.botSalirMod.Visible = true;
            frmModelos.dgvModelos1.Visible = true;

            frmModelos.botIngresarMod.Visible = true;
            frmModelos.botModificarMod.Visible = true;
            frmModelos.botEliminarMod.Visible = true;
            frmModelos.botListadoMod.Visible = true;

            this.Close();
        }
    }
}
