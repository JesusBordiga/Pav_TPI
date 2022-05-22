namespace Shopping_Buy_All.ABM_Tipo_Documento
{
    partial class TipoDoc_Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoDoc_Load));
            this.btnTipDocLoad = new System.Windows.Forms.Button();
            this.txtTipoDoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tablaTipDoc = new System.Windows.Forms.DataGridView();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTipDocLoad
            // 
            this.btnTipDocLoad.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTipDocLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTipDocLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipDocLoad.ForeColor = System.Drawing.Color.White;
            this.btnTipDocLoad.Location = new System.Drawing.Point(70, 250);
            this.btnTipDocLoad.Name = "btnTipDocLoad";
            this.btnTipDocLoad.Size = new System.Drawing.Size(75, 23);
            this.btnTipDocLoad.TabIndex = 2;
            this.btnTipDocLoad.Text = "Cargar";
            this.btnTipDocLoad.UseVisualStyleBackColor = false;
            this.btnTipDocLoad.Click += new System.EventHandler(this.btnSexoLoad_Click_1);
            // 
            // txtTipoDoc
            // 
            this.txtTipoDoc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtTipoDoc.ForeColor = System.Drawing.Color.White;
            this.txtTipoDoc.Location = new System.Drawing.Point(64, 133);
            this.txtTipoDoc.Name = "txtTipoDoc";
            this.txtTipoDoc.Size = new System.Drawing.Size(100, 20);
            this.txtTipoDoc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(81, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "Nombre";
            // 
            // tablaTipDoc
            // 
            this.tablaTipDoc.AllowUserToAddRows = false;
            this.tablaTipDoc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tablaTipDoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaTipDoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaTipDoc.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaTipDoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaTipDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTipDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoDocumento,
            this.NombreDocumento,
            this.Borrado});
            this.tablaTipDoc.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaTipDoc.Location = new System.Drawing.Point(210, 55);
            this.tablaTipDoc.Name = "tablaTipDoc";
            this.tablaTipDoc.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaTipDoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaTipDoc.RowHeadersWidth = 10;
            this.tablaTipDoc.Size = new System.Drawing.Size(235, 248);
            this.tablaTipDoc.TabIndex = 111;
            this.tablaTipDoc.TabStop = false;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.DataPropertyName = "TipoDocumento";
            this.TipoDocumento.HeaderText = "Id";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            // 
            // NombreDocumento
            // 
            this.NombreDocumento.DataPropertyName = "NombreDocumento";
            this.NombreDocumento.HeaderText = "Nombre";
            this.NombreDocumento.Name = "NombreDocumento";
            this.NombreDocumento.ReadOnly = true;
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "Borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            this.Borrado.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 44);
            this.label3.TabIndex = 114;
            this.label3.Text = "Cargar Tipos de\r\nDocumento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(228, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 22);
            this.label4.TabIndex = 113;
            this.label4.Text = "Tipos de Documento";
            // 
            // TipoDoc_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(453, 310);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tablaTipDoc);
            this.Controls.Add(this.btnTipDocLoad);
            this.Controls.Add(this.txtTipoDoc);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TipoDoc_Load";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Tipo de Documento";
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTipDocLoad;
        private System.Windows.Forms.TextBox txtTipoDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tablaTipDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}