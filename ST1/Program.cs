//Write a program that takes two numbers as input and checks whether the first number is the square of the second.

Console.Clear();

int inputNumberOne;
int inputNumberTwo;
int t;

//The method takes a number from the console
void ReadNumber()
{
Console.WriteLine("Let's check if the first number is the square of the second one?))");

Console.Write("Enter the first number: ");
string inputLineOne = Console.ReadLine() ?? "";
inputNumberOne = int.Parse(inputLineOne);

Console.Write("Enter the second number: ");
string inputLineTwo = Console.ReadLine() ?? "";
inputNumberTwo = int.Parse(inputLineTwo);
}

//The method solves in a simple way
void ConculateSimple()
{
    if (inputNumberOne == inputNumberTwo * inputNumberTwo)
    {
        t = Environment.TickCount;
        Console.WriteLine("Simple solution: Constitute");
        Console.WriteLine("Simple solution time: {0} ms", Environment.TickCount - t);
    }
    else
    {
        t = Environment.TickCount;
        Console.WriteLine("Simple solution: Is not");
        Console.WriteLine("Simple solution time: {0} ms", Environment.TickCount - t);
    }
}

//The method solves using Math
void ConculateMath()
{
    if (inputNumberTwo == Math.Sqrt(inputNumberOne))
    {
        t = Environment.TickCount;
        Console.WriteLine("Math solution: Constitute");
        Console.WriteLine("Math solution time: {0} ms", Environment.TickCount - t);
    }
    else
    {
        t = Environment.TickCount;
        Console.WriteLine("Math solution: Is not");
        Console.WriteLine("Math solution time: {0} ms", Environment.TickCount - t);
    }
}

ReadNumber();
ConculateSimple();
ConculateMath();