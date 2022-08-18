//Specify a two-dimensional array of size m×n filled with random integers.

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

//Method for printing a two-dimensional array
void PrintTwoDimArray(int[,] inpujitArray)
{
    for (int i = 0; i < inpujitArray.GetLength(0); i++)
    {
        for (int j = 0; j < inpujitArray.GetLength(1); j++)
        {
            Console.Write(inpujitArray[i, j] + " ");
        }
        Console.Write("\n");
    }
}

//The method prints an array in yellow
void PrintColorTwoDimArray(int[,] inpujitArray)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Yellow;

    for (int i = 0; i < inpujitArray.GetLength(0); i++)
    {
        for (int j = 0; j < inpujitArray.GetLength(1); j++)
        {
            Console.Write(inpujitArray[i, j] + " ");
        }
        Console.Write("\n");
    }
    Console.ResetColor();
}

int[,] twoDimArray = FillTowDimArray(5, 8);
PrintTwoDimArray(twoDimArray);
PrintColorTwoDimArray(twoDimArray);