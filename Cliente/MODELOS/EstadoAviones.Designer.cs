namespace _1.MODELOS
{
    partial class frmEstadoAviones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadoAviones));
            this.botEstadoEst = new System.Windows.Forms.Button();
            this.texEstadoEst = new System.Windows.Forms.TextBox();
            this.botCancelaEst = new System.Windows.Forms.Button();
            this.panEstadoEst = new System.Windows.Forms.Panel();
            this.radbotInactivoEst = new System.Windows.Forms.RadioButton();
            this.radbotConstruccionEst = new System.Windows.Forms.RadioButton();
            this.radbotReparacionEst = new System.Windows.Forms.RadioButton();
            this.radbotActivoEst = new System.Windows.Forms.RadioButton();
            this.panEstadoEst.SuspendLayout();
            this.SuspendLayout();
            // 
            // botEstadoEst
            // 
            this.botEstadoEst.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.botEstadoEst, "botEstadoEst");
            this.botEstadoEst.Name = "botEstadoEst";
            this.botEstadoEst.UseVisualStyleBackColor = true;
            this.botEstadoEst.Click += new System.EventHandler(this.botEstadoEst_Click);
            // 
            // texEstadoEst
            // 
            resources.ApplyResources(this.texEstadoEst, "texEstadoEst");
            this.texEstadoEst.Name = "texEstadoEst";
            // 
            // botCancelaEst
            // 
            resources.ApplyResources(this.botCancelaEst, "botCancelaEst");
            this.botCancelaEst.Name = "botCancelaEst";
            this.botCancelaEst.UseVisualStyleBackColor = true;
            this.botCancelaEst.Click += new System.EventHandler(this.botCancelaEst_Click);
            // 
            // panEstadoEst
            // 
            this.panEstadoEst.BackColor = System.Drawing.Color.Bisque;
            this.panEstadoEst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panEstadoEst.Controls.Add(this.radbotInactivoEst);
            this.panEstadoEst.Controls.Add(this.radbotConstruccionEst);
            this.panEstadoEst.Controls.Add(this.radbotReparacionEst);
            this.panEstadoEst.Controls.Add(this.radbotActivoEst);
            resources.ApplyResources(this.panEstadoEst, "panEstadoEst");
            this.panEstadoEst.Name = "panEstadoEst";
            // 
            // radbotInactivoEst
            // 
            resources.ApplyResources(this.radbotInactivoEst, "radbotInactivoEst");
            this.radbotInactivoEst.Name = "radbotInactivoEst";
            this.radbotInactivoEst.UseVisualStyleBackColor = true;
            this.radbotInactivoEst.CheckedChanged += new System.EventHandler(this.radbotInactivoEst_CheckedChanged_1);
            // 
            // radbotConstruccionEst
            // 
            resources.ApplyResources(this.radbotConstruccionEst, "radbotConstruccionEst");
            this.radbotConstruccionEst.Name = "radbotConstruccionEst";
            this.radbotConstruccionEst.TabStop = true;
            this.radbotConstruccionEst.UseVisualStyleBackColor = true;
            this.radbotConstruccionEst.CheckedChanged += new System.EventHandler(this.radbotConstruccionEst_CheckedChanged_1);
            // 
            // radbotReparacionEst
            // 
            resources.ApplyResources(this.radbotReparacionEst, "radbotReparacionEst");
            this.radbotReparacionEst.Name = "radbotReparacionEst";
            this.radbotReparacionEst.UseVisualStyleBackColor = true;
            this.radbotReparacionEst.CheckedChanged += new System.EventHandler(this.radbotReparacionEst_CheckedChanged_1);
            // 
            // radbotActivoEst
            // 
            resources.ApplyResources(this.radbotActivoEst, "radbotActivoEst");
            this.radbotActivoEst.Checked = true;
            this.radbotActivoEst.Name = "radbotActivoEst";
            this.radbotActivoEst.TabStop = true;
            this.radbotActivoEst.UseVisualStyleBackColor = true;
            this.radbotActivoEst.CheckedChanged += new System.EventHandler(this.radbotActivoEst_CheckedChanged_1);
            // 
            // frmEstadoAviones
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ControlBox = false;
            this.Controls.Add(this.panEstadoEst);
            this.Controls.Add(this.botCancelaEst);
            this.Controls.Add(this.texEstadoEst);
            this.Controls.Add(this.botEstadoEst);
            this.Name = "frmEstadoAviones";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.EstadoAviones_Load);
            this.panEstadoEst.ResumeLayout(false);
            this.panEstadoEst.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botCancelaEst;
        private System.Windows.Forms.TextBox texEstadoEst;
        public System.Windows.Forms.Button botEstadoEst;
        public System.Windows.Forms.RadioButton radbotInactivoEst;
        public System.Windows.Forms.RadioButton radbotConstruccionEst;
        public System.Windows.Forms.RadioButton radbotReparacionEst;
        public System.Windows.Forms.RadioButton radbotActivoEst;
        public System.Windows.Forms.Panel panEstadoEst;
    }
}