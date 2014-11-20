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
using System.Text.RegularExpressions;
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
            loadingBox connectingWaitBox = new loadingBox();

            
          
            connectingWaitBox.Show();
            MongoClient client = new MongoClient();
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("group3");
            MongoCollection<BsonDocument> colleciton = db.GetCollection("reddit");
            var query = new QueryDocument("author",new BsonRegularExpression(new Regex(keyword, RegexOptions.IgnoreCase)));
            MongoCursor cursor = colleciton.Find(query);
            foreach (BsonDocument record in cursor)
            {
               
                dataGridViewAuthorResult.Rows.Add(record.GetValue("created_utc").ToString(),  record.GetValue("title").ToString(), record.GetValue("author").ToString(), record.GetValue("score").ToString());
            }
            
            //will add the connection to the database here 
            //as well as the information from the search to make the results display
            connectingWaitBox.Dispose();
        }

        private void buttonReturnToSearch_Click(object sender, EventArgs e)
        {
            //RedditSearchForm firstForm = new RedditSearchForm();
            //firstForm.Show();
            this.Close();
        }

       

        private void dataGridViewAuthorResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected_id = Convert.ToInt32(dataGridViewAuthorResult[0, e.RowIndex].Value);
             FinalDisplay fd = new FinalDisplay(selected_id);
            fd.ShowDialog();   
        }
    }
}
