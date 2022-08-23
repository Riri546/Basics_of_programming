//Specify a two-dimensional array of integers. Find the arithmetic mean of the elements in each column.3

Console.Clear();

int n;
int m;

//The method creates an array
double[,] CreatingAnArray()
{
    Console.WriteLine("Enter n:");
    n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter m:");
    m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

    double[,] inputArray = new double[n, m];

    Random numberSyntezator = new Random();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            inputArray[i, j] = numberSyntezator.Next(0, 100);

            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return inputArray;
}

//The method finds the arithmetic mean
double[] ArithmeticMean(double[,] inputArray)
{
    Console.WriteLine();
    double[] sum = new double[m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            sum[i] += inputArray[j, i];
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"Сolumn № {i + 1}:  ");
        Console.ResetColor();

        Console.WriteLine($"{(sum[i] / n)}");
    }
    return sum;
}


double[,] resultArray = CreatingAnArray();
ArithmeticMean(resultArray);
