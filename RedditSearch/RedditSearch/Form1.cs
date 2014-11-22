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
    public partial class RedditSearchForm : Form
    {
        public RedditSearchForm()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(textBoxAuthorSearch.Text=="")
            {
                MessageBox.Show("Search bar empty!!!");
                return;    
            }

            SearchResults formSR = new SearchResults(textBoxAuthorSearch.Text,true);
            formSR.ShowDialog();
            
        }

        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            textBoxAuthorSearch.Text = "";
        }

        private void buttonTitle_Click(object sender, EventArgs e)
        {
            if (textBoxAuthorSearch.Text == "")
            {
                MessageBox.Show("Search bar empty!!!");
                return;
            }

            SearchResults formSR = new SearchResults(textBoxAuthorSearch.Text,false);
            formSR.ShowDialog();
        }
    }
}
