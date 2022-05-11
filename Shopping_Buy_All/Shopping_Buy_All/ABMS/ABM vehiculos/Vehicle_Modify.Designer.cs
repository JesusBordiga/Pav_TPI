namespace Shopping_Buy_All.ABMS.ABM_Vehiculos
{
    partial class Vehicle_Modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehicle_Modify));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNroDoc = new System.Windows.Forms.TextBox();
            this.btnSearchType = new System.Windows.Forms.Button();
            this.btnCleanType = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textNamePatente = new System.Windows.Forms.TextBox();
            this.btnModifyVehicle = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDocType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.DataGridView();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textNameModelo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.searchPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 88;
            this.label1.Text = "Modificar vehiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 90;
            this.label2.Text = "NroDocPropietario";
            // 
            // textNroDoc
            // 
            this.textNroDoc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNroDoc.ForeColor = System.Drawing.Color.White;
            this.textNroDoc.Location = new System.Drawing.Point(95, 226);
            this.textNroDoc.Name = "textNroDoc";
            this.textNroDoc.Size = new System.Drawing.Size(46, 20);
            this.textNroDoc.TabIndex = 91;
            // 
            // btnSearchType
            // 
            this.btnSearchType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchType.ForeColor = System.Drawing.Color.White;
            this.btnSearchType.Location = new System.Drawing.Point(72, 360);
            this.btnSearchType.Name = "btnSearchType";
            this.btnSearchType.Size = new System.Drawing.Size(75, 23);
            this.btnSearchType.TabIndex = 92;
            this.btnSearchType.Text = "Buscar";
            this.btnSearchType.UseVisualStyleBackColor = true;
            this.btnSearchType.Click += new System.EventHandler(this.btnSearchType_Click);
            // 
            // btnCleanType
            // 
            this.btnCleanType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCleanType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanType.ForeColor = System.Drawing.Color.White;
            this.btnCleanType.Location = new System.Drawing.Point(152, 360);
            this.btnCleanType.Name = "btnCleanType";
            this.btnCleanType.Size = new System.Drawing.Size(75, 23);
            this.btnCleanType.TabIndex = 93;
            this.btnCleanType.Text = "Limpiar";
            this.btnCleanType.UseVisualStyleBackColor = true;
            this.btnCleanType.Click += new System.EventHandler(this.btnCleanType_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(92, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 94;
            this.label3.Text = "Patente";
            // 
            // textNamePatente
            // 
            this.textNamePatente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNamePatente.ForeColor = System.Drawing.Color.White;
            this.textNamePatente.Location = new System.Drawing.Point(63, 118);
            this.textNamePatente.Name = "textNamePatente";
            this.textNamePatente.Size = new System.Drawing.Size(120, 20);
            this.textNamePatente.TabIndex = 95;
            // 
            // btnModifyVehicle
            // 
            this.btnModifyVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifyVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyVehicle.ForeColor = System.Drawing.Color.White;
            this.btnModifyVehicle.Location = new System.Drawing.Point(72, 319);
            this.btnModifyVehicle.Name = "btnModifyVehicle";
            this.btnModifyVehicle.Size = new System.Drawing.Size(75, 23);
            this.btnModifyVehicle.TabIndex = 96;
            this.btnModifyVehicle.Text = "Modificar";
            this.btnModifyVehicle.UseVisualStyleBackColor = true;
            this.btnModifyVehicle.Click += new System.EventHandler(this.btnModifyVehicle_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(152, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 97;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(60, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 98;
            this.label4.Text = "Tipo de Documento";
            // 
            // comboBoxDocType
            // 
            this.comboBoxDocType.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxDocType.ForeColor = System.Drawing.Color.White;
            this.comboBoxDocType.FormattingEnabled = true;
            this.comboBoxDocType.Location = new System.Drawing.Point(63, 176);
            this.comboBoxDocType.Name = "comboBoxDocType";
            this.comboBoxDocType.Size = new System.Drawing.Size(119, 21);
            this.comboBoxDocType.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(88, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 100;
            this.label5.Text = "Modelo";
            // 
            // searchPanel
            // 
            this.searchPanel.AllowUserToAddRows = false;
            this.searchPanel.AllowUserToDeleteRows = false;
            this.searchPanel.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searchPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchPanel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoDocumento,
            this.dataGridViewTextBoxColumn1,
            this.NroDocumento,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.searchPanel.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchPanel.Location = new System.Drawing.Point(274, 72);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.ReadOnly = true;
            this.searchPanel.RowHeadersWidth = 10;
            this.searchPanel.Size = new System.Drawing.Size(415, 311);
            this.searchPanel.TabIndex = 102;
            this.searchPanel.TabStop = false;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.DataPropertyName = "TipoDoc";
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.MinimumWidth = 6;
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            this.TipoDocumento.Width = 70;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Borrado";
            this.dataGridViewTextBoxColumn1.HeaderText = "Borrado";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // NroDocumento
            // 
            this.NroDocumento.DataPropertyName = "NroDoc";
            this.NroDocumento.HeaderText = "Nro Documento";
            this.NroDocumento.MinimumWidth = 6;
            this.NroDocumento.Name = "NroDocumento";
            this.NroDocumento.ReadOnly = true;
            this.NroDocumento.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Patente";
            this.dataGridViewTextBoxColumn2.HeaderText = "Patente";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // textNameModelo
            // 
            this.textNameModelo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNameModelo.ForeColor = System.Drawing.Color.White;
            this.textNameModelo.FormattingEnabled = true;
            this.textNameModelo.Location = new System.Drawing.Point(64, 278);
            this.textNameModelo.Name = "textNameModelo";
            this.textNameModelo.Size = new System.Drawing.Size(119, 21);
            this.textNameModelo.TabIndex = 103;
            // 
            // Vehicle_Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 390);
            this.Controls.Add(this.textNameModelo);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCleanType);
            this.Controls.Add(this.btnSearchType);
            this.Controls.Add(this.textNamePatente);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModifyVehicle);
            this.Controls.Add(this.textNroDoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDocType);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Vehicle_Modify";
            this.Text = "Modificar Vehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.searchPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNroDoc;
        private System.Windows.Forms.Button btnSearchType;
        private System.Windows.Forms.Button btnCleanType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNamePatente;
        private System.Windows.Forms.Button btnModifyVehicle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDocType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView searchPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox textNameModelo;
    }
}