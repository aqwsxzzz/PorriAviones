namespace _1.MODELOS
{
    partial class frmListadoMod
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
            this.picboxRecualista = new System.Windows.Forms.PictureBox();
            this.botModeloMod = new System.Windows.Forms.Button();
            this.botImprimeMod = new System.Windows.Forms.Button();
            this.botCancelaMod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRecualista)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxRecualista
            // 
            this.picboxRecualista.BackColor = System.Drawing.Color.Tan;
            this.picboxRecualista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxRecualista.Location = new System.Drawing.Point(228, 104);
            this.picboxRecualista.Name = "picboxRecualista";
            this.picboxRecualista.Size = new System.Drawing.Size(381, 203);
            this.picboxRecualista.TabIndex = 0;
            this.picboxRecualista.TabStop = false;
            // 
            // botModeloMod
            // 
            this.botModeloMod.Location = new System.Drawing.Point(349, 182);
            this.botModeloMod.Name = "botModeloMod";
            this.botModeloMod.Size = new System.Drawing.Size(135, 53);
            this.botModeloMod.TabIndex = 1;
            this.botModeloMod.Text = "MODELO";
            this.botModeloMod.UseVisualStyleBackColor = true;
            // 
            // botImprimeMod
            // 
            this.botImprimeMod.Location = new System.Drawing.Point(228, 338);
            this.botImprimeMod.Name = "botImprimeMod";
            this.botImprimeMod.Size = new System.Drawing.Size(127, 40);
            this.botImprimeMod.TabIndex = 2;
            this.botImprimeMod.Text = "IMPRIMIR";
            this.botImprimeMod.UseVisualStyleBackColor = true;
            this.botImprimeMod.Visible = false;
            // 
            // botCancelaMod
            // 
            this.botCancelaMod.Location = new System.Drawing.Point(482, 338);
            this.botCancelaMod.Name = "botCancelaMod";
            this.botCancelaMod.Size = new System.Drawing.Size(127, 40);
            this.botCancelaMod.TabIndex = 3;
            this.botCancelaMod.Text = "CANCELAR";
            this.botCancelaMod.UseVisualStyleBackColor = true;
            this.botCancelaMod.Click += new System.EventHandler(this.botCancelaMod_Click);
            // 
            // frmListadoMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.botCancelaMod);
            this.Controls.Add(this.botImprimeMod);
            this.Controls.Add(this.botModeloMod);
            this.Controls.Add(this.picboxRecualista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(400, 500);
            this.Name = "frmListadoMod";
            ((System.ComponentModel.ISupportInitialize)(this.picboxRecualista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxRecualista;
        private System.Windows.Forms.Button botModeloMod;
        public System.Windows.Forms.Button botImprimeMod;
        private System.Windows.Forms.Button botCancelaMod;
    }
}