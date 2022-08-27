//Specify a two-dimensional array. 
//Write a program that will sort the elements of each row of a two-dimensional array in descending order.

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
            outArray[i, j] = numberSyntezator.Next(0, 100);
        }
    }
    return outArray;
}

//The method prints an array in green
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

//The method of sorting the array in descending order
int[,] OrderArrayLines(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            for (int k = 0; k < inputArray.GetLength(1) - 1; k++)
            {
                if (inputArray[i, k] < inputArray[i, k + 1])
                {
                    int temp = inputArray[i, k + 1];
                    inputArray[i, k + 1] = inputArray[i, k];
                    inputArray[i, k] = temp;
                }
            }
        }
    }
    return inputArray;
}

//The body of the task, launches the ce methods
void Result()
{
    DateTime d1 = DateTime.Now;

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Исходный массив: ");
    Console.ResetColor();

    int[,] twoDimArray = FillTowDimArray(3, 3);
    PrintColorTwoDimArray(twoDimArray);
    
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Отсортированный массив: ");
    Console.ResetColor();

    int[,] resultArray = OrderArrayLines(twoDimArray);
    PrintColorTwoDimArray(resultArray);
    
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Solution time: ");
    Console.ResetColor();
    Console.WriteLine(DateTime.Now - d1);
}

Result();