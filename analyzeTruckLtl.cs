using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace truckCalculator1
{
    public partial class GlorifiedCalculator : Form
    {
        private string cargovan;

        public GlorifiedCalculator()
        {
            InitializeComponent();
        }
        //button textbox user input stuff
        private void exitButtonClick(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }
        //Get the amount of units from user
        public void unitTextbox_TextChanged(object sender, EventArgs e)
        {
            int amountUnit = int.Parse(unitTextbox.Text);
        }
        //Get the height of units from user
        public void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            int amountHeight = int.Parse(heightTextBox.Text);
        }
        //Get the weight of units from user
        public void weightTextBox_TextChanged(object sender, EventArgs e)
        {
            int weight = int.Parse(weightTextBox.Text);
        }
        //Get the length of units from user
        public void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            int length = int.Parse(lengthTextBox.Text);
        }
        //Get the width of units from user
        public void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            int width = int.Parse(widthTextBox.Text);
        }

        // has the check box been checked Y/N  deciphering what calculations to make for length based on how
        //tall the stack will be 
        //*******TODO:superfluous ADDITION DO AT WILL: (this will need to be edited and devision needed to extract information need
        //to make a whole number
        //for equation. see ELSE IF For needed fix)


        //calculations for height,length,and weight
        public int CalculateHeight()
        {
            int h = int.Parse(heightTextBox.Text);
            return h;
        }
        public int CalculateWeight()
        {
            int weight = int.Parse(weightTextBox.Text);
            return weight;
        }
        public int CalculateUnit()
        {
            int unit = int.Parse(unitTextbox.Text);
            return unit;
        }

        //returns biggest number and makes it the length by defalt making the 2nd number the width.
        // in the event units can be turned on the side and a smaller truck can be used due to length being shorter
        // theres the benifit. the smaller the truck the cheaper the transit.
        public int CalculateLength()
        {
            int l = int.Parse(lengthTextBox.Text);
            int w = int.Parse(widthTextBox.Text);
            int u = int.Parse(unitTextbox.Text);
            int biggestNumber = 0;

            if (l >= w)
            {
                biggestNumber = l;
                // return biggestNumber;
            }

            else if (l < w)
            {

                biggestNumber = w;
                //  return biggestNumber;
            }
            return biggestNumber * u;
        }
        //returns smallest number and makes it the width by defalt making the 2nd number the width.
        // in the event units can be turned on the side and a smaller truck can be used due to length being shorter
        // theres the benifit. the smaller the truck the cheaper the transit.
        public int CalculateWidth()
        {
            int l = int.Parse(lengthTextBox.Text);
            int w = int.Parse(widthTextBox.Text);
            int smallestNumber = 0;

            if (l >= w)
            {
                smallestNumber = w;
                return smallestNumber;
            }
            else if (l < w)
            {
                smallestNumber = l;
                return smallestNumber;
            }
            return smallestNumber;
        }

        int rowsUnit = CalculateUnit() / unitsSideBySideCargoVan;
        int newUnitLength = rowsUnit * CalculateUnit();//calculated length user input unit length

        // this button click activates the program to run equations
        //TODO: If theres time build a auto/copy paste method so user can extract the calculations information.
        // user might need this for expedites this will save them the need to type it out. 
        private void button_Click(object sender, EventArgs e)
        {
            int height = 0;

            try
            {
                height = CalculateHeight();

            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                MessageBox.Show("Please enter all required values.");
                return;
            }

            string calculationsFortruckMessage = " needed for this load. " +
                    "\n The length is " + CalculateLength() +
                                "\n The width is " + CalculateWidth() + " "+ 
                    "\n The height is " + CalculateHeight() +
                    "\n The weight is " + CalculateWeight()+"\n";

            string calculationsFortrucklength = = " needed for this load. " +
                    "\n The length is " + newUnitLength +
                                "\n The width is " + CalculateWidth() + " " +
                    "\n The height is " + CalculateHeight() +
                    "\n The weight is " + CalculateWeight() + "\n";

            //Cargo van size Check LxWxh, verifys that weight is with in range.
            if (CalculateLength() <= 108 && CalculateWidth() <= 48 && CalculateHeight() <= 47 && CalculateWeight() <= 2000)
            {
                int vehicleHeight = 47 / CalculateHeight();
                string cargoVan = "cargo Van";
                int unitsSideBySideCargoVan = 48 / CalculateWidth();
                int unitsHowHighCargoVan = 47 / CalculateHeight();
                int smallestOfWidth = Math.Min(unitsSideBySideCargoVan, CalculateUnit());
                int smallestOfHeight = Math.Min(unitsHowHighCargoVan, CalculateUnit());
                //int rowsUnit = CalculateUnit() / unitsSideBySideCargoVan;
                //int newUnitLength = rowsUnit * CalculateUnit();//calculated length user input unit length

                if (unitsSideBySideCargoVan == 1){
                    MessageBox.Show(cargoVan + calculationsFortruckMessage + " "
                 + smallestOfWidth + " units can fit side by side on this truck" + "\n units can be stacked " + smallestOfHeight +
                 " tall.");

                    return;
                }
                else if (unitsSideBySideCargoVan > 1)
                    {
                        MessageBox.Show(cargoVan + calculationsFortrucklength + " "
                     + smallestOfWidth + " units can fit side by side on this truck" + "\n units can be stacked " + smallestOfHeight +
                     " tall.");

                        return;

                }
            }

            ////sprinter van size Check LxWxh, verifys that weight is with in range
            else if (CalculateLength() <= 144 && CalculateWidth() <= 50 && CalculateHeight() <= 72 && CalculateWeight() <= 3000)
            {
                int vehicleHeight = 72 / CalculateHeight();
                string sprinterVan = "Sprinter";
                int unitsSideBySideSprinterVan = 50 / CalculateWidth();
                int unitsHowHighSprinterVan = 72 / CalculateHeight();
                int smallestOfWidth = Math.Min(unitsSideBySideSprinterVan, CalculateUnit());
                int smallestOfHeight = Math.Min(unitsHowHighSprinterVan, CalculateUnit());

                MessageBox.Show(sprinterVan + calculationsFortruckMessage + " "
                                + smallestOfWidth + " units can fit side by side on this truck" + "\n units can be stacked " + smallestOfHeight +
                                " tall.");

                return;

            }


            // 22ft  size Check LxWxh, verifys that weight is with in range
            else if (CalculateLength() <= 264 && CalculateWidth() <= 88 && CalculateHeight() <= 96 && CalculateWeight() < 13000)
            {
                int vehicleHeight = 96 / CalculateHeight();
                string twentyTwoFootStraightTruck = "22ft Straight Truck";
                int unitsSideBySideTwentyTwoFootStraightTruck = 102 / CalculateWidth();
                int unitsHowHighTwentyTwoFootStraightTruck = 96 / CalculateHeight();
                int smallestOfWidth = Math.Min(unitsSideBySideTwentyTwoFootStraightTruck, CalculateUnit());
                int smallestOfHeight = Math.Min(unitsHowHighTwentyTwoFootStraightTruck, CalculateUnit());

                MessageBox.Show(twentyTwoFootStraightTruck + calculationsFortruckMessage + " "
                                + smallestOfWidth + " units can fit side by side on this truck" + "\n units can be stacked " + smallestOfHeight +
                                " tall.");

                return;

            }

            //24ft size Check LxWxh, verifys that weight is with in range
            else if (CalculateLength() <= 288 && CalculateWidth() <= 102 && CalculateHeight() <= 96 && CalculateWeight() <= 13000)
            {
                int vehicleHeight = 96 / CalculateHeight();
                string twentyFourFootStraightTruck = "24ft Straight Truck";
                int unitsSideBySideTwentyFourFootStraightTruck = 102 / CalculateWidth();
                int unitsHowHighTwentyFourFootStraightTruck = 96 / CalculateHeight();
                int smallestOfWidth = Math.Min(unitsSideBySideTwentyFourFootStraightTruck, CalculateUnit());
                int smallestOfHeight = Math.Min(unitsHowHighTwentyFourFootStraightTruck, CalculateUnit());

                MessageBox.Show(twentyFourFootStraightTruck + calculationsFortruckMessage + " "
                                + smallestOfWidth + " units can fit side by side on this truck" + "\n units can be stacked " + smallestOfHeight +
                                " tall.");

                return;

            }
            //semi trailer size Check LxWxh, verifys that weight is with in range
            else if (CalculateLength() <= 636 && CalculateWidth() <= 102 && CalculateHeight() <= 108 && CalculateWeight() <= 45000)
            {
                int vehicleHeight = 108 / CalculateHeight();
                string semi = "Full truck load Semi";
                int unitsSideBySideSemi = 102 / CalculateWidth();
                int unitsHowHighSemi = 108 / CalculateHeight();
                int smallestOfWidth = Math.Min(unitsSideBySideSemi, CalculateUnit());
                int smallestOfHeight = Math.Min(unitsHowHighSemi, CalculateUnit());

                MessageBox.Show(semi + calculationsFortruckMessage + " "
                                + smallestOfWidth + " units can fit side by side on this truck" + "\n units can be stacked " + smallestOfHeight +
                                " tall.");

                return;

            }


        }

        //stackable checked box if checked do equation verifying how many units fit height

        //TODO: if this will cause reduced length, check if a smaller truck might work but verify that
        //while the lentgh is reduced Double check that the width of the smaller truck will still work. 
        // this will catch all exceptions to the rule.
        public void stackable_CheckedChanged(object sender, EventArgs e)
        {
            int Height = 0;
            int vehicleHeight = 0;

            if (stackable.Checked == false)
            {
                try
                {
                    Height = int.Parse(heightTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("You have not typed in an integer.");
                }
            }
            else if (stackable.Checked == true)
            {
                try
                {
                    Height = vehicleHeight / int.Parse(heightTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("You have not typed in an integer.");
                }
            }
        }

    }
}

       










