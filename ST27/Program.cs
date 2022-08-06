Console.Clear();

System.Random numberSintezator = new Random();

void VariantNaive()
{
    int i = 0;
    while (i < 8)
    {
        Console.Write(numberSintezator.Next(0, 2));
        i++;
    }
}


VariantNaive();