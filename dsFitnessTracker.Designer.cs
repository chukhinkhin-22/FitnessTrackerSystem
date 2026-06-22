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
    public partial class CustomerHomePage : Form
    {
        public CustomerHomePage()
        {
            InitializeComponent();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CustomerHomePage_Load(object sender, EventArgs e)
        {
            lblDisplay.Text = "Welcome to :" + UserLogin.FullName;
        }

        private void mnuSetGoals_Click(object sender, EventArgs e)
        {
            SetGoals sg = new SetGoals();
            sg.ShowDialog();
        }

        private void mnuApplyActivity_Click(object sender, EventArgs e)
        {
            ApplyActivity aa = new ApplyActivity();
            aa.ShowDialog();
        }

        private void mnuReportActivity_Click(object sender, EventArgs e)
        {
            CustomerProgressReport report = new CustomerProgressReport();
            report.ShowDialog();
        }
    }
}
