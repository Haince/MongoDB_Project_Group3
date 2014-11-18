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
            SearchResults formSR = new SearchResults();
            //////////////////////
            //this.Hide();
            //formSR.ShowDialog();
            //There are two ways that we show the next page 
            //the way right now leaves the first page so you can see your 
            //search but you are unable to interact with it so we do not need to
            //worry about people changing data
            /////////////////////////
            formSR.ShowDialog();
            
        }
    }
}
