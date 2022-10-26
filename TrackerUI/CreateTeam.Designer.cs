namespace TrackerUI
{
    partial class CreateTeam
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
            this.EnterTeamName = new System.Windows.Forms.TextBox();
            this.TeamName = new System.Windows.Forms.Label();
            this.CreateTeamHeader = new System.Windows.Forms.Label();
            this.TeamMembers = new System.Windows.Forms.ComboBox();
            this.SelectTeamMember = new System.Windows.Forms.Label();
            this.CreatePrize = new System.Windows.Forms.Button();
            this.AddNewMemberBox = new System.Windows.Forms.GroupBox();
            this.CreateMember = new System.Windows.Forms.Button();
            this.CellPhoneValue = new System.Windows.Forms.TextBox();
            this.CellPhone = new System.Windows.Forms.Label();
            this.EmailValue = new System.Windows.Forms.TextBox();
            this.EmailAddress = new System.Windows.Forms.Label();
            this.LastNameEntry = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstNameEntry = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.TeamMembersListBox = new System.Windows.Forms.ListBox();
            this.DeleteMember = new System.Windows.Forms.Button();
            this.CreateNewTeam = new System.Windows.Forms.Button();
            this.AddNewMemberBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnterTeamName
            // 
            this.EnterTeamName.Location = new System.Drawing.Point(31, 98);
            this.EnterTeamName.Name = "EnterTeamName";
            this.EnterTeamName.Size = new System.Drawing.Size(380, 47);
            this.EnterTeamName.TabIndex = 16;
            // 
            // TeamName
            // 
            this.TeamName.AutoSize = true;
            this.TeamName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamName.Location = new System.Drawing.Point(24, 54);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(175, 41);
            this.TeamName.TabIndex = 15;
            this.TeamName.Text = "Team Name";
            // 
            // CreateTeamHeader
            // 
            this.CreateTeamHeader.AutoSize = true;
            this.CreateTeamHeader.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.CreateTeamHeader.Location = new System.Drawing.Point(24, 9);
            this.CreateTeamHeader.Name = "CreateTeamHeader";
            this.CreateTeamHeader.Size = new System.Drawing.Size(205, 45);
            this.CreateTeamHeader.TabIndex = 14;
            this.CreateTeamHeader.Text = "Create Team:";
            // 
            // TeamMembers
            // 
            this.TeamMembers.FormattingEnabled = true;
            this.TeamMembers.Location = new System.Drawing.Point(31, 200);
            this.TeamMembers.Name = "TeamMembers";
            this.TeamMembers.Size = new System.Drawing.Size(380, 49);
            this.TeamMembers.TabIndex = 20;
            // 
            // SelectTeamMember
            // 
            this.SelectTeamMember.AutoSize = true;
            this.SelectTeamMember.Location = new System.Drawing.Point(24, 156);
            this.SelectTeamMember.Name = "SelectTeamMember";
            this.SelectTeamMember.Size = new System.Drawing.Size(296, 41);
            this.SelectTeamMember.TabIndex = 19;
            this.SelectTeamMember.Text = "Select Team Member";
            // 
            // CreatePrize
            // 
            this.CreatePrize.Location = new System.Drawing.Point(66, 255);
            this.CreatePrize.Name = "CreatePrize";
            this.CreatePrize.Size = new System.Drawing.Size(238, 50);
            this.CreatePrize.TabIndex = 22;
            this.CreatePrize.Text = "Add Member";
            this.CreatePrize.UseVisualStyleBackColor = true;
            this.CreatePrize.Click += new System.EventHandler(this.CreatePrize_Click);
            // 
            // AddNewMemberBox
            // 
            this.AddNewMemberBox.Controls.Add(this.CreateMember);
            this.AddNewMemberBox.Controls.Add(this.CellPhoneValue);
            this.AddNewMemberBox.Controls.Add(this.CellPhone);
            this.AddNewMemberBox.Controls.Add(this.EmailValue);
            this.AddNewMemberBox.Controls.Add(this.EmailAddress);
            this.AddNewMemberBox.Controls.Add(this.LastNameEntry);
            this.AddNewMemberBox.Controls.Add(this.LastName);
            this.AddNewMemberBox.Controls.Add(this.FirstNameEntry);
            this.AddNewMemberBox.Controls.Add(this.FirstName);
            this.AddNewMemberBox.Location = new System.Drawing.Point(31, 325);
            this.AddNewMemberBox.Name = "AddNewMemberBox";
            this.AddNewMemberBox.Size = new System.Drawing.Size(467, 384);
            this.AddNewMemberBox.TabIndex = 23;
            this.AddNewMemberBox.TabStop = false;
            this.AddNewMemberBox.Text = "Add New Member";
            // 
            // CreateMember
            // 
            this.CreateMember.Location = new System.Drawing.Point(99, 307);
            this.CreateMember.Name = "CreateMember";
            this.CreateMember.Size = new System.Drawing.Size(238, 50);
            this.CreateMember.TabIndex = 23;
            this.CreateMember.Text = "Create Member";
            this.CreateMember.UseVisualStyleBackColor = true;
            this.CreateMember.Click += new System.EventHandler(this.CreateMember_Click);
            // 
            // CellPhoneValue
            // 
            this.CellPhoneValue.Location = new System.Drawing.Point(183, 241);
            this.CellPhoneValue.Name = "CellPhoneValue";
            this.CellPhoneValue.Size = new System.Drawing.Size(256, 47);
            this.CellPhoneValue.TabIndex = 18;
            // 
            // CellPhone
            // 
            this.CellPhone.AutoSize = true;
            this.CellPhone.Location = new System.Drawing.Point(17, 244);
            this.CellPhone.Name = "CellPhone";
            this.CellPhone.Size = new System.Drawing.Size(160, 41);
            this.CellPhone.TabIndex = 17;
            this.CellPhone.Text = "Cell Phone";
            // 
            // EmailValue
            // 
            this.EmailValue.Location = new System.Drawing.Point(183, 179);
            this.EmailValue.Name = "EmailValue";
            this.EmailValue.Size = new System.Drawing.Size(256, 47);
            this.EmailValue.TabIndex = 16;
            // 
            // EmailAddress
            // 
            this.EmailAddress.AutoSize = true;
            this.EmailAddress.Location = new System.Drawing.Point(17, 182);
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Size = new System.Drawing.Size(88, 41);
            this.EmailAddress.TabIndex = 15;
            this.EmailAddress.Text = "Email";
            // 
            // LastNameEntry
            // 
            this.LastNameEntry.Location = new System.Drawing.Point(183, 114);
            this.LastNameEntry.Name = "LastNameEntry";
            this.LastNameEntry.Size = new System.Drawing.Size(256, 47);
            this.LastNameEntry.TabIndex = 14;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(17, 117);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(157, 41);
            this.LastName.TabIndex = 13;
            this.LastName.Text = "Last Name";
            // 
            // FirstNameEntry
            // 
            this.FirstNameEntry.Location = new System.Drawing.Point(183, 52);
            this.FirstNameEntry.Name = "FirstNameEntry";
            this.FirstNameEntry.Size = new System.Drawing.Size(256, 47);
            this.FirstNameEntry.TabIndex = 12;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(17, 55);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(160, 41);
            this.FirstName.TabIndex = 11;
            this.FirstName.Text = "First Name";
            // 
            // TeamMembersListBox
            // 
            this.TeamMembersListBox.FormattingEnabled = true;
            this.TeamMembersListBox.ItemHeight = 41;
            this.TeamMembersListBox.Location = new System.Drawing.Point(542, 104);
            this.TeamMembersListBox.Name = "TeamMembersListBox";
            this.TeamMembersListBox.Size = new System.Drawing.Size(352, 578);
            this.TeamMembersListBox.TabIndex = 24;
            // 
            // DeleteMember
            // 
            this.DeleteMember.Location = new System.Drawing.Point(921, 321);
            this.DeleteMember.Name = "DeleteMember";
            this.DeleteMember.Size = new System.Drawing.Size(173, 100);
            this.DeleteMember.TabIndex = 28;
            this.DeleteMember.Text = "Delete Member";
            this.DeleteMember.UseVisualStyleBackColor = true;
            this.DeleteMember.Click += new System.EventHandler(this.DeleteMember_Click);
            // 
            // CreateNewTeam
            // 
            this.CreateNewTeam.Location = new System.Drawing.Point(341, 737);
            this.CreateNewTeam.Name = "CreateNewTeam";
            this.CreateNewTeam.Size = new System.Drawing.Size(423, 100);
            this.CreateNewTeam.TabIndex = 29;
            this.CreateNewTeam.Text = "Create Team";
            this.CreateNewTeam.UseVisualStyleBackColor = true;
            this.CreateNewTeam.Click += new System.EventHandler(this.CreateNewTeam_Click);
            // 
            // CreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 864);
            this.Controls.Add(this.CreateNewTeam);
            this.Controls.Add(this.DeleteMember);
            this.Controls.Add(this.TeamMembersListBox);
            this.Controls.Add(this.AddNewMemberBox);
            this.Controls.Add(this.CreatePrize);
            this.Controls.Add(this.TeamMembers);
            this.Controls.Add(this.SelectTeamMember);
            this.Controls.Add(this.EnterTeamName);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.CreateTeamHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateTeam";
            this.Text = "Create Team";
            this.AddNewMemberBox.ResumeLayout(false);
            this.AddNewMemberBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox EnterTeamName;
        private Label TeamName;
        private Label CreateTeamHeader;
        private ComboBox TeamMembers;
        private Label SelectTeamMember;
        private Button CreatePrize;
        private GroupBox AddNewMemberBox;
        private TextBox FirstNameEntry;
        private Label FirstName;
        private TextBox LastNameEntry;
        private Label LastName;
        private TextBox CellPhoneValue;
        private Label CellPhone;
        private TextBox EmailValue;
        private Label EmailAddress;
        private Button CreateMember;
        private ListBox TeamMembersListBox;
        private Button DeleteMember;
        private Button CreateNewTeam;
    }
}