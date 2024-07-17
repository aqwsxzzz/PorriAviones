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
    public partial class frmListadosMat : Form
    {
        private frmMateriales frmMateriales;

        public frmListadosMat(frmMateriales Principal)
        {
            InitializeComponent();
            frmMateriales = Principal;

            this.Cursor = Cursors.Cross;

            botSalirListaMat.Focus();
            frmMateriales.labTituloMat.Location = new Point(870, 102);

            Insumos.Stock stock = new Insumos.Stock();
         //   stock.mostrarFamilia(comboxFamiliaValores);

            dgvListadoFamiliaValores.AutoGenerateColumns = false;
            dgvListadoFamiliaValores.Width =1110;
            dgvListadoFamiliaValores.Height =493;

            dgvListadoFamiliaValores.ColumnCount = 10;

            dgvListadoFamiliaValores.Columns[0].Name = "Grupo";
            dgvListadoFamiliaValores.Columns[0].HeaderText = "Grupo";
            dgvListadoFamiliaValores.Columns[0].DataPropertyName = "Grupo";
            dgvListadoFamiliaValores.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListadoFamiliaValores.Columns[0].Width = 150;

            dgvListadoFamiliaValores.Columns[1].Name = "Caracteristica";
            dgvListadoFamiliaValores.Columns[1].HeaderText = "Caracteristica";
            dgvListadoFamiliaValores.Columns[1].DataPropertyName = "Caracteristica";
            dgvListadoFamiliaValores.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListadoFamiliaValores.Columns[1].Width = 140;

            dgvListadoFamiliaValores.Columns[2].Name = "Medidas";
            dgvListadoFamiliaValores.Columns[2].HeaderText = "Medidas";
            dgvListadoFamiliaValores.Columns[2].DataPropertyName = "Medidas";
            dgvListadoFamiliaValores.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListadoFamiliaValores.Columns[2].Width = 140;

            dgvListadoFamiliaValores.Columns[3].Name = "Codigo";
            dgvListadoFamiliaValores.Columns[3].HeaderText = "Codigo";
            dgvListadoFamiliaValores.Columns[3].DataPropertyName = "Codigo";
            dgvListadoFamiliaValores.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListadoFamiliaValores.Columns[3].Width = 140;

            dgvListadoFamiliaValores.Columns[4].Name = "Fabricante";
            dgvListadoFamiliaValores.Columns[4].HeaderText = "Fabricante";
            dgvListadoFamiliaValores.Columns[4].DataPropertyName = "Fabricante";
            dgvListadoFamiliaValores.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListadoFamiliaValores.Columns[4].Width = 140;

            dgvListadoFamiliaValores.Columns[5].Name = "Cantidad";
            dgvListadoFamiliaValores.Columns[5].HeaderText = "Cantidad";
            dgvListadoFamiliaValores.Columns[5].DataPropertyName = "Cantidad";
            dgvListadoFamiliaValores.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListadoFamiliaValores.Columns[5].Width = 80;
            dgvListadoFamiliaValores.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvListadoFamiliaValores.Columns[6].Name = "Tipo";
            dgvListadoFamiliaValores.Columns[6].HeaderText = "Tipo";
            dgvListadoFamiliaValores.Columns[6].DataPropertyName = "Tipo";
            dgvListadoFamiliaValores.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListadoFamiliaValores.Columns[6].Width = 140;
            dgvListadoFamiliaValores.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvListadoFamiliaValores.Columns[7].Name = "Valor";
            dgvListadoFamiliaValores.Columns[7].HeaderText = "Valor unidad";
            dgvListadoFamiliaValores.Columns[7].DataPropertyName = "Valor";
            dgvListadoFamiliaValores.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListadoFamiliaValores.Columns[7].Width = 80;
            dgvListadoFamiliaValores.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvListadoFamiliaValores.Columns[8].Name = "Total";
            dgvListadoFamiliaValores.Columns[8].HeaderText = "Total";
            dgvListadoFamiliaValores.Columns[8].DataPropertyName = "Total";
            dgvListadoFamiliaValores.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListadoFamiliaValores.Columns[8].Width = 80;
            dgvListadoFamiliaValores.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvListadoFamiliaValores.Columns[9].Name = "IdAcopio";
            dgvListadoFamiliaValores.Columns[9].HeaderText = "IdAcopio";
            dgvListadoFamiliaValores.Columns[9].DataPropertyName = "IdAcopio";
           

            dgvListadoFamiliaValores.ReadOnly = true;
            dgvListadoFamiliaValores.Columns[9].Visible = false;
    
            dgvListadoFamiliaValores.BackgroundColor = Color.LightSteelBlue;  //  Color del fondo del dgv
            dgvListadoFamiliaValores.ColumnHeadersDefaultCellStyle.BackColor = Color.SkyBlue; //  Color de las cabeceras de las columnas

            dgvListadoFamiliaValores.DataBindingComplete += DgvData_DataBindingComplete;

            decimal valorTotalGral = 0;

            if(frmMateriales.dgvMateriales.Rows.Count > 0)
            {

            foreach(DataGridViewRow Row in frmMateriales.dgvMateriales.Rows)
            {
                decimal valorAAgregar = Decimal.Parse(Row.Cells[8].Value.ToString()) * Decimal.Parse(Row.Cells[11].Value.ToString());
                valorTotalGral += valorAAgregar;
            }
                valorTotalGral = Math.Round(valorTotalGral, 0);
                labValorTotalGral.Text = valorTotalGral.ToString();
            }

            Insumos.Stock objetostock = new Insumos.Stock();
            objetostock.mostrarFamilia(lisFamListMat);
        }

        private void botSalirListaMat_Click(object sender, EventArgs e)
        {
            frmMateriales.labTituloDgv.Visible = true;

            frmMateriales.botCancelarIngresoMat.Visible = false;
            frmMateriales.botSalirMat.Visible = true;
            frmMateriales.botIngresarMat.Visible = true;
            frmMateriales.botIngresarMat.Location = new Point(364, 940);
            frmMateriales.botModificarMat.Visible = true;
            frmMateriales.botModificarMat.Enabled = false;
            frmMateriales.botModificarMat.Font = new Font(frmMateriales.botModificarMat.Font, FontStyle.Regular);
            frmMateriales.botModificarMat.Location = new Point(528, 940);
            frmMateriales.botBuscarMat.Visible = true;
            frmMateriales.botBuscarMat.Location = new Point(692, 940);
            frmMateriales.botEliminarMat.Visible = true;
            frmMateriales.botEliminarMat.Enabled = false;
            frmMateriales.botEliminarMat.Font = new Font(frmMateriales.botEliminarMat.Font, FontStyle.Regular);
            frmMateriales.botEliminarMat.Location = new Point(856, 940);
            frmMateriales.botListarMat.Visible = true;
            frmMateriales.botListarMat.Location = new Point(1020, 940);

            frmMateriales.dgvMateriales.Visible = true;
            frmMateriales.dgvMateriales.Location = new Point(365, 295);

            frmMateriales.picboxTituloDgv.Visible = true;

            this.Close();
        }

        private void botListadoFamiliaMat_Click(object sender, EventArgs e)
        {
            labTituloTotalGral.Visible = false;
            labValorTotalGral.Visible = false;

            frmMateriales.botSalirMat.Visible = false;
            frmMateriales.labTituloMat.Location = new Point(870, 102);
            botListadoFamilia.BackColor = Color.LightSteelBlue;
            botListadoFamilia.Location = new Point(350, 230);
            botListadoFamilia.Font = new Font(botListadoFamilia.Font.FontFamily, 18);
            botListadoFamilia.FlatStyle = FlatStyle.Flat;
            botListadoFamilia.FlatAppearance.BorderSize = 0;

            botListadoFaltantesMat.Visible = false;
            botCancelarMat.Visible = true;
            botSalirListaMat.Visible = false;

            picboxRecuaTotalGral.Visible = false;

            lisFamListMat.Font = new Font(lisFamListMat.Font.FontFamily, 14); // Cambiar el tamaño según sea necesario
            lisFamListMat.Visible = true;
            lisFamListMat.Location = new Point(618, 154);
            lisFamListMat.BackColor = Color.LightSteelBlue;
            lisFamListMat.Height = 254;
            lisFamListMat.Width = 190;
        }
        private void botListadoFaltantesMat_Click(object sender, EventArgs e)
        {
            labTituloTotalGral.Visible = false;
            labValorTotalGral.Visible = false;
            labTituloListado.Text = "Listados";
            labTituloListado .Location =new Point (482, 1);

            botListadoFamilia.Visible = false;
            botFaltanteFamilia.Visible = true;
            botFaltanteFamilia.Location = new Point(550, 200);
            botListadoFaltantesMat.FlatStyle = FlatStyle.Flat;
            botListadoFaltantesMat.FlatAppearance.BorderSize = 0;
            botListadoFaltantesMat.BackColor = Color.Transparent;
            botListadoFaltantesMat.Location = new Point(360, 240);
            botFaltanteTotal.Visible = true;
            botFaltanteTotal.Location = new Point(550, 280);
            

            picboxRecuaTotalGral.Visible = false;
        }

        private void comboxFamiliaValores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Insumos.Stock stock = new Insumos.Stock();
            stock.MaterialesEnExistencia(dgvListadoFamiliaValores, comboxFamiliaValores.Text);

            labTituloFamilia.Text = frmMateriales.listFamiliaMat.Text;
            labTituloFamilia.Location = new Point(1, 40);
            labTituloFamilia.ForeColor = Color.Green;
            labTituloFamilia.BorderStyle = BorderStyle.None;
            labTituloFamilia.Visible = true;
            labTituloValorFamila.Visible = true;
            labValorFamilia.Visible = true;

            picboxRecuaTotalFamilia.Visible = true;
           
            botListadoFamilia.Visible = false;

            dgvListadoFamiliaValores.Visible = true;
            dgvListadoFamiliaValores.Location = new Point(3, 70);

            frmMateriales.listFamiliaMat.Visible = false;
        }

        private void botCancelarListado_Click(object sender, EventArgs e)
        {
            labTituloFamilia.Visible = false;
            labTituloListado.Text = "Listado de valores";
            labTituloListado.Location = new Point(422, 1);
            labTituloValorFamila.Visible = false;
            labValorFamilia.Visible = false;
            labTituloTotalGral.Visible = true;
            labValorTotalGral.Visible = true;

            botListadoFamilia.Visible = true;
            botListadoFamilia.FlatStyle = FlatStyle.Standard;
            botListadoFamilia.Location = new Point(459, 200);
            botListadoFamilia.Font = new Font(botListadoFamilia.Font.FontFamily, 14);
            botListadoFaltantesMat.Visible = true;
            botListadoFaltantesMat.Location = new Point(459, 275);
            botListadoFaltantesMat.FlatStyle = FlatStyle.Standard; 
            botListadoFaltantesMat.FlatAppearance.BorderSize = 1; 
            botListadoFaltantesMat.BackColor = SystemColors.Control;
            botFaltanteFamilia.Visible = false;
            botFaltanteTotal.Visible = false;
            botSalirListaMat.Location = new Point(1260, 740);
            frmMateriales.botBuscarMat.Visible = false;

            picboxRecuaTotalFamilia.Visible = false;
            picboxRecuaTotalGral.Visible = true;

            dgvListadoFamiliaValores.Visible = false;
        }

        private void DgvData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            decimal total = 0;
            // Realizar el cálculo y actualizar la columna "Resultado"
            foreach (DataGridViewRow row in dgvListadoFamiliaValores.Rows)
            {
                // Obtener los valores de las columnas "Columna1" y "Columna2"
                int valor1 = Convert.ToInt32(row.Cells["Cantidad"].Value);
                decimal valor2 = Convert.ToDecimal(row.Cells["Valor"].Value);

                // Calcular el resultado
                decimal resultado = valor1 * valor2; // Aquí puedes poner tu lógica de cálculo

                // Asignar el resultado a la columna "Resultado"
                row.Cells["Total"].Value = resultado;

                total += resultado;
            }
            labValorFamilia.Text = total.ToString();
        }

        private void frmListadosMat_Load(object sender, EventArgs e)
        {

        }

        private void botCancelarMat_Click(object sender, EventArgs e)
        {
            botCancelarMat.Visible = false;
            botSalirListaMat.Visible = true;
        }

        private void lisFamListMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            texFamAEnviar.Text = lisFamListMat.SelectedItem.ToString();
            MODELOS.FuncionesSeleccionMaterial FuncionesSel = new MODELOS.FuncionesSeleccionMaterial();
            FuncionesSel.llenarDGVSeleccionStock(dgvListadoFamiliaValores, texFamAEnviar);

            labTituloValorFamila.Visible = true;
            labValorFamilia.Visible = true;

            botListadoFamilia.Visible = false;
            botCancelaListaMat.Visible = true;
            botCancelaListaMat.Location = new Point(1263,732);
            botCancelarMat.Visible = false;

            picboxRecuaLista.Visible = false;
            picboxRecuaTotalFamilia.Visible = true;

            lisFamListMat.Visible = false;

        }

        private void botCancelaListaMat_Click(object sender, EventArgs e)
        {
            labTituloValorFamila.Visible = false;
            labValorFamilia.Visible = false;

            botListadoFamilia.Visible = true;
            botListadoFamilia.Location = new Point(459,206);
            botListadoFamilia.BackColor = SystemColors.Window;
            botListadoFamilia.FlatStyle = FlatStyle.Standard;
            botListadoFaltantesMat.Visible = true;
            botCancelaListaMat.Visible = false;
            botSalirListaMat.Visible = true;

            picboxRecuaLista.Visible = true;
            picboxRecuaTotalFamilia.Visible = false;


            dgvListadoFamiliaValores.Visible = false;
        }
    }
}
