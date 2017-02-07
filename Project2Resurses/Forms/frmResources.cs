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
    public partial class frmResources : Form
    {
        private ResourceList rates;

        public frmResources(ResourceList rates)
        {
            InitializeComponent();
            this.rates = rates;
            DgvUpdate();
        }

        private void DgvUpdate()
        {
            dgvResources.DataSource = null;
            dgvResources.DataSource = rates.AvailableResources;
            dgvResources.Columns[dgvResources.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void HideAdding()
        {
            lbResName.Visible = false;
            lbResCost.Visible = false;
            tbResName.Visible = false;
            tbResCost.Visible = false;
            btnApply.Visible = false;
            btnCancel.Visible = false;
        }

        private void ShowAdding()
        {
            lbResName.Visible = true;
            lbResCost.Visible = true;
            tbResName.Visible = true;
            tbResCost.Visible = true;
            btnApply.Visible = true;
            btnCancel.Visible = true;
        }

        private void ShowChanged()
        {
            lbResName.Visible = true;
            lbNewResCost.Visible = true;
            lbNowName.Visible = true;
            tbResCost.Visible = true;
            btnApply.Visible = true;
            btnCancel.Visible = true;
        }

        private void HideChanged()
        {
            lbResName.Visible = false;
            lbNewResCost.Visible = false;
            lbNowName.Visible = false;
            tbResCost.Visible = false;
            btnApply.Visible = false;
            btnCancel.Visible = false;
        }

        private void TbClear()
        {
            tbResCost.Text = "";
            tbResName.Text = "";
        }

        private void ButtonsEnable()
        {
            btnAddNewRes.Enabled = true;
            btnDelRes.Enabled = true;
            btnChangeRes.Enabled = true;
        }

        private void ButtonsDisable()
        {
            btnAddNewRes.Enabled = false;
            btnDelRes.Enabled = false;
            btnChangeRes.Enabled = false;
        }

        private void frmResources_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewRes_Click(object sender, EventArgs e)
        {
            ShowAdding();
            ButtonsDisable();
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            TbClear();
            HideAdding();
            HideChanged();
            ButtonsEnable();
        }

        private void btnAddRes_Click(object sender, EventArgs e)
        {
            if (lbNowName.Visible)
            {
                rates.GetResource(lbNowName.Text).Cost = double.Parse(tbResCost.Text);
            }
            else
            {
                Resource res = new Resource(tbResName.Text, double.Parse(tbResCost.Text));
                if (!rates.Add(res))
                {
                    MessageBox.Show("Resource not found");
                }
            }

            TbClear();
            HideAdding();
            HideChanged();
            DgvUpdate();
            ButtonsEnable();
        }

        private void btnChangeRes_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvResources.SelectedRows)
            {
                lbNowName.Text = row.Cells[0].Value as string;
                ShowChanged();
                ButtonsDisable();
            }

        }

        private void btnDelRes_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvResources.SelectedRows)
            {
                if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (!rates.Remove(row.Cells[0].Value as string))
                    {
                        MessageBox.Show("Resource not found");
                        return;
                    }
                }
                else return;
            }
            DgvUpdate();
        }
    }
}
