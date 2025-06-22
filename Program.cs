/*
string first = "Hello";
string second = "world"; ;
// string result = string.Format("{0} {1}", first, second);
// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second);


// String interpolation
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");
Console.WriteLine();

// Formatting currency
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:c} (save {discount:c})"); // the `:c` formats the number as currency regardless of whether it's int or decimal.
Console.WriteLine();

// Formatting numbers
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units"); // by default, N numeric format specifier displays only two or three digits after the decimal point.
Console.WriteLine($"Measurement: {measurement:N5} units"); // if you want to display more (or less) precision. You do that by adding a number after the specifier eg. :N5 in this code line.
Console.WriteLine();

// Formating percentages
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}"); // use the P format specifier to format percentages and rounds to prefered precissions.
Console.WriteLine();

// Combining formatting approaches
decimal thePrice = 67.55m;
decimal salePrice = 59.99m;

String yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (thePrice - salePrice), thePrice);
yourDiscount += $"A discount of {((thePrice - salePrice) / thePrice):P2}!";
Console.WriteLine(yourDiscount);
Console.WriteLine();




// Program to print a receipt for the customer purchasing shares

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"  Shares: {productShares:N3} Product");
Console.WriteLine($"    Sub Total: {subtotal:c}");
Console.WriteLine($"        Tax: {taxPercentage:P2}");
Console.WriteLine($"    Total Billed: {total:c}");
*/

// Discovering padding and alignment
// Here's a brief list of categories of these built-in methods so you can get an idea of what's possible.

//   -> Methods that add blank spaces for formatting purposes (PadLeft(), PadRight())
//   -> Methods that compare two strings or facilitate comparison (Trim(), TrimStart(), TrimEnd(), GetHashcode(), the Length property)
//   -> Methods that help you determine what's inside of a string, or even retrieve just a part of the string (Contains(), StartsWith(), EndsWith(), Substring())
//   -> Methods that change the content of the string by replacing, inserting, or removing parts (Replace(), Insert(), Remove())
//   -> Methods that turn a string into an array of strings or characters (Split(), ToCharArray())

// // The PadLeft() method adds blank spaces to the left-hand side of the string.
// string input = "Pad this";
// // Console.WriteLine(input.PadLeft(12));
// // Console.WriteLine(input.PadRight(12));
// Console.Clear();
// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));

// // Working with padded strings
// // Add the Payment ID to the output
// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";

// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);

// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);

// Applying string interpolation to form letter
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Clear the console
Console.Clear();
// Your logic here
Console.WriteLine($"Dear {customerName},");
Console.WriteLine("As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine("");
Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.");
Console.WriteLine("");
Console.WriteLine($"Our new product, Glorious Future offers a return of {newReturn:P2}.  Given your current volume, your potential profits would be {newProduct:C2}");
Console.WriteLine("");
Console.WriteLine("Here's a quick comparison:\n");
// Console.WriteLine("");

var currentProductFormatted = currentProduct.PadRight(20);
currentProductFormatted += $"{currentReturn:P2}".PadRight(10);
currentProductFormatted += $"{currentProfit:C2}".PadLeft(20);

var newProductFormatted = newProduct.PadRight(20);
newProductFormatted += $"{newReturn:P2}".PadRight(10);
newProductFormatted += $"{newProfit:C2}".PadLeft(20);

Console.WriteLine(currentProductFormatted);
Console.WriteLine(newProductFormatted);

// string comparisonMessage = "";

// // Your logic here

// Console.WriteLine(comparisonMessage);