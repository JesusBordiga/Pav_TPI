namespace Shopping_Buy_All
{
    partial class MarcaVeh_Modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarcaVeh_Modify));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMarcaLoad = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchMarca = new System.Windows.Forms.Button();
            this.labelMarca = new System.Windows.Forms.Label();
            this.tablaMarcas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textMarcaNew = new System.Windows.Forms.TextBox();
            this.textMarcaOld = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMarcas)).BeginInit();
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
            // btnMarcaLoad
            // 
            this.btnMarcaLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcaLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcaLoad.ForeColor = System.Drawing.Color.White;
            this.btnMarcaLoad.Location = new System.Drawing.Point(34, 419);
            this.btnMarcaLoad.Name = "btnMarcaLoad";
            this.btnMarcaLoad.Size = new System.Drawing.Size(75, 23);
            this.btnMarcaLoad.TabIndex = 52;
            this.btnMarcaLoad.Text = "Modificar";
            this.btnMarcaLoad.UseVisualStyleBackColor = true;
            this.btnMarcaLoad.Visible = false;
            this.btnMarcaLoad.Click += new System.EventHandler(this.btnMarcaLoad_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(586, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(196, 29);
            this.label15.TabIndex = 59;
            this.label15.Text = "Lista de Marcas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Buscar marca";
            // 
            // btnSearchMarca
            // 
            this.btnSearchMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMarca.ForeColor = System.Drawing.Color.White;
            this.btnSearchMarca.Location = new System.Drawing.Point(196, 419);
            this.btnSearchMarca.Name = "btnSearchMarca";
            this.btnSearchMarca.Size = new System.Drawing.Size(75, 23);
            this.btnSearchMarca.TabIndex = 62;
            this.btnSearchMarca.Text = "Buscar";
            this.btnSearchMarca.UseVisualStyleBackColor = true;
            this.btnSearchMarca.Click += new System.EventHandler(this.btnSearchMarca_Click);
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.BackColor = System.Drawing.Color.Transparent;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.ForeColor = System.Drawing.Color.White;
            this.labelMarca.Location = new System.Drawing.Point(132, 73);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(52, 17);
            this.labelMarca.TabIndex = 68;
            this.labelMarca.Text = "Marca";
            // 
            // tablaMarcas
            // 
            this.tablaMarcas.AllowUserToAddRows = false;
            this.tablaMarcas.AllowUserToDeleteRows = false;
            this.tablaMarcas.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaMarcas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaMarcas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.Borrado});
            this.tablaMarcas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaMarcas.Location = new System.Drawing.Point(645, 41);
            this.tablaMarcas.Name = "tablaMarcas";
            this.tablaMarcas.ReadOnly = true;
            this.tablaMarcas.RowHeadersWidth = 20;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.tablaMarcas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaMarcas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaMarcas.Size = new System.Drawing.Size(91, 368);
            this.tablaMarcas.TabIndex = 73;
            this.tablaMarcas.TabStop = false;
            this.tablaMarcas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaMarcas_CellContentClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "Borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            this.Borrado.Visible = false;
            // 
            // textMarcaNew
            // 
            this.textMarcaNew.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textMarcaNew.ForeColor = System.Drawing.Color.White;
            this.textMarcaNew.Location = new System.Drawing.Point(105, 94);
            this.textMarcaNew.Name = "textMarcaNew";
            this.textMarcaNew.Size = new System.Drawing.Size(119, 20);
            this.textMarcaNew.TabIndex = 74;
            // 
            // textMarcaOld
            // 
            this.textMarcaOld.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textMarcaOld.ForeColor = System.Drawing.Color.White;
            this.textMarcaOld.Location = new System.Drawing.Point(105, 94);
            this.textMarcaOld.Name = "textMarcaOld";
            this.textMarcaOld.Size = new System.Drawing.Size(119, 20);
            this.textMarcaOld.TabIndex = 75;
            // 
            // MarcaVeh_Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 449);
            this.Controls.Add(this.textMarcaOld);
            this.Controls.Add(this.tablaMarcas);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.btnSearchMarca);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMarcaLoad);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textMarcaNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1043, 488);
            this.MinimumSize = new System.Drawing.Size(1043, 488);
            this.Name = "MarcaVeh_Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Marca";
            ((System.ComponentModel.ISupportInitialize)(this.tablaMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMarcaLoad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchMarca;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.DataGridView tablaMarcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
        private System.Windows.Forms.TextBox textMarcaNew;
        private System.Windows.Forms.TextBox textMarcaOld;
    }
}