namespace truckCalculator1
{

    //all code below holds all of the code I tried to make work while figuring this program out.
    //this is my first real program that I have built with the intent of a user other then myself.
    //This is the first time I built any type of sophisticated program and my first time using c#.
    // today is 12/17/18--


    //- Dear future Pearl,
    //When you see this I hope you are not embarrassed.
    //I hope I make you proud. I know you will still love me and understand. I love you.
    //Youre enough, anything you do is enough.
    

    //public class truckType
    //{
    //    int length;
    //    int width;
    //    int weight;
    //    int height;
    //}
    //class truckTester
    //{
    //    static void main(string[] args)
    //    {
    //        truckType cargoVan = new truckType();
    //        truckType sprinter = new truckType();
    //        truckType twenty2FootStraight = new truckType();
    //        truckType twentyFourFootStraight = new truckType();
    //        truckType fullTruckVan = new truckType();

    //        cargoVan.length = CalculateLength();




    //    }

    //  }  




    //Declaring an object of type MyClass.
    //   private truckType CargoVan = new truckType();

    //Declaring another object of the same type, assigning it the value of the first object.
    //  truckType CargoVan = CalculateLength() <= 108 && CalculateWidth() * 2 <= 48 && calculateWeight() <= 2000;

    //    //cargo van size check lxwxh
    //    if (calculatelength() <= 108 && calculatewidth() * 2 <= 48 && calculateweight() <= 2000)
    //    {
    //      string truckType = "cargoVan";
    //        messagebox.show(string.format("cargo van needed the units can sit 2 per width "));
    //        messagebox.show("length" + " " + calculatelength() + " " +
    //                        "width" + " " + calculatewidth() + " " +
    //                        "height" + " " + calculateheight() + " " +
    //                        "weight" + " " + calculateweight() + " ");
    //        return;

    //    }
    //    else if (CalculateLength() <= 108 && CalculateWidth() <= 48 && calculateWeight() <= 2000)
    //    {

    //        MessageBox.Show(String.Format("Cargo van needed "));
    //        MessageBox.Show("length" + " " + CalculateLength() + " " +
    //                        "width" + " " + CalculateWidth() + " " +
    //                        "height" + CalculateHeight() + " " +
    //                        "weight" + " " + calculateWeight() + " ");
    //        //return;

    //    }
    ////sprinter van size check lxwxh
    //else if (CalculateLength() <= 144 && CalculateWidth()*2 < 50 && calculateWeight() < 3000)
    //{

    //    MessageBox.Show(String.Format("Sprinter van needed the units can sit 2 per width "));
    //    MessageBox.Show("length" + " " + CalculateLength() + " " +
    //                    "width" + " " + CalculateWidth() + " " +
    //                    "height" + CalculateHeight() + " " +
    //                    "weight" + " " + calculateWeight() + " ");
    //    return;

    //}
    //else if (CalculateLength() <= 144 && CalculateWidth() < 50 && calculateWeight() < 3000)
    //{

    //    MessageBox.Show(String.Format("Sprinter van needed"));
    //    MessageBox.Show("length" + " " + CalculateLength() + " " +
    //                    "width" + " " + CalculateWidth() + " " +
    //                    "height" + CalculateHeight() + " " +
    //                    "weight" + " " + calculateWeight() + " ");
    //    return;

    //}
    //// 22ft  
    //else if (CalculateLength() <= 264 && CalculateWidth() * 2 < 102 && calculateWeight() < 13000)
    //{

    //    MessageBox.Show(String.Format("22ft trailer needed the units can sit 2 per width "));
    //    MessageBox.Show("length" + " " + CalculateLength() + " " +
    //                    "width" + " " + CalculateWidth() + " " +
    //                    "height" + CalculateHeight() + " " +
    //                    "weight" + " " + calculateWeight() + " ");
    //    return;

    //}
    //else if (CalculateLength() <= 264 && CalculateWidth() < 102 && calculateWeight() < 13000)
    //{

    //    MessageBox.Show(String.Format("22 ft trailer van needed"));
    //    MessageBox.Show("length" + " " + CalculateLength() + " " +
    //                    "width" + " " + CalculateWidth() + " " +
    //                    "height" + CalculateHeight() + " " +
    //                    "weight" + " " + calculateWeight() + " ");
    //    return;

    //}
    ////24ft 
    //else if (CalculateLength() <= 288 && CalculateWidth() * 2 < 102 && calculateWeight() < 13000)
    //{

    //    MessageBox.Show(String.Format("24 ft trailer needed pallets fit 2 wide"));
    //    MessageBox.Show("length" + " " + CalculateLength() + " " +
    //                    "width" + " " + CalculateWidth() + " " +
    //                    "height" + CalculateHeight() + " " +
    //                    "weight" + " " + calculateWeight() + " ");
    //    return;

