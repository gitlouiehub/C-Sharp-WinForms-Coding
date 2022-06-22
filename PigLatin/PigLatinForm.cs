using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatin
{
    /*
     * allows the user to enter a word and displays the pig Latin version
     * To create a word in pig Latin, you remove the first letter and then add the first letter and ay at the end of the word. For example, dog becomes ogday, and cat becomes atcay
     * */
    public partial class PigLatinForm : Form
    {
        public PigLatinForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;

            pigLatinLabel.Text = input.Substring(1, input.Length-1) +
                                input.Substring(0, 1) + "ay";
            pigLatinLabel.Visible = true;

            inputTextBox.SelectAll();
            inputTextBox.Focus();
        }
    }
}
