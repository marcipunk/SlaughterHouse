namespace SlaughterHouse
{
    partial class SlaughterForm
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
            this.dGAnimals = new System.Windows.Forms.DataGridView();
            this.dGPart = new System.Windows.Forms.DataGridView();
            this.btSart = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGAnimals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dGAnimals
            // 
            this.dGAnimals.AllowUserToAddRows = false;
            this.dGAnimals.AllowUserToDeleteRows = false;
            this.dGAnimals.AutoGenerateColumns = false;
            this.dGAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGAnimals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dGAnimals.DataSource = this.animalBindingSource1;
            this.dGAnimals.Location = new System.Drawing.Point(17, 19);
            this.dGAnimals.Name = "dGAnimals";
            this.dGAnimals.ReadOnly = true;
            this.dGAnimals.Size = new System.Drawing.Size(325, 417);
            this.dGAnimals.TabIndex = 0;
            // 
            // dGPart
            // 
            this.dGPart.AllowUserToAddRows = false;
            this.dGPart.AllowUserToDeleteRows = false;
            this.dGPart.AutoGenerateColumns = false;
            this.dGPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGPart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dGPart.DataSource = this.partBindingSource;
            this.dGPart.Location = new System.Drawing.Point(38, 19);
            this.dGPart.Name = "dGPart";
            this.dGPart.ReadOnly = true;
            this.dGPart.Size = new System.Drawing.Size(279, 417);
            this.dGPart.TabIndex = 1;
            // 
            // btSart
            // 
            this.btSart.Location = new System.Drawing.Point(372, 19);
            this.btSart.Name = "btSart";
            this.btSart.Size = new System.Drawing.Size(102, 38);
            this.btSart.TabIndex = 2;
            this.btSart.Text = "START";
            this.btSart.UseVisualStyleBackColor = true;
            this.btSart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dGAnimals);
            this.splitContainer1.Panel1.Controls.Add(this.btSart);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dGPart);
            this.splitContainer1.Size = new System.Drawing.Size(826, 448);
            this.splitContainer1.SplitterDistance = 493;
            this.splitContainer1.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PartName";
            this.dataGridViewTextBoxColumn4.HeaderText = "PartName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(SlaughterHouse.part);
            // 
            // animalBindingSource1
            // 
            this.animalBindingSource1.DataSource = typeof(SlaughterHouse.Animal);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Weight";
            this.dataGridViewTextBoxColumn3.HeaderText = "Weight";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Breed";
            this.dataGridViewTextBoxColumn2.HeaderText = "Breed";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn1.HeaderText = "Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 57;
            // 
            // SlaughterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 448);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SlaughterForm";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.SlaughterForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dGAnimals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGPart)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dGAnimals;
        private System.Windows.Forms.DataGridView dGPart;
        //private System.Windows.Forms.DataGridViewTextBoxColumn partNameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn breedDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource animalBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.Button btSart;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

