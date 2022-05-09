namespace Shopping_Buy_All
{
    partial class TipoComercio_Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoComercio_Delete));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnDeleteTipoComercio = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tablaTipoComercio = new System.Windows.Forms.DataGridView();
            this.Tipo_Comercio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTipoComercio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId = new System.Windows.Forms.MaskedTextBox();
            this.txtNombreTipoComercio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoComercio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 44);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tipo Comercio \r\n    a eliminar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(73, 201);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.DarkGray;
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(73, 245);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 4;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnDeleteTipoComercio
            // 
            this.btnDeleteTipoComercio.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteTipoComercio.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.Trash;
            this.btnDeleteTipoComercio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteTipoComercio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTipoComercio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTipoComercio.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTipoComercio.Location = new System.Drawing.Point(86, 277);
            this.btnDeleteTipoComercio.Name = "btnDeleteTipoComercio";
            this.btnDeleteTipoComercio.Size = new System.Drawing.Size(39, 37);
            this.btnDeleteTipoComercio.TabIndex = 67;
            this.btnDeleteTipoComercio.UseVisualStyleBackColor = false;
            this.btnDeleteTipoComercio.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(218, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(217, 22);
            this.label15.TabIndex = 71;
            this.label15.Text = "Lista de Tipo Comercio";
            // 
            // tablaTipoComercio
            // 
            this.tablaTipoComercio.AllowUserToAddRows = false;
            this.tablaTipoComercio.AllowUserToDeleteRows = false;
            this.tablaTipoComercio.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaTipoComercio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaTipoComercio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTipoComercio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo_Comercio,
            this.NombreTipoComercio});
            this.tablaTipoComercio.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaTipoComercio.Location = new System.Drawing.Point(206, 82);
            this.tablaTipoComercio.Name = "tablaTipoComercio";
            this.tablaTipoComercio.ReadOnly = true;
            this.tablaTipoComercio.RowHeadersWidth = 10;
            this.tablaTipoComercio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaTipoComercio.Size = new System.Drawing.Size(229, 206);
            this.tablaTipoComercio.TabIndex = 72;
            this.tablaTipoComercio.TabStop = false;
            this.tablaTipoComercio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaTipoComercio_CellClick);
            // 
            // Tipo_Comercio
            // 
            this.Tipo_Comercio.DataPropertyName = "Tipo_Comercio";
            this.Tipo_Comercio.HeaderText = "Id";
            this.Tipo_Comercio.Name = "Tipo_Comercio";
            this.Tipo_Comercio.ReadOnly = true;
            this.Tipo_Comercio.Width = 50;
            // 
            // NombreTipoComercio
            // 
            this.NombreTipoComercio.DataPropertyName = "NombreTipoComercio";
            this.NombreTipoComercio.HeaderText = "Nombre";
            this.NombreTipoComercio.Name = "NombreTipoComercio";
            this.NombreTipoComercio.ReadOnly = true;
            this.NombreTipoComercio.Width = 150;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtId.Location = new System.Drawing.Point(91, 101);
            this.txtId.Mask = "9999";
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(35, 20);
            this.txtId.TabIndex = 76;
            this.txtId.ValidatingType = typeof(int);
            // 
            // txtNombreTipoComercio
            // 
            this.txtNombreTipoComercio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombreTipoComercio.ForeColor = System.Drawing.Color.White;
            this.txtNombreTipoComercio.Location = new System.Drawing.Point(59, 156);
            this.txtNombreTipoComercio.Name = "txtNombreTipoComercio";
            this.txtNombreTipoComercio.Size = new System.Drawing.Size(100, 20);
            this.txtNombreTipoComercio.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(78, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 74;
            this.label5.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(99, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 73;
            this.label3.Text = "Id";
            // 
            // TipoComercio_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(448, 322);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNombreTipoComercio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tablaTipoComercio);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnDeleteTipoComercio);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TipoComercio_Delete";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminar Tipo Comercio";
            this.Load += new System.EventHandler(this.Client_Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoComercio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnDeleteTipoComercio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView tablaTipoComercio;
        private System.Windows.Forms.MaskedTextBox txtId;
        private System.Windows.Forms.TextBox txtNombreTipoComercio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Comercio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTipoComercio;
    }
}