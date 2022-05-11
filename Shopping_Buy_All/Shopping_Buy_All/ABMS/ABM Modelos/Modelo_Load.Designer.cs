namespace Shopping_Buy_All
{
    partial class Modelo_Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modelo_Load));
            this.tablaModelos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.label15 = new System.Windows.Forms.Label();
            this.btnClientLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textNombreModelo = new System.Windows.Forms.TextBox();
            this.comboBoxIdMarca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTipoAuto = new System.Windows.Forms.ComboBox();
            this.CodigoModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoTipoAuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaModelos)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaModelos
            // 
            this.tablaModelos.AllowUserToAddRows = false;
            this.tablaModelos.AllowUserToDeleteRows = false;
            this.tablaModelos.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaModelos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaModelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoModelo,
            this.NombreModelo,
            this.IdMarca,
            this.CodigoTipoAuto});
            this.tablaModelos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaModelos.Location = new System.Drawing.Point(347, 47);
            this.tablaModelos.Name = "tablaModelos";
            this.tablaModelos.ReadOnly = true;
            this.tablaModelos.Size = new System.Drawing.Size(668, 390);
            this.tablaModelos.TabIndex = 0;
            this.tablaModelos.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cargar Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(85, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nombre del Modelo:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(590, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(234, 31);
            this.label15.TabIndex = 28;
            this.label15.Text = "Lista de Modelos";
            // 
            // btnClientLoad
            // 
            this.btnClientLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientLoad.ForeColor = System.Drawing.Color.White;
            this.btnClientLoad.Location = new System.Drawing.Point(54, 414);
            this.btnClientLoad.Name = "btnClientLoad";
            this.btnClientLoad.Size = new System.Drawing.Size(75, 23);
            this.btnClientLoad.TabIndex = 13;
            this.btnClientLoad.Text = "Cargar";
            this.btnClientLoad.UseVisualStyleBackColor = true;
            this.btnClientLoad.Click += new System.EventHandler(this.btnCargarCliente_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(174, 414);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(105, 131);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 17);
            this.label16.TabIndex = 29;
            this.label16.Text = "Marca:";
            // 
            // textNombreModelo
            // 
            this.textNombreModelo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNombreModelo.ForeColor = System.Drawing.Color.White;
            this.textNombreModelo.Location = new System.Drawing.Point(187, 98);
            this.textNombreModelo.Name = "textNombreModelo";
            this.textNombreModelo.Size = new System.Drawing.Size(119, 20);
            this.textNombreModelo.TabIndex = 3;
            // 
            // comboBoxIdMarca
            // 
            this.comboBoxIdMarca.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxIdMarca.ForeColor = System.Drawing.Color.White;
            this.comboBoxIdMarca.FormattingEnabled = true;
            this.comboBoxIdMarca.Location = new System.Drawing.Point(187, 128);
            this.comboBoxIdMarca.Name = "comboBoxIdMarca";
            this.comboBoxIdMarca.Size = new System.Drawing.Size(119, 21);
            this.comboBoxIdMarca.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tipo Auto:";
            // 
            // comboBoxTipoAuto
            // 
            this.comboBoxTipoAuto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxTipoAuto.ForeColor = System.Drawing.Color.White;
            this.comboBoxTipoAuto.FormattingEnabled = true;
            this.comboBoxTipoAuto.Location = new System.Drawing.Point(187, 158);
            this.comboBoxTipoAuto.Name = "comboBoxTipoAuto";
            this.comboBoxTipoAuto.Size = new System.Drawing.Size(119, 21);
            this.comboBoxTipoAuto.TabIndex = 32;
            // 
            // CodigoModelo
            // 
            this.CodigoModelo.DataPropertyName = "CodigoModelo";
            this.CodigoModelo.HeaderText = "Codigo Modelo";
            this.CodigoModelo.Name = "CodigoModelo";
            this.CodigoModelo.ReadOnly = true;
            // 
            // NombreModelo
            // 
            this.NombreModelo.DataPropertyName = "NombreModelo";
            this.NombreModelo.HeaderText = "Nombre Modelo";
            this.NombreModelo.Name = "NombreModelo";
            this.NombreModelo.ReadOnly = true;
            this.NombreModelo.Width = 300;
            // 
            // IdMarca
            // 
            this.IdMarca.DataPropertyName = "IdMarca";
            this.IdMarca.HeaderText = "Id Marca";
            this.IdMarca.Name = "IdMarca";
            this.IdMarca.ReadOnly = true;
            // 
            // CodigoTipoAuto
            // 
            this.CodigoTipoAuto.DataPropertyName = "CodigoTipoAuto";
            this.CodigoTipoAuto.HeaderText = "Codigo Tipo Auto";
            this.CodigoTipoAuto.Name = "CodigoTipoAuto";
            this.CodigoTipoAuto.ReadOnly = true;
            this.CodigoTipoAuto.Width = 150;
            // 
            // Modelo_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 449);
            this.Controls.Add(this.comboBoxTipoAuto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxIdMarca);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClientLoad);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textNombreModelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaModelos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1043, 488);
            this.MinimumSize = new System.Drawing.Size(1043, 488);
            this.Name = "Modelo_Load";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Modelo";
            ((System.ComponentModel.ISupportInitialize)(this.tablaModelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaModelos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnClientLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textNombreModelo;
        private System.Windows.Forms.ComboBox comboBoxIdMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTipoAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoTipoAuto;
    }
}