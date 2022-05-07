namespace Shopping_Buy_All.ABMS.ABM_TipoVehiculo
{
    partial class VehicleType_Modify
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textCodeType = new System.Windows.Forms.TextBox();
            this.tablaTipoVehiculo = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchType = new System.Windows.Forms.Button();
            this.btnCleanType = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNameTypeVehicle = new System.Windows.Forms.TextBox();
            this.btnTypeLoad = new System.Windows.Forms.Button();
            this.btnSearchType2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 32);
            this.label1.TabIndex = 61;
            this.label1.Text = "Modificar tipo vehiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(140, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Codigo";
            // 
            // textCodeType
            // 
            this.textCodeType.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textCodeType.ForeColor = System.Drawing.Color.White;
            this.textCodeType.Location = new System.Drawing.Point(144, 156);
            this.textCodeType.Margin = new System.Windows.Forms.Padding(4);
            this.textCodeType.Name = "textCodeType";
            this.textCodeType.Size = new System.Drawing.Size(60, 22);
            this.textCodeType.TabIndex = 1;
            // 
            // tablaTipoVehiculo
            // 
            this.tablaTipoVehiculo.AllowUserToAddRows = false;
            this.tablaTipoVehiculo.AllowUserToDeleteRows = false;
            this.tablaTipoVehiculo.AllowUserToOrderColumns = true;
            this.tablaTipoVehiculo.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaTipoVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaTipoVehiculo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tablaTipoVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTipoVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaTipoVehiculo.DefaultCellStyle = dataGridViewCellStyle8;
            this.tablaTipoVehiculo.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaTipoVehiculo.Location = new System.Drawing.Point(360, 41);
            this.tablaTipoVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.tablaTipoVehiculo.Name = "tablaTipoVehiculo";
            this.tablaTipoVehiculo.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaTipoVehiculo.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.tablaTipoVehiculo.RowHeadersWidth = 51;
            this.tablaTipoVehiculo.RowTemplate.Height = 24;
            this.tablaTipoVehiculo.Size = new System.Drawing.Size(421, 382);
            this.tablaTipoVehiculo.TabIndex = 86;
            this.tablaTipoVehiculo.TabStop = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "cod_tipo";
            this.codigo.HeaderText = "codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // btnSearchType
            // 
            this.btnSearchType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchType.ForeColor = System.Drawing.Color.White;
            this.btnSearchType.Location = new System.Drawing.Point(144, 311);
            this.btnSearchType.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchType.Name = "btnSearchType";
            this.btnSearchType.Size = new System.Drawing.Size(100, 28);
            this.btnSearchType.TabIndex = 2;
            this.btnSearchType.Text = "Buscar";
            this.btnSearchType.UseVisualStyleBackColor = true;
            // 
            // btnCleanType
            // 
            this.btnCleanType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCleanType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanType.ForeColor = System.Drawing.Color.White;
            this.btnCleanType.Location = new System.Drawing.Point(252, 311);
            this.btnCleanType.Margin = new System.Windows.Forms.Padding(4);
            this.btnCleanType.Name = "btnCleanType";
            this.btnCleanType.Size = new System.Drawing.Size(100, 28);
            this.btnCleanType.TabIndex = 3;
            this.btnCleanType.Text = "Limpiar";
            this.btnCleanType.UseVisualStyleBackColor = true;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.Transparent;
            this.searchPanel.Location = new System.Drawing.Point(52, 74);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(301, 299);
            this.searchPanel.TabIndex = 87;
            this.searchPanel.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(140, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Nombre";
            // 
            // textNameTypeVehicle
            // 
            this.textNameTypeVehicle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textNameTypeVehicle.ForeColor = System.Drawing.Color.White;
            this.textNameTypeVehicle.Location = new System.Drawing.Point(97, 225);
            this.textNameTypeVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.textNameTypeVehicle.Name = "textNameTypeVehicle";
            this.textNameTypeVehicle.Size = new System.Drawing.Size(159, 22);
            this.textNameTypeVehicle.TabIndex = 4;
            // 
            // btnTypeLoad
            // 
            this.btnTypeLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTypeLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeLoad.ForeColor = System.Drawing.Color.White;
            this.btnTypeLoad.Location = new System.Drawing.Point(30, 380);
            this.btnTypeLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnTypeLoad.Name = "btnTypeLoad";
            this.btnTypeLoad.Size = new System.Drawing.Size(100, 28);
            this.btnTypeLoad.TabIndex = 6;
            this.btnTypeLoad.Text = "Modificar";
            this.btnTypeLoad.UseVisualStyleBackColor = true;
            // 
            // btnSearchType2
            // 
            this.btnSearchType2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchType2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchType2.ForeColor = System.Drawing.Color.White;
            this.btnSearchType2.Location = new System.Drawing.Point(138, 380);
            this.btnSearchType2.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchType2.Name = "btnSearchType2";
            this.btnSearchType2.Size = new System.Drawing.Size(100, 28);
            this.btnSearchType2.TabIndex = 74;
            this.btnSearchType2.Text = "Buscar";
            this.btnSearchType2.UseVisualStyleBackColor = true;
            // 
            // VehicleType_Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Shopping_Buy_All.Properties.Resources.montanas_minimalista_arte_low_poly_2560x1440_xtrafondos_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(787, 421);
            this.Controls.Add(this.btnSearchType2);
            this.Controls.Add(this.btnTypeLoad);
            this.Controls.Add(this.textNameTypeVehicle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCleanType);
            this.Controls.Add(this.btnSearchType);
            this.Controls.Add(this.textCodeType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.tablaTipoVehiculo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(805, 468);
            this.MinimumSize = new System.Drawing.Size(805, 468);
            this.Name = "VehicleType_Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar tipo vehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCodeType;
        private System.Windows.Forms.DataGridView tablaTipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.Button btnSearchType;
        private System.Windows.Forms.Button btnCleanType;
        private System.Windows.Forms.PictureBox searchPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNameTypeVehicle;
        private System.Windows.Forms.Button btnTypeLoad;
        private System.Windows.Forms.Button btnSearchType2;
    }
}