using System.Reflection.Metadata;

//Console.Write("How many miles for your trip? ");
//double tripmiles = Convert.ToDouble(Console.ReadLine());

//Console.Write("How many miles per gallon can you car go");
//double milePerGallon = Convert.ToDouble(Console.ReadLine());

//Console.Write("how much did you pay for gas");
//double pricePeraGallon = Convert.ToDouble(Console.ReadLine());

//CALCILATION FOR PART 1 
//double gallonsNeeded = tripmiles / milePerGallon;
//double fuelCost = gallonsNeeded * pricePeraGallon;

//Print the calculations 
//system.Console.WriteLine("gallon needed: " + gallonsNeeded.ToString("F2"));
//system.Console.WriteLine("Fuel cost:" + fuelCost.ToString("C"));


//part 2 
Console.Write("How many people are going ");
double people = Convert.ToDouble(Console.ReadLine());

Console.Write("How many Pizzas ");
double pizzas = Convert.ToDouble(Console.ReadLine());

Console.Write("Prices Per Pizza ");
double pizzaPrice = Convert.ToDouble(Console.ReadLine());

const double Slices =8;


double totalslices = Slices *pizzas;
double slicesPerPerson = Slices/people;
double pizzaCost = pizzas*pizzaPrice;

System.Console.WriteLine("Total Slices: " + totalslices);
System.Console.WriteLine("Slices Per Person " + slicesPerPerson.ToString("F1") );
System.Console.WriteLine("Pizza cost " + pizzaCost.ToString("c"));

//part 3
Console.Write("Hours worked this week ");
double work = Convert.ToDouble(Console.ReadLine());
Console.Write("Hourly rate ");
double rate = Convert.ToDouble(Console.ReadLine());

const double Tax_Rate =.18;


double grosspay = work *rate;
double TaxWithHeld = grosspay*Tax_Rate;
double takeHomePay = grosspay-TaxWithHeld;

System.Console.WriteLine("grosspay: " + grosspay.ToString("c"));
System.Console.WriteLine("TaxWithHeld " + TaxWithHeld.ToString("c") );
System.Console.WriteLine("takeHomePay " + takeHomePay.ToString("c"));

//part4 

