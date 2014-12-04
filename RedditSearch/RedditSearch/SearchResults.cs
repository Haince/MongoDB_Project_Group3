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
        bool authorSelected;
       public SearchResults(String returnedText, bool author_selected)
        {
            InitializeComponent();
            keyword =returnedText;
            authorSelected = author_selected;
            
        }

        private void SearchResults_Load(object sender, EventArgs e)
        {
            loadingBox connectingWaitBox = new loadingBox();

            
          
            connectingWaitBox.Show();
            MongoClient client = new MongoClient();
            MongoServer server = client.GetServer();
            MongoDatabase db = server.GetDatabase("group3");
            MongoCollection<BsonDocument> colleciton = db.GetCollection("reddit");
            QueryDocument query;
            if(authorSelected)query = new QueryDocument("author",new BsonRegularExpression(new Regex(keyword, RegexOptions.IgnoreCase)));
            else query = new QueryDocument("title", new BsonRegularExpression(new Regex(keyword, RegexOptions.IgnoreCase)));
            MongoCursor cursor = colleciton.Find(query);
            Console.WriteLine(client.ToString());
            Console.WriteLine(server.ToString());
            Console.WriteLine(colleciton.ToString());
            Console.WriteLine(query.ToString());
            foreach (BsonDocument record in cursor)
            {
               
                dataGridViewAuthorResult.Rows.Add(record.GetValue("created_utc").ToString(),  record.GetValue("title").ToString(), record.GetValue("author").ToString(), record.GetValue("score").ToString());
            }
            DataGridViewColumn column = dataGridViewAuthorResult.Columns["Title"];
            dataGridViewAuthorResult.Sort(column, ListSortDirection.Ascending);
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

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
