namespace sportsclubmgmt
{
    partial class Form8
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.masterDataSet = new sportsclubmgmt.masterDataSet();
            this.viewallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewallTableAdapter = new sportsclubmgmt.masterDataSetTableAdapters.ViewallTableAdapter();
            this.playerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plfnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pllnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plsportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerIDhelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatperDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staminarateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bMIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerIDtrainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trfnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trlnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerIDkitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jerseysizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jerseynumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleatsizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewallBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerIDDataGridViewTextBoxColumn,
            this.plfnameDataGridViewTextBoxColumn,
            this.pllnameDataGridViewTextBoxColumn,
            this.plsportDataGridViewTextBoxColumn,
            this.playerIDhelDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.fatperDataGridViewTextBoxColumn,
            this.staminarateDataGridViewTextBoxColumn,
            this.bMIDataGridViewTextBoxColumn,
            this.playerIDtrainDataGridViewTextBoxColumn,
            this.trfnameDataGridViewTextBoxColumn,
            this.trlnameDataGridViewTextBoxColumn,
            this.trainerIDDataGridViewTextBoxColumn,
            this.trtypeDataGridViewTextBoxColumn,
            this.playerIDkitDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.jerseysizeDataGridViewTextBoxColumn,
            this.jerseynumDataGridViewTextBoxColumn,
            this.cleatsizeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewallBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "GENERATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(715, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Related Final Records :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "SPORTS CLUB MANAGEMENT SYSTEM";
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewallBindingSource
            // 
            this.viewallBindingSource.DataMember = "Viewall";
            this.viewallBindingSource.DataSource = this.masterDataSet;
            // 
            // viewallTableAdapter
            // 
            this.viewallTableAdapter.ClearBeforeFill = true;
            // 
            // playerIDDataGridViewTextBoxColumn
            // 
            this.playerIDDataGridViewTextBoxColumn.DataPropertyName = "player_ID";
            this.playerIDDataGridViewTextBoxColumn.HeaderText = "player_ID";
            this.playerIDDataGridViewTextBoxColumn.Name = "playerIDDataGridViewTextBoxColumn";
            // 
            // plfnameDataGridViewTextBoxColumn
            // 
            this.plfnameDataGridViewTextBoxColumn.DataPropertyName = "pl_fname";
            this.plfnameDataGridViewTextBoxColumn.HeaderText = "pl_fname";
            this.plfnameDataGridViewTextBoxColumn.Name = "plfnameDataGridViewTextBoxColumn";
            // 
            // pllnameDataGridViewTextBoxColumn
            // 
            this.pllnameDataGridViewTextBoxColumn.DataPropertyName = "pl_lname";
            this.pllnameDataGridViewTextBoxColumn.HeaderText = "pl_lname";
            this.pllnameDataGridViewTextBoxColumn.Name = "pllnameDataGridViewTextBoxColumn";
            // 
            // plsportDataGridViewTextBoxColumn
            // 
            this.plsportDataGridViewTextBoxColumn.DataPropertyName = "pl_sport";
            this.plsportDataGridViewTextBoxColumn.HeaderText = "pl_sport";
            this.plsportDataGridViewTextBoxColumn.Name = "plsportDataGridViewTextBoxColumn";
            // 
            // playerIDhelDataGridViewTextBoxColumn
            // 
            this.playerIDhelDataGridViewTextBoxColumn.DataPropertyName = "player_IDhel";
            this.playerIDhelDataGridViewTextBoxColumn.HeaderText = "player_IDhel";
            this.playerIDhelDataGridViewTextBoxColumn.Name = "playerIDhelDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // fatperDataGridViewTextBoxColumn
            // 
            this.fatperDataGridViewTextBoxColumn.DataPropertyName = "fat_per";
            this.fatperDataGridViewTextBoxColumn.HeaderText = "fat_per";
            this.fatperDataGridViewTextBoxColumn.Name = "fatperDataGridViewTextBoxColumn";
            // 
            // staminarateDataGridViewTextBoxColumn
            // 
            this.staminarateDataGridViewTextBoxColumn.DataPropertyName = "stamina_rate";
            this.staminarateDataGridViewTextBoxColumn.HeaderText = "stamina_rate";
            this.staminarateDataGridViewTextBoxColumn.Name = "staminarateDataGridViewTextBoxColumn";
            // 
            // bMIDataGridViewTextBoxColumn
            // 
            this.bMIDataGridViewTextBoxColumn.DataPropertyName = "BMI";
            this.bMIDataGridViewTextBoxColumn.HeaderText = "BMI";
            this.bMIDataGridViewTextBoxColumn.Name = "bMIDataGridViewTextBoxColumn";
            this.bMIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playerIDtrainDataGridViewTextBoxColumn
            // 
            this.playerIDtrainDataGridViewTextBoxColumn.DataPropertyName = "player_IDtrain";
            this.playerIDtrainDataGridViewTextBoxColumn.HeaderText = "player_IDtrain";
            this.playerIDtrainDataGridViewTextBoxColumn.Name = "playerIDtrainDataGridViewTextBoxColumn";
            // 
            // trfnameDataGridViewTextBoxColumn
            // 
            this.trfnameDataGridViewTextBoxColumn.DataPropertyName = "tr_fname";
            this.trfnameDataGridViewTextBoxColumn.HeaderText = "tr_fname";
            this.trfnameDataGridViewTextBoxColumn.Name = "trfnameDataGridViewTextBoxColumn";
            // 
            // trlnameDataGridViewTextBoxColumn
            // 
            this.trlnameDataGridViewTextBoxColumn.DataPropertyName = "tr_lname";
            this.trlnameDataGridViewTextBoxColumn.HeaderText = "tr_lname";
            this.trlnameDataGridViewTextBoxColumn.Name = "trlnameDataGridViewTextBoxColumn";
            // 
            // trainerIDDataGridViewTextBoxColumn
            // 
            this.trainerIDDataGridViewTextBoxColumn.DataPropertyName = "trainer_ID";
            this.trainerIDDataGridViewTextBoxColumn.HeaderText = "trainer_ID";
            this.trainerIDDataGridViewTextBoxColumn.Name = "trainerIDDataGridViewTextBoxColumn";
            // 
            // trtypeDataGridViewTextBoxColumn
            // 
            this.trtypeDataGridViewTextBoxColumn.DataPropertyName = "trtype";
            this.trtypeDataGridViewTextBoxColumn.HeaderText = "trtype";
            this.trtypeDataGridViewTextBoxColumn.Name = "trtypeDataGridViewTextBoxColumn";
            // 
            // playerIDkitDataGridViewTextBoxColumn
            // 
            this.playerIDkitDataGridViewTextBoxColumn.DataPropertyName = "player_IDkit";
            this.playerIDkitDataGridViewTextBoxColumn.HeaderText = "player_IDkit";
            this.playerIDkitDataGridViewTextBoxColumn.Name = "playerIDkitDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // jerseysizeDataGridViewTextBoxColumn
            // 
            this.jerseysizeDataGridViewTextBoxColumn.DataPropertyName = "jersey_size";
            this.jerseysizeDataGridViewTextBoxColumn.HeaderText = "jersey_size";
            this.jerseysizeDataGridViewTextBoxColumn.Name = "jerseysizeDataGridViewTextBoxColumn";
            // 
            // jerseynumDataGridViewTextBoxColumn
            // 
            this.jerseynumDataGridViewTextBoxColumn.DataPropertyName = "jersey_num";
            this.jerseynumDataGridViewTextBoxColumn.HeaderText = "jersey_num";
            this.jerseynumDataGridViewTextBoxColumn.Name = "jerseynumDataGridViewTextBoxColumn";
            // 
            // cleatsizeDataGridViewTextBoxColumn
            // 
            this.cleatsizeDataGridViewTextBoxColumn.DataPropertyName = "cleat_size";
            this.cleatsizeDataGridViewTextBoxColumn.HeaderText = "cleat_size";
            this.cleatsizeDataGridViewTextBoxColumn.Name = "cleatsizeDataGridViewTextBoxColumn";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(634, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "<<BACK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 372);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form8";
            this.Text = "SPORTS CLUB DBMS";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewallBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource viewallBindingSource;
        private masterDataSetTableAdapters.ViewallTableAdapter viewallTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plfnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pllnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plsportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIDhelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatperDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staminarateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIDtrainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trfnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trlnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIDkitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jerseysizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jerseynumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleatsizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}