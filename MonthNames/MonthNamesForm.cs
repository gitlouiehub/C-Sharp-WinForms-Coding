using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthNames
{
    /*
     * prompts the user for a month integer. Convert the user’s entry to a Month value, and display it.
     * */
    public partial class MonthNamesForm : Form
    {
        public enum Month
        {
            January = 1, Feburary, March, April, May, June, July, August, September, October, November, December
        }
        public MonthNamesForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            byte value = Convert.ToByte(monthIntegerTextBox.Text);

            monthLabel.Visible = true;
            monthLabel.Text = $"{(Month)value}";

            monthIntegerTextBox.Focus();
            monthIntegerTextBox.SelectAll();
        }
    }
}
