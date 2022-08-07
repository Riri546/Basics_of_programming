//Write a loop that takes two numbers (A and B) as input and raises the number A to the natural power of B.

Console.Clear();

Console.WriteLine("Enter two numbers and I will raise the first number to the power of the second");

int number1;
int number2;
int t;
int degreeAB;

void Read()
{
    Console.Write("Plese, enter first number: ");
    string firstNumber = Console.ReadLine() ?? "";
    number1 = int.Parse(firstNumber);

    Console.Write("Enter second number: ");
    string secondNumber = Console.ReadLine() ?? "";
    number2 = int.Parse(secondNumber);
}

//solution using the method
void VariantMethod()
{
    degreeAB = (int)Math.Pow(number1, number2);

    t = Environment.TickCount;
    Console.WriteLine("Solution using the method: " + degreeAB);
    Console.WriteLine("Solution using the method time: {0} ms", Environment.TickCount - t);
}

// Solution using a loop
void VariantCycle()
{
    degreeAB = 1;
    for (int i = 0; i < number2; i++)
    {
        degreeAB = degreeAB * number1;
    }

    t = Environment.TickCount;
    Console.WriteLine("Solution using a loop: " + degreeAB);
    Console.WriteLine("Solution using a loop time: {0} ms", Environment.TickCount - t);
}


Read();
VariantMethod();
VariantCycle();
