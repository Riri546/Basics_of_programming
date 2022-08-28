//Specify a rectangular two-dimensional array. 
//Write a program that will find the string with the smallest sum of elements.

Console.Clear();

//Method for filling a two-dimensional array
int[,] FillTowDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();

    int[,] outArray = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            outArray[i, j] = numberSyntezator.Next(0, 101);
        }
    }
    return outArray;
}

//The method prints an array in yellow
void PrintColorTwoDimArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.Write("\n");
    }
}

//The method outputs the index of the smallest element
int FindMinIndex(int[] inputArray)
{
    int index = 0; int min = inputArray[0]; int i = 0;

    while (i < inputArray.Length)
    {
        if (min > inputArray[i])
        {
            min = inputArray[i];
            index = i;
        }
        i++;
    }
    return index;
}

//The method counts the sum of elements in a row
int SummRows(int[,] inputArray, int row)
{
    int i = 0; int sum = 0;
    while (i < inputArray.GetLength(1))
    {
        sum += inputArray[row, i];
        i++;
    }
    return sum;
}

//The method outputs the row number with the smallest sum of elements
int FindRow(int[,] inputArray)
{
    int i = 0;
    int[] sum = new int[inputArray.GetLength(0)];
    while (i < inputArray.GetLength(0))
    {
        sum[i] = SummRows(inputArray, i);
        i++;
    }
    return FindMinIndex(sum) + 1;
}

//The body of the task, launches the ce methods
void Result()
{
    DateTime d1 = DateTime.Now;

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Source array: ");
    Console.ResetColor();

    int[,] twoDimArray = FillTowDimArray(3, 2);
    PrintColorTwoDimArray(twoDimArray);

    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("The number of the row with the smallest sum of elements: ");
    Console.ResetColor();
    Console.WriteLine(FindRow(twoDimArray));

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Sum of lines: ");
    Console.ResetColor();
    Console.WriteLine(SummRows(twoDimArray, 0));

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Solution time: ");
    Console.ResetColor();
    Console.WriteLine(DateTime.Now - d1);
}

Result();
