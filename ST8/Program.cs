//Write a program that takes a number (N) as input, and shows all even numbers from 1 to N as output.

Console.Clear();

int inputNumber;
int B;
string line;

int t;

//The method takes a number from the console
void ReadNumber()
{
    Console.Write("Enter an integer: ");
    string inputLine = Console.ReadLine() ?? "";
    inputNumber = int.Parse(inputLine);
}

//Solving the problem
void ConculateSimple()
{
    if (inputNumber < 1)
    {
        t = Environment.TickCount;
        Console.Write("This number is less than 1, enter another number");
        Console.WriteLine("Solution time: {0} ms", Environment.TickCount - t);
    }
    else
    {
        B = 2;

        line = "";

        while (B <= inputNumber - 2)
        {

            line = line + B + ", ";

            B = B + 2;
        }
        line = line + B;
        t = Environment.TickCount;
        Console.WriteLine("All even numbers from 1 to " + inputNumber + ": ");

        Console.WriteLine(line);
        Console.WriteLine("Solution time: {0} ms", Environment.TickCount - t);
    }
}

ReadNumber();
ConculateSimple();