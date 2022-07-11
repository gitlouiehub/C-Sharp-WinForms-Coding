using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeSales
{
    /*
     * Author: Luis Munoz
     *Danielle, Edward, and Francis are three salespeople at Holiday Homes. Write an application named HomeSales that prompts the user for a salesperson initial (D, E, or F). Either uppercase or lowercase initials are valid. While the user does not type Z, continue by prompting for the amount of a sale. Issue an error message for any invalid initials entered. Keep a running total of the amounts sold by each salesperson. After the user types Z or z for an initial, display each salesperson’s total, a grand total for all sales, and the name of the salesperson with the highest total
     * */
    public partial class HomeSalesForm : Form
    {
        //Declare and initialize variables
        double danielleSales = 0, edwardSales = 0, francisSales = 0, grandTotal = 0, inputSales;
        char initial;

        //Create each salesperson initial 
        enum SalesPersonInitial
        {
            D = 'D', d = 'd', E = 'E', e = 'e', F = 'F', f = 'f', Z = 'Z', z = 'z'
        }

        public HomeSalesForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            initial = Convert.ToChar(initialTextBox.Text);
            errorLabel.Visible = false;

            //LOGIC
            switch (initial)
            {
                case (char)SalesPersonInitial.D:
                case (char)SalesPersonInitial.d:
                    inputSales = Convert.ToDouble(salesTextBox.Text);
                    danielleSales += inputSales;
                    break;
                case (char)SalesPersonInitial.E:
                case (char)SalesPersonInitial.e:
                    inputSales = Convert.ToDouble(salesTextBox.Text);
                    edwardSales += inputSales;
                    break;
                case (char)SalesPersonInitial.F:
                case (char)SalesPersonInitial.f:
                    inputSales = Convert.ToDouble(salesTextBox.Text);
                    francisSales += inputSales;
                    break;
                case (char)SalesPersonInitial.Z:
                case (char)SalesPersonInitial.z:
                    grandTotal = danielleSales + edwardSales + francisSales;
                    grandTotalLabel.Text = grandTotal.ToString("C");
                    danielleLabel.Text = danielleSales.ToString("C");
                    edwardLabel.Text = edwardSales.ToString("C");
                    francisLabel.Text = francisSales.ToString("C");
                    grandTotalLabel.Text = grandTotal.ToString("C");
                    outputTableLayoutPanel.Visible = true;

                    //Determine highest salesperson
                    if (danielleSales > edwardSales && danielleSales > francisSales)
                    {
                        highestTotalLabel.Text = danielleSales.ToString("C");
                        salesPersonWHighestTotalLabel.Text += " (Danielle)";
                    }
                    else if (edwardSales > danielleSales && edwardSales > francisSales)
                    {
                        highestTotalLabel.Text = edwardSales.ToString("C");
                        salesPersonWHighestTotalLabel.Text += " (Edward)";
                    }
                    else 
                    {
                        highestTotalLabel.Text = francisSales.ToString("C");
                        salesPersonWHighestTotalLabel.Text += " (Francis)";
                    }
                    //Disable textboxes and button for no further input
                    initialTextBox.Enabled = false;
                    salesTextBox.Enabled = false;
                    submitButton.Enabled = false;
                    break;
                default: errorLabel.Visible = true;
                    break;
            }
            //RESET
            initialTextBox.SelectAll();
            initialTextBox.Focus();
            salesTextBox.Clear();
        }
    }
}
