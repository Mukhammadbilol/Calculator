string yesOrNo = "";
do
{
    Console.WriteLine("Enter values");

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

    Console.Write("Do you want to continue? [y/n]: ");
    yesOrNo = Console.ReadLine();
} while (yesOrNo.ToLower() == "y");

Console.WriteLine("Thank you for using our calculator!");
Console.WriteLine("Here is the multiplication table:");

for (int i = 2; i <= 10; i++)
{
    Console.WriteLine("**********");
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
}