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
        public CreateTeam()
        {
            InitializeComponent();
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

                GlobalConfig.Connection.createPerson(p);

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
    }
}
