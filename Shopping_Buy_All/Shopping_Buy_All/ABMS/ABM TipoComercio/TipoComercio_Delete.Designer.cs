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
            this.label4 = new System.Windows.Forms.Label();
            this.tablaTipoComercio = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnDeleteTipoComercio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTipoComercio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreTipoComercio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoComercio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Buscar Tipo Comercio a eliminar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(102, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Nombre del Tipo Comercio";
            // 
            // tablaTipoComercio
            // 
            this.tablaTipoComercio.AllowUserToAddRows = false;
            this.tablaTipoComercio.AllowUserToDeleteRows = false;
            this.tablaTipoComercio.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaTipoComercio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaTipoComercio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTipoComercio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NombreTipoComercio});
            this.tablaTipoComercio.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaTipoComercio.Location = new System.Drawing.Point(41, 196);
            this.tablaTipoComercio.Name = "tablaTipoComercio";
            this.tablaTipoComercio.ReadOnly = true;
            this.tablaTipoComercio.Size = new System.Drawing.Size(298, 54);
            this.tablaTipoComercio.TabIndex = 64;
            this.tablaTipoComercio.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(161, 196);
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
            this.btnClean.Location = new System.Drawing.Point(161, 256);
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
            this.btnDeleteTipoComercio.Location = new System.Drawing.Point(157, 294);
            this.btnDeleteTipoComercio.Name = "btnDeleteTipoComercio";
            this.btnDeleteTipoComercio.Size = new System.Drawing.Size(76, 73);
            this.btnDeleteTipoComercio.TabIndex = 67;
            this.btnDeleteTipoComercio.UseVisualStyleBackColor = false;
            this.btnDeleteTipoComercio.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(264, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 68;
            this.button1.Text = "Clientes";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Tipo_Comercio";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // NombreTipoComercio
            // 
            this.NombreTipoComercio.DataPropertyName = "NombreTipoComercio";
            this.NombreTipoComercio.HeaderText = "NombreTipoComercio";
            this.NombreTipoComercio.Name = "NombreTipoComercio";
            this.NombreTipoComercio.ReadOnly = true;
            this.NombreTipoComercio.Width = 200;
            // 
            // txtNombreTipoComercio
            // 
            this.txtNombreTipoComercio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombreTipoComercio.Location = new System.Drawing.Point(147, 124);
            this.txtNombreTipoComercio.Name = "txtNombreTipoComercio";
            this.txtNombreTipoComercio.Size = new System.Drawing.Size(100, 20);
            this.txtNombreTipoComercio.TabIndex = 69;
            // 
            // TipoComercio_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.txtNombreTipoComercio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeleteTipoComercio);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaTipoComercio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(400, 200);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tablaTipoComercio;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnDeleteTipoComercio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTipoComercio;
        private System.Windows.Forms.TextBox txtNombreTipoComercio;
    }
}