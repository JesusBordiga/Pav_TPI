namespace Shopping_Buy_All
{
    partial class MarcaTarjeta_Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarcaTarjeta_Delete));
            this.label1 = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.tablaMarcas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Marca a eliminar";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.BackColor = System.Drawing.Color.Transparent;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.ForeColor = System.Drawing.Color.White;
            this.labelMarca.Location = new System.Drawing.Point(89, 126);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(64, 17);
            this.labelMarca.TabIndex = 44;
            this.labelMarca.Text = "Nombre";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(84, 200);
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
            this.btnClean.Location = new System.Drawing.Point(84, 257);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 4;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.Trash;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(83, 298);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 73);
            this.btnDelete.TabIndex = 67;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(240, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(196, 29);
            this.label15.TabIndex = 71;
            this.label15.Text = "Lista de Marcas";
            // 
            // textMarca
            // 
            this.textMarca.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textMarca.ForeColor = System.Drawing.Color.White;
            this.textMarca.Location = new System.Drawing.Point(65, 146);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(110, 20);
            this.textMarca.TabIndex = 74;
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
            this.Id,
            this.Nombre,
            this.Borrado});
            this.tablaMarcas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaMarcas.Location = new System.Drawing.Point(242, 56);
            this.tablaMarcas.Name = "tablaMarcas";
            this.tablaMarcas.ReadOnly = true;
            this.tablaMarcas.RowHeadersWidth = 20;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.tablaMarcas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaMarcas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaMarcas.Size = new System.Drawing.Size(205, 302);
            this.tablaMarcas.TabIndex = 97;
            this.tablaMarcas.TabStop = false;
            this.tablaMarcas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaMarcas_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "idMarca";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 35;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "Borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            this.Borrado.Visible = false;
            // 
            // MarcaTarjeta_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(459, 405);
            this.Controls.Add(this.tablaMarcas);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MarcaTarjeta_Delete";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminar Cliente";
            this.Load += new System.EventHandler(this.Marca_Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.DataGridView tablaMarcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
    }
}