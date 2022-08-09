//Write a program that accepts two numbers as input and outputs which number is larger and which is smaller.

Console.Clear();

int A;
int B;
int t;

//The method takes a number from the console
void ReadNumber()
{
    Console.WriteLine("Enter two numbers and I'll tell you more");

    Console.Write("Enter the first number: ");
    string inputLineOne = Console.ReadLine() ?? "";
    A = int.Parse(inputLineOne);


    Console.Write("Enter the second number: ");
    string inputLineTwo = Console.ReadLine() ?? "";
    B = int.Parse(inputLineTwo);
}

//Solving the problem
void ConculateSimple()
{

    if (A == B)
    {
        t = Environment.TickCount;
        Console.WriteLine("The numbers are equal!");
        Console.WriteLine("Solution time: {0} ms", Environment.TickCount - t);
    }

    else
        if (A > B)
    {
        t = Environment.TickCount;
        Console.WriteLine("The first number is larger!");
        Console.WriteLine("Solution time: {0} ms", Environment.TickCount - t);
    }
    else
    {
        t = Environment.TickCount;
        Console.WriteLine("The second number is larger!");
        Console.WriteLine("Solution time: {0} ms", Environment.TickCount - t);
    }
}
    
ReadNumber();
ConculateSimple();