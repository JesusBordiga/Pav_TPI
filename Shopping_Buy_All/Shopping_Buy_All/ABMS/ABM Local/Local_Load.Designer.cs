namespace Shopping_Buy_All
{
    partial class Local_Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Local_Load));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.label15 = new System.Windows.Forms.Label();
            this.btnLocalLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbTipoComercio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreLocal = new System.Windows.Forms.TextBox();
            this.tablaLocales = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLocales)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cargar Local";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(331, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(169, 25);
            this.label15.TabIndex = 28;
            this.label15.Text = "Lista de Locales";
            // 
            // btnLocalLoad
            // 
            this.btnLocalLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocalLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalLoad.ForeColor = System.Drawing.Color.White;
            this.btnLocalLoad.Location = new System.Drawing.Point(28, 236);
            this.btnLocalLoad.Name = "btnLocalLoad";
            this.btnLocalLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLocalLoad.TabIndex = 3;
            this.btnLocalLoad.Text = "Cargar";
            this.btnLocalLoad.UseVisualStyleBackColor = true;
            this.btnLocalLoad.Click += new System.EventHandler(this.btnCargarLocal_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(124, 236);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbTipoComercio
            // 
            this.cmbTipoComercio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmbTipoComercio.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbTipoComercio.FormattingEnabled = true;
            this.cmbTipoComercio.Location = new System.Drawing.Point(86, 114);
            this.cmbTipoComercio.Name = "cmbTipoComercio";
            this.cmbTipoComercio.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoComercio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nombre";
            // 
            // txtNombreLocal
            // 
            this.txtNombreLocal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombreLocal.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNombreLocal.Location = new System.Drawing.Point(97, 83);
            this.txtNombreLocal.Name = "txtNombreLocal";
            this.txtNombreLocal.Size = new System.Drawing.Size(100, 20);
            this.txtNombreLocal.TabIndex = 1;
            // 
            // tablaLocales
            // 
            this.tablaLocales.AllowUserToAddRows = false;
            this.tablaLocales.AllowUserToDeleteRows = false;
            this.tablaLocales.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaLocales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaLocales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaLocales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tablaLocales.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaLocales.Location = new System.Drawing.Point(232, 42);
            this.tablaLocales.Name = "tablaLocales";
            this.tablaLocales.ReadOnly = true;
            this.tablaLocales.RowHeadersWidth = 10;
            this.tablaLocales.Size = new System.Drawing.Size(349, 222);
            this.tablaLocales.TabIndex = 92;
            this.tablaLocales.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodigoLocal";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tipo_Comercio";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id Tipo Comercio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NombreTipoComercio";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tipo Comercio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // Local_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 271);
            this.Controls.Add(this.tablaLocales);
            this.Controls.Add(this.txtNombreLocal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipoComercio);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLocalLoad);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1043, 488);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "Local_Load";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Local";
            ((System.ComponentModel.ISupportInitialize)(this.tablaLocales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnLocalLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbTipoComercio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreLocal;
        private System.Windows.Forms.DataGridView tablaLocales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}