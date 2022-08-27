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

int[] FindMinElement(int[,] inputArray)
{
    int[] array = new int[] { 0, 0 };
    int minElement = int.MaxValue;

    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (inputArray[i, j] < minElement)
            {
                minElement = inputArray[i, j];

                array[0] = i;
                array[1] = j;
            }
        }
    }
    Console.WriteLine("Min: " + minElement);
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




    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Solution time: ");
    Console.ResetColor();
    Console.WriteLine(DateTime.Now - d1);
}

Result();
