//Write a program that accepts a number (A) as input and outputs the sum of numbers from 1 to A.

Console.Clear();

Console.Write("Enter number: ");
string inputLineNumber = Console.ReadLine() ?? "";
int inputNum = int.Parse(inputLineNumber);

int t;

//VariantSimpele
void VariantSimpele()
{
    long sumOfNum = 0;
    for (long i = 1; i <= +inputNum; i++)
    {
        sumOfNum += i;

        //suOfNum = suOfNum + 1;
    }
    Console.WriteLine("Сумма чисел от 1 до " + inputNum + " = " + sumOfNum);
}

//VariantGauss
void VariantGauss()
{
    long sumOfNum = 0;

    sumOfNum = ((1 + inputNum) * inputNum) / 2;

    Console.WriteLine("Сумма чисел от 1 до " + inputNum + " = " + sumOfNum);
}

t = Environment.TickCount;
VariantSimpele();
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);

t = Environment.TickCount;
VariantGauss();
Console.WriteLine("Gauss time: {0} ms", Environment.TickCount - t);