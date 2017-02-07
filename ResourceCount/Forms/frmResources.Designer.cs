namespace Project2Resurses
{
    partial class frmResources
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
            this.dgvResources = new System.Windows.Forms.DataGridView();
            this.btnAddNewRes = new System.Windows.Forms.Button();
            this.btnChangeRes = new System.Windows.Forms.Button();
            this.btnDelRes = new System.Windows.Forms.Button();
            this.tbResCost = new System.Windows.Forms.TextBox();
            this.tbResName = new System.Windows.Forms.TextBox();
            this.lbResCost = new System.Windows.Forms.Label();
            this.lbResName = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbNowName = new System.Windows.Forms.Label();
            this.lbNewResCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResources)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResources
            // 
            this.dgvResources.AllowUserToAddRows = false;
            this.dgvResources.AllowUserToDeleteRows = false;
            this.dgvResources.AllowUserToResizeColumns = false;
            this.dgvResources.AllowUserToResizeRows = false;
            this.dgvResources.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResources.Location = new System.Drawing.Point(12, 12);
            this.dgvResources.Name = "dgvResources";
            this.dgvResources.ReadOnly = true;
            this.dgvResources.RowHeadersWidth = 25;
            this.dgvResources.Size = new System.Drawing.Size(305, 245);
            this.dgvResources.TabIndex = 0;
            // 
            // btnAddNewRes
            // 
            this.btnAddNewRes.Location = new System.Drawing.Point(323, 176);
            this.btnAddNewRes.Name = "btnAddNewRes";
            this.btnAddNewRes.Size = new System.Drawing.Size(115, 23);
            this.btnAddNewRes.TabIndex = 1;
            this.btnAddNewRes.Text = "Add new resource";
            this.btnAddNewRes.UseVisualStyleBackColor = true;
            this.btnAddNewRes.Click += new System.EventHandler(this.btnAddNewRes_Click);
            // 
            // btnChangeRes
            // 
            this.btnChangeRes.Location = new System.Drawing.Point(323, 205);
            this.btnChangeRes.Name = "btnChangeRes";
            this.btnChangeRes.Size = new System.Drawing.Size(115, 23);
            this.btnChangeRes.TabIndex = 2;
            this.btnChangeRes.Text = "Change rate";
            this.btnChangeRes.UseVisualStyleBackColor = true;
            this.btnChangeRes.Click += new System.EventHandler(this.btnChangeRes_Click);
            // 
            // btnDelRes
            // 
            this.btnDelRes.Location = new System.Drawing.Point(323, 234);
            this.btnDelRes.Name = "btnDelRes";
            this.btnDelRes.Size = new System.Drawing.Size(115, 23);
            this.btnDelRes.TabIndex = 3;
            this.btnDelRes.Text = "Delete resource";
            this.btnDelRes.UseVisualStyleBackColor = true;
            this.btnDelRes.Click += new System.EventHandler(this.btnDelRes_Click);
            // 
            // tbResCost
            // 
            this.tbResCost.Location = new System.Drawing.Point(323, 67);
            this.tbResCost.Name = "tbResCost";
            this.tbResCost.Size = new System.Drawing.Size(115, 20);
            this.tbResCost.TabIndex = 5;
            this.tbResCost.Visible = false;
            // 
            // tbResName
            // 
            this.tbResName.Location = new System.Drawing.Point(323, 28);
            this.tbResName.Name = "tbResName";
            this.tbResName.Size = new System.Drawing.Size(115, 20);
            this.tbResName.TabIndex = 4;
            this.tbResName.Visible = false;
            // 
            // lbResCost
            // 
            this.lbResCost.AutoSize = true;
            this.lbResCost.Location = new System.Drawing.Point(323, 51);
            this.lbResCost.Name = "lbResCost";
            this.lbResCost.Size = new System.Drawing.Size(28, 13);
            this.lbResCost.TabIndex = 6;
            this.lbResCost.Text = "Cost";
            this.lbResCost.Visible = false;
            // 
            // lbResName
            // 
            this.lbResName.AutoSize = true;
            this.lbResName.Location = new System.Drawing.Point(323, 12);
            this.lbResName.Name = "lbResName";
            this.lbResName.Size = new System.Drawing.Size(35, 13);
            this.lbResName.TabIndex = 7;
            this.lbResName.Text = "Name";
            this.lbResName.Visible = false;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(394, 93);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(44, 23);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Visible = false;
            this.btnApply.Click += new System.EventHandler(this.btnAddRes_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(323, 93);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(51, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // lbNowName
            // 
            this.lbNowName.AutoSize = true;
            this.lbNowName.Location = new System.Drawing.Point(403, 12);
            this.lbNowName.Name = "lbNowName";
            this.lbNowName.Size = new System.Drawing.Size(0, 13);
            this.lbNowName.TabIndex = 11;
            this.lbNowName.Visible = false;
            // 
            // lbNewResCost
            // 
            this.lbNewResCost.AutoSize = true;
            this.lbNewResCost.Location = new System.Drawing.Point(323, 51);
            this.lbNewResCost.Name = "lbNewResCost";
            this.lbNewResCost.Size = new System.Drawing.Size(53, 13);
            this.lbNewResCost.TabIndex = 13;
            this.lbNewResCost.Text = "New Cost";
            this.lbNewResCost.Visible = false;
            // 
            // frmResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 269);
            this.Controls.Add(this.lbNewResCost);
            this.Controls.Add(this.lbNowName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lbResName);
            this.Controls.Add(this.lbResCost);
            this.Controls.Add(this.tbResName);
            this.Controls.Add(this.tbResCost);
            this.Controls.Add(this.btnDelRes);
            this.Controls.Add(this.btnChangeRes);
            this.Controls.Add(this.btnAddNewRes);
            this.Controls.Add(this.dgvResources);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmResources";
            this.Text = "frmResources";
            this.Load += new System.EventHandler(this.frmResources_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResources)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResources;
        private System.Windows.Forms.Button btnAddNewRes;
        private System.Windows.Forms.Button btnChangeRes;
        private System.Windows.Forms.Button btnDelRes;
        private System.Windows.Forms.TextBox tbResCost;
        private System.Windows.Forms.TextBox tbResName;
        private System.Windows.Forms.Label lbResCost;
        private System.Windows.Forms.Label lbResName;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbNowName;
        private System.Windows.Forms.Label lbNewResCost;
    }
}