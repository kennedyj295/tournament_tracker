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
    public partial class CreateNewTournament : Form, IPrizeRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateNewTournament()
        {
            InitializeComponent();
            InitializeLists();
        }

        private void InitializeLists()
        {
            AddTeamSelection.DataSource = null;
            AddTeamSelection.DataSource = availableTeams;
            AddTeamSelection.DisplayMember = "TeamName";

            PlayersList.DataSource = null;
            PlayersList.DataSource = selectedTeams;
            PlayersList.DisplayMember = "TeamName";

            PrizesList.DataSource = null;
            PrizesList.DataSource = selectedPrizes;
            PrizesList.DisplayMember = "PlaceName";
        }

        private void AddToTournament_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)AddTeamSelection.SelectedItem;

            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                InitializeLists();
            }
        }

        private void CreatePrize_Click(object sender, EventArgs e)
        {
            CreatePrize frm = new CreatePrize(this);
            frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);
            InitializeLists();
        }
    }
}
