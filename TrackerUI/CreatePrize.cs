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
    public partial class CreatePrize : Form
    {
        public CreatePrize()
        {
            InitializeComponent();
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                PrizeModel model = new PrizeModel(PlaceNameValue.Text, PlaceNumberValue.Text, PrizeAmountValue.Text, PrizePercentValue.Text);
                
                GlobalConfig.Connection.createPrize(model);
                

                PlaceNameValue.Text = "";
                PlaceNumberValue.Text = "";
                PrizeAmountValue.Text = "0";
                PrizePercentValue.Text = "0";
            }
            else
            {
                MessageBox.Show("Invalid entries, please correct");
            }
        }

        private bool validateForm()
        {
            bool output = true;
            int placeNumber = 0;

            if (int.TryParse(PlaceNumberValue.Text, out placeNumber) == false)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output=false;
            }

            if (PlaceNameValue.Text.Length == 0)
            {
                output = false; 
            }

            decimal prizeAmt = 0;
            double prizePct = 0;
            bool prizeAmtValid = decimal.TryParse(PrizeAmountValue.Text, out prizeAmt);
            bool prizePctVaid = double.TryParse(PrizePercentValue.Text, out prizePct);

            if (prizeAmtValid == false || prizePctVaid == false)
            {
                output = false;
            }

            if (prizeAmt <= 0 && prizePct <= 0)
            {
                output = false;
            }

            if (prizePct < 0 || prizePct > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
