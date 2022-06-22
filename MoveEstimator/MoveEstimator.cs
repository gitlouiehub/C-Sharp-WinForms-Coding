using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveEstimator
{
    /**
     * allows a user to enter an employee’s salary. Then display, with explanatory text, next year’s salary, which reflects a 4 percent increase.
     * */
    public partial class MoveEstimatorForm : Form
    {
        public MoveEstimatorForm()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            totalLabel.Visible = true;
            const double BASE_RATE = 200;
            const double PER_HOUR_RATE = 150;
            const double PER_MILE_RATE = 2;

            double inputHours = Convert.ToDouble(hoursTextBox.Text);
            double inputMiles = Convert.ToDouble(milesTextBox.Text);

            double total = (inputHours * PER_HOUR_RATE) + (inputMiles * PER_MILE_RATE) + BASE_RATE;

            totalLabel.Text = $"The moving fee with a base rate of {BASE_RATE.ToString("C")} plus {PER_HOUR_RATE.ToString("C")} per hour and {PER_MILE_RATE.ToString("C")} per mile, which comes out to {total.ToString("C")}";
        }
    }
}
