Console.Clear();

Console.WriteLine("Is the second number a multiple of the first");

Console.Write("Enter the first number: ");
string? firstNumber = Console.ReadLine();

Console.Write("Enter the second number: ");
string? secondNumber = Console.ReadLine();

if (firstNumber!= null && secondNumber != null)
{
    int first = int.Parse(firstNumber);
    int second = int.Parse(secondNumber);

    int result = second%first;

    if (result == 0)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No, remains: " + result);
    }
}


