//Write a program that accepts a three-digit number as input and shows the last digit of this number as output.

Console.Clear();

string inputLine;
int inputNumber;
int outputNumber;
string lastNum;
int t;

//The method takes a number from the console
void ReadNumber()
{
    Console.Write("Enter a three-digit number:");
    inputLine = Console.ReadLine() ?? "";
    inputNumber = int.Parse(inputLine);
}

//The method solves by using the remainder of the division
void ConculateNaive()
{
    outputNumber = inputNumber % 10;
}

//The method solves when Substring
void ConculateSimple()
{
    lastNum = inputLine.Substring(2, 1);
}

//The method outputs the result of the solution
void PrintResult()
{
    t = Environment.TickCount;
    Console.WriteLine("Solution naive: " + outputNumber);
    Console.WriteLine("Solution naive time: {0} ms", Environment.TickCount - t);

    t = Environment.TickCount;
    Console.WriteLine("Solution simple: " + lastNum);
    Console.WriteLine("Solution simple time: {0} ms", Environment.TickCount - t);
}

ReadNumber();
ConculateNaive();
ConculateSimple();
PrintResult();