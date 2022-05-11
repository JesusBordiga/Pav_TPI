namespace Shopping_Buy_All
{
    partial class Rubro_Modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rubro_Modify));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelRubro = new System.Windows.Forms.Label();
            this.textRubroOld = new System.Windows.Forms.TextBox();
            this.tablaRubros = new System.Windows.Forms.DataGridView();
            this.CodigoRubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textRubroNew = new System.Windows.Forms.TextBox();
            this.labelMod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRubros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(189, 316);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnModify
            // 
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Location = new System.Drawing.Point(29, 316);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Visible = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(302, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 22);
            this.label15.TabIndex = 68;
            this.label15.Text = "Lista de Rubros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 61;
            this.label1.Text = "Modificar rubro";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(109, 316);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelRubro
            // 
            this.labelRubro.AutoSize = true;
            this.labelRubro.BackColor = System.Drawing.Color.Transparent;
            this.labelRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRubro.ForeColor = System.Drawing.Color.White;
            this.labelRubro.Location = new System.Drawing.Point(101, 125);
            this.labelRubro.Name = "labelRubro";
            this.labelRubro.Size = new System.Drawing.Size(52, 17);
            this.labelRubro.TabIndex = 73;
            this.labelRubro.Text = "Rubro";
            // 
            // textRubroOld
            // 
            this.textRubroOld.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textRubroOld.ForeColor = System.Drawing.Color.White;
            this.textRubroOld.Location = new System.Drawing.Point(72, 145);
            this.textRubroOld.Name = "textRubroOld";
            this.textRubroOld.Size = new System.Drawing.Size(110, 20);
            this.textRubroOld.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn1});
            this.tablaRubros.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaRubros.Location = new System.Drawing.Point(279, 44);
            this.tablaRubros.Name = "tablaRubros";
            this.tablaRubros.ReadOnly = true;
            this.tablaRubros.RowHeadersWidth = 20;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.tablaRubros.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaRubros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaRubros.Size = new System.Drawing.Size(205, 310);
            this.tablaRubros.TabIndex = 91;
            this.tablaRubros.TabStop = false;
            this.tablaRubros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaRubros_CellContentClick);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Borrado";
            this.dataGridViewTextBoxColumn1.HeaderText = "Borrado";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // textRubroNew
            // 
            this.textRubroNew.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textRubroNew.ForeColor = System.Drawing.Color.White;
            this.textRubroNew.Location = new System.Drawing.Point(72, 145);
            this.textRubroNew.Name = "textRubroNew";
            this.textRubroNew.Size = new System.Drawing.Size(110, 20);
            this.textRubroNew.TabIndex = 2;
            this.textRubroNew.Visible = false;
            // 
            // labelMod
            // 
            this.labelMod.AutoSize = true;
            this.labelMod.BackColor = System.Drawing.Color.Transparent;
            this.labelMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMod.ForeColor = System.Drawing.Color.White;
            this.labelMod.Location = new System.Drawing.Point(71, 125);
            this.labelMod.Name = "labelMod";
            this.labelMod.Size = new System.Drawing.Size(113, 17);
            this.labelMod.TabIndex = 95;
            this.labelMod.Text = "Nuevo nombre";
            this.labelMod.Visible = false;
            // 
            // Rubro_Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(499, 364);
            this.Controls.Add(this.tablaRubros);
            this.Controls.Add(this.textRubroOld);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelRubro);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textRubroNew);
            this.Controls.Add(this.labelMod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Rubro_Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Rubro";
            ((System.ComponentModel.ISupportInitialize)(this.tablaRubros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelRubro;
        private System.Windows.Forms.TextBox textRubroOld;
        private System.Windows.Forms.DataGridView tablaRubros;
        private System.Windows.Forms.TextBox textRubroNew;
        private System.Windows.Forms.Label labelMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoRubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}