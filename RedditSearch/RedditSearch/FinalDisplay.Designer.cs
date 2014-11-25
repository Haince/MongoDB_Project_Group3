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
            this.labelScore = new System.Windows.Forms.Label();
            this.labelScoreDisplay = new System.Windows.Forms.Label();
            this.labelUp = new System.Windows.Forms.Label();
            this.labelUpDisplay = new System.Windows.Forms.Label();
            this.labelDown = new System.Windows.Forms.Label();
            this.labelDownDisplay = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTitleDisplay = new System.Windows.Forms.Label();
            this.labelImage = new System.Windows.Forms.Label();
            this.pictureBoxImported = new System.Windows.Forms.PictureBox();
            this.textBoxAddedComments = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImported)).BeginInit();
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
            this.labelAuthor.Location = new System.Drawing.Point(12, 96);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(41, 13);
            this.labelAuthor.TabIndex = 5;
            this.labelAuthor.Text = "Author:";
            // 
            // textte
            // 
            this.textte.SynchronizingObject = this;
            // 
            // labelAuthorDisplay
            // 
            this.labelAuthorDisplay.AutoSize = true;
            this.labelAuthorDisplay.Location = new System.Drawing.Point(81, 96);
            this.labelAuthorDisplay.Name = "labelAuthorDisplay";
            this.labelAuthorDisplay.Size = new System.Drawing.Size(60, 13);
            this.labelAuthorDisplay.TabIndex = 6;
            this.labelAuthorDisplay.Text = "labelAuthor";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(12, 196);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(38, 13);
            this.labelScore.TabIndex = 7;
            this.labelScore.Text = "Score:";
            // 
            // labelScoreDisplay
            // 
            this.labelScoreDisplay.AutoSize = true;
            this.labelScoreDisplay.Location = new System.Drawing.Point(81, 196);
            this.labelScoreDisplay.Name = "labelScoreDisplay";
            this.labelScoreDisplay.Size = new System.Drawing.Size(57, 13);
            this.labelScoreDisplay.TabIndex = 8;
            this.labelScoreDisplay.Text = "labelScore";
            // 
            // labelUp
            // 
            this.labelUp.AutoSize = true;
            this.labelUp.Location = new System.Drawing.Point(12, 130);
            this.labelUp.Name = "labelUp";
            this.labelUp.Size = new System.Drawing.Size(49, 13);
            this.labelUp.TabIndex = 9;
            this.labelUp.Text = "Up Vote:";
            // 
            // labelUpDisplay
            // 
            this.labelUpDisplay.AutoSize = true;
            this.labelUpDisplay.Location = new System.Drawing.Point(81, 130);
            this.labelUpDisplay.Name = "labelUpDisplay";
            this.labelUpDisplay.Size = new System.Drawing.Size(43, 13);
            this.labelUpDisplay.TabIndex = 10;
            this.labelUpDisplay.Text = "labelUp";
            // 
            // labelDown
            // 
            this.labelDown.AutoSize = true;
            this.labelDown.Location = new System.Drawing.Point(12, 163);
            this.labelDown.Name = "labelDown";
            this.labelDown.Size = new System.Drawing.Size(63, 13);
            this.labelDown.TabIndex = 11;
            this.labelDown.Text = "Down Vote:";
            // 
            // labelDownDisplay
            // 
            this.labelDownDisplay.AutoSize = true;
            this.labelDownDisplay.Location = new System.Drawing.Point(81, 163);
            this.labelDownDisplay.Name = "labelDownDisplay";
            this.labelDownDisplay.Size = new System.Drawing.Size(57, 13);
            this.labelDownDisplay.TabIndex = 12;
            this.labelDownDisplay.Text = "labelDown";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(15, 33);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "Title:";
            // 
            // labelTitleDisplay
            // 
            this.labelTitleDisplay.AutoSize = true;
            this.labelTitleDisplay.Location = new System.Drawing.Point(81, 33);
            this.labelTitleDisplay.Name = "labelTitleDisplay";
            this.labelTitleDisplay.Size = new System.Drawing.Size(49, 13);
            this.labelTitleDisplay.TabIndex = 14;
            this.labelTitleDisplay.Text = "labelTitle";
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(378, 64);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(36, 13);
            this.labelImage.TabIndex = 15;
            this.labelImage.Text = "Image";
            // 
            // pictureBoxImported
            // 
            this.pictureBoxImported.Location = new System.Drawing.Point(381, 80);
            this.pictureBoxImported.Name = "pictureBoxImported";
            this.pictureBoxImported.Size = new System.Drawing.Size(201, 129);
            this.pictureBoxImported.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxImported.TabIndex = 16;
            this.pictureBoxImported.TabStop = false;
            // 
            // textBoxAddedComments
            // 
            this.textBoxAddedComments.Enabled = false;
            this.textBoxAddedComments.Location = new System.Drawing.Point(15, 252);
            this.textBoxAddedComments.Multiline = true;
            this.textBoxAddedComments.Name = "textBoxAddedComments";
            this.textBoxAddedComments.Size = new System.Drawing.Size(262, 100);
            this.textBoxAddedComments.TabIndex = 17;
            // 
            // FinalDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 389);
            this.Controls.Add(this.textBoxAddedComments);
            this.Controls.Add(this.pictureBoxImported);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.labelTitleDisplay);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelDownDisplay);
            this.Controls.Add(this.labelDown);
            this.Controls.Add(this.labelUpDisplay);
            this.Controls.Add(this.labelUp);
            this.Controls.Add(this.labelScoreDisplay);
            this.Controls.Add(this.labelScore);
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
            this.Load += new System.EventHandler(this.FinalDisplay_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImported)).EndInit();
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
        private System.Windows.Forms.Label labelUpDisplay;
        private System.Windows.Forms.Label labelUp;
        private System.Windows.Forms.Label labelScoreDisplay;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelAuthorDisplay;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Label labelTitleDisplay;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDownDisplay;
        private System.Windows.Forms.Label labelDown;
        private System.Windows.Forms.PictureBox pictureBoxImported;
        private System.Windows.Forms.TextBox textBoxAddedComments;
    }
}