namespace _1
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botInsumosPrinc = new System.Windows.Forms.Button();
            this.botModelosPrinc = new System.Windows.Forms.Button();
            this.botSalirPrinc = new System.Windows.Forms.Button();
            this.labTituloPrinc = new System.Windows.Forms.Label();
            this.botComprasPrinc = new System.Windows.Forms.Button();
            this.picboxFotoPrinc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxFotoPrinc)).BeginInit();
            this.SuspendLayout();
            // 
            // botInsumosPrinc
            // 
            this.botInsumosPrinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botInsumosPrinc.Location = new System.Drawing.Point(330, 403);
            this.botInsumosPrinc.Name = "botInsumosPrinc";
            this.botInsumosPrinc.Size = new System.Drawing.Size(200, 100);
            this.botInsumosPrinc.TabIndex = 1;
            this.botInsumosPrinc.Text = "INSUMOS GENERALES";
            this.botInsumosPrinc.UseVisualStyleBackColor = true;
            this.botInsumosPrinc.Click += new System.EventHandler(this.botInsumosPrinc_Click);
            // 
            // botModelosPrinc
            // 
            this.botModelosPrinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botModelosPrinc.Location = new System.Drawing.Point(330, 527);
            this.botModelosPrinc.Name = "botModelosPrinc";
            this.botModelosPrinc.Size = new System.Drawing.Size(200, 100);
            this.botModelosPrinc.TabIndex = 1;
            this.botModelosPrinc.Text = "MODELOS";
            this.botModelosPrinc.UseVisualStyleBackColor = true;
            this.botModelosPrinc.Click += new System.EventHandler(this.botModelosPrinc_Click);
            // 
            // botSalirPrinc
            // 
            this.botSalirPrinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botSalirPrinc.Location = new System.Drawing.Point(1608, 938);
            this.botSalirPrinc.Name = "botSalirPrinc";
            this.botSalirPrinc.Size = new System.Drawing.Size(213, 66);
            this.botSalirPrinc.TabIndex = 1;
            this.botSalirPrinc.Text = "SALIR DEL SISTEMA";
            this.botSalirPrinc.UseVisualStyleBackColor = true;
            this.botSalirPrinc.Click += new System.EventHandler(this.botSalirPrinc_Click);
            // 
            // labTituloPrinc
            // 
            this.labTituloPrinc.AutoSize = true;
            this.labTituloPrinc.BackColor = System.Drawing.Color.LightCyan;
            this.labTituloPrinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTituloPrinc.ForeColor = System.Drawing.Color.Maroon;
            this.labTituloPrinc.Location = new System.Drawing.Point(160, 176);
            this.labTituloPrinc.Name = "labTituloPrinc";
            this.labTituloPrinc.Size = new System.Drawing.Size(227, 55);
            this.labTituloPrinc.TabIndex = 2;
            this.labTituloPrinc.Text = "Mi hobby";
            // 
            // botComprasPrinc
            // 
            this.botComprasPrinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botComprasPrinc.Location = new System.Drawing.Point(330, 655);
            this.botComprasPrinc.Name = "botComprasPrinc";
            this.botComprasPrinc.Size = new System.Drawing.Size(200, 100);
            this.botComprasPrinc.TabIndex = 1;
            this.botComprasPrinc.Text = "COMPRAS";
            this.botComprasPrinc.UseVisualStyleBackColor = true;
            this.botComprasPrinc.Click += new System.EventHandler(this.botComprasPrinc_Click);
            // 
            // picboxFotoPrinc
            // 
            this.picboxFotoPrinc.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.picboxFotoPrinc.Image = global::_1.Properties.Resources.motor_21;
            this.picboxFotoPrinc.Location = new System.Drawing.Point(-1, 0);
            this.picboxFotoPrinc.Name = "picboxFotoPrinc";
            this.picboxFotoPrinc.Size = new System.Drawing.Size(1903, 1082);
            this.picboxFotoPrinc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxFotoPrinc.TabIndex = 0;
            this.picboxFotoPrinc.TabStop = false;
            this.picboxFotoPrinc.Click += new System.EventHandler(this.picboxFotoPrinc_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 1051);
            this.Controls.Add(this.labTituloPrinc);
            this.Controls.Add(this.botComprasPrinc);
            this.Controls.Add(this.botSalirPrinc);
            this.Controls.Add(this.botModelosPrinc);
            this.Controls.Add(this.botInsumosPrinc);
            this.Controls.Add(this.picboxFotoPrinc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxFotoPrinc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxFotoPrinc;
        private System.Windows.Forms.Button botInsumosPrinc;
        private System.Windows.Forms.Button botModelosPrinc;
        private System.Windows.Forms.Button botSalirPrinc;
        private System.Windows.Forms.Label labTituloPrinc;
        private System.Windows.Forms.Button botComprasPrinc;
    }
}

