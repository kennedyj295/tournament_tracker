namespace TrackerUI
{
    partial class CreateNewTournament
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
            this.Tournament = new System.Windows.Forms.Label();
            this.enterTournamentName = new System.Windows.Forms.TextBox();
            this.TournamentName = new System.Windows.Forms.Label();
            this.EnterEntryFee = new System.Windows.Forms.TextBox();
            this.EntryFee = new System.Windows.Forms.Label();
            this.AddTeamSelection = new System.Windows.Forms.ComboBox();
            this.AddTeam = new System.Windows.Forms.Label();
            this.CreateNewTeam = new System.Windows.Forms.LinkLabel();
            this.AddToTournament = new System.Windows.Forms.Button();
            this.CreatePrize = new System.Windows.Forms.Button();
            this.PlayersList = new System.Windows.Forms.ListBox();
            this.TeamsAndPlayers = new System.Windows.Forms.Label();
            this.DeletePlayers = new System.Windows.Forms.Button();
            this.DeletePrizes = new System.Windows.Forms.Button();
            this.PrizeListLabel = new System.Windows.Forms.Label();
            this.PrizesList = new System.Windows.Forms.ListBox();
            this.CreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tournament
            // 
            this.Tournament.AutoSize = true;
            this.Tournament.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Tournament.Location = new System.Drawing.Point(39, 22);
            this.Tournament.Name = "Tournament";
            this.Tournament.Size = new System.Drawing.Size(303, 45);
            this.Tournament.TabIndex = 1;
            this.Tournament.Text = "Create Tournament:";
            // 
            // enterTournamentName
            // 
            this.enterTournamentName.Location = new System.Drawing.Point(39, 119);
            this.enterTournamentName.Name = "enterTournamentName";
            this.enterTournamentName.Size = new System.Drawing.Size(314, 47);
            this.enterTournamentName.TabIndex = 13;
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentName.Location = new System.Drawing.Point(39, 75);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(264, 41);
            this.TournamentName.TabIndex = 11;
            this.TournamentName.Text = "Tournament Name";
            // 
            // EnterEntryFee
            // 
            this.EnterEntryFee.Location = new System.Drawing.Point(202, 178);
            this.EnterEntryFee.Name = "EnterEntryFee";
            this.EnterEntryFee.Size = new System.Drawing.Size(151, 47);
            this.EnterEntryFee.TabIndex = 16;
            // 
            // EntryFee
            // 
            this.EntryFee.AutoSize = true;
            this.EntryFee.Location = new System.Drawing.Point(39, 178);
            this.EntryFee.Name = "EntryFee";
            this.EntryFee.Size = new System.Drawing.Size(140, 41);
            this.EntryFee.TabIndex = 15;
            this.EntryFee.Text = "Entry Fee";
            // 
            // AddTeamSelection
            // 
            this.AddTeamSelection.FormattingEnabled = true;
            this.AddTeamSelection.Location = new System.Drawing.Point(44, 280);
            this.AddTeamSelection.Name = "AddTeamSelection";
            this.AddTeamSelection.Size = new System.Drawing.Size(309, 49);
            this.AddTeamSelection.TabIndex = 18;
            // 
            // AddTeam
            // 
            this.AddTeam.AutoSize = true;
            this.AddTeam.Location = new System.Drawing.Point(39, 236);
            this.AddTeam.Name = "AddTeam";
            this.AddTeam.Size = new System.Drawing.Size(151, 41);
            this.AddTeam.TabIndex = 17;
            this.AddTeam.Text = "Add Team";
            // 
            // CreateNewTeam
            // 
            this.CreateNewTeam.AutoSize = true;
            this.CreateNewTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateNewTeam.Location = new System.Drawing.Point(191, 246);
            this.CreateNewTeam.Name = "CreateNewTeam";
            this.CreateNewTeam.Size = new System.Drawing.Size(162, 28);
            this.CreateNewTeam.TabIndex = 19;
            this.CreateNewTeam.TabStop = true;
            this.CreateNewTeam.Text = "Create New Team";
            // 
            // AddToTournament
            // 
            this.AddToTournament.Location = new System.Drawing.Point(44, 400);
            this.AddToTournament.Name = "AddToTournament";
            this.AddToTournament.Size = new System.Drawing.Size(309, 63);
            this.AddToTournament.TabIndex = 20;
            this.AddToTournament.Text = "Add Team";
            this.AddToTournament.UseVisualStyleBackColor = true;
            this.AddToTournament.Click += new System.EventHandler(this.AddToTournament_Click);
            // 
            // CreatePrize
            // 
            this.CreatePrize.Location = new System.Drawing.Point(44, 335);
            this.CreatePrize.Name = "CreatePrize";
            this.CreatePrize.Size = new System.Drawing.Size(309, 60);
            this.CreatePrize.TabIndex = 21;
            this.CreatePrize.Text = "Create Prize";
            this.CreatePrize.UseVisualStyleBackColor = true;
            this.CreatePrize.Click += new System.EventHandler(this.CreatePrize_Click);
            // 
            // PlayersList
            // 
            this.PlayersList.FormattingEnabled = true;
            this.PlayersList.ItemHeight = 41;
            this.PlayersList.Location = new System.Drawing.Point(427, 75);
            this.PlayersList.Name = "PlayersList";
            this.PlayersList.Size = new System.Drawing.Size(385, 209);
            this.PlayersList.TabIndex = 22;
            // 
            // TeamsAndPlayers
            // 
            this.TeamsAndPlayers.AutoSize = true;
            this.TeamsAndPlayers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamsAndPlayers.Location = new System.Drawing.Point(427, 21);
            this.TeamsAndPlayers.Name = "TeamsAndPlayers";
            this.TeamsAndPlayers.Size = new System.Drawing.Size(206, 41);
            this.TeamsAndPlayers.TabIndex = 23;
            this.TeamsAndPlayers.Text = "Teams/Players";
            // 
            // DeletePlayers
            // 
            this.DeletePlayers.Location = new System.Drawing.Point(639, 18);
            this.DeletePlayers.Name = "DeletePlayers";
            this.DeletePlayers.Size = new System.Drawing.Size(173, 55);
            this.DeletePlayers.TabIndex = 24;
            this.DeletePlayers.Text = "Delete";
            this.DeletePlayers.UseVisualStyleBackColor = true;
            // 
            // DeletePrizes
            // 
            this.DeletePrizes.Location = new System.Drawing.Point(639, 287);
            this.DeletePrizes.Name = "DeletePrizes";
            this.DeletePrizes.Size = new System.Drawing.Size(173, 55);
            this.DeletePrizes.TabIndex = 27;
            this.DeletePrizes.Text = "Delete";
            this.DeletePrizes.UseVisualStyleBackColor = true;
            // 
            // PrizeListLabel
            // 
            this.PrizeListLabel.AutoSize = true;
            this.PrizeListLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrizeListLabel.Location = new System.Drawing.Point(427, 291);
            this.PrizeListLabel.Name = "PrizeListLabel";
            this.PrizeListLabel.Size = new System.Drawing.Size(95, 41);
            this.PrizeListLabel.TabIndex = 26;
            this.PrizeListLabel.Text = "Prizes";
            // 
            // PrizesList
            // 
            this.PrizesList.FormattingEnabled = true;
            this.PrizesList.ItemHeight = 41;
            this.PrizesList.Location = new System.Drawing.Point(427, 345);
            this.PrizesList.Name = "PrizesList";
            this.PrizesList.Size = new System.Drawing.Size(385, 209);
            this.PrizesList.TabIndex = 25;
            // 
            // CreateTournament
            // 
            this.CreateTournament.Location = new System.Drawing.Point(44, 469);
            this.CreateTournament.Name = "CreateTournament";
            this.CreateTournament.Size = new System.Drawing.Size(309, 63);
            this.CreateTournament.TabIndex = 28;
            this.CreateTournament.Text = "Create Tournament";
            this.CreateTournament.UseVisualStyleBackColor = true;
            // 
            // CreateNewTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 564);
            this.Controls.Add(this.CreateTournament);
            this.Controls.Add(this.DeletePrizes);
            this.Controls.Add(this.PrizeListLabel);
            this.Controls.Add(this.PrizesList);
            this.Controls.Add(this.DeletePlayers);
            this.Controls.Add(this.TeamsAndPlayers);
            this.Controls.Add(this.PlayersList);
            this.Controls.Add(this.CreatePrize);
            this.Controls.Add(this.AddToTournament);
            this.Controls.Add(this.CreateNewTeam);
            this.Controls.Add(this.AddTeamSelection);
            this.Controls.Add(this.AddTeam);
            this.Controls.Add(this.EnterEntryFee);
            this.Controls.Add(this.EntryFee);
            this.Controls.Add(this.enterTournamentName);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.Tournament);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateNewTournament";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Tournament;
        private TextBox enterTournamentName;
        private Label TournamentName;
        private TextBox EnterEntryFee;
        private Label EntryFee;
        private ComboBox AddTeamSelection;
        private Label AddTeam;
        private LinkLabel CreateNewTeam;
        private Button AddToTournament;
        private Button CreatePrize;
        private ListBox PlayersList;
        private Label TeamsAndPlayers;
        private Button DeletePlayers;
        private Button DeletePrizes;
        private Label PrizeListLabel;
        private ListBox PrizesList;
        private Button CreateTournament;
    }
}