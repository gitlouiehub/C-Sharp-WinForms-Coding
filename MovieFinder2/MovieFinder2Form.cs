using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieFinder2
{
    /*
     * Author: Luis Munoz
     * 
     **/
    public partial class MovieFinder2Form : Form
    {
        private int year; // year to search for
        public MovieFinder2Form()
        {
            InitializeComponent();
        }

        private void yearTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                splitListBox1.Items.Clear();
                splitListBox2.Items.Clear();
                if (yearTextBox.Text == string.Empty)
                {
                    // do nothing
                }
                else if (!int.TryParse(yearTextBox.Text, out year)) // in case user enter alphabetical letters
                {
                    splitListBox1.Items.Add("NO RESULTS");
                    splitListBox2.Items.Add("NO RESULTS");
                    splitYearLabel1.Visible = false;
                    splitYearLabel2.Visible = false;
                    yearTextBox.SelectAll();
                }
                else // go ahead and move forward
                {
                    year = int.Parse(yearTextBox.Text);
                    splitYearLabel1.Text = $"Movies released before {year}";
                    splitYearLabel2.Text = $"Movies released in {year} or after";
                    splitYearLabel1.Visible = true;
                    splitYearLabel2.Visible = true;

                    this.moviesTableAdapter.Fill(this.moviesDataSet.Movies);
                    // query movies before
                    var moviesBefore =
                        from movie in moviesDataSet.Movies
                        where movie.ReleaseYear <= year
                        orderby movie.ReleaseYear ascending
                        select movie;
                    // query movies after
                    var moviesAfter =
                        from movie in moviesDataSet.Movies
                        where movie.ReleaseYear >= year
                        orderby movie.ReleaseYear ascending
                        select movie;
                    // populate the movies in each listbox
                    foreach (var movie in moviesBefore)
                    {
                        splitListBox1.Items.Add(movie.ReleaseYear + " " + movie.Title);
                    }

                    foreach (var movie in moviesAfter)
                    {
                        splitListBox2.Items.Add(movie.ReleaseYear + " " + movie.Title);
                    }
                    yearTextBox.SelectAll();
                }
            }
            
        }

        private void MovieFinder2Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'moviesDataSet.Movies' table. You can move, or remove it, as needed.

        }
    }
}
