//Fill the 4-by-4 array spirally.

Console.Clear();

//The method creates the first two-dimensional array
int[,] FerstTowDimArray()
{
    int n = 4;
    int[,] inputArray = new int[n, n];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= inputArray.GetLength(0) * inputArray.GetLength(1))
    {
        inputArray[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < inputArray.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= inputArray.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > inputArray.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return inputArray;
}

//Solution task 62
void ConculeteArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (inputArray[i, j] / 10 <= 0)
                Console.Write($" {inputArray[i, j]} ");

            else Console.Write($"{inputArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

//The body of the task, launches the ce methods
void Result()
{
    DateTime d1 = DateTime.Now;

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Spiral filling of the array: ");
    Console.ResetColor();

    int[,] newArray = FerstTowDimArray();
    ConculeteArray(newArray);

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Solution time: ");
    Console.ResetColor();
    Console.WriteLine(DateTime.Now - d1);
}

Result();