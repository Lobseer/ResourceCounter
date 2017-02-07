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
    public partial class frmAddConsumer : Form
    {
        private ResourceList resources;
        private List<IConsumer> consumers;

        public frmAddConsumer(List<IConsumer> consumers, ResourceList rates)
        {
            InitializeComponent();
            this.resources = rates;
            this.consumers = consumers;
        }

        private void DgvResourcesSet()
        {
            DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
            column.DataPropertyName = "Resource";
            column.Name = "Resource";
            column.HeaderText = "Resource";
            column.DataSource = resources.AvailableResources;
            column.DisplayMember = "Name";
            dgvResourceTypes.Columns.Add(column);
        }

        private void frmAddConsumer_Load(object sender, EventArgs e)
        {
            DgvResourcesSet();
        }

        private void dgvResourceTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != dgvResourceTypes.RowCount - 1)
            {
                dgvResourceTypes.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnAddConsumer_Click(object sender, EventArgs e)
        {
            IConsumer consum;

            if(tbName.Text=="")
            {
                MessageBox.Show("The name field isn't filled");
                return;
            }

            if (chbIsCompany.Checked)
            {
                consum = new ConsumerCompany(tbName.Text);
            }
            else
            {
                consum = new ConsumerPerson(tbName.Text);
            }

            for (int i = 0; i < dgvResourceTypes.RowCount - 1; i++)
            {
                DataGridViewComboBoxCell cmCell = dgvResourceTypes.Rows[i].Cells[1] as DataGridViewComboBoxCell;
                Resource res = null;

                foreach (object ob in cmCell.Items)
                {
                    res = ob as Resource;
                    if (res.Name == (string)cmCell.Value) break;
                }

                if (chbIsCompany.Checked)
                {
                    consum.AddNewController(res);
                }
                else
                {
                    if (!consum.hasController(res.Name))
                    {
                        consum.AddNewController(res);
                    }
                    else
                    {
                        MessageBox.Show("The consumer isn't a company can have only one controller for each type of resource");
                        return;
                    }
                }
            }
            MessageBox.Show(consum.ToString());
            consumers.Add(consum);
            this.Close();
        }
    }
}
