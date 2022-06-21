using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractive
{
    public partial class EggsInteractiveForm : Form
    {
        public EggsInteractiveForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            totalLabel.Visible = true;
            int chicken1 = Convert.ToInt16(chicken1TextBox.Text);
            int chicken2 = Convert.ToInt16(chicken2TextBox.Text);
            int chicken3 = Convert.ToInt16(chicken3TextBox.Text);
            int chicken4 = Convert.ToInt16(chicken4TextBox.Text);
            int chicken5 = Convert.ToInt16(chicken5TextBox.Text);

            const byte aDozen = 12;
            int totalEggs = (chicken1 + chicken2 + chicken3 + chicken4 + chicken5);
            int dozen = totalEggs / aDozen;
            int leftOverEggs = totalEggs % aDozen;

            totalLabel.Text = $"A total of {totalEggs} eggs is {dozen} dozen and {leftOverEggs} eggs.";
        }
    }
}
