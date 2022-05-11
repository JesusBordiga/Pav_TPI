namespace Shopping_Buy_All.ABM_Estado_Civil
{
    partial class EstadoCivil_Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstadoCivil_Load));
            this.tablaEsCiv = new System.Windows.Forms.DataGridView();
            this.TipoEstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreEC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnECLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEsCiv)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaEsCiv
            // 
            this.tablaEsCiv.AllowUserToAddRows = false;
            this.tablaEsCiv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tablaEsCiv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaEsCiv.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaEsCiv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaEsCiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEsCiv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoEstadoCivil,
            this.NombreEstadoCivil,
            this.Borrado});
            this.tablaEsCiv.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaEsCiv.Location = new System.Drawing.Point(194, 40);
            this.tablaEsCiv.Name = "tablaEsCiv";
            this.tablaEsCiv.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaEsCiv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaEsCiv.RowHeadersWidth = 10;
            this.tablaEsCiv.Size = new System.Drawing.Size(234, 253);
            this.tablaEsCiv.TabIndex = 61;
            this.tablaEsCiv.TabStop = false;
            // 
            // TipoEstadoCivil
            // 
            this.TipoEstadoCivil.DataPropertyName = "TipoEstadoCivil";
            this.TipoEstadoCivil.HeaderText = "Id";
            this.TipoEstadoCivil.Name = "TipoEstadoCivil";
            this.TipoEstadoCivil.ReadOnly = true;
            // 
            // NombreEstadoCivil
            // 
            this.NombreEstadoCivil.DataPropertyName = "NombreEstadoCivil";
            this.NombreEstadoCivil.HeaderText = "Nombre";
            this.NombreEstadoCivil.Name = "NombreEstadoCivil";
            this.NombreEstadoCivil.ReadOnly = true;
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "Borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            this.Borrado.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(203, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(225, 22);
            this.label15.TabIndex = 62;
            this.label15.Text = "Lista de Estados Civiles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 50);
            this.label1.TabIndex = 63;
            this.label1.Text = "   Cargar \r\nEstado Civil";
            // 
            // txtNombreEC
            // 
            this.txtNombreEC.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombreEC.ForeColor = System.Drawing.Color.White;
            this.txtNombreEC.Location = new System.Drawing.Point(54, 145);
            this.txtNombreEC.Name = "txtNombreEC";
            this.txtNombreEC.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEC.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 64;
            this.label2.Text = "Nombre";
            // 
            // btnECLoad
            // 
            this.btnECLoad.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnECLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnECLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnECLoad.ForeColor = System.Drawing.Color.White;
            this.btnECLoad.Location = new System.Drawing.Point(63, 189);
            this.btnECLoad.Name = "btnECLoad";
            this.btnECLoad.Size = new System.Drawing.Size(75, 23);
            this.btnECLoad.TabIndex = 66;
            this.btnECLoad.Text = "Cargar";
            this.btnECLoad.UseVisualStyleBackColor = false;
            this.btnECLoad.Click += new System.EventHandler(this.btnECLoad_Click);
            // 
            // EstadoCivil_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(436, 301);
            this.Controls.Add(this.btnECLoad);
            this.Controls.Add(this.txtNombreEC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tablaEsCiv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EstadoCivil_Load";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de  Estado Civil";
            ((System.ComponentModel.ISupportInitialize)(this.tablaEsCiv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaEsCiv;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreEC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnECLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
    }
}