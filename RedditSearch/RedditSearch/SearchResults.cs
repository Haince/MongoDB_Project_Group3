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
            Form firstForm = new Form();
            firstForm.Show();
            this.Close();
        }
    }
}
