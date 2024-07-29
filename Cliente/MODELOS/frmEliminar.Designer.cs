namespace _1.MODELOS
{
    partial class frmEliminar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListaMateriales = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.botEliminar = new System.Windows.Forms.Button();
            this.botCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaMateriales
            // 
            this.dgvListaMateriales.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvListaMateriales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaMateriales.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaMateriales.EnableHeadersVisualStyles = false;
            this.dgvListaMateriales.Location = new System.Drawing.Point(276, 98);
            this.dgvListaMateriales.Name = "dgvListaMateriales";
            this.dgvListaMateriales.RowHeadersVisible = false;
            this.dgvListaMateriales.Size = new System.Drawing.Size(773, 416);
            this.dgvListaMateriales.TabIndex = 0;
            this.dgvListaMateriales.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvListaMateriales_DefaultValuesNeeded);
            // 
            // botEliminar
            // 
            this.botEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botEliminar.ForeColor = System.Drawing.Color.Red;
            this.botEliminar.Location = new System.Drawing.Point(276, 569);
            this.botEliminar.Name = "botEliminar";
            this.botEliminar.Size = new System.Drawing.Size(124, 48);
            this.botEliminar.TabIndex = 1;
            this.botEliminar.Text = "ELIMINAR";
            this.botEliminar.UseVisualStyleBackColor = true;
            this.botEliminar.Click += new System.EventHandler(this.botEliminar_Click);
            // 
            // botCancelar
            // 
            this.botCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botCancelar.Location = new System.Drawing.Point(932, 569);
            this.botCancelar.Name = "botCancelar";
            this.botCancelar.Size = new System.Drawing.Size(124, 48);
            this.botCancelar.TabIndex = 2;
            this.botCancelar.Text = "CANCELAR";
            this.botCancelar.UseVisualStyleBackColor = true;
            this.botCancelar.Click += new System.EventHandler(this.botCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(517, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Materiales reciclables";
            // 
            // frmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1077, 624);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botCancelar);
            this.Controls.Add(this.botEliminar);
            this.Controls.Add(this.dgvListaMateriales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(200, 300);
            this.Name = "frmEliminar";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmEliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMateriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.DataGridView dgvListaMateriales;
        private System.Windows.Forms.Button botEliminar;
        private System.Windows.Forms.Button botCancelar;
        private System.Windows.Forms.Label label1;
    }
}