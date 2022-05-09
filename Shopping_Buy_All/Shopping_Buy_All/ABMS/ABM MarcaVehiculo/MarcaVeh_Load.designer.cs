namespace Shopping_Buy_All
{
    partial class MarcaVeh_Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarcaVeh_Load));
            this.tablaMarcas = new System.Windows.Forms.DataGridView();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.label15 = new System.Windows.Forms.Label();
            this.btnTarjetaLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMarcas)).BeginInit();
            this.SuspendLayout();
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
            this.Marca,
            this.Borrado});
            this.tablaMarcas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaMarcas.Location = new System.Drawing.Point(638, 40);
            this.tablaMarcas.Name = "tablaMarcas";
            this.tablaMarcas.ReadOnly = true;
            this.tablaMarcas.RowHeadersWidth = 20;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.tablaMarcas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaMarcas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaMarcas.Size = new System.Drawing.Size(93, 397);
            this.tablaMarcas.TabIndex = 0;
            this.tablaMarcas.TabStop = false;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Descripcion";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 70;
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "Borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            this.Borrado.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cargar Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(130, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Marca";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(590, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(208, 29);
            this.label15.TabIndex = 28;
            this.label15.Text = "Lista de Tarjetas";
            // 
            // btnTarjetaLoad
            // 
            this.btnTarjetaLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTarjetaLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarjetaLoad.ForeColor = System.Drawing.Color.White;
            this.btnTarjetaLoad.Location = new System.Drawing.Point(73, 422);
            this.btnTarjetaLoad.Name = "btnTarjetaLoad";
            this.btnTarjetaLoad.Size = new System.Drawing.Size(75, 23);
            this.btnTarjetaLoad.TabIndex = 13;
            this.btnTarjetaLoad.Text = "Cargar";
            this.btnTarjetaLoad.UseVisualStyleBackColor = true;
            this.btnTarjetaLoad.Click += new System.EventHandler(this.btnMarcaLoad_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(169, 422);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbMarca
            // 
            this.cmbMarca.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmbMarca.ForeColor = System.Drawing.Color.White;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(94, 74);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(119, 21);
            this.cmbMarca.TabIndex = 1;
            // 
            // MarcaVeh_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 449);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTarjetaLoad);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaMarcas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1043, 488);
            this.MinimumSize = new System.Drawing.Size(1043, 488);
            this.Name = "MarcaVeh_Load";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Marca";
            ((System.ComponentModel.ISupportInitialize)(this.tablaMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaMarcas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnTarjetaLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
    }
}