namespace Shopping_Buy_All
{
    partial class Modelo_Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modelo_Delete));
            this.lblBuscar = new System.Windows.Forms.Label();
            this.tablaModelos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CodigoModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoTipoAuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaModelos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(45, 66);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(207, 31);
            this.lblBuscar.TabIndex = 33;
            this.lblBuscar.Text = "Buscar modelo";
            // 
            // tablaModelos
            // 
            this.tablaModelos.AllowUserToAddRows = false;
            this.tablaModelos.AllowUserToDeleteRows = false;
            this.tablaModelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaModelos.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaModelos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaModelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoModelo,
            this.NombreModelo,
            this.IdMarca,
            this.Descripcion,
            this.CodigoTipoAuto,
            this.Nombre});
            this.tablaModelos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaModelos.Location = new System.Drawing.Point(287, 66);
            this.tablaModelos.Name = "tablaModelos";
            this.tablaModelos.ReadOnly = true;
            this.tablaModelos.Size = new System.Drawing.Size(501, 372);
            this.tablaModelos.TabIndex = 64;
            this.tablaModelos.TabStop = false;
            this.tablaModelos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaModelos_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(67, 327);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(148, 327);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(162, 111);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(119, 20);
            this.txtNombre.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "Nombre del Modelo:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.DarkGray;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(67, 327);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 75;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(441, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 31);
            this.label2.TabIndex = 76;
            this.label2.Text = "Lista de modelos";
            // 
            // CodigoModelo
            // 
            this.CodigoModelo.DataPropertyName = "CodigoModelo";
            this.CodigoModelo.FillWeight = 50F;
            this.CodigoModelo.HeaderText = "Codigo Modelo";
            this.CodigoModelo.Name = "CodigoModelo";
            this.CodigoModelo.ReadOnly = true;
            // 
            // NombreModelo
            // 
            this.NombreModelo.DataPropertyName = "NombreModelo";
            this.NombreModelo.FillWeight = 121.8274F;
            this.NombreModelo.HeaderText = "Nombre Modelo";
            this.NombreModelo.Name = "NombreModelo";
            this.NombreModelo.ReadOnly = true;
            // 
            // IdMarca
            // 
            this.IdMarca.DataPropertyName = "IdMarca";
            this.IdMarca.FillWeight = 50F;
            this.IdMarca.HeaderText = "Id Marca";
            this.IdMarca.Name = "IdMarca";
            this.IdMarca.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.FillWeight = 116.2897F;
            this.Descripcion.HeaderText = "Nombre marca";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // CodigoTipoAuto
            // 
            this.CodigoTipoAuto.DataPropertyName = "CodigoTipoAuto";
            this.CodigoTipoAuto.FillWeight = 50F;
            this.CodigoTipoAuto.HeaderText = "Codigo Tipo Auto";
            this.CodigoTipoAuto.Name = "CodigoTipoAuto";
            this.CodigoTipoAuto.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.FillWeight = 111.9744F;
            this.Nombre.HeaderText = "TipoAuto";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Modelo_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.tablaModelos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Modelo_Delete";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminar Modelo";
            ((System.ComponentModel.ISupportInitialize)(this.tablaModelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView tablaModelos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoTipoAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}