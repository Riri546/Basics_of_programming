//Write a loop that takes two numbers (A and B) as input and raises the number A to the natural power of B.

Console.Clear();

Console.WriteLine("Enter two numbers and I will raise the first number to the power of the second");

int number1;
int number2;
int t;

void Read()
{
    Console.Write("Plese, enter first number: ");
    string firstNumber = Console.ReadLine() ?? "";
    number1 = int.Parse(firstNumber);

    Console.Write("Enter second number: ");
    string secondNumber = Console.ReadLine() ?? "";
    number2 = int.Parse(secondNumber);
}


//Solution using the method
int VariantMethod(int degreeAB)
{
    degreeAB = (int)Math.Pow(number1,number2);

    return degreeAB;
}

void Time()
{
    t = Environment.TickCount;
    Console.WriteLine(VariantMethod());
    Console.WriteLine("Simple solution time: {0} ms", Environment.TickCount - t);
}


Read();
Time();
