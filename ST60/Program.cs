//Specify two matrices. Write a program that will find the product of two matrices.

Console.Clear();

//The method creates the first two-dimensional array
int[,] FerstTowDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();

    int[,] ferstInputArray = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            ferstInputArray[i, j] = numberSyntezator.Next(0, 100);
        }
    }
    return ferstInputArray;
}

//The method creates the second two-dimensional array
int[,] SecondTowDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();

    int[,] secondInputArray = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            secondInputArray[i, j] = numberSyntezator.Next(0, 100);
        }
    }
    return secondInputArray;
}

//The method prints an array 
void PrintTwoDimArray(int[,] inputArray)
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

//The method multiplies the first array by the second, provided that their lengths are equal
int[,] MultiplyingArrays(int[,] ferstInputArray, int[,] secondInputArray)
{
    int[,] resultArray = new int[ferstInputArray.GetLength(0), ferstInputArray.GetLength(1)];

    for (int i = 0; i < ferstInputArray.GetLength(0); i++)
    {
        for (int j = 0; j < ferstInputArray.GetLength(1); j++)
        {
            resultArray[i, j] = ferstInputArray[i, j] * secondInputArray[i, j];
        }
    }
    return resultArray;
}

//The body of the task, launches the ce methods
void Result()
{
    int[,] ferstArray = FerstTowDimArray(3, 3);
    int[,] secondArray = SecondTowDimArray(3, 3);
    int[,] result = MultiplyingArrays(ferstArray, secondArray);

    Console.WriteLine("The first array: ");
    PrintTwoDimArray(ferstArray);
    Console.WriteLine();

    Console.WriteLine("The second array: ");
    PrintTwoDimArray(secondArray);
    Console.WriteLine();

    if (ferstArray.GetLength(0) == secondArray.GetLength(0)
    && ferstArray.GetLength(1) == secondArray.GetLength(1))
    {
        Console.WriteLine("Result array: ");
        PrintTwoDimArray(result);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error");
        Console.ResetColor();
    }
}

Result();