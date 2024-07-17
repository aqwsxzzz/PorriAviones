namespace _1.INSUMOS
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
            this.botElimina = new System.Windows.Forms.Button();
            this.botCancela = new System.Windows.Forms.Button();
            this.labTituloElimina = new System.Windows.Forms.Label();
            this.picboxRecuaElimina = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRecuaElimina)).BeginInit();
            this.SuspendLayout();
            // 
            // botElimina
            // 
            this.botElimina.BackColor = System.Drawing.SystemColors.HighlightText;
            this.botElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botElimina.Location = new System.Drawing.Point(25, 110);
            this.botElimina.Name = "botElimina";
            this.botElimina.Size = new System.Drawing.Size(124, 42);
            this.botElimina.TabIndex = 1;
            this.botElimina.Text = "ELIMINAR";
            this.botElimina.UseVisualStyleBackColor = false;
            this.botElimina.Click += new System.EventHandler(this.botElimina_Click);
            // 
            // botCancela
            // 
            this.botCancela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botCancela.Location = new System.Drawing.Point(179, 110);
            this.botCancela.Name = "botCancela";
            this.botCancela.Size = new System.Drawing.Size(124, 42);
            this.botCancela.TabIndex = 2;
            this.botCancela.Text = "CANCELAR";
            this.botCancela.UseVisualStyleBackColor = true;
            this.botCancela.Click += new System.EventHandler(this.botCancela_Click);
            // 
            // labTituloElimina
            // 
            this.labTituloElimina.AutoSize = true;
            this.labTituloElimina.BackColor = System.Drawing.Color.Maroon;
            this.labTituloElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTituloElimina.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labTituloElimina.Location = new System.Drawing.Point(109, 40);
            this.labTituloElimina.Name = "labTituloElimina";
            this.labTituloElimina.Size = new System.Drawing.Size(120, 24);
            this.labTituloElimina.TabIndex = 3;
            this.labTituloElimina.Text = "Está seguro?";
            // 
            // picboxRecuaElimina
            // 
            this.picboxRecuaElimina.BackColor = System.Drawing.Color.Maroon;
            this.picboxRecuaElimina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxRecuaElimina.Location = new System.Drawing.Point(2, 3);
            this.picboxRecuaElimina.Name = "picboxRecuaElimina";
            this.picboxRecuaElimina.Size = new System.Drawing.Size(324, 179);
            this.picboxRecuaElimina.TabIndex = 0;
            this.picboxRecuaElimina.TabStop = false;
            // 
            // frmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(329, 186);
            this.Controls.Add(this.labTituloElimina);
            this.Controls.Add(this.botCancela);
            this.Controls.Add(this.botElimina);
            this.Controls.Add(this.picboxRecuaElimina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEliminar";
            this.Text = "Eliminar";
            ((System.ComponentModel.ISupportInitialize)(this.picboxRecuaElimina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxRecuaElimina;
        private System.Windows.Forms.Button botElimina;
        private System.Windows.Forms.Button botCancela;
        private System.Windows.Forms.Label labTituloElimina;
    }
}