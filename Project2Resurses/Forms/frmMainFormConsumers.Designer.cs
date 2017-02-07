namespace Project2Resurses
{
    partial class frmMainFormConsumers
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
            this.dgvConsumers = new System.Windows.Forms.DataGridView();
            this.btnAddConsumer = new System.Windows.Forms.Button();
            this.btnAddResource = new System.Windows.Forms.Button();
            this.btnDelConsumer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsumers
            // 
            this.dgvConsumers.AllowUserToAddRows = false;
            this.dgvConsumers.AllowUserToDeleteRows = false;
            this.dgvConsumers.AllowUserToResizeColumns = false;
            this.dgvConsumers.AllowUserToResizeRows = false;
            this.dgvConsumers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsumers.Location = new System.Drawing.Point(12, 12);
            this.dgvConsumers.Name = "dgvConsumers";
            this.dgvConsumers.RowHeadersWidth = 25;
            this.dgvConsumers.Size = new System.Drawing.Size(644, 326);
            this.dgvConsumers.TabIndex = 0;
            this.dgvConsumers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsumers_CellDoubleClick);
            // 
            // btnAddConsumer
            // 
            this.btnAddConsumer.Location = new System.Drawing.Point(12, 356);
            this.btnAddConsumer.Name = "btnAddConsumer";
            this.btnAddConsumer.Size = new System.Drawing.Size(90, 23);
            this.btnAddConsumer.TabIndex = 1;
            this.btnAddConsumer.Text = "Add Consumer";
            this.btnAddConsumer.UseVisualStyleBackColor = true;
            this.btnAddConsumer.Click += new System.EventHandler(this.btnAddConsumer_Click);
            // 
            // btnAddResource
            // 
            this.btnAddResource.Location = new System.Drawing.Point(573, 356);
            this.btnAddResource.Name = "btnAddResource";
            this.btnAddResource.Size = new System.Drawing.Size(83, 25);
            this.btnAddResource.TabIndex = 2;
            this.btnAddResource.Text = "Resources";
            this.btnAddResource.UseVisualStyleBackColor = true;
            this.btnAddResource.Click += new System.EventHandler(this.btnAddResource_Click);
            // 
            // btnDelConsumer
            // 
            this.btnDelConsumer.Location = new System.Drawing.Point(108, 356);
            this.btnDelConsumer.Name = "btnDelConsumer";
            this.btnDelConsumer.Size = new System.Drawing.Size(97, 23);
            this.btnDelConsumer.TabIndex = 3;
            this.btnDelConsumer.Text = "Delete consumer";
            this.btnDelConsumer.UseVisualStyleBackColor = true;
            this.btnDelConsumer.Click += new System.EventHandler(this.btnDelConsumer_Click);
            // 
            // frmMainFormConsumers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 386);
            this.Controls.Add(this.btnDelConsumer);
            this.Controls.Add(this.btnAddResource);
            this.Controls.Add(this.btnAddConsumer);
            this.Controls.Add(this.dgvConsumers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMainFormConsumers";
            this.Text = "Consumers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainFormConsumers_FormClosing);
            this.Load += new System.EventHandler(this.MainFormConsumers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsumers;
        private System.Windows.Forms.Button btnAddConsumer;
        private System.Windows.Forms.Button btnAddResource;
        private System.Windows.Forms.Button btnDelConsumer;
    }
}

