using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedditSearch
{
    public partial class SearchResults : Form
    {
        public SearchResults()
        {
            InitializeComponent();
        }

        private void SearchResults_Load(object sender, EventArgs e)
        {
            //will add the connection to the database here 
            //as well as the information from the search to make the results display
        }

        private void buttonReturnToSearch_Click(object sender, EventArgs e)
        {
            //RedditSearchForm firstForm = new RedditSearchForm();
            //firstForm.Show();
            this.Close();
        }

        private void buttonToFinal_Click(object sender, EventArgs e)
        {
            // we will just use this for now while we do not have the data 
            //that will be used to move to the next form.
            FinalDisplay fd = new FinalDisplay();
            fd.ShowDialog();
        }
    }
}
