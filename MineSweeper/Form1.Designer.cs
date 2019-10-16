namespace MineSweeper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TimerHundreadsBox = new System.Windows.Forms.PictureBox();
            this.TimerTensBox = new System.Windows.Forms.PictureBox();
            this.TimerOnesBox = new System.Windows.Forms.PictureBox();
            this.FlagsLeftToPlaceOnesBox = new System.Windows.Forms.PictureBox();
            this.FlagsLeftToPlaceTensBox = new System.Windows.Forms.PictureBox();
            this.FlagsLeftToPlaceHundreadsBox = new System.Windows.Forms.PictureBox();
            this.SmileyBox = new System.Windows.Forms.PictureBox();
            this.ShowLeaderBoard = new System.Windows.Forms.Button();
            this.GameMenuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intermediateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TimerHundreadsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerTensBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerOnesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlagsLeftToPlaceOnesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlagsLeftToPlaceTensBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlagsLeftToPlaceHundreadsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmileyBox)).BeginInit();
            this.GameMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerHundreadsBox
            // 
            this.TimerHundreadsBox.Location = new System.Drawing.Point(16, 57);
            this.TimerHundreadsBox.Name = "TimerHundreadsBox";
            this.TimerHundreadsBox.Size = new System.Drawing.Size(33, 50);
            this.TimerHundreadsBox.TabIndex = 100;
            this.TimerHundreadsBox.TabStop = false;
            // 
            // TimerTensBox
            // 
            this.TimerTensBox.Location = new System.Drawing.Point(46, 57);
            this.TimerTensBox.Name = "TimerTensBox";
            this.TimerTensBox.Size = new System.Drawing.Size(33, 50);
            this.TimerTensBox.TabIndex = 101;
            this.TimerTensBox.TabStop = false;
            // 
            // TimerOnesBox
            // 
            this.TimerOnesBox.Location = new System.Drawing.Point(79, 57);
            this.TimerOnesBox.Name = "TimerOnesBox";
            this.TimerOnesBox.Size = new System.Drawing.Size(33, 50);
            this.TimerOnesBox.TabIndex = 102;
            this.TimerOnesBox.TabStop = false;
            // 
            // FlagsLeftToPlaceOnesBox
            // 
            this.FlagsLeftToPlaceOnesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FlagsLeftToPlaceOnesBox.Location = new System.Drawing.Point(311, 57);
            this.FlagsLeftToPlaceOnesBox.Name = "FlagsLeftToPlaceOnesBox";
            this.FlagsLeftToPlaceOnesBox.Size = new System.Drawing.Size(33, 50);
            this.FlagsLeftToPlaceOnesBox.TabIndex = 105;
            this.FlagsLeftToPlaceOnesBox.TabStop = false;
            // 
            // FlagsLeftToPlaceTensBox
            // 
            this.FlagsLeftToPlaceTensBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FlagsLeftToPlaceTensBox.Location = new System.Drawing.Point(278, 57);
            this.FlagsLeftToPlaceTensBox.Name = "FlagsLeftToPlaceTensBox";
            this.FlagsLeftToPlaceTensBox.Size = new System.Drawing.Size(33, 50);
            this.FlagsLeftToPlaceTensBox.TabIndex = 104;
            this.FlagsLeftToPlaceTensBox.TabStop = false;
            // 
            // FlagsLeftToPlaceHundreadsBox
            // 
            this.FlagsLeftToPlaceHundreadsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FlagsLeftToPlaceHundreadsBox.Location = new System.Drawing.Point(245, 57);
            this.FlagsLeftToPlaceHundreadsBox.Name = "FlagsLeftToPlaceHundreadsBox";
            this.FlagsLeftToPlaceHundreadsBox.Size = new System.Drawing.Size(33, 50);
            this.FlagsLeftToPlaceHundreadsBox.TabIndex = 103;
            this.FlagsLeftToPlaceHundreadsBox.TabStop = false;
            // 
            // SmileyBox
            // 
            this.SmileyBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SmileyBox.Location = new System.Drawing.Point(158, 57);
            this.SmileyBox.Name = "SmileyBox";
            this.SmileyBox.Size = new System.Drawing.Size(50, 50);
            this.SmileyBox.TabIndex = 106;
            this.SmileyBox.TabStop = false;
            this.SmileyBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SmileyBox_MouseDown);
            this.SmileyBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SmileyBox_MouseUp);
            // 
            // ShowLeaderBoard
            // 
            this.ShowLeaderBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowLeaderBoard.Location = new System.Drawing.Point(245, 18);
            this.ShowLeaderBoard.Name = "ShowLeaderBoard";
            this.ShowLeaderBoard.Size = new System.Drawing.Size(99, 23);
            this.ShowLeaderBoard.TabIndex = 110;
            this.ShowLeaderBoard.Text = "LeaderBoard";
            this.ShowLeaderBoard.UseVisualStyleBackColor = true;
            this.ShowLeaderBoard.Click += new System.EventHandler(this.ShowLeaderBoard_Click);
            // 
            // GameMenuStrip
            // 
            this.GameMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.GameMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.GameMenuStrip.Name = "GameMenuStrip";
            this.GameMenuStrip.Size = new System.Drawing.Size(357, 24);
            this.GameMenuStrip.TabIndex = 111;
            this.GameMenuStrip.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginnerToolStripMenuItem,
            this.intermediateToolStripMenuItem,
            this.expertToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // beginnerToolStripMenuItem
            // 
            this.beginnerToolStripMenuItem.Name = "beginnerToolStripMenuItem";
            this.beginnerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.beginnerToolStripMenuItem.Text = "Beginner";
            this.beginnerToolStripMenuItem.Click += new System.EventHandler(this.beginnerToolStripMenuItem_Click);
            // 
            // intermediateToolStripMenuItem
            // 
            this.intermediateToolStripMenuItem.Name = "intermediateToolStripMenuItem";
            this.intermediateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.intermediateToolStripMenuItem.Text = "Intermediate";
            this.intermediateToolStripMenuItem.Click += new System.EventHandler(this.intermediateToolStripMenuItem_Click);
            // 
            // expertToolStripMenuItem
            // 
            this.expertToolStripMenuItem.Name = "expertToolStripMenuItem";
            this.expertToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.expertToolStripMenuItem.Text = "Expert";
            this.expertToolStripMenuItem.Click += new System.EventHandler(this.expertToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(357, 479);
            this.Controls.Add(this.ShowLeaderBoard);
            this.Controls.Add(this.SmileyBox);
            this.Controls.Add(this.FlagsLeftToPlaceOnesBox);
            this.Controls.Add(this.FlagsLeftToPlaceTensBox);
            this.Controls.Add(this.FlagsLeftToPlaceHundreadsBox);
            this.Controls.Add(this.TimerOnesBox);
            this.Controls.Add(this.TimerTensBox);
            this.Controls.Add(this.TimerHundreadsBox);
            this.Controls.Add(this.GameMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.GameMenuStrip;
            this.Name = "Form1";
            this.Text = "MineSweeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TimerHundreadsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerTensBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerOnesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlagsLeftToPlaceOnesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlagsLeftToPlaceTensBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlagsLeftToPlaceHundreadsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmileyBox)).EndInit();
            this.GameMenuStrip.ResumeLayout(false);
            this.GameMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox TimerHundreadsBox;
        public System.Windows.Forms.PictureBox TimerTensBox;
        public System.Windows.Forms.PictureBox TimerOnesBox;
        public System.Windows.Forms.PictureBox FlagsLeftToPlaceOnesBox;
        public System.Windows.Forms.PictureBox FlagsLeftToPlaceTensBox;
        public System.Windows.Forms.PictureBox FlagsLeftToPlaceHundreadsBox;
        public System.Windows.Forms.PictureBox SmileyBox;
        private System.Windows.Forms.Button ShowLeaderBoard;
        private System.Windows.Forms.MenuStrip GameMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beginnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intermediateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertToolStripMenuItem;
    }
}

