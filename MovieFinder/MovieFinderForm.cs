using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieFinder
{
    /**
     * AUTHOR: LUIS MUNOZ
     * */
    public partial class MovieFinderForm : Form
    {
        private string value;
        public MovieFinderForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Focus();
            searchTextBox.SelectAll();
            searchListBox.Items.Clear();

            //CHECK FOR EMPTY INPUT
            if (searchTextBox.Text == "")
            {
                searchListBox.Items.Add($"No results");
            }
            //CHECK IF THE USER HAS NOT SELECTED ANY RADIO BUTTONS
            else if ((!directorRadioButton.Checked) && (!titleRadioButton.Checked))
            {
                searchListBox.Items.Add($"You must select \"{titleRadioButton.Text}\" or \"{directorRadioButton.Text}\"");
            }
            else if(directorRadioButton.Checked)
            {
                this.moviesTableAdapter.Fill(this.moviesDataSet.Movies);
                value = searchTextBox.Text.ToUpper().Trim();

                var movies =
                    from movie in moviesDataSet.Movies
                    where movie.Director.ToUpper().Contains(value) // CONVERT TO CAPITAL LETTERS FOR GOOD SEARCH RESULTS
                    select movie;

                searchListBox.Items.Add($"Director's name contains \"{value}\"\r\n");
                searchListBox.Items.Add("");

                //ITERATE THROUGH EACH MOVIE BY DIRECTOR
                foreach (var movie in movies)
                {
                    searchListBox.Items.Add($"  {movie.Title} directed by {movie.Director}");
                    searchListBox.Items.Add($"    Released in {movie.ReleaseYear}");
                    searchListBox.Items.Add("");
                }
            }
            else if (titleRadioButton.Checked)
            {
                this.moviesTableAdapter.Fill(this.moviesDataSet.Movies);
                value = searchTextBox.Text.ToUpper().Trim();

                var movies =
                    from movie in moviesDataSet.Movies
                    where movie.Title.ToUpper().Contains(value) // CONVERT TO CAPITAL LETTERS FOR GOOD SEARCH RESULTS
                    select movie;

                searchListBox.Items.Add($"Title's name contains \"{value}\"\r\n");
                searchListBox.Items.Add("");

                // ITERATE THROUGH EACH MOVIE BY TITLE
                foreach (var movie in movies)
                {
                    searchListBox.Items.Add($"  {movie.Title} directed by {movie.Director}");
                    searchListBox.Items.Add($"    Released in {movie.ReleaseYear}");
                    searchListBox.Items.Add("");
                }
            }

        }

        private void MovieFinderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'moviesDataSet.Movies' table. You can move, or remove it, as needed.
            searchTextBox.Focus();
        }
    }
}
