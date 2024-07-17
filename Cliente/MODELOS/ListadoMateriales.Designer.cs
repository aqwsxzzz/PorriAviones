namespace _1.MODELOS
{
    partial class ListadoMateriales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListadoMaterialesLis = new System.Windows.Forms.DataGridView();
            this.labTotal = new System.Windows.Forms.Label();
            this.texTotal = new System.Windows.Forms.TextBox();
            this.picboxRecuaTotal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoMaterialesLis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRecuaTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoMaterialesLis
            // 
            this.dgvListadoMaterialesLis.AllowUserToAddRows = false;
            this.dgvListadoMaterialesLis.AllowUserToDeleteRows = false;
            this.dgvListadoMaterialesLis.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvListadoMaterialesLis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListadoMaterialesLis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListadoMaterialesLis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListadoMaterialesLis.EnableHeadersVisualStyles = false;
            this.dgvListadoMaterialesLis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvListadoMaterialesLis.Location = new System.Drawing.Point(1, 12);
            this.dgvListadoMaterialesLis.Name = "dgvListadoMaterialesLis";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoMaterialesLis.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListadoMaterialesLis.RowHeadersVisible = false;
            this.dgvListadoMaterialesLis.Size = new System.Drawing.Size(721, 456);
            this.dgvListadoMaterialesLis.TabIndex = 0;
            this.dgvListadoMaterialesLis.VirtualMode = true;
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotal.Location = new System.Drawing.Point(485, 492);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(65, 18);
            this.labTotal.TabIndex = 1;
            this.labTotal.Text = "Total us:";
            // 
            // texTotal
            // 
            this.texTotal.BackColor = System.Drawing.Color.Bisque;
            this.texTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texTotal.Location = new System.Drawing.Point(555, 489);
            this.texTotal.Name = "texTotal";
            this.texTotal.Size = new System.Drawing.Size(123, 24);
            this.texTotal.TabIndex = 2;
            this.texTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // picboxRecuaTotal
            // 
            this.picboxRecuaTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxRecuaTotal.Location = new System.Drawing.Point(468, 474);
            this.picboxRecuaTotal.Name = "picboxRecuaTotal";
            this.picboxRecuaTotal.Size = new System.Drawing.Size(227, 60);
            this.picboxRecuaTotal.TabIndex = 3;
            this.picboxRecuaTotal.TabStop = false;
            // 
            // ListadoMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(814, 549);
            this.Controls.Add(this.texTotal);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.dgvListadoMaterialesLis);
            this.Controls.Add(this.picboxRecuaTotal);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Location = new System.Drawing.Point(500, 700);
            this.Name = "ListadoMateriales";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.ListadoMateriales_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoMaterialesLis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRecuaTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvListadoMaterialesLis;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.PictureBox picboxRecuaTotal;
        public System.Windows.Forms.TextBox texTotal;
    }
}