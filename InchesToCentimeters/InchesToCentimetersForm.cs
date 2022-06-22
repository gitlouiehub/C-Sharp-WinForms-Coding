using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InchesToCentimeters
{
    /*
     * allows the user to input a measurement in inches, click a Button, and output the value in centimeters. There are 2.54 centimeters in an inch.
     * 
     * */
    public partial class InchesToCentimeters : Form
    {
        public InchesToCentimeters()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            const double CENTIMETERS_IN_INCH = 2.54;
            double input = Convert.ToDouble(inputTextBox.Text);

            double result = CENTIMETERS_IN_INCH * input;

            label1.Visible = true;
            label1.Text = result.ToString();
        }
    }
}
