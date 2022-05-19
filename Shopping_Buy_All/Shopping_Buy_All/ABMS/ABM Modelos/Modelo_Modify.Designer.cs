namespace Shopping_Buy_All
{
    partial class Modelo_Modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modelo_Modify));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClientLoad = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchPanel = new System.Windows.Forms.PictureBox();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.btnSearchClient2 = new System.Windows.Forms.Button();
            this.comboBoxTipoAuto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxIdMarca = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textNombreModelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tablaModelos = new System.Windows.Forms.DataGridView();
            this.CodigoModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoTipoAuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textNombreNuevo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNuevoTipoAuto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxNuevoIdMarca = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaModelos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(115, 419);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClientLoad
            // 
            this.btnClientLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientLoad.ForeColor = System.Drawing.Color.White;
            this.btnClientLoad.Location = new System.Drawing.Point(160, 282);
            this.btnClientLoad.Name = "btnClientLoad";
            this.btnClientLoad.Size = new System.Drawing.Size(75, 23);
            this.btnClientLoad.TabIndex = 52;
            this.btnClientLoad.Text = "Modificar";
            this.btnClientLoad.UseVisualStyleBackColor = true;
            this.btnClientLoad.Click += new System.EventHandler(this.btnClientLoad_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(586, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(232, 31);
            this.label15.TabIndex = 59;
            this.label15.Text = "Lista de Clientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "Buscar Modelo";
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.Transparent;
            this.SearchPanel.Location = new System.Drawing.Point(-1, 155);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(369, 150);
            this.SearchPanel.TabIndex = 61;
            this.SearchPanel.TabStop = false;
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClient.ForeColor = System.Drawing.Color.White;
            this.btnSearchClient.Location = new System.Drawing.Point(199, 419);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(75, 23);
            this.btnSearchClient.TabIndex = 62;
            this.btnSearchClient.Text = "Buscar";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            this.btnSearchClient.Click += new System.EventHandler(this.btnBuscarCliente_click);
            // 
            // btnSearchClient2
            // 
            this.btnSearchClient2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchClient2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClient2.ForeColor = System.Drawing.Color.White;
            this.btnSearchClient2.Location = new System.Drawing.Point(199, 419);
            this.btnSearchClient2.Name = "btnSearchClient2";
            this.btnSearchClient2.Size = new System.Drawing.Size(75, 23);
            this.btnSearchClient2.TabIndex = 63;
            this.btnSearchClient2.Text = "Buscar";
            this.btnSearchClient2.UseVisualStyleBackColor = true;
            this.btnSearchClient2.Click += new System.EventHandler(this.btnSearchClient2_Click);
            // 
            // comboBoxTipoAuto
            // 
            this.comboBoxTipoAuto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxTipoAuto.ForeColor = System.Drawing.Color.White;
            this.comboBoxTipoAuto.FormattingEnabled = true;
            this.comboBoxTipoAuto.Location = new System.Drawing.Point(196, 128);
            this.comboBoxTipoAuto.Name = "comboBoxTipoAuto";
            this.comboBoxTipoAuto.Size = new System.Drawing.Size(119, 21);
            this.comboBoxTipoAuto.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(107, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 79;
            this.label3.Text = "Tipo Auto:";
            // 
            // comboBoxIdMarca
            // 
            this.comboBoxIdMarca.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxIdMarca.ForeColor = System.Drawing.Color.White;
            this.comboBoxIdMarca.FormattingEnabled = true;
            this.comboBoxIdMarca.Location = new System.Drawing.Point(196, 101);
            this.comboBoxIdMarca.Name = "comboBoxIdMarca";
            this.comboBoxIdMarca.Size = new System.Drawing.Size(119, 21);
            this.comboBoxIdMarca.TabIndex = 78;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(133, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 17);
            this.label16.TabIndex = 77;
            this.label16.Text = "Marca:";
            // 
            // textNombreModelo
            // 
            this.textNombreModelo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNombreModelo.ForeColor = System.Drawing.Color.White;
            this.textNombreModelo.Location = new System.Drawing.Point(196, 75);
            this.textNombreModelo.Name = "textNombreModelo";
            this.textNombreModelo.Size = new System.Drawing.Size(119, 20);
            this.textNombreModelo.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 17);
            this.label5.TabIndex = 76;
            this.label5.Text = "Nombre del Modelo:";
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
            this.CodigoTipoAuto});
            this.tablaModelos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaModelos.Location = new System.Drawing.Point(374, 43);
            this.tablaModelos.Name = "tablaModelos";
            this.tablaModelos.ReadOnly = true;
            this.tablaModelos.Size = new System.Drawing.Size(650, 364);
            this.tablaModelos.TabIndex = 81;
            this.tablaModelos.TabStop = false;
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
            // 
            // textNombreNuevo
            // 
            this.textNombreNuevo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNombreNuevo.ForeColor = System.Drawing.Color.White;
            this.textNombreNuevo.Location = new System.Drawing.Point(223, 187);
            this.textNombreNuevo.Name = "textNombreNuevo";
            this.textNombreNuevo.Size = new System.Drawing.Size(119, 20);
            this.textNombreNuevo.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "Nuevo Nombre del Modelo:";
            // 
            // comboBoxNuevoTipoAuto
            // 
            this.comboBoxNuevoTipoAuto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxNuevoTipoAuto.ForeColor = System.Drawing.Color.White;
            this.comboBoxNuevoTipoAuto.FormattingEnabled = true;
            this.comboBoxNuevoTipoAuto.Location = new System.Drawing.Point(223, 244);
            this.comboBoxNuevoTipoAuto.Name = "comboBoxNuevoTipoAuto";
            this.comboBoxNuevoTipoAuto.Size = new System.Drawing.Size(119, 21);
            this.comboBoxNuevoTipoAuto.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(80, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 86;
            this.label4.Text = "Tipo Auto Nuevo:";
            // 
            // comboBoxNuevoIdMarca
            // 
            this.comboBoxNuevoIdMarca.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxNuevoIdMarca.ForeColor = System.Drawing.Color.White;
            this.comboBoxNuevoIdMarca.FormattingEnabled = true;
            this.comboBoxNuevoIdMarca.Location = new System.Drawing.Point(223, 217);
            this.comboBoxNuevoIdMarca.Name = "comboBoxNuevoIdMarca";
            this.comboBoxNuevoIdMarca.Size = new System.Drawing.Size(119, 21);
            this.comboBoxNuevoIdMarca.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(107, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 84;
            this.label6.Text = "Marca Nueva:";
            // 
            // Modelo_Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 449);
            this.Controls.Add(this.comboBoxNuevoTipoAuto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxNuevoIdMarca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textNombreNuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tablaModelos);
            this.Controls.Add(this.comboBoxTipoAuto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxIdMarca);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textNombreModelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearchClient);
            this.Controls.Add(this.btnSearchClient2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.btnClientLoad);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1043, 488);
            this.MinimumSize = new System.Drawing.Size(1043, 488);
            this.Name = "Modelo_Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Modelo";
            ((System.ComponentModel.ISupportInitialize)(this.SearchPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaModelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClientLoad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.Button btnSearchClient2;
        private System.Windows.Forms.ComboBox comboBoxTipoAuto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxIdMarca;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textNombreModelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView tablaModelos;
        private System.Windows.Forms.TextBox textNombreNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoTipoAuto;
        private System.Windows.Forms.ComboBox comboBoxNuevoTipoAuto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxNuevoIdMarca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox SearchPanel;
    }
}