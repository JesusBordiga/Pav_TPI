namespace Shopping_Buy_All
{
    partial class Rubro_Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rubro_Load));
            this.labelTitle = new System.Windows.Forms.Label();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.labelUserList = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.textRubro = new System.Windows.Forms.TextBox();
            this.labelRubro = new System.Windows.Forms.Label();
            this.tablaRubros = new System.Windows.Forms.DataGridView();
            this.CodigoRubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRubros)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(47, 95);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(124, 22);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Cargar rubro";
            // 
            // labelUserList
            // 
            this.labelUserList.AutoSize = true;
            this.labelUserList.BackColor = System.Drawing.Color.Transparent;
            this.labelUserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserList.ForeColor = System.Drawing.Color.White;
            this.labelUserList.Location = new System.Drawing.Point(255, 19);
            this.labelUserList.Name = "labelUserList";
            this.labelUserList.Size = new System.Drawing.Size(166, 22);
            this.labelUserList.TabIndex = 28;
            this.labelUserList.Text = "Lista de Usuarios";
            // 
            // btnLoad
            // 
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(33, 312);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Cargar";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(114, 312);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textRubro
            // 
            this.textRubro.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textRubro.ForeColor = System.Drawing.Color.White;
            this.textRubro.Location = new System.Drawing.Point(57, 154);
            this.textRubro.Name = "textRubro";
            this.textRubro.Size = new System.Drawing.Size(110, 20);
            this.textRubro.TabIndex = 1;
            // 
            // labelRubro
            // 
            this.labelRubro.AutoSize = true;
            this.labelRubro.BackColor = System.Drawing.Color.Transparent;
            this.labelRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRubro.ForeColor = System.Drawing.Color.White;
            this.labelRubro.Location = new System.Drawing.Point(82, 134);
            this.labelRubro.Name = "labelRubro";
            this.labelRubro.Size = new System.Drawing.Size(64, 17);
            this.labelRubro.TabIndex = 3;
            this.labelRubro.Text = "Nombre";
            this.labelRubro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablaRubros
            // 
            this.tablaRubros.AllowUserToAddRows = false;
            this.tablaRubros.AllowUserToDeleteRows = false;
            this.tablaRubros.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaRubros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaRubros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaRubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaRubros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoRubro,
            this.nombre,
            this.dataGridViewTextBoxColumn2});
            this.tablaRubros.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaRubros.Location = new System.Drawing.Point(232, 41);
            this.tablaRubros.Name = "tablaRubros";
            this.tablaRubros.ReadOnly = true;
            this.tablaRubros.RowHeadersWidth = 10;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.tablaRubros.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaRubros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaRubros.Size = new System.Drawing.Size(217, 317);
            this.tablaRubros.TabIndex = 93;
            this.tablaRubros.TabStop = false;
            // 
            // CodigoRubro
            // 
            this.CodigoRubro.DataPropertyName = "CodigoRubro";
            this.CodigoRubro.HeaderText = "Id";
            this.CodigoRubro.Name = "CodigoRubro";
            this.CodigoRubro.ReadOnly = true;
            this.CodigoRubro.Width = 35;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Borrado";
            this.dataGridViewTextBoxColumn2.HeaderText = "Borrado";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // Rubro_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(462, 366);
            this.Controls.Add(this.tablaRubros);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.labelUserList);
            this.Controls.Add(this.textRubro);
            this.Controls.Add(this.labelRubro);
            this.Controls.Add(this.labelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Rubro_Load";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Rubro";
            ((System.ComponentModel.ISupportInitialize)(this.tablaRubros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Label labelUserList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textRubro;
        private System.Windows.Forms.Label labelRubro;
        private System.Windows.Forms.DataGridView tablaRubros;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoRubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}