Console.Clear();

Console.Write("Enter number: ");

int inputNum = int.Parse(Console.ReadLine());

//
void VariantSimpele()
{
    int sumOfNum = 0;
    for (int i = 1; i <= +inputNum; i++)
    {
        sumOfNum += i;

        //suOfNum = suOfNum + 1;
    }
    Console.WriteLine("Сумма чисел от 1 до " + inputNum + " = " + sumOfNum);
}

void VariantGauss()
{
    int sumOfNum = 0;

    sumOfNum = ((1 + inputNum) * inputNum) / 2;

    Console.WriteLine("Сумма чисел от 1 до " + inputNum + " = " + sumOfNum);
}

VariantSimpele();
VariantGauss();