using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaises
{
    public partial class ProjectedRaises : Form
    {
        public ProjectedRaises()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            double salary = Convert.ToDouble(inputTextBox.Text);

            double nextYearSalary = salary * .04 + salary;

            label1.Visible = true;
            label1.Text = String.Format("Current salary: {0}\n" +
                "Next year's salary with 4% increase: {1}", salary.ToString("C"), nextYearSalary.ToString("C"));
        }
    }
}
