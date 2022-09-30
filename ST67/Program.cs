//Set the values of M and N. Write a program that outputs all natural numbers in the range from M to N.
Console.Clear();

int numberM = ReadData("Set the number M: ");
int numberN = ReadData("Set the number N: ");

//Variable input method
int ReadData(string line)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(line);
    Console.ResetColor();
    return int.Parse(Console.ReadLine() ?? "");
}

//Recursive calculation method
void NuturalNumberPrinter(int m, int n)
{
    if (m - 1 == n) return;
    {
        Console.Write(m + " ");
        NuturalNumberPrinter(m + 1, n);
    }
}

//The body of the task, launches the ce methods
void Result()
{
    DateTime d1 = DateTime.Now;

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Answer: ");
    Console.ResetColor();
    NuturalNumberPrinter(numberM, numberN);
}

Result();

