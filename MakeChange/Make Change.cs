using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeChange
{
    public partial class MakeChangeForm : Form
    {
        /**
         * calculates and displays the conversion of an entered number of dollars into currency denominations—twenties, tens, fives, and ones. For example, $113 is 5 twenties, 1 ten, 0 fives, and 3 ones
         * */
        public MakeChangeForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            int input = Convert.ToInt16(inputTextBox.Text);

            int twenties, ten, fives, ones;
            twenties = input / 20;
            int numerator = (input - (20 * twenties));
            ten =  numerator / 10;
            numerator = numerator - (10 * ten);
            fives = numerator / 5; 
            numerator = numerator - (5 * fives);
            ones = numerator / 1;

            label2.Text = $"{input.ToString("C0")} is {twenties} twenties, {ten} ten, {fives} fives, and {ones} ones.";
        }
    }
}
