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
    if (n == m +1 ) return;
    {
        Console.Write(m + " ");
        NuturalNumberPrinter(m + 1, n);
    }
}

NuturalNumberPrinter(numberM, numberN);

int Sum(int m, int n)
{
    int sum = 0;

    if (m - 1 == n) return 1;
    {
        sum += m;
        Console.Write(m + " ");
        Sum(m + 1, n);
    }
    Console.WriteLine(sum);
    return sum;
}