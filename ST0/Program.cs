//Write a program that takes a number as input and outputs its square (a number multiplied by itself).

Console.Clear();

int inputNumber;
int outNumber;
int t;

DateTime timePoint = DateTime.Now;

//The method takes a number from the console
void ReadNumber()
{
    Console.WriteLine("Welcome, here you can find the square of any number quickly and easily!)))");
    Console.Write("Enter a number: ");
    string inputLine = Console.ReadLine() ?? "";
    inputNumber = int.Parse (inputLine);
}

//The method squares the number
void ConculateSimple()
{
    ///int outNumber = inputNumber*inputNumber;
    outNumber = (int)Math.Pow(inputNumber,2);
}

//The method outputs the result of the solution
void PrintResult()
{
    t = Environment.TickCount;
    Console.WriteLine("The square of the number: " + outNumber);
    Console.WriteLine("Solution time: {0} ms", Environment.TickCount - t);
}

ReadNumber();
ConculateSimple();
PrintResult();
