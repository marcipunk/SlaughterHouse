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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dGPart = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btSart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGAnimals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
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
            this.dGAnimals.Location = new System.Drawing.Point(22, 114);
            this.dGAnimals.Name = "dGAnimals";
            this.dGAnimals.ReadOnly = true;
            this.dGAnimals.Size = new System.Drawing.Size(343, 360);
            this.dGAnimals.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn1.HeaderText = "Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Breed";
            this.dataGridViewTextBoxColumn2.HeaderText = "Breed";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Weight";
            this.dataGridViewTextBoxColumn3.HeaderText = "Weight";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // animalBindingSource1
            // 
            this.animalBindingSource1.DataSource = typeof(SlaughterHouse.Animal);
            // 
            // dGPart
            // 
            this.dGPart.AutoGenerateColumns = false;
            this.dGPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGPart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dGPart.DataSource = this.partBindingSource;
            this.dGPart.Location = new System.Drawing.Point(428, 114);
            this.dGPart.Name = "dGPart";
            this.dGPart.Size = new System.Drawing.Size(248, 360);
            this.dGPart.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PartName";
            this.dataGridViewTextBoxColumn4.HeaderText = "PartName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(SlaughterHouse.part);
            // 
            // btSart
            // 
            this.btSart.Location = new System.Drawing.Point(22, 29);
            this.btSart.Name = "btSart";
            this.btSart.Size = new System.Drawing.Size(75, 23);
            this.btSart.TabIndex = 2;
            this.btSart.Text = "START";
            this.btSart.UseVisualStyleBackColor = true;
            this.btSart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // SlaughterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 499);
            this.Controls.Add(this.btSart);
            this.Controls.Add(this.dGPart);
            this.Controls.Add(this.dGAnimals);
            this.Name = "SlaughterForm";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.SlaughterForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dGAnimals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.Button btSart;
    }
}

