Console.Clear();

int first;
int second;
int result;

//The method takes a number from the console
void ReadNumber()
{
    Console.WriteLine("Is the second number a multiple of the first?");

    Console.Write("Enter the first number: ");
    string firstNumber = Console.ReadLine() ?? "";
    first = int.Parse(firstNumber);

    Console.Write("Enter the second number: ");
    string secondNumber = Console.ReadLine() ?? "";
    second = int.Parse(secondNumber);
}

//Solving the problem
void ConculateSimple()
{
    result = first % second ;

    if (result == 0)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No, remains: " + result);
    }
}

ReadNumber();
ConculateSimple();
