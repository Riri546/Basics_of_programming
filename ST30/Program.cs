//Write a program that sets an array of 8 elements and displays them on the screen.

Console.Clear();

System.Random numberSintezator = new Random();
int t;

void VariantNaive()
{
    int i = 0;
    Console.Write("Solution: [");
    while (i < 8 - 1)
    {
        Console.Write(numberSintezator.Next(0,100) + ",");
        i++;
    }
    Console.Write(numberSintezator.Next(0,100));
    Console.WriteLine("]");
   
    t = Environment.TickCount;
    Console.WriteLine("Solution time: {0} ms", Environment.TickCount - t);

}


VariantNaive();
