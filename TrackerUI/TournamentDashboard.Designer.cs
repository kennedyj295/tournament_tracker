namespace TrackerUI
{
    partial class TournamentDashboard
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
            this.DashboardHeader = new System.Windows.Forms.Label();
            this.SelectTournament = new System.Windows.Forms.ComboBox();
            this.LoadExistingTournament = new System.Windows.Forms.Label();
            this.LoadTournament = new System.Windows.Forms.Button();
            this.CreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DashboardHeader
            // 
            this.DashboardHeader.AutoSize = true;
            this.DashboardHeader.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.DashboardHeader.Location = new System.Drawing.Point(178, 73);
            this.DashboardHeader.Name = "DashboardHeader";
            this.DashboardHeader.Size = new System.Drawing.Size(408, 50);
            this.DashboardHeader.TabIndex = 16;
            this.DashboardHeader.Text = "Tournament Dashboard";
            // 
            // SelectTournament
            // 
            this.SelectTournament.FormattingEnabled = true;
            this.SelectTournament.Location = new System.Drawing.Point(191, 210);
            this.SelectTournament.Name = "SelectTournament";
            this.SelectTournament.Size = new System.Drawing.Size(380, 49);
            this.SelectTournament.TabIndex = 22;
            // 
            // LoadExistingTournament
            // 
            this.LoadExistingTournament.AutoSize = true;
            this.LoadExistingTournament.Location = new System.Drawing.Point(203, 157);
            this.LoadExistingTournament.Name = "LoadExistingTournament";
            this.LoadExistingTournament.Size = new System.Drawing.Size(359, 41);
            this.LoadExistingTournament.TabIndex = 21;
            this.LoadExistingTournament.Text = "Load Existing Tournament";
            // 
            // LoadTournament
            // 
            this.LoadTournament.Location = new System.Drawing.Point(250, 275);
            this.LoadTournament.Name = "LoadTournament";
            this.LoadTournament.Size = new System.Drawing.Size(274, 60);
            this.LoadTournament.TabIndex = 30;
            this.LoadTournament.Text = "Load Tournament";
            this.LoadTournament.UseVisualStyleBackColor = true;
            // 
            // CreateTournament
            // 
            this.CreateTournament.Location = new System.Drawing.Point(227, 365);
            this.CreateTournament.Name = "CreateTournament";
            this.CreateTournament.Size = new System.Drawing.Size(321, 100);
            this.CreateTournament.TabIndex = 31;
            this.CreateTournament.Text = "Create New Tournament";
            this.CreateTournament.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 536);
            this.Controls.Add(this.CreateTournament);
            this.Controls.Add(this.LoadTournament);
            this.Controls.Add(this.SelectTournament);
            this.Controls.Add(this.LoadExistingTournament);
            this.Controls.Add(this.DashboardHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TournamentDashboard";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label DashboardHeader;
        private ComboBox SelectTournament;
        private Label LoadExistingTournament;
        private Button LoadTournament;
        private Button CreateTournament;
    }
}