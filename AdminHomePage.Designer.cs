using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTrackerProgram_L4DC193_
{
    
    public partial class Activitiy : Form
    {
        dsFitnessTrackerTableAdapters.ActivityTableAdapter ads = new dsFitnessTrackerTableAdapters.ActivityTableAdapter();
        public Activitiy()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtActivityName.Text=="")
            {
                MessageBox.Show("Enter Activity Name", "Activity Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtActivityName.Focus();
            }
           else if (txtMetric1.Text == "")
            {
                MessageBox.Show("Enter Metric1", "Activity Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMetric1.Focus();
            }
            else if (txtMetric2.Text == "")
            {
                MessageBox.Show("Enter Metric2", "Activity Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMetric2.Focus();
            }
            else if (txtMetric3.Text == "")
            {
                MessageBox.Show("Enter Metric3", "Activity Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMetric3.Focus();
            }
            else
            {
                clsActivity a = new clsActivity();
                a.ActivityName = txtActivityName.Text;
                a.Metric1 = txtMetric1.Text;
                a.Metric2 = txtMetric2.Text;
                a.Metric3 = txtMetric3.Text;
                int data=ads.Insert(a.ActivityName, a.Metric1, a.Metric2, a.Metric3);
                if(data>0)
                {
                    MessageBox.Show("Activity Save Success", "Activity Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtActivityName.Text = "";
                    txtMetric1.Text = "";
                    txtMetric2.Text = "";
                    txtMetric3.Text = "";
                    txtActivityName.Focus();
                }

            }
        }

    }
}
