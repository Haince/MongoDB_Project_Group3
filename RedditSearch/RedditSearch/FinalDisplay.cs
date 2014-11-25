using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
            if (textBoxComment.Text == "") 
            {
                MessageBox.Show("Enter a comment");
                return;
            }
            loadingBox connectingWaitBox = new loadingBox();



            connectingWaitBox.Show();
            MongoClient client = new MongoClient();
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("group3");
            MongoCollection<BsonDocument> colleciton = db.GetCollection("reddit");
            
            var query = new QueryDocument("created_utc", selectedID);
            MongoCursor cursor = colleciton.Find(query);
           
            var comment = new BsonDocument("comment",textBoxComment.Text);
            var comments = new BsonArray();
         //  var comments = new BsonDocument(allowDuplicateNames:true);
            //string commentQuery;
             foreach (BsonDocument record in cursor)
             {
                 if (record.Contains("comments"))
                 {
                     comments.Add(record.GetValue("comments"));
                     //comments.AllowDuplicateNames = true;
                     comments.Add(comment);
                     //commentQuery = record.GetValue("comments").ToString();
                     //commentQuery +=","+comment.ToString();
                     ////comments.Add(record.GetValue("comments"));
                     ////comments = new BsonArray("comments", record.GetValue("comments"));
                     //comments = new BsonDocument("comments", BsonDocument.Parse("{"+commentQuery+"}"));

                 }
                 else
                 { comments.Add(comment); }

             }

             var commentsadding = new BsonDocument("comments", comments);
             var update = new UpdateDocument { {"$set", commentsadding }};
             var result = colleciton.FindAndModify(query,new SortByDocument() ,update,false,true);
            //will add the connection to the database here 
            //as well as the information from the search to make the results display
            connectingWaitBox.Dispose();

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
                this.Text = record.GetValue("title").ToString();
                labelAuthorDisplay.Text = record.GetValue("author").ToString();
                labelTitleDisplay.Text = record.GetValue("title").ToString();
                labelUpDisplay.Text = record.GetValue("ups").ToString();
                labelDownDisplay.Text = record.GetValue("downs").ToString();
                labelScoreDisplay.Text = record.GetValue("score").ToString();
                pictureBoxImported.Image = GetImageFromUrl(record.GetValue("thumbnail").ToString());
                if (record.Contains("comments")) textBoxAddedComments.Text = record.GetValue("comments").ToString();
            }

            //will add the connection to the database here 
            //as well as the information from the search to make the results display
            connectingWaitBox.Dispose();
        }
        public  Image GetImageFromUrl(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);

            using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (Stream stream = httpWebReponse.GetResponseStream())
                {
                    return Image.FromStream(stream);
                }
            }
        }
    }
}
