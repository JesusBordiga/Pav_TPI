namespace Shopping_Buy_All.ABMS.ABM_Vehiculos
{
    partial class Vehicle_Delete
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablaVehiculos = new System.Windows.Forms.DataGridView();
            this.Patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocPropietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocPropietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchPanel = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNroDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNamePatente = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearchvehicle = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnSerach2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaVehiculos
            // 
            this.tablaVehiculos.AllowUserToAddRows = false;
            this.tablaVehiculos.AllowUserToDeleteRows = false;
            this.tablaVehiculos.AllowUserToOrderColumns = true;
            this.tablaVehiculos.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaVehiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Patente,
            this.TipoDocPropietario,
            this.NroDocPropietario,
            this.Modelo,
            this.Borrado});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaVehiculos.DefaultCellStyle = dataGridViewCellStyle5;
            this.tablaVehiculos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaVehiculos.Location = new System.Drawing.Point(531, 74);
            this.tablaVehiculos.Margin = new System.Windows.Forms.Padding(4);
            this.tablaVehiculos.Name = "tablaVehiculos";
            this.tablaVehiculos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaVehiculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tablaVehiculos.RowHeadersWidth = 51;
            this.tablaVehiculos.RowTemplate.Height = 24;
            this.tablaVehiculos.Size = new System.Drawing.Size(700, 400);
            this.tablaVehiculos.TabIndex = 88;
            this.tablaVehiculos.TabStop = false;
            // 
            // Patente
            // 
            this.Patente.HeaderText = "Patente";
            this.Patente.MinimumWidth = 6;
            this.Patente.Name = "Patente";
            this.Patente.ReadOnly = true;
            this.Patente.Width = 125;
            // 
            // TipoDocPropietario
            // 
            this.TipoDocPropietario.DataPropertyName = "TipDoc";
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
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.MinimumWidth = 6;
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            this.Borrado.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(134, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 32);
            this.label1.TabIndex = 89;
            this.label1.Text = "Eliminar  vehiculo";
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.Transparent;
            this.SearchPanel.Location = new System.Drawing.Point(75, 124);
            this.SearchPanel.Margin = new System.Windows.Forms.Padding(4);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(333, 306);
            this.SearchPanel.TabIndex = 93;
            this.SearchPanel.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(169, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 94;
            this.label2.Text = "NroDocPropietario";
            // 
            // textNroDoc
            // 
            this.textNroDoc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNroDoc.ForeColor = System.Drawing.Color.White;
            this.textNroDoc.Location = new System.Drawing.Point(217, 180);
            this.textNroDoc.Margin = new System.Windows.Forms.Padding(4);
            this.textNroDoc.Name = "textNroDoc";
            this.textNroDoc.Size = new System.Drawing.Size(60, 22);
            this.textNroDoc.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(213, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 96;
            this.label3.Text = "Patente";
            // 
            // textNamePatente
            // 
            this.textNamePatente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNamePatente.ForeColor = System.Drawing.Color.White;
            this.textNamePatente.Location = new System.Drawing.Point(173, 281);
            this.textNamePatente.Margin = new System.Windows.Forms.Padding(4);
            this.textNamePatente.Name = "textNamePatente";
            this.textNamePatente.Size = new System.Drawing.Size(159, 22);
            this.textNamePatente.TabIndex = 97;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(75, 415);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 98;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearchvehicle
            // 
            this.btnSearchvehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchvehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchvehicle.ForeColor = System.Drawing.Color.White;
            this.btnSearchvehicle.Location = new System.Drawing.Point(186, 415);
            this.btnSearchvehicle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchvehicle.Name = "btnSearchvehicle";
            this.btnSearchvehicle.Size = new System.Drawing.Size(100, 28);
            this.btnSearchvehicle.TabIndex = 99;
            this.btnSearchvehicle.Text = "Buscar";
            this.btnSearchvehicle.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(310, 415);
            this.btnClean.Margin = new System.Windows.Forms.Padding(4);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(100, 28);
            this.btnClean.TabIndex = 100;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // btnSerach2
            // 
            this.btnSerach2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSerach2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerach2.ForeColor = System.Drawing.Color.White;
            this.btnSerach2.Location = new System.Drawing.Point(186, 341);
            this.btnSerach2.Margin = new System.Windows.Forms.Padding(4);
            this.btnSerach2.Name = "btnSerach2";
            this.btnSerach2.Size = new System.Drawing.Size(100, 28);
            this.btnSerach2.TabIndex = 101;
            this.btnSerach2.Text = "Buscar";
            this.btnSerach2.UseVisualStyleBackColor = true;
            // 
            // Vehicle_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 553);
            this.Controls.Add(this.btnSerach2);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSearchvehicle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.textNamePatente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNroDoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaVehiculos);
            this.Name = "Vehicle_Delete";
            this.Text = "Vehicle_Delete";
            ((System.ComponentModel.ISupportInitialize)(this.tablaVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaVehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocPropietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocPropietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox SearchPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNroDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNamePatente;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearchvehicle;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnSerach2;
    }
}