    //}
    //else if (CalculateLength() <= 288 && CalculateWidth() < 102 && calculateWeight() < 13000)
    //{

    //    MessageBox.Show(String.Format("24ft trailer needed"));
    //    MessageBox.Show("length" + " " + CalculateLength() + " " +
    //                    "width" + " " + CalculateWidth() + " " +
    //                    "height" + CalculateHeight() + " " +
    //                    "weight" + " " + calculateWeight() + " ");
    //    return;

    //}
    ////semi trailer needed
    //else if (CalculateLength() <= 636 && CalculateWidth() * 2 < 102 && calculateWeight() < 45000)
    //{

    //    MessageBox.Show(String.Format("full truck trailer needed units fit 2 wide"));
    //    MessageBox.Show("length" + " " + CalculateLength() + " " +
    //                    "width" + " " + CalculateWidth() + " " +
    //                    "height" + CalculateHeight() + " " +
    //                    "weight" + " " + calculateWeight() + " ");
    //    return;

    //}
    //else if (CalculateLength() <= 636 && CalculateWidth() < 102 && calculateWeight() < 45000)
    //{

    //    MessageBox.Show(String.Format("full truck trailer needed"));
    //    MessageBox.Show("length" + " " + CalculateLength() + " " +
    //                    "width" + " " + CalculateWidth() + " " +
    //                    "height" + CalculateHeight() + " " +
    //                    "weight" + " " + calculateWeight() + " ");
    //    return;






    //(CalculateLength() <= 108 && CalculateWidth()*2 <= 48 && calculateWeight() <= 2000)
    //public int calculateWeight()
    //{
    //    int weight = int.Parse(weightTextBox.Text);
    //    return weight;
    //}
    //public int CalculateLength()
    //{


    //    int l = int.Parse(lengthTextBox.Text);
    //    int w = int.Parse(widthTextBox.Text);
    //    int u = int.Parse(unitTextbox.Text);
    //    int biggestNumber = 0;

    //    if (l <= w)
    //    {
    //        biggestNumber = l;
    //        // return biggestNumber;
    //    }

    //    else if (l > w)
    //    {

    //        biggestNumber = w;
    //        //  return biggestNumber;
    //    }
    //    return biggestNumber * u;
    //}




    //public int CalculateWidth()
    //{
    //    int l = int.Parse(lengthTextBox.Text);
    //    int w = int.Parse(widthTextBox.Text);
    //    int u = int.Parse(unitTextbox.Text);
    //    int smallestNumber = 0;

    //    if (l >= w)
    //    {
    //        smallestNumber = l;
    //        //return biggestNumber;
    //    }

    //    else if (l < w)
    //    {

    //        smallestNumber = w;
    //        // return biggestNumber;
    //    }
    //    return smallestNumber * u;
    //}
    //TODO: Create cargovan method using below code for referance
    //cargo van size check lxwxh



    //(CalculateLength() <= 108 && CalculateWidth()*2 <= 48 && calculateWeight() <= 2000)

    //MessageBox.Show(String.Format("Cargo van needed the units can sit 2 per width "));
    //MessageBox.Show("length" + " " + CalculateLength() + " " +
    //                "width" + " " + CalculateWidth() + " " +
    //                "height" + CalculateHeight() + " " +
    //                "weight" + " " + calculateWeight() + " " );
    //return CargoVan;
    //}



    ////  TODO : Make method for calculation checking how many units will fit width based on truck
    //public int utruckSizeWidth()
    //{
    //    int UFW = CalculateWidth * truckSizeWidth;

    //    truck size width / modulous smallest number
    //unit needs to fit width
    //}


    ////  TODO : Make method for calculation checking how many units will fit width
    //public int unitsFitwidth()
    //{
    //    int UFW = CalculateWidth * truckSizeWidth;

    //truck size width / modulous smallest number
    //unit needs to fit width
    //}

    //  TODO : Make method for calculation checking trucktype
    //}
    //TODO: make message box method to shorten code
    // might be possible to use an array or Icompare method

    //    MessageBox.Show(String.Format("Cargo van needed the units can sit 2 per width "));
    //    MessageBox.Show("length" + " " + CalculateLength() + " " +
    //                    "width" + " " + CalculateWidth() + " " +
    //                    "height" + CalculateHeight() + " " +
    //                    "weight" + " " + calculateWeight() + " " );

    //public int UnitsStacked()
    //{
    //    int Stacked = truckTypeHeight / unitHeight;
    //}


    //public int FitOnside()
    //{
    //    int stackedHeight = 0;
    //    int vehicleHeight = 0;
    //    NewMethod(vehicleHeight);

    //    return stackedHeight;

    //    //take smallestnumber and find out how many fit in truck based on wideness of truck
    //}

    //public int vehicleHeight()
    //{
    //    int h = int.Parse(heightTextBox.Text);

    //    return heightOfVehicle;
    //}
}
