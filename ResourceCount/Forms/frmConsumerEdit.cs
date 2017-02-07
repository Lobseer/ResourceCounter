using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2Resurses
{
    public partial class frmConsumerEdit : Form
    {
        private IConsumer consumer;
        private ResourceList rates;

        public frmConsumerEdit(IConsumer consumer, ResourceList rates)
        {
            InitializeComponent();
            this.consumer = consumer;
            this.rates = rates;
        }

        private void DgvUpdate()
        {
            dgvControllers.DataSource = null;
            dgvControllers.DataSource = consumer.Controllers;
            dgvControllers.Columns[dgvControllers.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ShowAdding()
        {
            cbControllerType.Visible = true;
            btnAdd.Visible = true;
            btnCancel.Visible = true;
        }

        private void HideAdding()
        {
            cbControllerType.Visible = false;
            btnAdd.Visible = false;
            btnCancel.Visible = false;
        }

        private void ButtonsEnable()
        {
            btnAddController.Enabled = true;
            btnDelController.Enabled = true;
        }

        private void ButtonsDisable()
        {
            btnAddController.Enabled = false;
            btnDelController.Enabled = false;
        }

        private void frmConsumerEdit_Load(object sender, EventArgs e)
        {
            cbControllerType.DataSource = rates.AvailableResources;
            cbControllerType.DisplayMember = "Name";
            tbName.Text = consumer.Name;
            chbIsCompany.Checked = consumer.Type == "ConsumerCompany";
            DgvUpdate();
        }

        private void btnAddController_Click(object sender, EventArgs e)
        {
            ShowAdding();
            ButtonsDisable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Resource res = cbControllerType.SelectedItem as Resource;
            if (chbIsCompany.Checked)
            {
                consumer.AddNewController(res);
            }
            else
            {
                if (!consumer.hasController(res.Name))
                {
                    consumer.AddNewController(res);
                }
                else
                {
                    MessageBox.Show("The consumer isn't a company can have only one controller for each type of resource");
                    return;
                }
            }
            DgvUpdate();
            ButtonsEnable();
            HideAdding();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ButtonsEnable();
            HideAdding();
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvControllers.SelectedRows)
            {
                consumer.Controllers[row.Index].On();
            }
            DgvUpdate();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvControllers.SelectedRows)
            {
                consumer.Controllers[row.Index].Off();
            }
            DgvUpdate();
        }

        private void btnDelController_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvControllers.SelectedRows)
            {
                if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    consumer.Controllers.Remove(consumer.Controllers[row.Index]);
                }
                else return;
            }
            DgvUpdate();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DgvUpdate();
        }
    }
}
