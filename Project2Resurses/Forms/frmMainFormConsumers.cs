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
    
    public partial class frmMainFormConsumers : Form
    {       
        private List<IConsumer> consumers = new List<IConsumer>();

        private ResourceList rates = new ResourceList();
       
        ///////////////////////////////////////////////////////////////////////////////

        public frmMainFormConsumers()
        {
            InitializeComponent();

            rates.Add(new Resource("Electicity", 28));
            rates.Add(new Resource("Gas", 23));
            rates.Add(new Resource("Water", 18));

            consumers.Add(new ConsumerPerson("Vasya"));
            consumers.Add(new ConsumerPerson("Petya"));
            consumers.Add(new ConsumerCompany("Fodreyd"));

            consumers[0].AddNewController(rates.AvailableResources[0]);
            consumers[0].AddNewController(rates.AvailableResources[1]);
            consumers[0].AddNewController(rates.AvailableResources[2]);

            consumers[2].AddNewController(rates.AvailableResources[0]);
            consumers[2].AddNewController(rates.AvailableResources[2]);
            consumers[2].AddNewController(rates.AvailableResources[2]);
            consumers[2].AddNewController(rates.AvailableResources[2]);
        }

        private void DgvUpdate()
        {
            dgvConsumers.DataSource = null;
            dgvConsumers.DataSource = consumers;
            dgvConsumers.Columns[dgvConsumers.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvConsumers.Height = dgvConsumers.RowTemplate.Height * (dgvConsumers.RowCount + 1) + 1;
        }

        private void MainFormConsumers_Load(object sender, EventArgs e)
        {         
            //DataGridViewColumn column = new DataGridViewButtonColumn();
            //column.DataPropertyName = "colBtnInfo";
            //column.Name = "colBtnInfo";
            //column.HeaderText = "Info";
            //column.Width = 50;
            //dgvConsumers.Columns.Add(column);
            if(consumers.Count>0) DgvUpdate();
        }

        private void btnDelConsumer_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvConsumers.SelectedRows)
            {
                if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (!consumers.Remove(consumers[row.Index]))
                    {
                        MessageBox.Show("Resource not found");
                        return;
                    }
                }
                else return;
            }
            DgvUpdate();
        }

        private void btnAddConsumer_Click(object sender, EventArgs e)
        {
            Form addConsumer = new frmAddConsumer(consumers, rates);
            addConsumer.ShowDialog();
            DgvUpdate();
        }

        private void btnAddResource_Click(object sender, EventArgs e)
        {
            Form showResources = new frmResources(rates);
            showResources.ShowDialog();
        }

        private void dgvConsumers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                IConsumer consumer = consumers[index];
                Form consumerEdit = new frmConsumerEdit(consumer, rates);
                consumerEdit.ShowDialog();
            }
        }

        private void frmMainFormConsumers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                foreach (IConsumer consumer in consumers)
                {
                    foreach (Controller ctrl in consumer.Controllers)
                    {
                        if (ctrl.Enabled) ctrl.Off();
                    }
                }
            }
        }
    }
}
