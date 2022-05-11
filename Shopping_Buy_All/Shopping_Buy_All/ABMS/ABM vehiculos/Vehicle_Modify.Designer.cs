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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchPanel = new System.Windows.Forms.DataGridView();
            this.Patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocPropietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocPropietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.textNameModelo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.searchPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.AllowUserToAddRows = false;
            this.searchPanel.AllowUserToDeleteRows = false;
            this.searchPanel.AllowUserToOrderColumns = true;
            this.searchPanel.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchPanel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.searchPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchPanel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Patente,
            this.TipoDocPropietario,
            this.NroDocPropietario,
            this.Modelo,
            this.Borrado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.searchPanel.DefaultCellStyle = dataGridViewCellStyle2;
            this.searchPanel.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchPanel.Location = new System.Drawing.Point(463, 32);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchPanel.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.searchPanel.RowHeadersWidth = 51;
            this.searchPanel.RowTemplate.Height = 24;
            this.searchPanel.Size = new System.Drawing.Size(525, 325);
            this.searchPanel.TabIndex = 87;
            this.searchPanel.TabStop = false;
            // 
            // Patente
            // 
            this.Patente.DataPropertyName = "Patente";
            this.Patente.HeaderText = "Patente";
            this.Patente.MinimumWidth = 6;
            this.Patente.Name = "Patente";
            this.Patente.ReadOnly = true;
            this.Patente.Width = 125;
            // 
            // TipoDocPropietario
            // 
            this.TipoDocPropietario.DataPropertyName = "TipoDoc";
            this.TipoDocPropietario.HeaderText = "TipoDocPropietario";
            this.TipoDocPropietario.MinimumWidth = 6;
            this.TipoDocPropietario.Name = "TipoDocPropietario";
            this.TipoDocPropietario.ReadOnly = true;
            this.TipoDocPropietario.Width = 125;
            // 
            // NroDocPropietario
            // 
            this.NroDocPropietario.DataPropertyName = "NroDoc";
            this.NroDocPropietario.HeaderText = "NroDocPropietario";
            this.NroDocPropietario.MinimumWidth = 6;
            this.NroDocPropietario.Name = "NroDocPropietario";
            this.NroDocPropietario.ReadOnly = true;
            this.NroDocPropietario.Width = 125;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 6;
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 125;
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "Borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.MinimumWidth = 6;
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            this.Borrado.Visible = false;
            this.Borrado.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 88;
            this.label1.Text = "Modificar vehiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 90;
            this.label2.Text = "NroDocPropietario";
            // 
            // textNroDoc
            // 
            this.textNroDoc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNroDoc.ForeColor = System.Drawing.Color.White;
            this.textNroDoc.Location = new System.Drawing.Point(169, 219);
            this.textNroDoc.Name = "textNroDoc";
            this.textNroDoc.Size = new System.Drawing.Size(46, 20);
            this.textNroDoc.TabIndex = 91;
            // 
            // btnSearchType
            // 
            this.btnSearchType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchType.ForeColor = System.Drawing.Color.White;
            this.btnSearchType.Location = new System.Drawing.Point(146, 353);
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
            this.btnCleanType.Location = new System.Drawing.Point(226, 353);
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
            this.label3.Location = new System.Drawing.Point(166, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 94;
            this.label3.Text = "Patente";
            // 
            // textNamePatente
            // 
            this.textNamePatente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNamePatente.ForeColor = System.Drawing.Color.White;
            this.textNamePatente.Location = new System.Drawing.Point(137, 111);
            this.textNamePatente.Name = "textNamePatente";
            this.textNamePatente.Size = new System.Drawing.Size(120, 20);
            this.textNamePatente.TabIndex = 95;
            // 
            // btnModifyVehicle
            // 
            this.btnModifyVehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifyVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyVehicle.ForeColor = System.Drawing.Color.White;
            this.btnModifyVehicle.Location = new System.Drawing.Point(146, 312);
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
            this.btnCancel.Location = new System.Drawing.Point(226, 312);
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
            this.label4.Location = new System.Drawing.Point(134, 150);
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
            this.comboBoxDocType.Location = new System.Drawing.Point(137, 169);
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
            this.label5.Location = new System.Drawing.Point(162, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 100;
            this.label5.Text = "Modelo";
            // 
            // textNameModelo
            // 
            this.textNameModelo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNameModelo.ForeColor = System.Drawing.Color.White;
            this.textNameModelo.Location = new System.Drawing.Point(137, 270);
            this.textNameModelo.Name = "textNameModelo";
            this.textNameModelo.Size = new System.Drawing.Size(100, 20);
            this.textNameModelo.TabIndex = 101;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(391, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 102;
            // 
            // Vehicle_Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1025, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCleanType);
            this.Controls.Add(this.btnSearchType);
            this.Controls.Add(this.textNamePatente);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModifyVehicle);
            this.Controls.Add(this.textNroDoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.textNameModelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDocType);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Vehicle_Modify";
            this.Text = "Vehicle_Modify";
            ((System.ComponentModel.ISupportInitialize)(this.searchPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView searchPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNroDoc;
        private System.Windows.Forms.Button btnSearchType;
        private System.Windows.Forms.Button btnCleanType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNamePatente;
        private System.Windows.Forms.Button btnModifyVehicle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocPropietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocPropietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDocType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNameModelo;
        private System.Windows.Forms.Panel panel1;
    }
}