using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace _1.MODELOS
{
    public partial class SeleccionMaterialMod : Form
    {
        private frmModelos frmModelos;

        // Nuevo Modelo
        List<string> ListaMaterialesAEnviar = new List<string>();
        List<string> CantidadDeMaterialAEnviar = new List<string>();
        List<string> CantidadDisponibleActualizadaAEnviar = new List<string>();

        // Modificacion de cantidad de material ya usado en un modelo.
        List<string> NuevaCantidadxModeloList = new List<string>();
        List<string> texCantidadViejaList = new List<string>();
        List<string> IdMaterialList = new List<string>();

        // Eliminacion de material reciclable en modelo.
        List<string> IdMaterialReciclableAEliminar = new List<string>();
        List<string> CantidadUsadaDeMaterial = new List<string>();
        List<string> IdMaterialNoReciclableAEliminar = new List<string>();


        public SeleccionMaterialMod(frmModelos principal)
        {
            InitializeComponent();
            frmModelos = principal;
           
            this.Location = new Point(356,158);

            MODELOS.FuncionesSeleccionMaterial FuncionesSel = new MODELOS.FuncionesSeleccionMaterial();
            FuncionesSel.mostrarFamilias(comboxFamiliasSel);

            dgvSeleccionstockSel.AutoGenerateColumns = false;
            
            dgvSeleccionstockSel.ColumnCount = 9;

            dgvSeleccionstockSel.Columns[0].Name = "Grupo";
            dgvSeleccionstockSel.Columns[0].HeaderText = "          Grupo";
            dgvSeleccionstockSel.Columns[0].DataPropertyName = "Grupo";

            dgvSeleccionstockSel.Columns[1].Name = "Caracteristica";
            dgvSeleccionstockSel.Columns[1].HeaderText = " Caracteristica";
            dgvSeleccionstockSel.Columns[1].DataPropertyName = "Caracteristica";

            dgvSeleccionstockSel.Columns[2].Name = "Medidas";
            dgvSeleccionstockSel.Columns[2].HeaderText = "        Medidas";
            dgvSeleccionstockSel.Columns[2].DataPropertyName = "Medidas";

            dgvSeleccionstockSel.Columns[3].Name = "Codigo";
            dgvSeleccionstockSel.Columns[3].HeaderText = "          Codigo";
            dgvSeleccionstockSel.Columns[3].DataPropertyName = "Codigo";

            dgvSeleccionstockSel.Columns[4].Name = "Disponible";
            dgvSeleccionstockSel.Columns[4].HeaderText ="Disponible";
            dgvSeleccionstockSel.Columns[4].DataPropertyName = "Disponible";

            dgvSeleccionstockSel.Columns[5].Name = "Tipo";
            dgvSeleccionstockSel.Columns[5].HeaderText = "           Tipo";
            dgvSeleccionstockSel.Columns[5].DataPropertyName = "Tipo";

            dgvSeleccionstockSel.Columns[6].Name = "Fabricante";
            dgvSeleccionstockSel.Columns[6].HeaderText = "      Fabricante";
            dgvSeleccionstockSel.Columns[6].DataPropertyName = "Fabricante";

            dgvSeleccionstockSel.Columns[7].Name = "Estado";
            dgvSeleccionstockSel.Columns[7].HeaderText = "      Estado";
            dgvSeleccionstockSel.Columns[7].DataPropertyName = "Estado";
            dgvSeleccionstockSel.Columns[7].Width = 40;
            dgvSeleccionstockSel.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvSeleccionstockSel.Columns[8].Name = "IdAcopio";
            dgvSeleccionstockSel.Columns[8].HeaderText = "        IdAcopio";
            dgvSeleccionstockSel.Columns[8].DataPropertyName = "IdAcopio";

            dgvSeleccionstockSel.Columns[8].Visible = false;
            dgvSeleccionstockSel.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSeleccionstockSel.ReadOnly = true;
            int AnchoCant = 60;
            DataGridViewColumn columna8 = dgvSeleccionstockSel.Columns[4];
            columna8.Width = AnchoCant;

            dgvSeleccionstockSel.BackgroundColor = Color.Bisque;  //  Color del fondo del dgv
            dgvSeleccionstockSel.ColumnHeadersDefaultCellStyle.BackColor = Color.Tan ; //  Color de las cabeceras de las columnas
            dgvSeleccionstockSel.Height = 450;
           
            dgvMaterialesSeleccionadosSel.AutoGenerateColumns = false;
            if (frmModelos.dgvDatosSelecciondos.Rows.Count == 0)
            {
                dgvMaterialesSeleccionadosSel.Rows.Clear();
                dgvMaterialesSeleccionadosSel.Visible = false;
            }

            dgvMaterialesSeleccionadosSel.ColumnCount = 12;

            dgvMaterialesSeleccionadosSel.Columns[0].Name = "Familia";
            dgvMaterialesSeleccionadosSel.Columns[0].HeaderText = "          Familia";
            dgvMaterialesSeleccionadosSel.Columns[0].DataPropertyName = "Familia";

            dgvMaterialesSeleccionadosSel.Columns[1].Name = "Grupo";
            dgvMaterialesSeleccionadosSel.Columns[1].HeaderText = "          Grupo";
            dgvMaterialesSeleccionadosSel.Columns[1].DataPropertyName = "Grupo";

            dgvMaterialesSeleccionadosSel.Columns[2].Name = "Caracteristica";
            dgvMaterialesSeleccionadosSel.Columns[2].HeaderText = " Caracteristica";
            dgvMaterialesSeleccionadosSel.Columns[2].DataPropertyName = " Caracteristica";

            dgvMaterialesSeleccionadosSel.Columns[3].Name = "Medidas";
            dgvMaterialesSeleccionadosSel.Columns[3].HeaderText = "        Medidas";
            dgvMaterialesSeleccionadosSel.Columns[3].DataPropertyName = "Medidas";

            dgvMaterialesSeleccionadosSel.Columns[4].Name = "Codigo";
            dgvMaterialesSeleccionadosSel.Columns[4].HeaderText = "          Codigo";
            dgvMaterialesSeleccionadosSel.Columns[4].DataPropertyName = "Codigo";
            dgvMaterialesSeleccionadosSel.Columns[4].Width = 90;

            dgvMaterialesSeleccionadosSel.Columns[5].Name = "Fabricante";
            dgvMaterialesSeleccionadosSel.Columns[5].HeaderText = "Fabricante";
            dgvMaterialesSeleccionadosSel.Columns[5].DataPropertyName = "Fabricante";
            dgvMaterialesSeleccionadosSel.Columns[5].Width = 90;

            dgvMaterialesSeleccionadosSel.Columns[6].Name = "CantidadSeleccionada";
            dgvMaterialesSeleccionadosSel.Columns[6].HeaderText ="Cant.Sel";
            dgvMaterialesSeleccionadosSel.Columns[6].DataPropertyName = "CantidadSeleccionada";
            dgvMaterialesSeleccionadosSel.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMaterialesSeleccionadosSel.Columns[6].Width = 60;

            dgvMaterialesSeleccionadosSel.Columns[7].Name = "Tipo";
            dgvMaterialesSeleccionadosSel.Columns[7].HeaderText = "     Tipo";
            dgvMaterialesSeleccionadosSel.Columns[7].DataPropertyName = "Tipo";
            dgvMaterialesSeleccionadosSel.Columns[7].Width = 70;

            dgvMaterialesSeleccionadosSel.Columns[8].Name = "Cantidad";
            dgvMaterialesSeleccionadosSel.Columns[8].HeaderText = " Cantidad";
            dgvMaterialesSeleccionadosSel.Columns[8].DataPropertyName = "Cantidad";
            dgvMaterialesSeleccionadosSel.Columns[8].Visible = false;

            dgvMaterialesSeleccionadosSel.Columns[9].Name = "IdAcopio";
            dgvMaterialesSeleccionadosSel.Columns[9].HeaderText = "        IdAcopio";
            dgvMaterialesSeleccionadosSel.Columns[9].DataPropertyName = "IdAcopio";
            dgvMaterialesSeleccionadosSel.Columns[9].Visible = false;

            dgvMaterialesSeleccionadosSel.Columns[10].Name = "IdMaterial";
            dgvMaterialesSeleccionadosSel.Columns[10].HeaderText = " IdMaterial";
            dgvMaterialesSeleccionadosSel.Columns[10].DataPropertyName = "IdMaterial";
            dgvMaterialesSeleccionadosSel.Columns[10].Visible = false;

            dgvMaterialesSeleccionadosSel.Columns[11].Name = "IdMaterialesModelo";
            dgvMaterialesSeleccionadosSel.Columns[11].HeaderText = " IdMaterialesModelo";
            dgvMaterialesSeleccionadosSel.Columns[11].DataPropertyName = "IdMaterialesModelo";
            dgvMaterialesSeleccionadosSel.Columns[11].Visible = false;
             
            dgvMaterialesSeleccionadosSel.Location = new Point(207, 466);

            frmModelos.labModificaMod.Location = new Point(1093,224);

            frmModelos.picboxFotoMod.Location = new Point(1310, 173);
            frmModelos.picboxRecuaMod4.Location = new Point(1074,213);

            foreach (DataGridViewColumn column in dgvMaterialesSeleccionadosSel.Columns)
            {
                if (column.Index != 5) // Cambia el índice según la columna que desees permitir editar
                {
                    column.ReadOnly = true; // Establece la columna como solo lectura
                }
            }

            dgvMaterialesSeleccionadosSel.BackgroundColor = Color.Bisque;  //  Color del fondo del dgv
            dgvMaterialesSeleccionadosSel.ColumnHeadersDefaultCellStyle.BackColor = Color.Tan;  //  Color de las cabeceras de las columnas
            dgvMaterialesSeleccionadosSel.DefaultCellStyle.BackColor = Color.White;
            
            texCantidadMaterialSel.Focus();

            if (frmModelos.NuevoOModificacion == "Modificacion" || frmModelos.NuevoOModificacion == "Eliminacion")
            {
                //Se Limpian los list por si tenian informacion vieja.
                NuevaCantidadxModeloList.Clear();
                texCantidadViejaList.Clear();
                IdMaterialList.Clear();
                CantidadUsadaDeMaterial.Clear();
                IdMaterialReciclableAEliminar.Clear();
                IdMaterialNoReciclableAEliminar.Clear();

                dgvMaterialesSeleccionadosSel.Columns[8].Visible = false;
                dgvMaterialesSeleccionadosSel.Width = 732;
                botBorrarMaterialSel.Visible = true;

                if (dgvMaterialesSeleccionadosSel != null)
                {
                dgvMaterialesSeleccionadosSel.Rows.Clear();
                }
                if (frmModelos.dgvMaterialesenModificacion.Rows.Count > 0)
                {
                    // Itera (repite) a través de las filas en dgvMaterialesenModificacion
                    foreach (DataGridViewRow row in frmModelos.dgvMaterialesenModificacion.Rows)
                    {
                        DataGridViewRow newRow = new DataGridViewRow();
                        // Itera (repite) a través de las columnas en dgvMaterialesenModificacion, excluyendo la última columna
                        for (int columnIndex = 0; columnIndex < (frmModelos.dgvMaterialesenModificacion.Columns.Count -2); columnIndex++)
                        {
                            newRow.Cells.Add(new DataGridViewTextBoxCell());
                            // Copia el valor de la celda en dgvMaterialesenModificacion a la celda correspondiente en dgvMaterialesSeleccionadosSel
                            newRow.Cells[columnIndex].Value = row.Cells[columnIndex].Value;
                        }
                        dgvMaterialesSeleccionadosSel.Rows.Add(newRow);
                        int rowIndex = dgvMaterialesSeleccionadosSel.Rows.Count - 1;
                        dgvMaterialesSeleccionadosSel.Rows[rowIndex].Cells[10].Value = row.Cells[7].Value;
                        dgvMaterialesSeleccionadosSel.Rows[rowIndex].Cells[11].Value = row.Cells[8].Value;
                    }
                }
                dgvMaterialesSeleccionadosSel.Visible = true;

                if (frmModelos.NuevoOModificacion == "Eliminacion")
                {
                    labCantAsignada.Visible = false;

                    texFamiliaSel.Visible = false;
                    texCantidadMaterialSel.Visible = false;

                    botAceptarSel.Visible = false;

                    picboxRecuaCantAsignada.Visible = false;

                    comboxFamiliasSel.Visible = false;

                    dgvSeleccionstockSel.Visible = false;
                    dgvMaterialesSeleccionadosSel.Location = new Point(240,40);
                }
                dgvMaterialesSeleccionadosSel.ClearSelection();
            }
            else if (frmModelos.NuevoOModificacion == "Nuevo")
            {
                botSalirSel.Text = "CANCELAR";
                botSalirSel.Visible = true;
                botSalirSel.Location = new Point(1020,245);
            }
        }
          
        private void botSalirSel_Click(object sender, EventArgs e)
        {
            frmModelos.labModeloMod.BackColor = Color.Tan;
            frmModelos.labModeloMod.Location = new Point(534, 286);
            frmModelos.labAliasMod.BackColor = Color.Tan;
            frmModelos.labAliasMod.Location = new Point(783, 286);
            frmModelos.labEstadoMod.Visible = true;
            frmModelos.labEstadoMod.Location = new Point(593, 730);
            frmModelos.labEstadoMod.BackColor = Color.Tan;
            frmModelos.labDesdeMod.Visible = true;
            frmModelos.labDesdeMod.Location = new Point(834, 730);
            frmModelos.labDesdeMod.BackColor = Color.Tan;
            frmModelos.labIngresoMod.Visible = false;
            frmModelos.labModificaMod.Visible = true;
            frmModelos.labModificaMod.Location = new Point(976, 224);
            frmModelos.labTituloMod.Location = new Point(872, 96);

            frmModelos.texModeloMod.BackColor = Color.Tan;
            frmModelos.texModeloMod.Location = new Point(534, 305);
            frmModelos.texAliasMod.BackColor = Color.Tan;
            frmModelos.texAliasMod.Location = new Point(783, 305);
            frmModelos.texEstadoMod.Visible = true;
            frmModelos.texEstadoMod.Location = new Point(665, 729);
            frmModelos.texEstadoMod.BackColor = Color.Tan;
            frmModelos.texDesdeMod.Location = new Point(910,724);

            frmModelos.botIngresarMaterialMod.Visible = true;
            frmModelos.botIngresarMaterialMod.Location = new Point(1030, 298);
            frmModelos.botCancelarMod.Location = new Point(1079, 829);
            frmModelos.botGuardarMod.Visible = false;
            frmModelos.botCancelarMod.Visible = true;
            frmModelos.botCargarFotoMod.Visible = true;
            frmModelos.botCargarFotoMod.Location = new Point(401, 830);

            frmModelos.picboxRecuaMod3.Visible = true;
            frmModelos.picboxRecuaMod3.BackColor = Color.Tan;
            frmModelos.picboxRecuaMod3.Location = new Point(402, 257);
            frmModelos.picboxRecuaMod3.Height = 550;
            frmModelos.picboxRecuaMod4.Visible = true;
            frmModelos.picboxRecuaMod4.Location = new Point(959,213);
            frmModelos.picboxRecuaModeloAlias.Visible = true;
            frmModelos.picboxRecuaModeloAlias.Location = new Point(498,280);
            frmModelos.picboxRecuaModeloAlias.Height = 72;
            frmModelos.picboxRecuaModeloAlias.Width = 470;
            frmModelos.picboxRecuaModeloAlias.BackColor = Color.Tan;
            frmModelos.picboxRecuaEstadoFecha.Visible = true;
            frmModelos.picboxRecuaEstadoFecha.Location = new Point(561, 707);
            frmModelos.picboxRecuaEstadoFecha.BackColor = Color.Tan;
            frmModelos.picboxRecuaEstadoFecha.Width = 480;
            frmModelos.picboxFotoMod.Visible = true;

            frmModelos.dattimFechaMod.Location = new Point(910,727);

            dgvMaterialesSeleccionadosSel.Visible = true;

            frmModelos.dgvDatosSelecciondos .Visible = false;
            frmModelos.dgvMaterialesenModificacion.Visible = true; 
            frmModelos.dgvMaterialesenModificacion.Width = 755;
            frmModelos.dgvMaterialesenModificacion.Height = 332;
            frmModelos.dgvMaterialesenModificacion.Location = new Point(437, 370);
                    
            this.Close();
        }
          
        private void comboxFamiliasSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (frmModelos.NuevoOModificacion != "Eliminacion")
            {
            texFamiliaSel.Text = "Agrega Material";
            texFamiliaSel.Text = comboxFamiliasSel.Text;
            MODELOS.FuncionesSeleccionMaterial FuncionesSel = new MODELOS.FuncionesSeleccionMaterial();

            FuncionesSel.llenarDGVSeleccionStock(dgvSeleccionstockSel, texFamiliaSel);
                        
            comboxFamiliasSel.Visible = false;
            texFamiliaSel.Visible = true ;
            texFamiliaSel.Location = new Point(0, 41);
            texFamiliaSel.BackColor = Color.Bisque;
            
            texCantidadMaterialSel.Focus();
            }
            dgvSeleccionstockSel.ClearSelection();
            dgvSeleccionstockSel.CurrentCell = null;
            dgvSeleccionstockSel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSeleccionstockSel.MultiSelect = false;
        }
  
        private void texCantidadMaterialSel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (dgvSeleccionstockSel.RowCount > 0)
                {
                 decimal disponible = decimal.Parse(dgvSeleccionstockSel.CurrentRow.Cells[4].Value.ToString());
                    decimal cantSeleccionada = decimal.Parse(texCantidadMaterialSel.Text);
                    if (cantSeleccionada <= disponible)
                    {
                        ListaMaterialesAEnviar.Add(dgvSeleccionstockSel.CurrentRow.Cells[8].Value.ToString());
                        CantidadDeMaterialAEnviar.Add(texCantidadMaterialSel.Text);
                        CantidadDisponibleActualizadaAEnviar.Add((disponible - decimal.Parse(texCantidadMaterialSel.Text)).ToString()); ;
                        DataGridViewRow currentRow = dgvSeleccionstockSel.CurrentRow;

                        if (currentRow != null)
                        {
                            DataGridViewRow newRow = new DataGridViewRow();  // Clona la fila actual para copiarla
                            newRow.Cells.Add(new DataGridViewTextBoxCell());
                            newRow.Cells[0].Value = texFamiliaSel.Text;
                            for (int i = 0; i < currentRow.Cells.Count; i++)  // Copia las celdas de la fila actual a la nueva fila
                            {
                                newRow.Cells.Add(new DataGridViewTextBoxCell());
                                if (i >= 0 && i <= 3 || i >= 5 && i <= 7)
                                {
                                    newRow.Cells[(i + 1)].Value = currentRow.Cells[i].Value;
                                }
                                else if (i == 4)
                                {
                                    newRow.Cells[(i + 1)].Value = texCantidadMaterialSel.Text;
                                }
                                                          }
                            newRow.Cells.Add(new DataGridViewTextBoxCell());
                            newRow.Cells[9].Value = currentRow.Cells[4].Value;

                            // Agrega la nueva fila a dgvDestination
                            dgvMaterialesSeleccionadosSel.Rows.Add(newRow);
                            picboxRecuaCantAsignada.Visible = false;
                            labCantAsignada.Visible = false;
                            texCantidadMaterialSel.Visible = false;

                            dgvMaterialesSeleccionadosSel.Visible = true;

                            texCantidadMaterialSel.Text = "";
                        }
                        botAceptarSel.Focus();
                        botBorrarMaterialSel.Visible = true;

                        if (dgvMaterialesSeleccionadosSel.RowCount == 1)
                        {
                            this.Height = 850;
                            dgvMaterialesSeleccionadosSel .Location =new Point (240,490);
                            botSalirSel.Location = new Point (855, 793);
                            botSalirSel.Text = "SALIR"; 
                        }
                        decimal nuevoDisponible = disponible - cantSeleccionada;
                        dgvSeleccionstockSel.CurrentRow.Cells[4].Value = nuevoDisponible;
                        dgvSeleccionstockSel.ClearSelection();
                        //dgvMaterialesSeleccionadosSel.SelectionChanged += DgvMaterialesSeleccionadosSel_SelectionChanged;

                        if (dgvMaterialesSeleccionadosSel.Rows.Count > 0)
                        {
                            dgvMaterialesSeleccionadosSel.Rows[0].Selected = false;
                        }

                    }
                    else
                        MessageBox.Show("La cantidad supera lo disponible");
                }
            else MessageBox.Show("La familia seleccionada no tiene materiales ingresados");
            }
        }

        private void texFamiliaSel_Click(object sender, EventArgs e)
        {
            comboxFamiliasSel.DroppedDown = true;
            comboxFamiliasSel.Visible = true;
            texFamiliaSel.Visible = false;
        }

        private void botAceptarSel_Click(object sender, EventArgs e)
        {
            frmModelos.labModeloMod.Location = new Point(534, 286);
            frmModelos.labAliasMod.Location = new Point(783, 286);
            frmModelos.labModificaMod.Location = new Point(976, 224);
            frmModelos.labIngresoMod.Location = new Point(1166,223);
            frmModelos.labTituloMod.Location = new Point(872, 96);

            frmModelos.texModeloMod.BackColor = Color.Tan;
            frmModelos.texModeloMod.Location = new Point(534, 305);
            frmModelos.texAliasMod.BackColor = Color.Tan;
            frmModelos.texAliasMod.Location = new Point(783, 305);

            frmModelos.botSalirMod.Visible = false;
            frmModelos.botIngresarMaterialMod.Visible = false;
           
            frmModelos.picboxRecuaMod3.Visible = true;
            frmModelos.picboxRecuaMod3.Location = new Point(402, 257);
            frmModelos.picboxRecuaMod3.BackColor = Color.Tan;
            frmModelos.picboxRecuaMod4.Visible = true;
            frmModelos.picboxRecuaMod4.Location = new Point(959, 213);
            frmModelos.picboxRecuaModeloAlias.Visible = true;
            frmModelos.picboxRecuaModeloAlias.Height = 72;
            frmModelos.picboxRecuaModeloAlias.Width = 470;
            frmModelos.picboxRecuaModeloAlias.Location = new Point(498,280);
            frmModelos.picboxRecuaModeloAlias.BackColor = Color.Tan;
            frmModelos.picboxFotoMod.Visible = true;

           /* frmModelos.dgvDatosSelecciondos.Visible = true;
            frmModelos.dgvDatosSelecciondos.Location = new Point(423, 370);
            frmModelos.dgvDatosSelecciondos.BackgroundColor  = Color.Tan ;
            frmModelos.dgvDatosSelecciondos.Width = 733;
            frmModelos.dgvDatosSelecciondos.Height = 300;
            frmModelos.dgvDatosSelecciondos.Columns.Clear();*/

            foreach (DataGridViewColumn column in dgvMaterialesSeleccionadosSel.Columns)
            {
                frmModelos.dgvDatosSelecciondos.Columns.Add(column.Clone() as DataGridViewColumn);
            }

            // Copia los datos de dataGridView1 a dataGridView2
            foreach (DataGridViewRow row in dgvMaterialesSeleccionadosSel.Rows)
            {
                if (!row.IsNewRow) // Asegúrate de no copiar la fila de edición si está habilitada
                {
                    int rowIndex = frmModelos.dgvDatosSelecciondos.Rows.Add();
                    for (int columnIndex = 0; columnIndex < dgvMaterialesSeleccionadosSel.Columns.Count; columnIndex++)
                    {
                        frmModelos.dgvDatosSelecciondos.Rows[rowIndex].Cells[columnIndex].Value = row.Cells[columnIndex].Value;
                    }
                }
            }
           
            frmModelos.picboxRecuaMod3.Size = new Size(775, 550);
            frmModelos.ListaMateriales.Clear();
            frmModelos.CantidadDeMaterial.Clear();
            frmModelos.CantidadDisponibleActualizada.Clear();
            frmModelos.IdMaterialNoReciclableAEliminarMod.Clear();
            frmModelos.IdMaterialReciclableAEliminarMod.Clear();
            frmModelos.CantidadUsadaDeMaterialMod.Clear();

            if (ListaMaterialesAEnviar.Count() > 0)
            {
            for (int i = 0; i < ListaMaterialesAEnviar.Count; i++)
            {
                frmModelos.ListaMateriales.Add(ListaMaterialesAEnviar[i]);
                frmModelos.CantidadDeMaterial.Add(CantidadDeMaterialAEnviar[i]);
                frmModelos.CantidadDisponibleActualizada.Add(CantidadDisponibleActualizadaAEnviar[i]);
            }
            if (IdMaterialReciclableAEliminar.Count() > 0)
                {
                    for (int i = 0; i < IdMaterialReciclableAEliminar.Count; i++)
                    {
                        frmModelos.IdMaterialReciclableAEliminarMod.Add(IdMaterialReciclableAEliminar[i]);
                        frmModelos.CantidadUsadaDeMaterialMod.Add(CantidadUsadaDeMaterial[i]);
                    }
                }
            }
            if (IdMaterialNoReciclableAEliminar.Count > 0)
            {
                for (int i = 0; i < IdMaterialNoReciclableAEliminar.Count; i++)
                {
                    frmModelos.IdMaterialNoReciclableAEliminarMod.Add(IdMaterialNoReciclableAEliminar[i]);
                }
            }
            if (IdMaterialList.Count() > 0)
            {
                for (int i = 0; i < IdMaterialList.Count; i++)
                {
                    frmModelos.NuevaCantidadxModelo.Add(NuevaCantidadxModeloList[i]);
                    frmModelos.texCantidadVieja.Add(texCantidadViejaList[i]);
                    frmModelos.IdMaterial.Add(IdMaterialList[i]);
                }
            }
            if (frmModelos.NuevoOModificacion == "Nuevo")
            {
                MODELOS.frmEstadoAviones frmEstadoAviones = new MODELOS.frmEstadoAviones(frmModelos);
                frmEstadoAviones.Location = new Point(660, 479);
                frmEstadoAviones.Show();
                frmEstadoAviones.botEstadoEst.Focus();
            }
            else if (frmModelos.NuevoOModificacion == "Modificacion")
            {
                frmModelos.labModeloMod.BackColor = Color.Tan;
                frmModelos.labAliasMod.BackColor = Color.Tan;
                frmModelos.labEstadoMod .Location =new Point (593,730);
                frmModelos.labDesdeMod.Location = new Point(834, 730);

                frmModelos.texModeloMod.BackColor = Color.Tan;
                frmModelos.texAliasMod.BackColor = Color.Tan;
                frmModelos.texEstadoMod.Location = new Point(665, 729);
                frmModelos.texDesdeMod.Location = new Point(910, 724);

                frmModelos.dattimFechaMod.Location = new Point(910, 727);

                frmModelos.picboxRecuaModeloAlias.BackColor = Color.Tan;
                frmModelos.picboxRecuaEstadoFecha.BackColor = Color.Tan;
                frmModelos.picboxRecuaEstadoFecha.Location = new Point(561, 707);
                frmModelos.picboxRecuaMod3.Width = 810;
                frmModelos.picboxRecuaMod3.Height = 550;

                frmModelos.botIngresarMaterialMod.Visible = true;
                frmModelos.botIngresarMaterialMod.Location = new Point(1020, 295);
                frmModelos.botCargarFotoMod.Visible = true;
                frmModelos.botCargarFotoMod.Location = new Point(401, 830);
                frmModelos.botCancelarMod.Visible = true;

                dgvMaterialesSeleccionadosSel.Visible = true;
                
                frmModelos.dgvDatosSelecciondos.BorderStyle = BorderStyle.None;
                frmModelos.dgvDatosSelecciondos.Location = new Point(430, 370);
                frmModelos.dgvDatosSelecciondos.BackgroundColor = Color.Tan;
                frmModelos.dgvDatosSelecciondos.Width = 750;
                frmModelos.dgvDatosSelecciondos.Height = 326;

                
                
                frmModelos.dgvDatosSelecciondos.ClearSelection();
                frmModelos.dgvDatosSelecciondos.CurrentCell = null;
                frmModelos.dgvDatosSelecciondos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                frmModelos.dgvDatosSelecciondos.MultiSelect = false;

                frmModelos.dgvMaterialesenModificacion.Visible = true;
            }
            this.Close();
        }

        private void dgvSeleccionstockSel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            texCantidadMaterialSel.Visible = true;
            picboxRecuaCantAsignada.Visible = true;
            labCantAsignada.Visible = true;
            texCantidadMaterialSel.Focus();
        }

        private void botBorrarMaterialSel_Click(object sender, EventArgs e)
        {
            if (frmModelos.NuevoOModificacion == "Nuevo")
            {
                botBorrarMaterialSel.ForeColor = Color.Black;
                for(int i = 0; i < ListaMaterialesAEnviar.Count(); i++)
                {
                    if (ListaMaterialesAEnviar[i] == dgvMaterialesSeleccionadosSel.CurrentRow.Cells[8].Value.ToString())
                    {
                        ListaMaterialesAEnviar.RemoveAt(i);
                        CantidadDeMaterialAEnviar.RemoveAt(i);
                        CantidadDisponibleActualizadaAEnviar.RemoveAt(i);
                    }
                }
                dgvMaterialesSeleccionadosSel.Rows.Remove(dgvMaterialesSeleccionadosSel.CurrentRow);
                botBorrarMaterialSel.Enabled = false;
            }
            else if (frmModelos.NuevoOModificacion == "Modificacion" || frmModelos.NuevoOModificacion == "Eliminacion")
            {
                bool existe = false;
                for (int i = 0; i < ListaMaterialesAEnviar.Count(); i++)
                {
                    if (ListaMaterialesAEnviar[i] == dgvMaterialesSeleccionadosSel.CurrentRow.Cells[8].Value.ToString())
                    {
                        ListaMaterialesAEnviar.RemoveAt(i);
                        CantidadDeMaterialAEnviar.RemoveAt(i);
                        CantidadDisponibleActualizadaAEnviar.RemoveAt(i);
                        existe = true;
                    }
                }
                if (!existe)
                {
                    // Mostrar un cuadro de diálogo con botones de Sí y No
                    DialogResult resultado = MessageBox.Show("¿Este material se recicla?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    botAceptarSel.Visible = true;

                    // Verificar la decisión del usuario
                    if (resultado == DialogResult.Yes)
                    {
                        IdMaterialReciclableAEliminar.Add(dgvMaterialesSeleccionadosSel.CurrentRow.Cells[11].Value.ToString());
                        CantidadUsadaDeMaterial.Add(dgvMaterialesSeleccionadosSel.CurrentRow.Cells[5].Value.ToString());
                        MessageBox.Show(IdMaterialReciclableAEliminar[0], CantidadUsadaDeMaterial[0]);
                    }
                    else
                    {
                        IdMaterialNoReciclableAEliminar.Add(dgvMaterialesSeleccionadosSel.CurrentRow.Cells[11].Value.ToString());
                    }
                }
                dgvMaterialesSeleccionadosSel.Rows.Remove(dgvMaterialesSeleccionadosSel.CurrentRow);
                dgvMaterialesSeleccionadosSel.ClearSelection();
                dgvMaterialesSeleccionadosSel.CurrentCell = null;
                dgvMaterialesSeleccionadosSel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvMaterialesSeleccionadosSel.MultiSelect = false;
                botBorrarMaterialSel.Enabled = false;
            }
        }

        private void dgvMaterialesSeleccionadosSel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex != -1 && dgvMaterialesSeleccionadosSel.CurrentRow.Cells[0].Value.ToString() != "Monokote")
            {
                texCantViejaSel.Text = dgvMaterialesSeleccionadosSel.CurrentCell.Value.ToString();
            }
        }

        private void dgvMaterialesSeleccionadosSel_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMaterialesSeleccionadosSel.CurrentRow.Cells[5].Value.ToString() != texCantViejaSel.Text)
            {
                if (frmModelos.NuevoOModificacion == "Nuevo")
                {
                    string idAcopioAModificar = dgvMaterialesSeleccionadosSel.CurrentRow.Cells[8].Value.ToString();
                    for (int i = 0; i < ListaMaterialesAEnviar.Count(); i++)
                    {
                        if (ListaMaterialesAEnviar[i] == idAcopioAModificar)
                        {

                            CantidadDeMaterialAEnviar[i] = dgvMaterialesSeleccionadosSel.CurrentRow.Cells[5].Value.ToString();
                            MODELOS.FuncionesSeleccionMaterial funciones = new MODELOS.FuncionesSeleccionMaterial();
                            string variableDisponible = funciones.DisponibleMaterialSeleccion(idAcopioAModificar);
                            decimal disponible = decimal.Parse(variableDisponible);
                            if (decimal.Parse(dgvMaterialesSeleccionadosSel.CurrentRow.Cells[5].Value.ToString()) <= disponible)
                            {
                                CantidadDisponibleActualizadaAEnviar[i] = (disponible - decimal.Parse(dgvMaterialesSeleccionadosSel.CurrentRow.Cells[5].Value.ToString())).ToString();
                            } else MessageBox.Show("La cantidad supera lo disponible");

                        }
                    }
                }else if (frmModelos.NuevoOModificacion == "Modificacion")
                {
                    if (dgvMaterialesSeleccionadosSel.CurrentRow.Cells[11].Value == null)
                    {
                        for ( int i = 0; i < ListaMaterialesAEnviar.Count; i++)
                        {
                            if(dgvMaterialesSeleccionadosSel.CurrentRow.Cells[8].Value.ToString() == ListaMaterialesAEnviar[i])
                            {
                                CantidadDeMaterialAEnviar[i] = (dgvMaterialesSeleccionadosSel.CurrentRow.Cells[5].Value.ToString());
                                CantidadDisponibleActualizadaAEnviar[i] = (decimal.Parse(CantidadDisponibleActualizadaAEnviar[i]) + (decimal.Parse(texCantViejaSel.Text) - decimal.Parse(dgvMaterialesSeleccionadosSel.CurrentRow.Cells[5].Value.ToString())) ).ToString();
                            }
                        }
                    } else
                    {
                        NuevaCantidadxModeloList.Add(dgvMaterialesSeleccionadosSel.CurrentRow.Cells[5].Value.ToString());
                        texCantidadViejaList.Add(texCantViejaSel.Text);
                        IdMaterialList.Add(dgvMaterialesSeleccionadosSel.CurrentRow.Cells[10].Value.ToString());
                    }
                }
            }
        }

        private void SeleccionMaterialMod_Load(object sender, EventArgs e)
        {
            comboxFamiliasSel.SelectedIndex = 0;
            texCantidadMaterialSel.Select();
            dgvSeleccionstockSel.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvMaterialesSeleccionadosSel.CurrentRow.Cells[11].Value == null)
            {

            MessageBox.Show("Estoy Vacio");
            } else MessageBox.Show("No Estoy Vacio");
        }

         private void DgvMaterialesSeleccionadosSel_SelectionChanged(object sender, EventArgs e)
        {
            dgvSeleccionstockSel.ClearSelection();
            dgvSeleccionstockSel.CurrentCell = null;
            dgvSeleccionstockSel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSeleccionstockSel.MultiSelect = false;
        }

        private void dgvMaterialesSeleccionadosSel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            botBorrarMaterialSel.ForeColor = Color.Blue;
            botBorrarMaterialSel.Enabled = true;
        }
    }
}
