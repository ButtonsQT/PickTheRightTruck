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
        //*******TODO:superfluous ADDITION DO AT WILL: (this will need to be edited and modulus needed to extract information need to make modulus a whole number
        //for equation. see ELSE IF For needed fix)
        public void stackable_CheckedChanged(object sender, EventArgs e)
        {
            int Height = 0;


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
                    int unitsStacked = 0;
                    Height = int.Parse(heightTextBox.Text) * 2; // UnitsStacked();
                }
                catch
                {
                    MessageBox.Show("You have not typed in an integer.");
                }
            }
        }

        //calculations for height,length,and weight
        public int CalculateHeight()
        {
            int h = int.Parse(heightTextBox.Text);

            if (stackable.Checked) h = h * 2;
            return h;
        }

        public int CalculateWeight()
        {
            int weight = int.Parse(weightTextBox.Text);
            return weight;
        }
        public int CalculateLength()
        {
            int l = int.Parse(lengthTextBox.Text);
            int w = int.Parse(widthTextBox.Text);
            int u = int.Parse(unitTextbox.Text);
            int biggestNumber = 0;

            if (l <= w)
            {
                biggestNumber = l;
                // return biggestNumber;
            }

            else if (l > w)
            {

                biggestNumber = w;
                //  return biggestNumber;
            }
            return biggestNumber * u;
        }

        public int CalculateWidth()
        {
            int l = int.Parse(lengthTextBox.Text);
            int w = int.Parse(widthTextBox.Text);
            int smallestNumber = 0;

            if (l >= w)
            {
                smallestNumber = l;
                return smallestNumber;
            }
            else if (l <= w)
            {
                smallestNumber = w;
                return smallestNumber;
            }
            return smallestNumber*1;
        }



        // this button click activates the program to run equations

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
         

            if (CalculateLength() <= 108 && CalculateWidth() <= 48 && CalculateHeight() <= 2000)
                
            {
                int unitsSideBySideCargoVan =   48/ CalculateWidth();
                string cargoVan = "cargo Van";
                


                MessageBox.Show(cargoVan + calculationsFortruckMessage+" " + unitsSideBySideCargoVan + " units can fit side by side on this truck");

                    return;
                
            }

            ////sprinter van size check lxwxh
            else if (CalculateLength() <= 144 && CalculateWidth() * 2 < 50 && CalculateWeight() < 3000)
            {
            int unitsSideBySideSprinter = 50 / CalculateWidth();
            string sprinter = "sprinter";



            MessageBox.Show(sprinter + calculationsFortruckMessage + " " + unitsSideBySideSprinter + " units can fit side by side on this truck");

            return;

            }

           // 22ft  
            else if (CalculateLength() <= 264 && CalculateWidth() * 2 < 102 && CalculateWeight() < 13000)
            {
                int unitsSideBySideTwentTwo = 88 / CalculateWidth();
                string twentyTwoStraight = "22FT straight truck";



                MessageBox.Show(twentyTwoStraight + calculationsFortruckMessage + " " + unitsSideBySideTwentTwo + " units can fit side by side on this truck");

                return;
                }

            //24ft 
            else if (CalculateLength() <= 288 && CalculateWidth() * 2 < 102 && CalculateWeight() < 13000)
            {
                int unitsSideBySidetwentyFourStraight = 50 / CalculateWidth();
                string twentyFourStraight = "24FT straight truck";



                MessageBox.Show(twentyFourStraight + calculationsFortruckMessage + " " + unitsSideBySidetwentyFourStraight + " units can fit side by side on this truck");

                return;

            }
            //semi trailer needed
            else if (CalculateLength() <= 636 && CalculateWidth() * 2 < 102 && CalculateWeight() < 45000)
            {
                int unitsSideBySideSemi = 50 / CalculateWidth();
                string semi = "Full truck load semi";



                MessageBox.Show(semi + calculationsFortruckMessage + " " + unitsSideBySideSemi + " units can fit side by side on this truck");

                return;

            }

        }


    }
}

       










