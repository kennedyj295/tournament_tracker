namespace TrackerUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tournament = new System.Windows.Forms.Label();
            this.TourneyName = new System.Windows.Forms.Label();
            this.WhichRound = new System.Windows.Forms.Label();
            this.RoundSelection = new System.Windows.Forms.ComboBox();
            this.UnplayedOnly = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.FirstTeam = new System.Windows.Forms.Label();
            this.TeamTwo = new System.Windows.Forms.Label();
            this.TeamOneScore = new System.Windows.Forms.Label();
            this.TeamTwoScore = new System.Windows.Forms.Label();
            this.TeamOneScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.Versus = new System.Windows.Forms.Label();
            this.ScoreIt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tournament
            // 
            this.Tournament.AutoSize = true;
            this.Tournament.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Tournament.Location = new System.Drawing.Point(77, 52);
            this.Tournament.Name = "Tournament";
            this.Tournament.Size = new System.Drawing.Size(207, 46);
            this.Tournament.TabIndex = 0;
            this.Tournament.Text = "Tournament:";
            // 
            // TourneyName
            // 
            this.TourneyName.AutoSize = true;
            this.TourneyName.Location = new System.Drawing.Point(296, 57);
            this.TourneyName.Name = "TourneyName";
            this.TourneyName.Size = new System.Drawing.Size(86, 41);
            this.TourneyName.TabIndex = 1;
            this.TourneyName.Text = "none";
            // 
            // WhichRound
            // 
            this.WhichRound.AutoSize = true;
            this.WhichRound.Location = new System.Drawing.Point(91, 113);
            this.WhichRound.Name = "WhichRound";
            this.WhichRound.Size = new System.Drawing.Size(112, 41);
            this.WhichRound.TabIndex = 2;
            this.WhichRound.Text = "Round:";
            // 
            // RoundSelection
            // 
            this.RoundSelection.FormattingEnabled = true;
            this.RoundSelection.Location = new System.Drawing.Point(209, 110);
            this.RoundSelection.Name = "RoundSelection";
            this.RoundSelection.Size = new System.Drawing.Size(189, 49);
            this.RoundSelection.TabIndex = 3;
            // 
            // UnplayedOnly
            // 
            this.UnplayedOnly.AutoSize = true;
            this.UnplayedOnly.Location = new System.Drawing.Point(153, 165);
            this.UnplayedOnly.Name = "UnplayedOnly";
            this.UnplayedOnly.Size = new System.Drawing.Size(229, 45);
            this.UnplayedOnly.TabIndex = 4;
            this.UnplayedOnly.Text = "UnplayedOnly";
            this.UnplayedOnly.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 41;
            this.listBox1.Location = new System.Drawing.Point(107, 234);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(311, 373);
            this.listBox1.TabIndex = 5;
            // 
            // FirstTeam
            // 
            this.FirstTeam.AutoSize = true;
            this.FirstTeam.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.FirstTeam.Location = new System.Drawing.Point(495, 179);
            this.FirstTeam.Name = "FirstTeam";
            this.FirstTeam.Size = new System.Drawing.Size(112, 41);
            this.FirstTeam.TabIndex = 6;
            this.FirstTeam.Text = "Team 1";
            // 
            // TeamTwo
            // 
            this.TeamTwo.AutoSize = true;
            this.TeamTwo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.TeamTwo.Location = new System.Drawing.Point(495, 373);
            this.TeamTwo.Name = "TeamTwo";
            this.TeamTwo.Size = new System.Drawing.Size(112, 41);
            this.TeamTwo.TabIndex = 7;
            this.TeamTwo.Text = "Team 2";
            // 
            // TeamOneScore
            // 
            this.TeamOneScore.AutoSize = true;
            this.TeamOneScore.Location = new System.Drawing.Point(495, 236);
            this.TeamOneScore.Name = "TeamOneScore";
            this.TeamOneScore.Size = new System.Drawing.Size(92, 41);
            this.TeamOneScore.TabIndex = 8;
            this.TeamOneScore.Text = "Score";
            // 
            // TeamTwoScore
            // 
            this.TeamTwoScore.AutoSize = true;
            this.TeamTwoScore.Location = new System.Drawing.Point(495, 427);
            this.TeamTwoScore.Name = "TeamTwoScore";
            this.TeamTwoScore.Size = new System.Drawing.Size(92, 41);
            this.TeamTwoScore.TabIndex = 9;
            this.TeamTwoScore.Text = "Score";
            // 
            // TeamOneScoreValue
            // 
            this.TeamOneScoreValue.Location = new System.Drawing.Point(590, 233);
            this.TeamOneScoreValue.Name = "TeamOneScoreValue";
            this.TeamOneScoreValue.Size = new System.Drawing.Size(151, 47);
            this.TeamOneScoreValue.TabIndex = 10;
            // 
            // TeamTwoScoreValue
            // 
            this.TeamTwoScoreValue.Location = new System.Drawing.Point(590, 427);
            this.TeamTwoScoreValue.Name = "TeamTwoScoreValue";
            this.TeamTwoScoreValue.Size = new System.Drawing.Size(151, 47);
            this.TeamTwoScoreValue.TabIndex = 11;
            // 
            // Versus
            // 
            this.Versus.AutoSize = true;
            this.Versus.Location = new System.Drawing.Point(590, 318);
            this.Versus.Name = "Versus";
            this.Versus.Size = new System.Drawing.Size(101, 41);
            this.Versus.TabIndex = 12;
            this.Versus.Text = "--VS--";
            // 
            // ScoreIt
            // 
            this.ScoreIt.Location = new System.Drawing.Point(738, 309);
            this.ScoreIt.Name = "ScoreIt";
            this.ScoreIt.Size = new System.Drawing.Size(114, 59);
            this.ScoreIt.TabIndex = 13;
            this.ScoreIt.Text = "Score";
            this.ScoreIt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 645);
            this.Controls.Add(this.ScoreIt);
            this.Controls.Add(this.Versus);
            this.Controls.Add(this.TeamTwoScoreValue);
            this.Controls.Add(this.TeamOneScoreValue);
            this.Controls.Add(this.TeamTwoScore);
            this.Controls.Add(this.TeamOneScore);
            this.Controls.Add(this.TeamTwo);
            this.Controls.Add(this.FirstTeam);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.UnplayedOnly);
            this.Controls.Add(this.RoundSelection);
            this.Controls.Add(this.WhichRound);
            this.Controls.Add(this.TourneyName);
            this.Controls.Add(this.Tournament);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Tournament Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Tournament;
        private Label TourneyName;
        private Label WhichRound;
        private ComboBox RoundSelection;
        private CheckBox UnplayedOnly;
        private ListBox listBox1;
        private Label FirstTeam;
        private Label TeamTwo;
        private Label TeamOneScore;
        private Label TeamTwoScore;
        private TextBox TeamOneScoreValue;
        private TextBox TeamTwoScoreValue;
        private Label Versus;
        private Button ScoreIt;
    }
}