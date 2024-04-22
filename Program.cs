Console.WriteLine("Welcome to calculator! Enter values.");

Console.Write("First number: ");
string firstValue = Console.ReadLine();

Console.Write("Operation [+, -, *, /, %]: ");
string operation = Console.ReadLine();

Console.Write("Second number: ");
string secondValue = Console.ReadLine();

Console.WriteLine("Converting values in progress...");
decimal firstNumber = Convert.ToDecimal(firstValue);
decimal secondNumber = Convert.ToDecimal(secondValue);

Console.WriteLine("Calculating results...");

string template = $"{firstNumber} {operation} {secondNumber} =";

decimal result = operation switch
{
    "+" => firstNumber + secondNumber,
    "-" => firstNumber - secondNumber,
    "*" => firstNumber * secondNumber,
    "/" => firstNumber / secondNumber,
    "%" => firstNumber % secondNumber,
    _ => 0
};

Console.WriteLine($"{template} {result}");