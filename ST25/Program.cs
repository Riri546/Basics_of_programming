//Write a program that accepts a number as input and outputs the number of digits in the number.

Console.Clear();

Console.Write("Enter number: ");

string inputLineNumber = Console.ReadLine() ?? "";
long inputNum = long.Parse(inputLineNumber);

DateTime timePoint = DateTime.Now;

//VariantSimpele
long Variantchar()
{
    // int numberLength = 0;
    // char[] array = inputLineNumber.ToCharArray();
    // numberLength = array.Length;
    return inputLineNumber.ToCharArray().Length;
}

long VariantSimpele()
{
    long numberLength = 0;
    long digits = 1;

    while (digits < inputNum)
    {
        digits = digits * 10;
        numberLength++;
    }

    return numberLength;
}

long VariantLog10()
{
    return (long)Math.Log10(inputNum) + 1;
}

long result = 0;

timePoint = DateTime.Now;
result = Variantchar();
Console.Write("Length variant chsr: ");
Console.WriteLine(result);
Console.WriteLine(DateTime.Now - timePoint);

timePoint = DateTime.Now;
result = VariantSimpele();
Console.Write("Length variant simle: ");
Console.WriteLine(result);
Console.WriteLine(DateTime.Now - timePoint);

timePoint = DateTime.Now;
result = VariantLog10();
Console.Write("Length variant log10: ");
Console.WriteLine(result);
Console.WriteLine(DateTime.Now - timePoint);


