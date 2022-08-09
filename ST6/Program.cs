//Write a program that accepts three numbers as input and outputs the maximum of these numbers.

Console.Clear();

int A;
int B;
int C;

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


    Console.Write("Enter the third number: ");
    string inputLineThree = Console.ReadLine() ?? "";
    C = int.Parse(inputLineThree);
}

//Solving the problem
void ConculateSimple()
{
    if (A > B)
    {
        if (A > C)
        {
            t = Environment.TickCount;
            Console.WriteLine("The first number is larger!");
            Console.WriteLine("Solution time: {0} ms", Environment.TickCount - t);
        }
        else
        {
            t = Environment.TickCount;
            Console.WriteLine("The third number is larger!");
            Console.WriteLine("Solution time: {0} ms", Environment.TickCount - t);
        }
    }
    else
    {
        if (B > C)
        {
            t = Environment.TickCount;
            Console.WriteLine("The second number is larger!");
            Console.WriteLine("Solution time: {0} ms", Environment.TickCount - t);
        }
        else
        {
            t = Environment.TickCount;
            Console.WriteLine("The third number is larger!");
            Console.WriteLine("Solution time: {0} ms", Environment.TickCount - t);
        }
    }
}

ReadNumber();
ConculateSimple();