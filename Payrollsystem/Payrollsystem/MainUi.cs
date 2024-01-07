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
    public partial class MainUi : Form
    {
        public MainUi()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee form2 = new Employee();

            // Show Form2
            form2.Show();

            // If you want to hide Form1 when opening Form2
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Salary form3 = new Salary();

            // Show Form2
            form3.Show();

            // If you want to hide Form1 when opening Form2
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Settings form4 = new Settings();

            // Show Form2
            form4.Show();

            // If you want to hide Form1 when opening Form2
            this.Hide();

        }
    }
}
