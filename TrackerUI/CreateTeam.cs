using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeam : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        public CreateTeam()
        {
            InitializeComponent();

            //CreateSampleData();

            wireUpLists();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Al", LastName = "Topps" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Glenn", LastName = "Weast" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Tina", LastName = "Ulis" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Lars", LastName = "Mancini" });
        }
        private void wireUpLists()
        {
            TeamMembers.DataSource = null;
            TeamMembers.DataSource = availableTeamMembers;
            TeamMembers.DisplayMember = "FullName";

            TeamMembersListBox.DataSource = null;
            TeamMembersListBox.DataSource = selectedTeamMembers;
            TeamMembersListBox.DisplayMember = "FullName";
        }
        private void CreateMember_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = FirstNameEntry.Text;
                p.LastName = LastNameEntry.Text;
                p.EmailAddress = EmailValue.Text;
                p.CellphoneNumber = CellPhoneValue.Text;

                p = GlobalConfig.Connection.createPerson(p);

                selectedTeamMembers.Add(p);

                wireUpLists();

                FirstNameEntry.Text = "";
                LastNameEntry.Text = "";
                EmailValue.Text = "";
                CellPhoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("Please provide valid input");
            }
        }
        private bool ValidateForm()
        {
            if (FirstNameEntry.Text.Length == 0)
            {
                return false;
            }
            if (LastNameEntry.Text.Length == 0)
            {
                return false;
            }
            if (EmailValue.Text.Length == 0)
            {
                return false;
            }
            if (CellPhoneValue.Text.Length == 0)
            {
                return false;
            }


            return true;
        }

        private void CreatePrize_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)TeamMembers.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                wireUpLists();
            }
        }

        private void DeleteMember_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)TeamMembersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                wireUpLists();
            }
        }
    }
}
