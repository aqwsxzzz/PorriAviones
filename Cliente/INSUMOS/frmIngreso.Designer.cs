namespace _1.INSUMOS
{
    partial class frmIngreso
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
            this.labGrupo = new System.Windows.Forms.Label();
            this.labCaracteristica = new System.Windows.Forms.Label();
            this.labMedidas = new System.Windows.Forms.Label();
            this.labCodigo = new System.Windows.Forms.Label();
            this.labValor = new System.Windows.Forms.Label();
            this.labTipo = new System.Windows.Forms.Label();
            this.labCantidad = new System.Windows.Forms.Label();
            this.labUbicacion = new System.Windows.Forms.Label();
            this.labEstado = new System.Windows.Forms.Label();
            this.labFabricante = new System.Windows.Forms.Label();
            this.texFamilia = new System.Windows.Forms.TextBox();
            this.texGrupo = new System.Windows.Forms.TextBox();
            this.texMedidas = new System.Windows.Forms.TextBox();
            this.texCaracteristica = new System.Windows.Forms.TextBox();
            this.texCodigo = new System.Windows.Forms.TextBox();
            this.texValor = new System.Windows.Forms.TextBox();
            this.texTipo = new System.Windows.Forms.TextBox();
            this.texCantidad = new System.Windows.Forms.TextBox();
            this.texUbicacion = new System.Windows.Forms.TextBox();
            this.texFabricante = new System.Windows.Forms.TextBox();
            this.texEstado = new System.Windows.Forms.TextBox();
            this.botCargarFoto = new System.Windows.Forms.Button();
            this.botAceptar = new System.Windows.Forms.Button();
            this.botCancelar = new System.Windows.Forms.Button();
            this.picboxRecuaIngreso1 = new System.Windows.Forms.PictureBox();
            this.dgvMaterialesEnExistencia = new System.Windows.Forms.DataGridView();
            this.picboxRecuaIngreso2 = new System.Windows.Forms.PictureBox();
        //    this.gruboxEstado = new System.Windows.Forms.GroupBox();
            this.radbotUsado = new System.Windows.Forms.RadioButton();
            this.radbotNuevo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRecuaIngreso1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialesEnExistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRecuaIngreso2)).BeginInit();
           // this.gruboxEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // labGrupo
            // 
            this.labGrupo.AutoSize = true;
            this.labGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGrupo.Location = new System.Drawing.Point(369, 505);
            this.labGrupo.Name = "labGrupo";
            this.labGrupo.Size = new System.Drawing.Size(50, 18);
            this.labGrupo.TabIndex = 1;
            this.labGrupo.Text = "Grupo";
            this.labGrupo.Click += new System.EventHandler(this.labGrupo_Click);
            // 
            // labCaracteristica
            // 
            this.labCaracteristica.AutoSize = true;
            this.labCaracteristica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCaracteristica.Location = new System.Drawing.Point(320, 550);
            this.labCaracteristica.Name = "labCaracteristica";
            this.labCaracteristica.Size = new System.Drawing.Size(99, 18);
            this.labCaracteristica.TabIndex = 2;
            this.labCaracteristica.Text = "Caracteristica";
            this.labCaracteristica.Click += new System.EventHandler(this.labCaracteristica_Click);
            // 
            // labMedidas
            // 
            this.labMedidas.AutoSize = true;
            this.labMedidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMedidas.Location = new System.Drawing.Point(355, 593);
            this.labMedidas.Name = "labMedidas";
            this.labMedidas.Size = new System.Drawing.Size(64, 18);
            this.labMedidas.TabIndex = 3;
            this.labMedidas.Text = "Medidas";
            this.labMedidas.Click += new System.EventHandler(this.labMedidas_Click);
            // 
            // labCodigo
            // 
            this.labCodigo.AutoSize = true;
            this.labCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCodigo.Location = new System.Drawing.Point(363, 640);
            this.labCodigo.Name = "labCodigo";
            this.labCodigo.Size = new System.Drawing.Size(56, 18);
            this.labCodigo.TabIndex = 4;
            this.labCodigo.Text = "Codigo";
            this.labCodigo.Click += new System.EventHandler(this.labCodigo_Click);
            // 
            // labValor
            // 
            this.labValor.AutoSize = true;
            this.labValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labValor.Location = new System.Drawing.Point(756, 688);
            this.labValor.Name = "labValor";
            this.labValor.Size = new System.Drawing.Size(42, 18);
            this.labValor.TabIndex = 8;
            this.labValor.Text = "Valor";
            this.labValor.Click += new System.EventHandler(this.labValor_Click);
            // 
            // labTipo
            // 
            this.labTipo.AutoSize = true;
            this.labTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTipo.Location = new System.Drawing.Point(761, 640);
            this.labTipo.Name = "labTipo";
            this.labTipo.Size = new System.Drawing.Size(37, 18);
            this.labTipo.TabIndex = 7;
            this.labTipo.Text = "Tipo";
            this.labTipo.Click += new System.EventHandler(this.labTipo_Click);
            // 
            // labCantidad
            // 
            this.labCantidad.AutoSize = true;
            this.labCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCantidad.Location = new System.Drawing.Point(732, 593);
            this.labCantidad.Name = "labCantidad";
            this.labCantidad.Size = new System.Drawing.Size(66, 18);
            this.labCantidad.TabIndex = 6;
            this.labCantidad.Text = "Cantidad";
            this.labCantidad.Click += new System.EventHandler(this.labCantidad_Click);
            // 
            // labUbicacion
            // 
            this.labUbicacion.AutoSize = true;
            this.labUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUbicacion.Location = new System.Drawing.Point(726, 550);
            this.labUbicacion.Name = "labUbicacion";
            this.labUbicacion.Size = new System.Drawing.Size(74, 18);
            this.labUbicacion.TabIndex = 5;
            this.labUbicacion.Text = "Ubicacion";
            this.labUbicacion.Click += new System.EventHandler(this.labUbicacion_Click);
            // 
            // labEstado
            // 
            this.labEstado.AutoSize = true;
            this.labEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEstado.Location = new System.Drawing.Point(743, 505);
            this.labEstado.Name = "labEstado";
            this.labEstado.Size = new System.Drawing.Size(55, 18);
            this.labEstado.TabIndex = 9;
            this.labEstado.Text = "Estado";
            this.labEstado.Click += new System.EventHandler(this.labEstado_Click);
            // 
            // labFabricante
            // 
            this.labFabricante.AutoSize = true;
            this.labFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFabricante.Location = new System.Drawing.Point(342, 688);
            this.labFabricante.Name = "labFabricante";
            this.labFabricante.Size = new System.Drawing.Size(77, 18);
            this.labFabricante.TabIndex = 10;
            this.labFabricante.Text = "Fabricante";
            this.labFabricante.Click += new System.EventHandler(this.labFabricante_Click);
            // 
            // texFamilia
            // 
            this.texFamilia.BackColor = System.Drawing.Color.LightSteelBlue;
            this.texFamilia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texFamilia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.texFamilia.Location = new System.Drawing.Point(3, 124);
            this.texFamilia.Name = "texFamilia";
            this.texFamilia.ReadOnly = true;
            this.texFamilia.Size = new System.Drawing.Size(242, 38);
            this.texFamilia.TabIndex = 11;
            this.texFamilia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // texGrupo
            // 
            this.texGrupo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.texGrupo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texGrupo.Location = new System.Drawing.Point(434, 503);
            this.texGrupo.Name = "texGrupo";
            this.texGrupo.Size = new System.Drawing.Size(200, 22);
            this.texGrupo.TabIndex = 12;
            this.texGrupo.TextChanged += new System.EventHandler(this.texGrupo_TextChanged);
            // 
            // texMedidas
            // 
            this.texMedidas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.texMedidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texMedidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texMedidas.Location = new System.Drawing.Point(434, 593);
            this.texMedidas.Name = "texMedidas";
            this.texMedidas.Size = new System.Drawing.Size(200, 22);
            this.texMedidas.TabIndex = 14;
            this.texMedidas.TextChanged += new System.EventHandler(this.texMedidas_TextChanged);
            // 
            // texCaracteristica
            // 
            this.texCaracteristica.BackColor = System.Drawing.Color.LightSteelBlue;
            this.texCaracteristica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texCaracteristica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texCaracteristica.Location = new System.Drawing.Point(434, 548);
            this.texCaracteristica.Name = "texCaracteristica";
            this.texCaracteristica.Size = new System.Drawing.Size(200, 22);
            this.texCaracteristica.TabIndex = 13;
            this.texCaracteristica.TextChanged += new System.EventHandler(this.texCaracteristica_TextChanged);
            // 
            // texCodigo
            // 
            this.texCodigo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.texCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texCodigo.Location = new System.Drawing.Point(434, 640);
            this.texCodigo.Name = "texCodigo";
            this.texCodigo.Size = new System.Drawing.Size(200, 22);
            this.texCodigo.TabIndex = 15;
            this.texCodigo.TextChanged += new System.EventHandler(this.texCodigo_TextChanged);
            // 
            // texValor
            // 
            this.texValor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.texValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texValor.Location = new System.Drawing.Point(817, 688);
            this.texValor.Name = "texValor";
            this.texValor.Size = new System.Drawing.Size(100, 22);
            this.texValor.TabIndex = 20;
            this.texValor.TextChanged += new System.EventHandler(this.texValor_TextChanged);
            // 
            // texTipo
            // 
            this.texTipo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.texTipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texTipo.Location = new System.Drawing.Point(817, 640);
            this.texTipo.Name = "texTipo";
            this.texTipo.Size = new System.Drawing.Size(200, 22);
            this.texTipo.TabIndex = 19;
            this.texTipo.TextChanged += new System.EventHandler(this.texTipo_TextChanged);
            // 
            // texCantidad
            // 
            this.texCantidad.BackColor = System.Drawing.Color.LightSteelBlue;
            this.texCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texCantidad.Location = new System.Drawing.Point(815, 589);
            this.texCantidad.Name = "texCantidad";
            this.texCantidad.Size = new System.Drawing.Size(50, 22);
            this.texCantidad.TabIndex = 18;
            this.texCantidad.TextChanged += new System.EventHandler(this.texCantidad_TextChanged);
            // 
            // texUbicacion
            // 
            this.texUbicacion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.texUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texUbicacion.Location = new System.Drawing.Point(820, 550);
            this.texUbicacion.Name = "texUbicacion";
            this.texUbicacion.Size = new System.Drawing.Size(200, 22);
            this.texUbicacion.TabIndex = 17;
            this.texUbicacion.TextChanged += new System.EventHandler(this.texUbicacion_TextChanged);
            // 
            // texFabricante
            // 
            this.texFabricante.BackColor = System.Drawing.Color.LightSteelBlue;
            this.texFabricante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texFabricante.Location = new System.Drawing.Point(434, 688);
            this.texFabricante.Name = "texFabricante";
            this.texFabricante.Size = new System.Drawing.Size(200, 22);
            this.texFabricante.TabIndex = 16;
            this.texFabricante.TextChanged += new System.EventHandler(this.texFabricante_TextChanged);
            // 
            // texEstado
            // 
            this.texEstado.BackColor = System.Drawing.Color.LightSteelBlue;
            this.texEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texEstado.Location = new System.Drawing.Point(1067, 495);
            this.texEstado.Name = "texEstado";
            this.texEstado.Size = new System.Drawing.Size(50, 29);
            this.texEstado.TabIndex = 21;
            this.texEstado.Visible = false;
            this.texEstado.TextChanged += new System.EventHandler(this.texEstado_TextChanged);
            // 
            // botCargarFoto
            // 
            this.botCargarFoto.Location = new System.Drawing.Point(306, 759);
            this.botCargarFoto.Name = "botCargarFoto";
            this.botCargarFoto.Size = new System.Drawing.Size(129, 43);
            this.botCargarFoto.TabIndex = 22;
            this.botCargarFoto.Text = "CARGAR FOTO";
            this.botCargarFoto.UseVisualStyleBackColor = true;
            this.botCargarFoto.Click += new System.EventHandler(this.botCargarFoto_Click);
            // 
            // botAceptar
            // 
            this.botAceptar.Location = new System.Drawing.Point(779, 759);
            this.botAceptar.Name = "botAceptar";
            this.botAceptar.Size = new System.Drawing.Size(129, 43);
            this.botAceptar.TabIndex = 23;
            this.botAceptar.Text = "ACEPTAR";
            this.botAceptar.UseVisualStyleBackColor = true;
            this.botAceptar.Click += new System.EventHandler(this.botAceptar_Click);
            // 
            // botCancelar
            // 
            this.botCancelar.Location = new System.Drawing.Point(933, 759);
            this.botCancelar.Name = "botCancelar";
            this.botCancelar.Size = new System.Drawing.Size(129, 43);
            this.botCancelar.TabIndex = 24;
            this.botCancelar.Text = "CANCELAR";
            this.botCancelar.UseVisualStyleBackColor = true;
            this.botCancelar.Click += new System.EventHandler(this.botCancelar_Click);
            // 
            // picboxRecuaIngreso1
            // 
            this.picboxRecuaIngreso1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxRecuaIngreso1.Location = new System.Drawing.Point(303, 468);
            this.picboxRecuaIngreso1.Name = "picboxRecuaIngreso1";
            this.picboxRecuaIngreso1.Size = new System.Drawing.Size(378, 271);
            this.picboxRecuaIngreso1.TabIndex = 25;
            this.picboxRecuaIngreso1.TabStop = false;
            this.picboxRecuaIngreso1.Click += new System.EventHandler(this.picboxRecuaIngreso1_Click);
            // 
            // dgvMaterialesEnExistencia
            // 
            this.dgvMaterialesEnExistencia.AllowUserToAddRows = false;
            this.dgvMaterialesEnExistencia.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvMaterialesEnExistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialesEnExistencia.Location = new System.Drawing.Point(261, 21);
            this.dgvMaterialesEnExistencia.Name = "dgvMaterialesEnExistencia";
            this.dgvMaterialesEnExistencia.RowHeadersVisible = false;
            this.dgvMaterialesEnExistencia.Size = new System.Drawing.Size(843, 440);
            this.dgvMaterialesEnExistencia.TabIndex = 26;
            this.dgvMaterialesEnExistencia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterialesEnExistencia_CellClick);
            this.dgvMaterialesEnExistencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterialesEnExistencia_CellContentClick);
            this.dgvMaterialesEnExistencia.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterialesEnExistencia_CellDoubleClick);
            // 
            // picboxRecuaIngreso2
            // 
            this.picboxRecuaIngreso2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxRecuaIngreso2.Location = new System.Drawing.Point(679, 468);
            this.picboxRecuaIngreso2.Name = "picboxRecuaIngreso2";
            this.picboxRecuaIngreso2.Size = new System.Drawing.Size(382, 271);
            this.picboxRecuaIngreso2.TabIndex = 28;
            this.picboxRecuaIngreso2.TabStop = false;
            this.picboxRecuaIngreso2.Click += new System.EventHandler(this.picboxRecuaIngreso2_Click);
            // 
            // gruboxEstado
            // 
         /*   this.gruboxEstado.Controls.Add(this.radbotUsado);
            this.gruboxEstado.Controls.Add(this.radbotNuevo);
            this.gruboxEstado.Location = new System.Drawing.Point(835, 496);
            this.gruboxEstado.Name = "gruboxEstado";
            this.gruboxEstado.Size = new System.Drawing.Size(129, 29);
            this.gruboxEstado.TabIndex = 33;
            this.gruboxEstado.TabStop = false;
            this.gruboxEstado.Enter += new System.EventHandler(this.gruboxEstado_Enter);*/
            // 
            // radbotUsado
            // 
            this.radbotUsado.AutoSize = true;
            this.radbotUsado.Location = new System.Drawing.Point(65, 10);
            this.radbotUsado.Name = "radbotUsado";
            this.radbotUsado.Size = new System.Drawing.Size(56, 17);
            this.radbotUsado.TabIndex = 32;
            this.radbotUsado.TabStop = true;
            this.radbotUsado.Text = "Usado";
            this.radbotUsado.UseVisualStyleBackColor = true;
            this.radbotUsado.Click += new System.EventHandler(this.radbotUsado_Click);
            // 
            // radbotNuevo
            // 
            this.radbotNuevo.AutoSize = true;
            this.radbotNuevo.Location = new System.Drawing.Point(2, 11);
            this.radbotNuevo.Name = "radbotNuevo";
            this.radbotNuevo.Size = new System.Drawing.Size(57, 17);
            this.radbotNuevo.TabIndex = 31;
            this.radbotNuevo.TabStop = true;
            this.radbotNuevo.Text = "Nuevo";
            this.radbotNuevo.UseVisualStyleBackColor = true;
            this.radbotNuevo.Click += new System.EventHandler(this.radbotNuevo_Click);
            // 
            // frmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1182, 847);
        //    this.Controls.Add(this.gruboxEstado);
            this.Controls.Add(this.dgvMaterialesEnExistencia);
            this.Controls.Add(this.botCancelar);
            this.Controls.Add(this.botAceptar);
            this.Controls.Add(this.botCargarFoto);
            this.Controls.Add(this.texEstado);
            this.Controls.Add(this.texValor);
            this.Controls.Add(this.texTipo);
            this.Controls.Add(this.texCantidad);
            this.Controls.Add(this.texUbicacion);
            this.Controls.Add(this.texFabricante);
            this.Controls.Add(this.texCodigo);
            this.Controls.Add(this.texMedidas);
            this.Controls.Add(this.texCaracteristica);
            this.Controls.Add(this.texGrupo);
            this.Controls.Add(this.texFamilia);
            this.Controls.Add(this.labFabricante);
            this.Controls.Add(this.labEstado);
            this.Controls.Add(this.labValor);
            this.Controls.Add(this.labTipo);
            this.Controls.Add(this.labCantidad);
            this.Controls.Add(this.labUbicacion);
            this.Controls.Add(this.labCodigo);
            this.Controls.Add(this.labMedidas);
            this.Controls.Add(this.labCaracteristica);
            this.Controls.Add(this.labGrupo);
            this.Controls.Add(this.picboxRecuaIngreso1);
            this.Controls.Add(this.picboxRecuaIngreso2);
            this.Name = "frmIngreso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmIngreso";
            this.Load += new System.EventHandler(this.frmIngreso_Load);
            this.Shown += new System.EventHandler(this.frmIngreso_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picboxRecuaIngreso1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialesEnExistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRecuaIngreso2)).EndInit();
         //   this.gruboxEstado.ResumeLayout(false);
         //   this.gruboxEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labGrupo;
        private System.Windows.Forms.Label labCaracteristica;
        private System.Windows.Forms.Label labMedidas;
        private System.Windows.Forms.Label labCodigo;
        private System.Windows.Forms.Label labValor;
        private System.Windows.Forms.Label labTipo;
        private System.Windows.Forms.Label labCantidad;
        private System.Windows.Forms.Label labUbicacion;
        private System.Windows.Forms.Label labEstado;
        private System.Windows.Forms.Label labFabricante;
        private System.Windows.Forms.TextBox texMedidas;
        private System.Windows.Forms.TextBox texCaracteristica;
        private System.Windows.Forms.TextBox texCodigo;
        private System.Windows.Forms.TextBox texValor;
        private System.Windows.Forms.TextBox texTipo;
        private System.Windows.Forms.TextBox texCantidad;
        private System.Windows.Forms.TextBox texUbicacion;
        private System.Windows.Forms.TextBox texFabricante;
        private System.Windows.Forms.Button botCargarFoto;
        private System.Windows.Forms.Button botAceptar;
        private System.Windows.Forms.Button botCancelar;
        public System.Windows.Forms.TextBox texEstado;
        private System.Windows.Forms.PictureBox picboxRecuaIngreso1;
        private System.Windows.Forms.PictureBox picboxRecuaIngreso2;
        public System.Windows.Forms.TextBox texFamilia;
        public System.Windows.Forms.DataGridView dgvMaterialesEnExistencia;
        public System.Windows.Forms.TextBox texGrupo;
     //   private System.Windows.Forms.GroupBox gruboxEstado;
        private System.Windows.Forms.RadioButton radbotUsado;
        private System.Windows.Forms.RadioButton radbotNuevo;
    }
}