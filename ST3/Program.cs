//Write a program that takes one number (N) as input, and shows all integers in the range from -N to N as output.

Console.Clear();

int inputNumber;
int startNumber;
string lineOutput;

int t;

//The method takes a number from the console
void ReadNumber()
{
    Console.Write("Enter an integer: ");
    string inputLineOne = Console.ReadLine() ?? "";
    inputNumber = int.Parse(inputLineOne);
}

//The method solves in a simple way
void Conculate()
{
    startNumber = 1;

    lineOutput = "0";

        while (startNumber <= inputNumber)
        {
            lineOutput = startNumber*(-1)+", "+lineOutput+", "+startNumber;
            startNumber++;
        }
            
    //  lineOutput = lineOutput+inputNumber;
}

//The method outputs the result of the solution
void PrintResult()
{
    t = Environment.TickCount;
    Console.WriteLine(lineOutput);
    Console.WriteLine("Solution time: {0} ms", Environment.TickCount - t);
}

ReadNumber();
Conculate();
PrintResult();