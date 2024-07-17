namespace _1.INSUMOS
{
    partial class frmListadosMat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.botListadoFaltantesMat = new System.Windows.Forms.Button();
            this.botListadoFamilia = new System.Windows.Forms.Button();
            this.labTituloListado = new System.Windows.Forms.Label();
            this.botSalirListaMat = new System.Windows.Forms.Button();
            this.labTituloTotalGral = new System.Windows.Forms.Label();
            this.labValorTotalGral = new System.Windows.Forms.Label();
            this.picboxRecuaTotalGral = new System.Windows.Forms.PictureBox();
            this.comboxFamiliaValores = new System.Windows.Forms.ComboBox();
            this.dgvListadoFamiliaValores = new System.Windows.Forms.DataGridView();
            this.labTituloFamilia = new System.Windows.Forms.Label();
            this.picboxRecuaTotalFamilia = new System.Windows.Forms.PictureBox();
            this.labTituloValorFamila = new System.Windows.Forms.Label();
            this.labValorFamilia = new System.Windows.Forms.Label();
            this.picboxRecuaLista = new System.Windows.Forms.PictureBox();
            this.botFaltanteFamilia = new System.Windows.Forms.Button();
            this.botFaltanteTotal = new System.Windows.Forms.Button();
            this.botCancelarMat = new System.Windows.Forms.Button();
            this.lisFamListMat = new System.Windows.Forms.ListBox();
            this.texFamAEnviar = new System.Windows.Forms.TextBox();
            this.botCancelaListaMat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRecuaTotalGral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoFamiliaValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRecuaTotalFamilia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRecuaLista)).BeginInit();
            this.SuspendLayout();
            // 
            // botListadoFaltantesMat
            // 
            this.botListadoFaltantesMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botListadoFaltantesMat.Location = new System.Drawing.Point(459, 282);
            this.botListadoFaltantesMat.Name = "botListadoFaltantesMat";
            this.botListadoFaltantesMat.Size = new System.Drawing.Size(160, 54);
            this.botListadoFaltantesMat.TabIndex = 0;
            this.botListadoFaltantesMat.Text = "Faltantes";
            this.botListadoFaltantesMat.UseVisualStyleBackColor = true;
            this.botListadoFaltantesMat.Click += new System.EventHandler(this.botListadoFaltantesMat_Click);
            // 
            // botListadoFamilia
            // 
            this.botListadoFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botListadoFamilia.Location = new System.Drawing.Point(459, 206);
            this.botListadoFamilia.Name = "botListadoFamilia";
            this.botListadoFamilia.Size = new System.Drawing.Size(160, 54);
            this.botListadoFamilia.TabIndex = 0;
            this.botListadoFamilia.Text = "Por familia";
            this.botListadoFamilia.UseCompatibleTextRendering = true;
            this.botListadoFamilia.UseVisualStyleBackColor = true;
            this.botListadoFamilia.Click += new System.EventHandler(this.botListadoFamiliaMat_Click);
            // 
            // labTituloListado
            // 
            this.labTituloListado.AutoSize = true;
            this.labTituloListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTituloListado.Location = new System.Drawing.Point(402, 1);
            this.labTituloListado.Name = "labTituloListado";
            this.labTituloListado.Size = new System.Drawing.Size(286, 33);
            this.labTituloListado.TabIndex = 1;
            this.labTituloListado.Text = "Listados de valores";
            // 
            // botSalirListaMat
            // 
            this.botSalirListaMat.BackColor = System.Drawing.SystemColors.Window;
            this.botSalirListaMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botSalirListaMat.Location = new System.Drawing.Point(1263, 732);
            this.botSalirListaMat.Name = "botSalirListaMat";
            this.botSalirListaMat.Size = new System.Drawing.Size(153, 54);
            this.botSalirListaMat.TabIndex = 2;
            this.botSalirListaMat.Text = "SALIR";
            this.botSalirListaMat.UseVisualStyleBackColor = false;
            this.botSalirListaMat.Visible = false;
            this.botSalirListaMat.Click += new System.EventHandler(this.botSalirListaMat_Click);
            // 
            // labTituloTotalGral
            // 
            this.labTituloTotalGral.AutoSize = true;
            this.labTituloTotalGral.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTituloTotalGral.Location = new System.Drawing.Point(407, 530);
            this.labTituloTotalGral.Name = "labTituloTotalGral";
            this.labTituloTotalGral.Size = new System.Drawing.Size(179, 25);
            this.labTituloTotalGral.TabIndex = 3;
            this.labTituloTotalGral.Text = "Total general US:";
            // 
            // labValorTotalGral
            // 
            this.labValorTotalGral.AutoSize = true;
            this.labValorTotalGral.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labValorTotalGral.ForeColor = System.Drawing.Color.Green;
            this.labValorTotalGral.Location = new System.Drawing.Point(609, 524);
            this.labValorTotalGral.Name = "labValorTotalGral";
            this.labValorTotalGral.Size = new System.Drawing.Size(78, 31);
            this.labValorTotalGral.TabIndex = 4;
            this.labValorTotalGral.Text = "valor";
            // 
            // picboxRecuaTotalGral
            // 
            this.picboxRecuaTotalGral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxRecuaTotalGral.Location = new System.Drawing.Point(359, 509);
            this.picboxRecuaTotalGral.Name = "picboxRecuaTotalGral";
            this.picboxRecuaTotalGral.Size = new System.Drawing.Size(376, 66);
            this.picboxRecuaTotalGral.TabIndex = 5;
            this.picboxRecuaTotalGral.TabStop = false;
            // 
            // comboxFamiliaValores
            // 
            this.comboxFamiliaValores.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboxFamiliaValores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxFamiliaValores.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboxFamiliaValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxFamiliaValores.FormattingEnabled = true;
            this.comboxFamiliaValores.Location = new System.Drawing.Point(1086, 123);
            this.comboxFamiliaValores.Name = "comboxFamiliaValores";
            this.comboxFamiliaValores.Size = new System.Drawing.Size(264, 32);
            this.comboxFamiliaValores.TabIndex = 6;
            this.comboxFamiliaValores.Visible = false;
            this.comboxFamiliaValores.SelectedIndexChanged += new System.EventHandler(this.comboxFamiliaValores_SelectedIndexChanged);
            // 
            // dgvListadoFamiliaValores
            // 
            this.dgvListadoFamiliaValores.AllowUserToAddRows = false;
            this.dgvListadoFamiliaValores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListadoFamiliaValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoFamiliaValores.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListadoFamiliaValores.EnableHeadersVisualStyles = false;
            this.dgvListadoFamiliaValores.Location = new System.Drawing.Point(1, 90);
            this.dgvListadoFamiliaValores.Name = "dgvListadoFamiliaValores";
            this.dgvListadoFamiliaValores.RowHeadersVisible = false;
            this.dgvListadoFamiliaValores.Size = new System.Drawing.Size(367, 100);
            this.dgvListadoFamiliaValores.TabIndex = 7;
            this.dgvListadoFamiliaValores.Visible = false;
            // 
            // labTituloFamilia
            // 
            this.labTituloFamilia.AutoSize = true;
            this.labTituloFamilia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTituloFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTituloFamilia.Location = new System.Drawing.Point(1189, 38);
            this.labTituloFamilia.Name = "labTituloFamilia";
            this.labTituloFamilia.Size = new System.Drawing.Size(2, 33);
            this.labTituloFamilia.TabIndex = 9;
            this.labTituloFamilia.Visible = false;
            // 
            // picboxRecuaTotalFamilia
            // 
            this.picboxRecuaTotalFamilia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxRecuaTotalFamilia.Location = new System.Drawing.Point(749, 650);
            this.picboxRecuaTotalFamilia.Name = "picboxRecuaTotalFamilia";
            this.picboxRecuaTotalFamilia.Size = new System.Drawing.Size(365, 66);
            this.picboxRecuaTotalFamilia.TabIndex = 10;
            this.picboxRecuaTotalFamilia.TabStop = false;
            this.picboxRecuaTotalFamilia.Visible = false;
            // 
            // labTituloValorFamila
            // 
            this.labTituloValorFamila.AutoSize = true;
            this.labTituloValorFamila.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTituloValorFamila.Location = new System.Drawing.Point(793, 672);
            this.labTituloValorFamila.Name = "labTituloValorFamila";
            this.labTituloValorFamila.Size = new System.Drawing.Size(171, 24);
            this.labTituloValorFamila.TabIndex = 11;
            this.labTituloValorFamila.Text = "Total                  US:";
            this.labTituloValorFamila.Visible = false;
            // 
            // labValorFamilia
            // 
            this.labValorFamilia.AutoSize = true;
            this.labValorFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labValorFamilia.ForeColor = System.Drawing.Color.DarkRed;
            this.labValorFamilia.Location = new System.Drawing.Point(992, 666);
            this.labValorFamilia.Name = "labValorFamilia";
            this.labValorFamilia.Size = new System.Drawing.Size(82, 31);
            this.labValorFamilia.TabIndex = 12;
            this.labValorFamilia.Text = "Valor";
            this.labValorFamilia.Visible = false;
            // 
            // picboxRecuaLista
            // 
            this.picboxRecuaLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxRecuaLista.Location = new System.Drawing.Point(278, 152);
            this.picboxRecuaLista.Name = "picboxRecuaLista";
            this.picboxRecuaLista.Size = new System.Drawing.Size(533, 245);
            this.picboxRecuaLista.TabIndex = 15;
            this.picboxRecuaLista.TabStop = false;
            // 
            // botFaltanteFamilia
            // 
            this.botFaltanteFamilia.BackColor = System.Drawing.SystemColors.Window;
            this.botFaltanteFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botFaltanteFamilia.Location = new System.Drawing.Point(931, 194);
            this.botFaltanteFamilia.Name = "botFaltanteFamilia";
            this.botFaltanteFamilia.Size = new System.Drawing.Size(139, 54);
            this.botFaltanteFamilia.TabIndex = 16;
            this.botFaltanteFamilia.Text = "Por familia";
            this.botFaltanteFamilia.UseVisualStyleBackColor = false;
            this.botFaltanteFamilia.Visible = false;
            // 
            // botFaltanteTotal
            // 
            this.botFaltanteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botFaltanteTotal.Location = new System.Drawing.Point(931, 269);
            this.botFaltanteTotal.Name = "botFaltanteTotal";
            this.botFaltanteTotal.Size = new System.Drawing.Size(139, 54);
            this.botFaltanteTotal.TabIndex = 17;
            this.botFaltanteTotal.Text = "Total";
            this.botFaltanteTotal.UseVisualStyleBackColor = true;
            this.botFaltanteTotal.Visible = false;
            // 
            // botCancelarMat
            // 
            this.botCancelarMat.Location = new System.Drawing.Point(678, 419);
            this.botCancelarMat.Name = "botCancelarMat";
            this.botCancelarMat.Size = new System.Drawing.Size(133, 38);
            this.botCancelarMat.TabIndex = 18;
            this.botCancelarMat.Text = "CANCELAR";
            this.botCancelarMat.UseVisualStyleBackColor = true;
            this.botCancelarMat.Visible = false;
            this.botCancelarMat.Click += new System.EventHandler(this.botCancelarMat_Click);
            // 
            // lisFamListMat
            // 
            this.lisFamListMat.FormattingEnabled = true;
            this.lisFamListMat.Location = new System.Drawing.Point(34, 596);
            this.lisFamListMat.Name = "lisFamListMat";
            this.lisFamListMat.Size = new System.Drawing.Size(120, 95);
            this.lisFamListMat.TabIndex = 19;
            this.lisFamListMat.Visible = false;
            this.lisFamListMat.SelectedIndexChanged += new System.EventHandler(this.lisFamListMat_SelectedIndexChanged);
            // 
            // texFamAEnviar
            // 
            this.texFamAEnviar.Location = new System.Drawing.Point(63, 38);
            this.texFamAEnviar.Name = "texFamAEnviar";
            this.texFamAEnviar.Size = new System.Drawing.Size(100, 20);
            this.texFamAEnviar.TabIndex = 20;
            this.texFamAEnviar.Visible = false;
            // 
            // botCancelaListaMat
            // 
            this.botCancelaListaMat.Location = new System.Drawing.Point(1263, 650);
            this.botCancelaListaMat.Name = "botCancelaListaMat";
            this.botCancelaListaMat.Size = new System.Drawing.Size(152, 54);
            this.botCancelaListaMat.TabIndex = 21;
            this.botCancelaListaMat.Text = "CANCELAR";
            this.botCancelaListaMat.UseVisualStyleBackColor = true;
            this.botCancelaListaMat.Visible = false;
            this.botCancelaListaMat.Click += new System.EventHandler(this.botCancelaListaMat_Click);
            // 
            // frmListadosMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1428, 798);
            this.Controls.Add(this.botCancelaListaMat);
            this.Controls.Add(this.texFamAEnviar);
            this.Controls.Add(this.lisFamListMat);
            this.Controls.Add(this.botCancelarMat);
            this.Controls.Add(this.botFaltanteTotal);
            this.Controls.Add(this.botFaltanteFamilia);
            this.Controls.Add(this.labValorFamilia);
            this.Controls.Add(this.labTituloValorFamila);
            this.Controls.Add(this.picboxRecuaTotalFamilia);
            this.Controls.Add(this.labTituloFamilia);
            this.Controls.Add(this.dgvListadoFamiliaValores);
            this.Controls.Add(this.comboxFamiliaValores);
            this.Controls.Add(this.labValorTotalGral);
            this.Controls.Add(this.labTituloTotalGral);
            this.Controls.Add(this.botSalirListaMat);
            this.Controls.Add(this.labTituloListado);
            this.Controls.Add(this.botListadoFaltantesMat);
            this.Controls.Add(this.botListadoFamilia);
            this.Controls.Add(this.picboxRecuaTotalGral);
            this.Controls.Add(this.picboxRecuaLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListadosMat";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmListadosMat";
            this.Load += new System.EventHandler(this.frmListadosMat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxRecuaTotalGral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoFamiliaValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRecuaTotalFamilia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRecuaLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botListadoFaltantesMat;
        private System.Windows.Forms.Button botListadoFamilia;
        private System.Windows.Forms.Label labTituloListado;
        private System.Windows.Forms.Label labTituloTotalGral;
        private System.Windows.Forms.Label labValorTotalGral;
        private System.Windows.Forms.PictureBox picboxRecuaTotalGral;
        private System.Windows.Forms.ComboBox comboxFamiliaValores;
        public System.Windows.Forms.DataGridView dgvListadoFamiliaValores;
        private System.Windows.Forms.Label labTituloFamilia;
        private System.Windows.Forms.PictureBox picboxRecuaTotalFamilia;
        private System.Windows.Forms.Label labTituloValorFamila;
        private System.Windows.Forms.Label labValorFamilia;
        public System.Windows.Forms.Button botSalirListaMat;
        private System.Windows.Forms.PictureBox picboxRecuaLista;
        private System.Windows.Forms.Button botFaltanteFamilia;
        private System.Windows.Forms.Button botFaltanteTotal;
        private System.Windows.Forms.Button botCancelarMat;
        private System.Windows.Forms.ListBox lisFamListMat;
        private System.Windows.Forms.TextBox texFamAEnviar;
        private System.Windows.Forms.Button botCancelaListaMat;
    }
}