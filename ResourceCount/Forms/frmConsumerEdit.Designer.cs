namespace Project2Resurses
{
    partial class frmConsumerEdit
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.dgvControllers = new System.Windows.Forms.DataGridView();
            this.tbName = new System.Windows.Forms.TextBox();
            this.chbIsCompany = new System.Windows.Forms.CheckBox();
            this.btnAddController = new System.Windows.Forms.Button();
            this.cbControllerType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelController = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControllers)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(38, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name:";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(12, 35);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(34, 13);
            this.lbType.TabIndex = 1;
            this.lbType.Text = "Type:";
            // 
            // dgvControllers
            // 
            this.dgvControllers.AllowUserToAddRows = false;
            this.dgvControllers.AllowUserToDeleteRows = false;
            this.dgvControllers.AllowUserToResizeColumns = false;
            this.dgvControllers.AllowUserToResizeRows = false;
            this.dgvControllers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControllers.Location = new System.Drawing.Point(12, 58);
            this.dgvControllers.Name = "dgvControllers";
            this.dgvControllers.ReadOnly = true;
            this.dgvControllers.RowHeadersWidth = 25;
            this.dgvControllers.Size = new System.Drawing.Size(381, 192);
            this.dgvControllers.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Location = new System.Drawing.Point(56, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(219, 20);
            this.tbName.TabIndex = 3;
            // 
            // chbIsCompany
            // 
            this.chbIsCompany.AutoSize = true;
            this.chbIsCompany.Enabled = false;
            this.chbIsCompany.Location = new System.Drawing.Point(56, 35);
            this.chbIsCompany.Name = "chbIsCompany";
            this.chbIsCompany.Size = new System.Drawing.Size(81, 17);
            this.chbIsCompany.TabIndex = 4;
            this.chbIsCompany.Text = "Is Company";
            this.chbIsCompany.UseVisualStyleBackColor = true;
            // 
            // btnAddController
            // 
            this.btnAddController.Location = new System.Drawing.Point(12, 256);
            this.btnAddController.Name = "btnAddController";
            this.btnAddController.Size = new System.Drawing.Size(103, 23);
            this.btnAddController.TabIndex = 5;
            this.btnAddController.Text = "Add new controller";
            this.btnAddController.UseVisualStyleBackColor = true;
            this.btnAddController.Click += new System.EventHandler(this.btnAddController_Click);
            // 
            // cbControllerType
            // 
            this.cbControllerType.FormattingEnabled = true;
            this.cbControllerType.Location = new System.Drawing.Point(12, 285);
            this.cbControllerType.Name = "cbControllerType";
            this.cbControllerType.Size = new System.Drawing.Size(271, 21);
            this.cbControllerType.TabIndex = 6;
            this.cbControllerType.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(289, 283);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(349, 29);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(44, 23);
            this.btnOff.TabIndex = 8;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(349, 4);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(44, 23);
            this.btnOn.TabIndex = 9;
            this.btnOn.Text = "On";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(339, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(54, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelController
            // 
            this.btnDelController.Location = new System.Drawing.Point(121, 256);
            this.btnDelController.Name = "btnDelController";
            this.btnDelController.Size = new System.Drawing.Size(97, 23);
            this.btnDelController.TabIndex = 11;
            this.btnDelController.Text = "Delete controller";
            this.btnDelController.UseVisualStyleBackColor = true;
            this.btnDelController.Click += new System.EventHandler(this.btnDelController_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(281, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(62, 42);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmConsumerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 310);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelController);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbControllerType);
            this.Controls.Add(this.btnAddController);
            this.Controls.Add(this.chbIsCompany);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.dgvControllers);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmConsumerEdit";
            this.Text = "frmConsumerEdit";
            this.Load += new System.EventHandler(this.frmConsumerEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvControllers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.DataGridView dgvControllers;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.CheckBox chbIsCompany;
        private System.Windows.Forms.Button btnAddController;
        private System.Windows.Forms.ComboBox cbControllerType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelController;
        private System.Windows.Forms.Button btnUpdate;
    }
}