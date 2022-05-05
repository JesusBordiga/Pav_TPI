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
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tablaSexo = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSexo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTipDocLoad
            // 
            this.btnTipDocLoad.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTipDocLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTipDocLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipDocLoad.ForeColor = System.Drawing.Color.White;
            this.btnTipDocLoad.Location = new System.Drawing.Point(113, 318);
            this.btnTipDocLoad.Name = "btnTipDocLoad";
            this.btnTipDocLoad.Size = new System.Drawing.Size(75, 23);
            this.btnTipDocLoad.TabIndex = 78;
            this.btnTipDocLoad.Text = "Cargar";
            this.btnTipDocLoad.UseVisualStyleBackColor = false;
            this.btnTipDocLoad.Click += new System.EventHandler(this.btnSexoLoad_Click_1);
            // 
            // txtTipoDoc
            // 
            this.txtTipoDoc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtTipoDoc.ForeColor = System.Drawing.Color.White;
            this.txtTipoDoc.Location = new System.Drawing.Point(93, 155);
            this.txtTipoDoc.Name = "txtTipoDoc";
            this.txtTipoDoc.Size = new System.Drawing.Size(100, 20);
            this.txtTipoDoc.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(110, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 75;
            this.label1.Text = "Cargar Tipo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(206, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(393, 31);
            this.label15.TabIndex = 74;
            this.label15.Text = "Lista de Tipos de Documento";
            // 
            // tablaSexo
            // 
            this.tablaSexo.AllowUserToAddRows = false;
            this.tablaSexo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tablaSexo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaSexo.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaSexo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaSexo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaSexo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoDocumento,
            this.NombreDocumento,
            this.Borrado});
            this.tablaSexo.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaSexo.Location = new System.Drawing.Point(293, 43);
            this.tablaSexo.Name = "tablaSexo";
            this.tablaSexo.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaSexo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaSexo.Size = new System.Drawing.Size(246, 298);
            this.tablaSexo.TabIndex = 73;
            this.tablaSexo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 31);
            this.label3.TabIndex = 79;
            this.label3.Text = "de Documento";
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.DataPropertyName = "TipoDoumento";
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
            // TipoDoc_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTipDocLoad);
            this.Controls.Add(this.txtTipoDoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tablaSexo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TipoDoc_Load";
            this.Text = "Alta de Tipo de Documento";
            ((System.ComponentModel.ISupportInitialize)(this.tablaSexo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTipDocLoad;
        private System.Windows.Forms.TextBox txtTipoDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView tablaSexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
    }
}