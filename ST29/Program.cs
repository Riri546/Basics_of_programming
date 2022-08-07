//Write a program that accepts a number as input and outputs the sum of the digits in the number.

Console.Clear();

int firstNumber;
int secondNumber;
int t;

void Read()
{
    Console.Write("Plese, enter number: ");
    string inputNumber = Console.ReadLine() ?? "";
    firstNumber = int.Parse(inputNumber);

    secondNumber = 0;
}

void Conculate()
{
    for (int i = 0; firstNumber > 0; i++)
    {
        secondNumber = secondNumber + firstNumber%10;

        firstNumber=firstNumber/10;
    }
    t = Environment.TickCount;
    Console.WriteLine("Solution: " + secondNumber);
    Console.WriteLine("Solution time: {0} ms", Environment.TickCount - t);
}

Read();
Conculate();