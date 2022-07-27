Console.Clear();

Console.WriteLine("Is your number a multiple of 7 and 23?");

Console.Write("Enter number: ");
string? firstNumber = Console.ReadLine();

if (firstNumber!= null)
{
    int number= int.Parse(firstNumber);

    int resultNumber1 = number%7;

    if (resultNumber1 == 0)
    {
        Console.WriteLine("Yes, this number is a multiple of 7!");
    }
    else
    {
        Console.WriteLine("No , this number is not a multiple of 7: " + resultNumber1);
    }

    int resultNumber2 = number%23;

    if (resultNumber2 == 0)
    {
        Console.WriteLine("Yes, this number is a multiple of 23!");
    }
    else
    {
        Console.WriteLine("No , this number is not a multiple of 23: " + resultNumber2);
    }
}


