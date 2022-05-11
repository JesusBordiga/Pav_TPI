namespace Shopping_Buy_All.ABMS.ABM_TipoVehiculo
{
    partial class VehicleType_Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleType_Delete));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textCodeType = new System.Windows.Forms.TextBox();
            this.btnSearchType = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textNameType = new System.Windows.Forms.TextBox();
            this.btnDeleteType = new System.Windows.Forms.Button();
            this.btnSerachType2 = new System.Windows.Forms.Button();
            this.tablaTipoVehiculo = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchPanel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 44);
            this.label1.TabIndex = 81;
            this.label1.Text = "    Eliminar \r\ntipo vehiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(107, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 87;
            this.label2.Text = "Codigo";
            // 
            // textCodeType
            // 
            this.textCodeType.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textCodeType.ForeColor = System.Drawing.Color.White;
            this.textCodeType.Location = new System.Drawing.Point(110, 140);
            this.textCodeType.Name = "textCodeType";
            this.textCodeType.Size = new System.Drawing.Size(46, 20);
            this.textCodeType.TabIndex = 75;
            // 
            // btnSearchType
            // 
            this.btnSearchType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchType.ForeColor = System.Drawing.Color.White;
            this.btnSearchType.Location = new System.Drawing.Point(102, 309);
            this.btnSearchType.Name = "btnSearchType";
            this.btnSearchType.Size = new System.Drawing.Size(75, 23);
            this.btnSearchType.TabIndex = 76;
            this.btnSearchType.Text = "Buscar";
            this.btnSearchType.UseVisualStyleBackColor = true;
            this.btnSearchType.Click += new System.EventHandler(this.btnSerachType2_Click);
            // 
            // btnClean
            // 
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(183, 309);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 77;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(107, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 88;
            this.label3.Text = "Nombre";
            // 
            // textNameType
            // 
            this.textNameType.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNameType.ForeColor = System.Drawing.Color.White;
            this.textNameType.Location = new System.Drawing.Point(77, 193);
            this.textNameType.Name = "textNameType";
            this.textNameType.Size = new System.Drawing.Size(120, 20);
            this.textNameType.TabIndex = 89;
            // 
            // btnDeleteType
            // 
            this.btnDeleteType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteType.ForeColor = System.Drawing.Color.White;
            this.btnDeleteType.Location = new System.Drawing.Point(21, 309);
            this.btnDeleteType.Name = "btnDeleteType";
            this.btnDeleteType.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteType.TabIndex = 90;
            this.btnDeleteType.Text = "Eliminar";
            this.btnDeleteType.UseVisualStyleBackColor = true;
            this.btnDeleteType.Click += new System.EventHandler(this.btnDeleteType_Click);
            // 
            // btnSerachType2
            // 
            this.btnSerachType2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSerachType2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerachType2.ForeColor = System.Drawing.Color.White;
            this.btnSerachType2.Location = new System.Drawing.Point(102, 268);
            this.btnSerachType2.Name = "btnSerachType2";
            this.btnSerachType2.Size = new System.Drawing.Size(75, 23);
            this.btnSerachType2.TabIndex = 1;
            this.btnSerachType2.Text = "Buscar";
            this.btnSerachType2.UseVisualStyleBackColor = true;
            this.btnSerachType2.Click += new System.EventHandler(this.btnSearchType_Click_1);
            // 
            // tablaTipoVehiculo
            // 
            this.tablaTipoVehiculo.AllowUserToAddRows = false;
            this.tablaTipoVehiculo.AllowUserToDeleteRows = false;
            this.tablaTipoVehiculo.AllowUserToOrderColumns = true;
            this.tablaTipoVehiculo.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaTipoVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablaTipoVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTipoVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Nombre,
            this.Borrado});
            this.tablaTipoVehiculo.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaTipoVehiculo.Location = new System.Drawing.Point(297, 29);
            this.tablaTipoVehiculo.Name = "tablaTipoVehiculo";
            this.tablaTipoVehiculo.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaTipoVehiculo.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaTipoVehiculo.RowHeadersWidth = 10;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.tablaTipoVehiculo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaTipoVehiculo.RowTemplate.Height = 24;
            this.tablaTipoVehiculo.Size = new System.Drawing.Size(201, 310);
            this.tablaTipoVehiculo.TabIndex = 93;
            this.tablaTipoVehiculo.TabStop = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "cod_tipo";
            this.codigo.HeaderText = "Codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "Borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.MinimumWidth = 6;
            this.Borrado.Name = "Borrado";
            this.Borrado.ReadOnly = true;
            this.Borrado.Visible = false;
            this.Borrado.Width = 125;
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.Transparent;
            this.SearchPanel.Location = new System.Drawing.Point(12, 88);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(250, 249);
            this.SearchPanel.TabIndex = 92;
            this.SearchPanel.TabStop = false;
            // 
            // VehicleType_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(507, 349);
            this.Controls.Add(this.tablaTipoVehiculo);
            this.Controls.Add(this.btnSerachType2);
            this.Controls.Add(this.textCodeType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.btnDeleteType);
            this.Controls.Add(this.textNameType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSearchType);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "VehicleType_Delete";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar tipo vehiculo";
            this.Load += new System.EventHandler(this.TypeDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCodeType;
        private System.Windows.Forms.Button btnSearchType;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNameType;
        private System.Windows.Forms.Button btnDeleteType;
        private System.Windows.Forms.Button btnSerachType2;
        private System.Windows.Forms.DataGridView tablaTipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
        private System.Windows.Forms.PictureBox SearchPanel;
    }
}