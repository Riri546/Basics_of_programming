//Set the values of M and N. Write a program that finds the sum of natural elements in the range from M to N.

Console.Clear();

int numberM = ReadData("Set the number M: ");
int numberN = ReadData("Set the number N: ");

int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine() ?? "");
}


// функция сумма чисел от M до N
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Answer: ");
Console.ResetColor();
SumMN(numberM, numberN);
