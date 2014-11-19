namespace RedditSearch
{
    partial class FinalDisplay
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
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCommentSubmit = new System.Windows.Forms.Button();
            this.buttonCommentClear = new System.Windows.Forms.Button();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textte = new System.Diagnostics.EventLog();
            this.labelAuthorDisplay = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textte)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 24);
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
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(378, 243);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(213, 80);
            this.textBoxComment.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Leave A Comment";
            // 
            // buttonCommentSubmit
            // 
            this.buttonCommentSubmit.Location = new System.Drawing.Point(516, 329);
            this.buttonCommentSubmit.Name = "buttonCommentSubmit";
            this.buttonCommentSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonCommentSubmit.TabIndex = 3;
            this.buttonCommentSubmit.Text = "Submit";
            this.buttonCommentSubmit.UseVisualStyleBackColor = true;
            this.buttonCommentSubmit.Click += new System.EventHandler(this.buttonCommentSubmit_Click);
            // 
            // buttonCommentClear
            // 
            this.buttonCommentClear.Location = new System.Drawing.Point(378, 329);
            this.buttonCommentClear.Name = "buttonCommentClear";
            this.buttonCommentClear.Size = new System.Drawing.Size(75, 23);
            this.buttonCommentClear.TabIndex = 4;
            this.buttonCommentClear.Text = "Clear";
            this.buttonCommentClear.UseVisualStyleBackColor = true;
            this.buttonCommentClear.Click += new System.EventHandler(this.buttonCommentClear_Click);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(12, 65);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(44, 13);
            this.labelAuthor.TabIndex = 5;
            this.labelAuthor.Text = "Author: ";
            // 
            // textte
            // 
            this.textte.SynchronizingObject = this;
            // 
            // labelAuthorDisplay
            // 
            this.labelAuthorDisplay.AutoSize = true;
            this.labelAuthorDisplay.Location = new System.Drawing.Point(62, 65);
            this.labelAuthorDisplay.Name = "labelAuthorDisplay";
            this.labelAuthorDisplay.Size = new System.Drawing.Size(35, 13);
            this.labelAuthorDisplay.TabIndex = 6;
            this.labelAuthorDisplay.Text = "label2";
            // 
            // FinalDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 389);
            this.Controls.Add(this.labelAuthorDisplay);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.buttonCommentClear);
            this.Controls.Add(this.buttonCommentSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FinalDisplay";
            this.Text = "FinalDisplay";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCommentSubmit;
        private System.Windows.Forms.Button buttonCommentClear;
        private System.Windows.Forms.Label labelAuthor;
        private System.Diagnostics.EventLog textte;
        private System.Windows.Forms.Label labelAuthorDisplay;
    }
}