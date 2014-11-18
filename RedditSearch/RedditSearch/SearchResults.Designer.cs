namespace RedditSearch
{
    partial class SearchResults
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewAuthorResult = new System.Windows.Forms.DataGridView();
            this.buttonReturnToSearch = new System.Windows.Forms.Button();
            this.buttonToFinal = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthorResult)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // dataGridViewAuthorResult
            // 
            this.dataGridViewAuthorResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthorResult.Location = new System.Drawing.Point(12, 27);
            this.dataGridViewAuthorResult.Name = "dataGridViewAuthorResult";
            this.dataGridViewAuthorResult.Size = new System.Drawing.Size(560, 266);
            this.dataGridViewAuthorResult.TabIndex = 1;
            // 
            // buttonReturnToSearch
            // 
            this.buttonReturnToSearch.Location = new System.Drawing.Point(21, 326);
            this.buttonReturnToSearch.Name = "buttonReturnToSearch";
            this.buttonReturnToSearch.Size = new System.Drawing.Size(133, 23);
            this.buttonReturnToSearch.TabIndex = 2;
            this.buttonReturnToSearch.Text = "Return To Search ";
            this.buttonReturnToSearch.UseVisualStyleBackColor = true;
            this.buttonReturnToSearch.Click += new System.EventHandler(this.buttonReturnToSearch_Click);
            // 
            // buttonToFinal
            // 
            this.buttonToFinal.Location = new System.Drawing.Point(358, 326);
            this.buttonToFinal.Name = "buttonToFinal";
            this.buttonToFinal.Size = new System.Drawing.Size(75, 23);
            this.buttonToFinal.TabIndex = 3;
            this.buttonToFinal.Text = "To Final";
            this.buttonToFinal.UseVisualStyleBackColor = true;
            this.buttonToFinal.Click += new System.EventHandler(this.buttonToFinal_Click);
            // 
            // SearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.buttonToFinal);
            this.Controls.Add(this.buttonReturnToSearch);
            this.Controls.Add(this.dataGridViewAuthorResult);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SearchResults";
            this.Text = "SearchResults";
            this.Load += new System.EventHandler(this.SearchResults_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthorResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewAuthorResult;
        private System.Windows.Forms.Button buttonReturnToSearch;
        private System.Windows.Forms.Button buttonToFinal;
    }
}