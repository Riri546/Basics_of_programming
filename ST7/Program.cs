//Write a program that takes a number 
//as input and outputs whether the number is even (whether it is divisible by two without remainder).

Console.Clear();

int inputNumber;
int outputNumber;

int t;

//The method takes a number from the console
void ReadNumber()
{
    Console.Write("Enter a number and I'll tell you if it's even: ");
    string inputLine = Console.ReadLine() ?? "";
    inputNumber = int.Parse(inputLine);
}

//Solving the problem
void ConculateSimple()
{
    outputNumber = inputNumber % 2;

    if (inputNumber % 2 == 0)
    {
        t = Environment.TickCount;
        Console.WriteLine("Even number");
        Console.WriteLine("Solution time: {0} ms", Environment.TickCount - t);
    }
    else
    {
        t = Environment.TickCount;
        Console.WriteLine("Odd number");
        Console.WriteLine("Solution time: {0} ms", Environment.TickCount - t);
    }
}

ReadNumber();
ConculateSimple();