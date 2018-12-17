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
            //TODO: at this time width unit output shows max possible with out considering actual units avalible
            // need to disply what ever size is smallest 
            // display output desired = totalunits || how many fit side by side what ever number is the lesser of the two.
            //Cargo van size Check LxWxh, verifys that weight is with in range
            if(CalculateLength() <= 108 && CalculateWidth() <= 48 && CalculateHeight() <= 47 && CalculateWeight() <= 2000)
            {
                int vehicleHeight = 47 / CalculateHeight();
                int x =0;
                int unitsSideBySideCargoVan = 48 / CalculateWidth();
                string cargoVan = "cargo Van";

                MessageBox.Show(cargoVan + calculationsFortruckMessage + " " 
                                + unitsSideBySideCargoVan + " units can fit side by side on this truck"+ "\n units can be stacked " + vehicleHeight + 
                                " tall.");

                return;

            }

            ////sprinter van size Check LxWxh, verifys that weight is with in range
            else if (CalculateLength() <= 144 && CalculateWidth() <= 50 && CalculateHeight() <= 50 && CalculateWeight() <= 3000)
            {
            int unitsSideBySideSprinter = 50 / CalculateWidth();
            string sprinter = "sprinter";

            MessageBox.Show(sprinter + calculationsFortruckMessage + " " + unitsSideBySideSprinter + " units can fit side by side on this truck");

            return;

            }


            // 22ft  size Check LxWxh, verifys that weight is with in range
            else if (CalculateLength() <= 264 && CalculateWidth() <= 102 && CalculateHeight() <= 96 && CalculateWeight() < 13000)
            {
                int unitsSideBySideTwentTwo = 102 / CalculateWidth();
                string twentyTwoStraight = "22FT straight truck";



                MessageBox.Show(twentyTwoStraight + calculationsFortruckMessage + " " + unitsSideBySideTwentTwo + " units can fit side by side on this truck");

                return;
            }

            //24ft size Check LxWxh, verifys that weight is with in range
            else if (CalculateLength() <= 288 && CalculateWidth() <= 102 && CalculateHeight() <= 96 && CalculateWeight() <= 13000)
            {
                int unitsSideBySidetwentyFourStraight = 102 / CalculateWidth();
                string twentyFourStraight = "24FT straight truck";



                MessageBox.Show(twentyFourStraight + calculationsFortruckMessage + " " + unitsSideBySidetwentyFourStraight + " units can fit side by side on this truck");

                return;

            }
            //semi trailer size Check LxWxh, verifys that weight is with in range
            else if (CalculateLength() <= 636 && CalculateWidth() <= 102 && CalculateHeight() <= 108 && CalculateWeight() <= 45000)
            {
                int unitsSideBySideSemi = 102 / CalculateWidth();
                string semi = "Full truck load semi";



                MessageBox.Show(semi + calculationsFortruckMessage + " " + unitsSideBySideSemi + " units can fit side by side on this truck");

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

       










