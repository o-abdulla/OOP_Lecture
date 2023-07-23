// OOP Lecture

using OOPLecture;

Pen myPen = new Pen("Blue", "Pilot", "Gel", 1.50m, 5);
myPen.Color = "Blue";
myPen.Brand = "Pilot";
myPen.InkType = "Gel";
myPen.Price = 1.50m;
myPen.Length = 5;

Pen myPen2 = new Pen("Red", "Bic", "Gel", .75m, 5);
myPen2.Color = "Red";
myPen2.Brand = "Bic";
myPen2.InkType = "Gel";
myPen2.Price = 0.75m;
myPen2.Length = 5;

Pen myPen3 = new Pen("Black", "Pilot", "Gel", 1.50m, 6.5f);
Console.WriteLine(myPen.Color);
Console.WriteLine(myPen2.Color);

myPen.Draw();
myPen2.Draw();

//array/lists
List<Pen> CupOfPens = new List<Pen>()
{
    myPen, // use objects
    myPen2,
    myPen3,
    new Pen("Pink", "Sharpie", "Ball point", 5, 6.3f) // generate new ones
};

foreach (Pen singlePen in CupOfPens)
{
    DisplayPenDetails(singlePen);
    singlePen.Draw();
}
//--------------------------------------------------------------------
//Bank section
Bank myBank = new Bank(5);
myBank.Deposit(10);
Console.WriteLine(myBank.GetBalance());
Console.WriteLine(myBank.Withdraw(1000));
//--------------------------------------------------------------------

//New car not in list
Cars myCar1 = new Cars("Green", "Jeep", "SUV");
myCar1.Color = "Green";
myCar1.Brand = "Jeep";
myCar1.Size = "SUV";

Console.WriteLine(myCar1.Color, myCar1.Size);

//Car section using List
List<Cars> manyCars = new List<Cars>()
{
    new Cars("Red", "Toyota", "SUV"),
    myCar1,


};
Console.WriteLine(manyCars[0].Color);


foreach (Cars car in manyCars)
{
    car.DriveFast();
}




//---------------------------------------------------------------------------------------------------
//methods
static void DisplayPenDetails(Pen inputPen)
{
    Console.WriteLine($"{inputPen.Brand} {inputPen.Color} {inputPen.InkType} {inputPen.Length} inches ${inputPen.Price}");
}


