//
Console.Clear();

int numberM = ReadData("Set the number M: ");
int numberN = ReadData("Set the number N: ");

int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine() ?? "");
}

void NuturalNumberPrinter(int m, int n)
{
    if (m - 1 == n) return;
    {
        Console.Write(m + " ");
        NuturalNumberPrinter(m + 1, n);
    }
}

NuturalNumberPrinter(numberM, numberN);