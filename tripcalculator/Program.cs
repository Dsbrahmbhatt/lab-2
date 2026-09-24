Console.Write("How many miles for your trip? ");
double tripmiles = Convert.ToDouble(Console.ReadLine());

Console.Write("How many miles per gallon can you car go");
double milePerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("how much did you pay for gas");
double pricePeraGallon = Convert.ToDouble(Console.ReadLine());

//CALCILATION FOR PART 1 
double gallonsNeeded = tripmiles / milePerGallon;
double fuelCost = gallonsNeeded * pricePeraGallon;

//Print the calculations 
Console.WriteLine("gallon needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel cost:" + fuelCost.ToString("C"));
