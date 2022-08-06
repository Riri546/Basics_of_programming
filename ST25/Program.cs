Console.Clear();

Console.Write("Enter number: ");

string inputLineNumber = Console.ReadLine() ?? "";
int inputNum = int.Parse(inputLineNumber);

//VariantSimpele
int Variantchar()
{
    // int numberLength = 0;
    // char[] array = inputLineNumber.ToCharArray();
    // numberLength = array.Length;
    return inputLineNumber.ToCharArray().Length;
}

int VariantSimpele()
{
    int numberLength = 0;
    int digits = 1;

    while (digits < inputNum)
    {
        digits = digits * 10;
        numberLength++;
    }

    return numberLength;
}

int VariantLog10()
{
    return (int)Math.Log10(inputNum)+1;
}

int result = 0;
result = Variantchar();
Console.Write("Length variant chsr: ");
Console.WriteLine(result);

result = VariantSimpele();
Console.Write("Length variant simle: ");
Console.WriteLine(result);

result = VariantLog10();
Console.Write("Length variant log10: ");
Console.WriteLine(result);


