namespace Shopping_Buy_All
{
    partial class TipoComercio_Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoComercio_Load));
            this.tablaTipoComercio = new System.Windows.Forms.DataGridView();
            this.Tipo_Comercio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTipoComercio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.label15 = new System.Windows.Forms.Label();
            this.btnTipoComercioLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtNombreTipoComercio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoComercio)).BeginInit();
            this.SuspendLayout();
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
            this.tablaTipoComercio.Location = new System.Drawing.Point(42, 215);
            this.tablaTipoComercio.Name = "tablaTipoComercio";
            this.tablaTipoComercio.ReadOnly = true;
            this.tablaTipoComercio.Size = new System.Drawing.Size(296, 206);
            this.tablaTipoComercio.TabIndex = 0;
            this.tablaTipoComercio.TabStop = false;
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
            this.NombreTipoComercio.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cargar Tipo Comercio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(95, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre Tipo Comercio";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(36, 181);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(314, 31);
            this.label15.TabIndex = 28;
            this.label15.Text = "Lista de Tipo Comercio";
            // 
            // btnTipoComercioLoad
            // 
            this.btnTipoComercioLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTipoComercioLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoComercioLoad.ForeColor = System.Drawing.Color.White;
            this.btnTipoComercioLoad.Location = new System.Drawing.Point(98, 132);
            this.btnTipoComercioLoad.Name = "btnTipoComercioLoad";
            this.btnTipoComercioLoad.Size = new System.Drawing.Size(75, 23);
            this.btnTipoComercioLoad.TabIndex = 13;
            this.btnTipoComercioLoad.Text = "Cargar";
            this.btnTipoComercioLoad.UseVisualStyleBackColor = true;
            this.btnTipoComercioLoad.Click += new System.EventHandler(this.btnCargarTipoComercio_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(194, 132);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtNombreTipoComercio
            // 
            this.txtNombreTipoComercio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombreTipoComercio.ForeColor = System.Drawing.Color.White;
            this.txtNombreTipoComercio.Location = new System.Drawing.Point(132, 79);
            this.txtNombreTipoComercio.Name = "txtNombreTipoComercio";
            this.txtNombreTipoComercio.Size = new System.Drawing.Size(100, 20);
            this.txtNombreTipoComercio.TabIndex = 3;
            // 
            // TipoComercio_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 449);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTipoComercioLoad);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtNombreTipoComercio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaTipoComercio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1043, 488);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "TipoComercio_Load";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Tipo Comercio";
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoComercio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaTipoComercio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnTipoComercioLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtNombreTipoComercio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Comercio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTipoComercio;
    }
}