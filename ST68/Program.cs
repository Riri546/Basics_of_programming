//Set the values of M and N. Write a program that finds the sum of natural elements in the range from M to N.

Console.Clear();

int numberM = ReadData("Set the number M: ");
int numberN = ReadData("Set the number N: ");


int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine() ?? "");
}


void SumNuturalNumber (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum += (++m);
    SumNuturalNumber(numberM, numberN, sum);
}

SumNuturalNumber(numberM, numberN, 0);
