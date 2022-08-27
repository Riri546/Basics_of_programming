//Specify a two-dimensional array of integers. 
//Write a program that will delete the row or column at the intersection of which the smallest array is located.

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

//Solution task 56
int[,] Update2_DArray(int[,] inputArray, int row, int column)
{
    Console.WriteLine();
    int[,] outArray = new int[inputArray.GetLength(0) - 1, inputArray.GetLength(1) - 1];

    int k = 0; int m = 0;

    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        m = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (i != row && j != column)
            {
                outArray[k, m] = inputArray[i, j];
            }

            if (j != column) m++;
        }
        if (i != row) k++;
    }
    return outArray;
}

//Print solution task 56
int[] FindMinElement(int[,] matrix)
{
    int[] array = new int[] { 0, 0 };
    int minElement = int.MaxValue;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minElement)
            {
                minElement = matrix[i, j];

                array[0] = i;
                array[1] = j;
            }
        }
    }
    return array;
}

//The body of the task, launches the ce methods
void Result()
{
    DateTime d1 = DateTime.Now;

    Console.ForegroundColor = ConsoleColor.Magenta;
    int[,] twoDimArray = FillTowDimArray(5, 5);
    PrintColorTwoDimArray(twoDimArray);
    Console.ResetColor();

    Console.WriteLine();

    int[] indexes = FindMinElement(twoDimArray);
    Console.WriteLine(indexes[0] + " " + indexes[1]);

    Console.ForegroundColor = ConsoleColor.Blue;
    int[,] buferTwoDimArray = Update2_DArray(twoDimArray, indexes[0], indexes[1]);
    PrintColorTwoDimArray(buferTwoDimArray);
    Console.ResetColor();

    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Solution time: ");
    Console.ResetColor();
    Console.WriteLine(DateTime.Now - d1);
}

Result();
