//Specify a two-dimensional array. Find the elements that have both indexes even, and 
//replace these elements with their squares.

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

//The method prints an array in yellow
void PrintColorTwoDimArray(int[,] inputArray)
{
    Console.ForegroundColor = ConsoleColor.Yellow;

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

//The method solves the problem 48
int[,] UpdateTwoDimArray(int[,] inputArray)
{
    Console.WriteLine();

    int[,] outArray = new int[inputArray.GetLength(0), inputArray.GetLength(1)];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                outArray[i, j] = inputArray[i, j] * inputArray[i, j];
            }
            else
            {
                outArray[i, j] = inputArray[i, j];
            }
        }
    }
    return outArray;
}

DateTime d1 = DateTime.Now;

int[,] twoDimArray = FillTowDimArray(5, 8);
PrintTwoDimArray(twoDimArray);
PrintColorTwoDimArray(UpdateTwoDimArray(twoDimArray));

Console.WriteLine("Solution time: ");
Console.WriteLine(DateTime.Now - d1);