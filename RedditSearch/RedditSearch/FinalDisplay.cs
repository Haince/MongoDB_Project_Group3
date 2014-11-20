using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedditSearch
{
    public partial class FinalDisplay : Form
    {
        int selectedID;
        public FinalDisplay(int selected_id)
        {
            selectedID = selected_id;
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

        private void buttonCommentSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comment has been added!");
            textBoxComment.Text = "";
        }

        private void FinalDisplay_Load(object sender, EventArgs e)
        {
            loadingBox connectingWaitBox = new loadingBox();



            connectingWaitBox.Show();
            MongoClient client = new MongoClient();
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("group3");
            MongoCollection<BsonDocument> colleciton = db.GetCollection("reddit");

            var query = new QueryDocument("created_utc", selectedID);
            MongoCursor cursor = colleciton.Find(query);
            foreach (BsonDocument record in cursor)
            {
                labelAuthorDisplay.Text = record.GetValue("author").ToString();
                labelTitleDisplay.Text = record.GetValue("title").ToString();
                labelUpDisplay.Text = record.GetValue("ups").ToString();
                labelDownDisplay.Text = record.GetValue("downs").ToString();
                labelScoreDisplay.Text = record.GetValue("score").ToString();
                displayImage.Images.Add(Image.FromFile(record.GetValue("thumbnail").ToString()));
            }

            //will add the connection to the database here 
            //as well as the information from the search to make the results display
            connectingWaitBox.Dispose();
        }
    }
}
