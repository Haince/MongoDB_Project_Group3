﻿using System;
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
    public partial class FinalDisplay : Form
    {
        public FinalDisplay()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCommentClear_Click(object sender, EventArgs e)
        {
            textBoxComment.Text = "";
        }
    }
}
