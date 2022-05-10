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
            this.label1 = new System.Windows.Forms.Label();
            this.tablaModelos = new System.Windows.Forms.DataGridView();
            this.CodigoModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoTipoAuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnDeleteModelo = new System.Windows.Forms.Button();
            this.botonModelos = new System.Windows.Forms.Button();
            this.comboBoxTipoAuto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxIdMarca = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textNombreModelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaModelos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(242, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "Buscar modelo a eliminar";
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
            this.tablaModelos.Location = new System.Drawing.Point(60, 196);
            this.tablaModelos.Name = "tablaModelos";
            this.tablaModelos.ReadOnly = true;
            this.tablaModelos.Size = new System.Drawing.Size(674, 54);
            this.tablaModelos.TabIndex = 64;
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
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(368, 204);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.DarkGray;
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(368, 264);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 4;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnDeleteModelo
            // 
            this.btnDeleteModelo.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteModelo.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.Trash;
            this.btnDeleteModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteModelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteModelo.ForeColor = System.Drawing.Color.White;
            this.btnDeleteModelo.Location = new System.Drawing.Point(364, 302);
            this.btnDeleteModelo.Name = "btnDeleteModelo";
            this.btnDeleteModelo.Size = new System.Drawing.Size(76, 73);
            this.btnDeleteModelo.TabIndex = 67;
            this.btnDeleteModelo.UseVisualStyleBackColor = false;
            this.btnDeleteModelo.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // botonModelos
            // 
            this.botonModelos.BackColor = System.Drawing.Color.DarkGray;
            this.botonModelos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonModelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonModelos.ForeColor = System.Drawing.Color.White;
            this.botonModelos.Location = new System.Drawing.Point(722, 425);
            this.botonModelos.Name = "botonModelos";
            this.botonModelos.Size = new System.Drawing.Size(75, 23);
            this.botonModelos.TabIndex = 68;
            this.botonModelos.Text = "Modelos";
            this.botonModelos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonModelos.UseVisualStyleBackColor = false;
            this.botonModelos.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxTipoAuto
            // 
            this.comboBoxTipoAuto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxTipoAuto.ForeColor = System.Drawing.Color.White;
            this.comboBoxTipoAuto.FormattingEnabled = true;
            this.comboBoxTipoAuto.Location = new System.Drawing.Point(423, 136);
            this.comboBoxTipoAuto.Name = "comboBoxTipoAuto";
            this.comboBoxTipoAuto.Size = new System.Drawing.Size(119, 21);
            this.comboBoxTipoAuto.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(315, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 73;
            this.label3.Text = "Tipo Auto:";
            // 
            // comboBoxIdMarca
            // 
            this.comboBoxIdMarca.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxIdMarca.ForeColor = System.Drawing.Color.White;
            this.comboBoxIdMarca.FormattingEnabled = true;
            this.comboBoxIdMarca.Location = new System.Drawing.Point(423, 106);
            this.comboBoxIdMarca.Name = "comboBoxIdMarca";
            this.comboBoxIdMarca.Size = new System.Drawing.Size(119, 21);
            this.comboBoxIdMarca.TabIndex = 72;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(341, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 17);
            this.label16.TabIndex = 71;
            this.label16.Text = "Marca:";
            // 
            // textNombreModelo
            // 
            this.textNombreModelo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNombreModelo.ForeColor = System.Drawing.Color.White;
            this.textNombreModelo.Location = new System.Drawing.Point(423, 76);
            this.textNombreModelo.Name = "textNombreModelo";
            this.textNombreModelo.Size = new System.Drawing.Size(119, 20);
            this.textNombreModelo.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(264, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "Nombre del Modelo:";
            // 
            // Modelo_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxTipoAuto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxIdMarca);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textNombreModelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botonModelos);
            this.Controls.Add(this.btnDeleteModelo);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaModelos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Modelo_Delete";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminar Modelo";
            this.Load += new System.EventHandler(this.Client_Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaModelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaModelos;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnDeleteModelo;
        private System.Windows.Forms.Button botonModelos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoTipoAuto;
        private System.Windows.Forms.ComboBox comboBoxTipoAuto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxIdMarca;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textNombreModelo;
        private System.Windows.Forms.Label label5;
    }
}