using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payrollsystem
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void datarange_TextChanged(object sender, EventArgs e)
        {

        }
        public static class AppSettings
        {
            public static int DateRange { get; set; }
            public static DateTime SalaryCycleBeginDate { get; set; }
            public static DateTime SalaryCycleEndDate { get; set; }
            public static int LeavesPerYear { get; set; }

            public static int GetLeavesPerYear()
            {
                return LeavesPerYear;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                // Update the settings
                AppSettings.DateRange = Convert.ToInt32(datarange.Text);
                AppSettings.SalaryCycleBeginDate = start.Value;
                AppSettings.SalaryCycleEndDate = end.Value;
                AppSettings.LeavesPerYear = Convert.ToInt32(leavedate.Text);

                MessageBox.Show("Settings updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating settings: " + ex.Message);
            }
        }
    }
}
