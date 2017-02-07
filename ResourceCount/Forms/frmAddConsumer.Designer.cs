namespace Project2Resurses
{
    partial class frmAddConsumer
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
            this.btnAddConsumer = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.chbIsCompany = new System.Windows.Forms.CheckBox();
            this.dgvResourceTypes = new System.Windows.Forms.DataGridView();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResourceTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddConsumer
            // 
            this.btnAddConsumer.Location = new System.Drawing.Point(268, 22);
            this.btnAddConsumer.Name = "btnAddConsumer";
            this.btnAddConsumer.Size = new System.Drawing.Size(60, 23);
            this.btnAddConsumer.TabIndex = 0;
            this.btnAddConsumer.Text = "Add";
            this.btnAddConsumer.UseVisualStyleBackColor = true;
            this.btnAddConsumer.Click += new System.EventHandler(this.btnAddConsumer_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 25);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(169, 20);
            this.tbName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(83, 13);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Consumer name";
            // 
            // chbIsCompany
            // 
            this.chbIsCompany.AutoSize = true;
            this.chbIsCompany.Location = new System.Drawing.Point(12, 51);
            this.chbIsCompany.Name = "chbIsCompany";
            this.chbIsCompany.Size = new System.Drawing.Size(80, 17);
            this.chbIsCompany.TabIndex = 4;
            this.chbIsCompany.Text = "is Company";
            this.chbIsCompany.UseVisualStyleBackColor = true;
            // 
            // dgvResourceTypes
            // 
            this.dgvResourceTypes.AllowUserToResizeColumns = false;
            this.dgvResourceTypes.AllowUserToResizeRows = false;
            this.dgvResourceTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResourceTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResourceTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDelete});
            this.dgvResourceTypes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvResourceTypes.Location = new System.Drawing.Point(12, 74);
            this.dgvResourceTypes.Name = "dgvResourceTypes";
            this.dgvResourceTypes.RowHeadersVisible = false;
            this.dgvResourceTypes.Size = new System.Drawing.Size(316, 86);
            this.dgvResourceTypes.TabIndex = 6;
            this.dgvResourceTypes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResourceTypes_CellContentClick);
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDelete.HeaderText = "";
            this.colDelete.MinimumWidth = 21;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDelete.Text = "del";
            this.colDelete.ToolTipText = "del";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 40;
            // 
            // frmAddConsumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 172);
            this.Controls.Add(this.dgvResourceTypes);
            this.Controls.Add(this.chbIsCompany);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnAddConsumer);
            this.Name = "frmAddConsumer";
            this.Text = "Add new consumer";
            this.Load += new System.EventHandler(this.frmAddConsumer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResourceTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddConsumer;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.CheckBox chbIsCompany;
        private System.Windows.Forms.DataGridView dgvResourceTypes;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}