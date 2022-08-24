//Create a frequency dictionary of elements of a two-dimensional array. 
//The frequency dictionary contains information about. how many times do the input data elements occur

//array = [1, 2, 3, 4, 9, 7, 8, 1, 2, 1, 6, 5, 6]
//alphadet = [1, 2, 3, 4, 5, 6, 7, 8, 9]
//freqmency = [3,2,1,1...]

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
int[,] RotateTwoDimArray(int[,] inputArray)
{
    Console.WriteLine();

    int buferElement = 0;
    int i = 0;
    int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = i;
        while (j < inputArray.GetLength(0))
        {
            buferElement = inputArray[i, j];
            inputArray[i, j] = inputArray[j, i];
            inputArray[j, i] = buferElement;
            j++;
        }
        i++;
    }
    return inputArray;
}



//The body of the task, launches the ce methods
void Result()
{
    DateTime d1 = DateTime.Now;

    int[,] twoDimArray = FillTowDimArray(3, 3);
    PrintColorTwoDimArray(twoDimArray);

    if (twoDimArray.GetLength(0) != twoDimArray.GetLength(1))
    {
        Console.WriteLine();
        Console.WriteLine("This array inverts the error!");
    }
    else
    {
        PrintColorTwoDimArray(RotateTwoDimArray(twoDimArray));
    }

    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Solution time: ");
    Console.ResetColor();
    Console.WriteLine(DateTime.Now - d1);
}

Result();
