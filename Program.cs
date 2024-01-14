Console.WriteLine("Welcome to calculator! Enter values.");

Console.Write("First number: ");
string firstValue = Console.ReadLine();
Console.Write("Second number: ");
string secondValue = Console.ReadLine();

Console.WriteLine("Converting values in progress...");
decimal firstNumber = Convert.ToDecimal(firstValue);
decimal secondNumber = Convert.ToDecimal(secondValue);

Console.WriteLine("Calculating results..."); 
Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");