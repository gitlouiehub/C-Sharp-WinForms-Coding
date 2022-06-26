using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckMonthAndDay
{
    /// <summary>
    /// prompts a user to enter a birth month and day. Display an error message if the month is invalid (not  1 through 12) or the day is invalid for the month (for example, not between 1 and 31 for January or   between 1 and 29 for February). If the month and day are valid, display them with a message
    /// </summary>
    public partial class CheckMonthAndDayForm : Form
    {

        public CheckMonthAndDayForm()
        {
            InitializeComponent();
        }
        
        enum Month
        {
            January = 1, Feburary, March, April, May, June, July, August, September, October, November, December
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int month = Convert.ToInt16(monthTextBox.Text);
            int day = Convert.ToInt16(dayTextBox.Text);
            string message = string.Empty;

            switch ((Month)month)
            {
                case Month.January:
                    message = day > 0 && day < 31 ? $"{Month.January} {day} is valid" : "INCORRECT DAY";
                    break;
                case Month.Feburary:
                    message = day > 0 && day < 29 ? $"{Month.Feburary} {day} is valid" : "INCORRECT DAY";
                    break;
                case Month.March:
                    message = day > 0 && day < 31 ? $"{Month.March} {day} is valid" : "INCORRECT DAY";
                    break;
                case Month.April:
                    message = day > 0 && day < 30 ? $"{Month.April} {day} is valid" : "INCORRECT DAY";
                    break;
                case Month.May:
                    message = day > 0 && day < 31 ? $"{Month.May} {day} is valid" : "INCORRECT DAY";
                    break;
                case Month.June:
                    message = day > 0 && day < 30 ? $"{Month.June} {day} is valid" : "INCORRECT DAY";
                    break;
                case Month.July:
                    message = day > 0 && day < 31 ? $"{Month.July} {day} is valid" : "INCORRECT DAY";
                    break;
                case Month.August:
                    message = day > 0 && day < 31 ? $"{Month.August} {day} is valid" : "INCORRECT DAY";
                    break;
                case Month.September:
                    message = day > 0 && day < 30 ? $"{Month.September} {day} is valid" : "INCORRECT DAY";
                    break;
                case Month.October:
                    message = day > 0 && day < 31 ? $"{Month.October} {day} is valid" : "INCORRECT DAY";
                    break;
                case Month.November:
                    message = day > 0 && day < 30 ? $"{Month.November} {day} is valid" : "INCORRECT DAY";
                    break;
                case Month.December:
                    message = day > 0 && day < 31 ? $"{Month.December} {day} is valid" : "INCORRECT DAY";
                    break;
                default:
                    message = "INCORRECT MONTH VALUE";
                    break;
            }

            messageLabel.Text = message;
            messageLabel.Visible = true;

            monthTextBox.SelectAll();
            monthTextBox.Focus();
            dayTextBox.Clear();
        }

    }
}
