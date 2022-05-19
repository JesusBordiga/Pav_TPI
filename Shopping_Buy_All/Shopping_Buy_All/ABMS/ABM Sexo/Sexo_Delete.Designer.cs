namespace Shopping_Buy_All.ABM_Sexo
{
    partial class Sexo_Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sexo_Delete));
            this.btnSexoDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarSexo = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaSexo = new System.Windows.Forms.DataGridView();
            this.TipoSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSexo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSexoDelete
            // 
            this.btnSexoDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSexoDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSexoDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSexoDelete.ForeColor = System.Drawing.Color.White;
            this.btnSexoDelete.Location = new System.Drawing.Point(64, 234);
            this.btnSexoDelete.Name = "btnSexoDelete";
            this.btnSexoDelete.Size = new System.Drawing.Size(75, 23);
            this.btnSexoDelete.TabIndex = 3;
            this.btnSexoDelete.Text = "Dar de Baja";
            this.btnSexoDelete.UseVisualStyleBackColor = false;
            this.btnSexoDelete.Click += new System.EventHandler(this.btnSexoDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 143;
            this.label2.Text = "Nombre";
            // 
            // btnBuscarSexo
            // 
            this.btnBuscarSexo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBuscarSexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarSexo.ForeColor = System.Drawing.Color.White;
            this.btnBuscarSexo.Location = new System.Drawing.Point(64, 234);
            this.btnBuscarSexo.Name = "btnBuscarSexo";
            this.btnBuscarSexo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarSexo.TabIndex = 2;
            this.btnBuscarSexo.Text = "Buscar";
            this.btnBuscarSexo.UseVisualStyleBackColor = false;
            this.btnBuscarSexo.Click += new System.EventHandler(this.btnBuscarSexo_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(57, 118);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 44);
            this.label1.TabIndex = 140;
            this.label1.Text = "Buscar nombres\r\nde Sexo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.TipoSexo,
            this.NombreSexo,
            this.Borrado});
            this.tablaSexo.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaSexo.Location = new System.Drawing.Point(202, 34);
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
            this.tablaSexo.RowHeadersWidth = 10;
            this.tablaSexo.Size = new System.Drawing.Size(230, 239);
            this.tablaSexo.TabIndex = 145;
            this.tablaSexo.TabStop = false;
            // 
            // TipoSexo
            // 
            this.TipoSexo.DataPropertyName = "TipoSexo";
            this.TipoSexo.HeaderText = "Id";
            this.TipoSexo.Name = "TipoSexo";
            this.TipoSexo.ReadOnly = true;
            // 
            // NombreSexo
            // 
            this.NombreSexo.DataPropertyName = "NombreSexo";
            this.NombreSexo.HeaderText = "Nombre";
            this.NombreSexo.Name = "NombreSexo";
            this.NombreSexo.ReadOnly = true;
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "Borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            this.Borrado.Visible = false;
            // 
            // Sexo_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(441, 283);
            this.Controls.Add(this.tablaSexo);
            this.Controls.Add(this.btnSexoDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarSexo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Sexo_Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrar Sexo";
            ((System.ComponentModel.ISupportInitialize)(this.tablaSexo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSexoDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarSexo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
    }
}