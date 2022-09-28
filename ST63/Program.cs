//Set the value to N.
// Write a program that outputs all natural numbers in the range from 1 to N.

Console.Clear();

int ReadData()
{
    Console.WriteLine("Set the number: ");
    return int.Parse(Console.ReadLine() ?? "");
}

int NuturalNumberPrinter(int num)
{
    if (num == 2) return 1;
    {
        num--;
        Console.WriteLine(num);
        Console.WriteLine(NuturalNumberPrinter(num) + " ");
    }
    return num;
}
int inputNumber = ReadData();
NuturalNumberPrinter(inputNumber);