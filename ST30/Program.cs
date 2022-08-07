//Write a program that sets an array of 8 elements and displays them on the screen.

Console.Clear();

System.Random numberSintezator = new Random();

void VariantNaive()
{
    int i = 0;
    Console.Write("[");
    while (i < 8 - 1)
    {
        Console.Write(numberSintezator.Next(0,100) + ",");
        i++;
    }
    Console.Write(numberSintezator.Next(0,100));
    Console.Write("]");
}


VariantNaive();
