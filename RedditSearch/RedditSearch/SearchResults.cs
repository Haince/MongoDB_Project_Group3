using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB;
using MongoDB.Driver.Linq;
using MongoDB.Driver;
namespace RedditSearch
{
    public partial class SearchResults : Form
    {
        String keyword;
        public SearchResults(String returnedText)
        {
            InitializeComponent();
            keyword =returnedText;
        }

        private void SearchResults_Load(object sender, EventArgs e)
        {
            MongoClient client = new MongoClient();
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("group3DB");
            MongoCollection<BsonDocument> colleciton = db.GetCollection("reddit");
            BsonDocument document = new BsonDocument {
                                        {"author",keyword}};

            var query = new QueryDocument("author","\b"+keyword+"");
            MongoCursor cursor = colleciton.Find(query);
            foreach (var record in cursor)
            {
                
            }
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
