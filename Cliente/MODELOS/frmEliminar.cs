using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace _1.MODELOS
{
    public partial class frmEliminar : Form
    {
        private frmModelos frmModelos;

        public frmEliminar(frmModelos principal)
        {
            InitializeComponent();
            frmModelos = principal;

            // Accede directamente al dgvModelos1
            var dgvModelos1 = frmModelos.dgvModelos1;
            dgvModelos1.Visible = false;

            dgvListaMateriales.AutoGenerateColumns = false;

            dgvListaMateriales.ColumnCount = 9;

            dgvListaMateriales.Columns[0].Name = "Familia";
            dgvListaMateriales.Columns[0].HeaderText = "Familia";
            dgvListaMateriales.Columns[0].DataPropertyName = "Familia";

            dgvListaMateriales.Columns[1].Name = "Grupo";
            dgvListaMateriales.Columns[1].HeaderText = "Grupo";
            dgvListaMateriales.Columns[1].DataPropertyName = "Grupo";

            dgvListaMateriales.Columns[2].Name = "Caracteristica";
            dgvListaMateriales.Columns[2].HeaderText = "Caracteristica";
            dgvListaMateriales.Columns[2].DataPropertyName = "Caracteristica";

            dgvListaMateriales.Columns[3].Name = "Medidas";
            dgvListaMateriales.Columns[3].HeaderText = "Medidas";
            dgvListaMateriales.Columns[3].DataPropertyName = "Medidas";

            dgvListaMateriales.Columns[4].Name = "Tipo";
            dgvListaMateriales.Columns[4].HeaderText = "Tipo";
            dgvListaMateriales.Columns[4].DataPropertyName = "Tipo";

            dgvListaMateriales.Columns[5].Name = "Codigo";
            dgvListaMateriales.Columns[5].HeaderText = "Codigo";
            dgvListaMateriales.Columns[5].DataPropertyName = "Codigo";

            dgvListaMateriales.Columns[6].Name = "Cantidad";
            dgvListaMateriales.Columns[6].HeaderText = "Cantidad";
            dgvListaMateriales.Columns[6].DataPropertyName = "CantidadxModelo";

            dgvListaMateriales.Columns[7].Name = "IdMaterialesModelo";
            dgvListaMateriales.Columns[7].HeaderText = "IdMaterialesModelo";
            dgvListaMateriales.Columns[7].DataPropertyName = "IdMaterialesModelo";
            dgvListaMateriales.Columns[7].Visible = false;

            dgvListaMateriales.Columns[8].Name = "IdAcopio";
            dgvListaMateriales.Columns[8].HeaderText = "IdAcopio";
            dgvListaMateriales.Columns[8].DataPropertyName = "IdAcopio";
            dgvListaMateriales.Columns[8].Visible = false;

            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.HeaderText = "Reciclable";
            dgvListaMateriales.Columns.Add(checkboxColumn);
            
            dgvListaMateriales.Columns[9].Width = 58;
            dgvListaMateriales.AllowUserToAddRows = false;
            dgvListaMateriales.DefaultValuesNeeded += dgvListaMateriales_DefaultValuesNeeded;
            dgvListaMateriales.ColumnHeadersDefaultCellStyle.BackColor = Color.Tan; //  Color de las cabeceras de las columnas         
            this.Location = new Point(400, 180);
        }

        private void frmEliminar_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvListaMateriales.Rows)
            {

                // Establecer el valor de la celda de checkbox a false
                row.Cells[9].Value = false;
            }

        }

        private void botEliminar_Click(object sender, EventArgs e)
        {
            FuncionesEliminar funcEliminar = new FuncionesEliminar();
            for(int i = 0; i < dgvListaMateriales.Rows.Count; i++)
            {
                if ((bool)dgvListaMateriales.Rows[i].Cells[9].Value == true)
                {
                    funcEliminar.DevolverStock(dgvListaMateriales.Rows[i].Cells[8].Value.ToString(), dgvListaMateriales.Rows[i].Cells[6].Value.ToString().Replace(",", "."));
                } else if ((bool)dgvListaMateriales.Rows[i].Cells[9].Value == false)
                {
                    funcEliminar.ReducirTotalStock(dgvListaMateriales.Rows[i].Cells[8].Value.ToString(), dgvListaMateriales.Rows[i].Cells[6].Value.ToString().Replace(",", "."));
                }
            }
            funcEliminar.EliminarModelo(frmModelos.dgvModelos1.CurrentRow.Cells[4].Value.ToString());
            this.Close();
        }

        public void dgvListaMateriales_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            // Supongamos que la columna de checkbox está en la columna index 1
            int checkBoxColumnIndex = 9;

            // Establecer el valor predeterminado de la celda de checkbox en false
            e.Row.Cells[checkBoxColumnIndex].Value = false;
        }

        private void botCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmModelos.botSalirMod.Visible = true ;
            frmModelos.botIngresarMod.Visible = true;
            frmModelos.botModificarMod.Visible = true;
            frmModelos.botModificarMod.Enabled = false;
            frmModelos.botEliminarMod.Visible = true;
            frmModelos.botEliminarMod.Enabled = false;
            frmModelos.botListadoMod.Visible = true;

            frmModelos.picboxFotoMod.Visible = false;

            frmModelos.dgvModelos1.Visible = true ;
            frmModelos.dgvModelos1.ClearSelection();
            frmModelos.dgvModelos1.CurrentCell = null;
            frmModelos.dgvModelos1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            frmModelos.dgvModelos1.MultiSelect = false;
        }
    }
}
