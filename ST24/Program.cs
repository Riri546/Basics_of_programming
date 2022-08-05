Console.Clear();

Console.Write("Enter number: ");

int inputNum = int.Parse(Console.ReadLine());
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