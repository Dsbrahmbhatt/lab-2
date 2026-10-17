const double TAX_RATE = 0.18;
const int SLICES_PER_PIZZA = 8;

Console.Write("Round trip miles: ");
double miles = Convert.ToDouble(Console.ReadLine());

Console.Write("Miles per gallon: ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("Price per gallon: ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("How many pizzas: ");
int pizzas = Convert.ToInt32(Console.ReadLine());

Console.Write("Price per pizza: ");
double pizzaPrice = Convert.ToDouble(Console.ReadLine());

double fuelCost = FuelCost(miles, milesPerGallon, pricePerGallon);
double pizzaCost = pizzas * pizzaPrice;
double tripTotal = fuelCost + pizzaCost;

Console.WriteLine("\n=== Part 1: The Trip ===");
Console.WriteLine($"Fuel cost: ${fuelCost:F2}");
Console.WriteLine($"Pizza cost: ${pizzaCost:F2}");
Console.WriteLine($"Trip total: ${tripTotal:F2}");

string[] names = { "Ada", "Grace", "Alan", "Katherine" };
double[] hoursWorked = { 22, 15, 30, 18 };
double[] hourlyRates = { 13.50, 16.00, 11.20, 14.80 };

double totalSlices = SLICES_PER_PIZZA * pizzas;
double slicesPerPerson = totalSlices / names.Length;
double costPerPerson = tripTotal / names.Length;

Console.WriteLine("\n=== Part 2: The Group ===");
Console.WriteLine($"People going: {names.Length}");
Console.WriteLine($"Slices each: {slicesPerPerson:F1}");
Console.WriteLine($"Cost per person: ${costPerPerson:F2}");

Console.WriteLine("\n=== Part 3: Who Works How Long ===");

double totalHours = 0;
double totalTakeHomePay = 0;
double longest = 0;

for (int i = 0; i < names.Length; i++)
{
    double takeHome = TakeHomePay(hoursWorked[i], hourlyRates[i], TAX_RATE);
    double takeHomePerHour = takeHome / hoursWorked[i];
    double hoursNeeded = HoursToCover(costPerPerson, takeHomePerHour);

    totalHours += hoursWorked[i];
    totalTakeHomePay += takeHome;
    longest = Math.Max(longest, hoursNeeded);

    Console.WriteLine($"{names[i]}: takes home ${takeHome:F2} for {hoursWorked[i]} hours, ${takeHomePerHour:F2} per hour, must work {hoursNeeded:F2} hours");
}

Console.WriteLine($"Total hours worked: {totalHours:F0}");
Console.WriteLine($"Total take home pay: ${totalTakeHomePay:F2}");
Console.WriteLine($"Longest anyone must work: {longest:F2}");

static double FuelCost(double miles, double milesPerGallon, double pricePerGallon)
{
    double gallonsNeeded = miles / milesPerGallon;
    return gallonsNeeded * pricePerGallon;
}

static double TakeHomePay(double hours, double hourlyRate, double taxRate)
{
    double grossPay = hours * hourlyRate;
    double taxWithHeld = grossPay * taxRate;
    return grossPay - taxWithHeld;
}

static double HoursToCover(double amountOwed, double takeHomePerHour)
{
    return amountOwed / takeHomePerHour;
}
