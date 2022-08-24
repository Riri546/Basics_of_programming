//Set a two-dimensional array. Write a program that swaps the first and last row of the array

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
    Console.ForegroundColor = ConsoleColor.Green;

    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.Write("\n");
    }
    Console.ResetColor();
}

//The method swaps the first and the next line
int[,] RotateFirstLast(int[,] inputArray)
{
    Console.WriteLine();

    int buferElement = 0;
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        buferElement = inputArray[0, j];
        inputArray[0, j] = inputArray[inputArray.GetLength(0) - 1, j];
        inputArray[inputArray.GetLength(0) - 1, j] = buferElement;
    }
    return inputArray;
}


DateTime d1 = DateTime.Now;

int[,] twoDimArray = FillTowDimArray(3, 4);
PrintColorTwoDimArray(twoDimArray);

Console.WriteLine();

PrintColorTwoDimArray(RotateFirstLast(twoDimArray));

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Solution time: ");
Console.ResetColor();
Console.WriteLine(DateTime.Now - d1);




