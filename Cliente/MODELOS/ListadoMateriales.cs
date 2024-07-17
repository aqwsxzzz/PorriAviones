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
    public partial class ListadoMateriales : Form
    {
        public ListadoMateriales()
        {
            InitializeComponent();
 
            FormBorderStyle = FormBorderStyle.None;
            dgvListadoMaterialesLis.ColumnCount = 10;

            dgvListadoMaterialesLis.Columns[0].Name = "Familia";
            dgvListadoMaterialesLis.Columns[0].HeaderText = "          Familia";
            dgvListadoMaterialesLis.Columns[0].DataPropertyName = "Familia";

            dgvListadoMaterialesLis.Columns[1].Name = "Grupo";
            dgvListadoMaterialesLis.Columns[1].HeaderText = "         Grupo";
            dgvListadoMaterialesLis.Columns[1].DataPropertyName = "Grupo";

            dgvListadoMaterialesLis.Columns[2].Name = "Caracteristica";
            dgvListadoMaterialesLis.Columns[2].HeaderText = " Caracteristica";
            dgvListadoMaterialesLis.Columns[2].DataPropertyName = "Caracteristica";

            dgvListadoMaterialesLis.Columns[3].Name = "Medidas";
            dgvListadoMaterialesLis.Columns[3].HeaderText = "       Medidas";
            dgvListadoMaterialesLis.Columns[3].DataPropertyName = "Medidas";

            dgvListadoMaterialesLis.Columns[4].Name = "Codigo";
            dgvListadoMaterialesLis.Columns[4].HeaderText = "        Codigo";
            dgvListadoMaterialesLis.Columns[4].DataPropertyName = "Codigo";

            dgvListadoMaterialesLis.Columns[5].Name = "CantidadxModelo";
            dgvListadoMaterialesLis.Columns[5].HeaderText = "      CantxMod";
            dgvListadoMaterialesLis.Columns[5].DataPropertyName = "CantidadxModelo";
            dgvListadoMaterialesLis.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvListadoMaterialesLis.Columns[6].Name = "Tipo";
            dgvListadoMaterialesLis.Columns[6].HeaderText = "      Tipo";
            dgvListadoMaterialesLis.Columns[6].DataPropertyName = "Tipo";
            dgvListadoMaterialesLis.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvListadoMaterialesLis.Columns[7].Name = "IdMaterial";
            dgvListadoMaterialesLis.Columns[7].HeaderText = "IdMaterial";
            dgvListadoMaterialesLis.Columns[7].DataPropertyName = "IdMaterial";
            dgvListadoMaterialesLis.Columns[7].Visible = false;

            dgvListadoMaterialesLis.Columns[8].Name = "IdMaterialesModelo";
            dgvListadoMaterialesLis.Columns[8].HeaderText = "IdMaterialesModelo";
            dgvListadoMaterialesLis.Columns[8].DataPropertyName = "IdMaterialesModelo";
            dgvListadoMaterialesLis.Columns[8].Visible = false;

            dgvListadoMaterialesLis.Columns[9].Name = "Valor";
            dgvListadoMaterialesLis.Columns[9].HeaderText = "Valor";
            dgvListadoMaterialesLis.Columns[9].DataPropertyName = "Valor";
            dgvListadoMaterialesLis.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListadoMaterialesLis.Columns[9].Visible = false;

            dgvListadoMaterialesLis.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128); //  Color de las cabeceras de las columnas
            dgvListadoMaterialesLis.DefaultCellStyle.SelectionBackColor = Color.IndianRed;  //  Color de la celda seleccionada  
 
            this.Load += ListadoMateriales_Load;
        }

        // Desseleccionar la primera fila después de cargar los datos
        private void ListadoMateriales_Load(object sender, EventArgs e)
        {
            dgvListadoMaterialesLis.SelectionChanged += DgvListadoMaterialesLis_SelectionChanged;

            if (dgvListadoMaterialesLis.Rows.Count > 0)
            {
                dgvListadoMaterialesLis.Rows[0].Selected = false;
            }
        }

        private void DgvListadoMaterialesLis_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada y si es la primera fila
            if (dgvListadoMaterialesLis.SelectedRows.Count > 0 && dgvListadoMaterialesLis.SelectedRows[0].Index == 0)
            {
                // Desseleccionar la primera fila
                dgvListadoMaterialesLis.ClearSelection();

                MODELOS.frmModelos Mod = new frmModelos();
                Mod.picboxRecuaMod3.BackColor = Color.Tan;
            }
        }

        private void ListadoMateriales_Load_1(object sender, EventArgs e)
        {

        }
    }
}
