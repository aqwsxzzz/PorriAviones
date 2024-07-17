using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.INSUMOS
{
    public partial class frmEliminar : Form
    {
        private frmMateriales _frmMateriales;

        public bool Confirmacion { get; private set; }
        public Action EliminarAccion { get; set; }

        public frmEliminar(frmMateriales frmMateriales)
        {
            InitializeComponent();
            _frmMateriales = frmMateriales;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1430, 690);
        }

        private void botCancela_Click(object sender, EventArgs e)
        {
            Confirmacion = false;
            this.Close(); // Cierra el formulario

            // Asegúrate de que el frmMateriales no sea nulo
            if (_frmMateriales != null)
            {
                _frmMateriales.botSalirMat.Visible = true;
            }
        }

        private void botElimina_Click(object sender, EventArgs e)
        {
            Insumos.Stock funcStock = new Insumos.Stock();

            if (_frmMateriales.dgvMateriales.CurrentRow.Cells[8].Value.ToString() == _frmMateriales.dgvMateriales.CurrentRow.Cells[9].Value.ToString())
            {
                funcStock.EliminarMaterial(_frmMateriales.dgvMateriales.CurrentRow.Cells[12].Value.ToString());
                funcStock.mostrarMateriales(_frmMateriales.dgvMateriales);
            }
            else
            {
                MessageBox.Show("Verifique que el material no esté siendo utilizado en algún modelo.");
            }


            // Asegúrate de que el frmMateriales no sea nulo
            if (_frmMateriales != null)
            {
                _frmMateriales.picboxFotoMat.Image = null;
                _frmMateriales.botSalirMat.Visible = true;
                _frmMateriales.dgvMateriales.Location = new Point(365, 295);

                _frmMateriales.dgvMateriales.ClearSelection();
                _frmMateriales.dgvMateriales.CurrentCell = null;
                _frmMateriales.dgvMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                _frmMateriales.dgvMateriales.MultiSelect = false;

            }

            this.Close(); // Cierra el formulario
        }
    }
}