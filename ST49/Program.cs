//Specify a two-dimensional array. 
//Find the sum of the elements located on the main diagonal (with indexes (0,0); (1;1), etc.

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

//The method solves the problem 49
int CalcDigTwoDimArr(int[,] inputArray)
{
    Console.WriteLine();

    int outSumDiaganal = 0;

    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        outSumDiaganal += inputArray[i, i];
    }
    return outSumDiaganal;
}

DateTime d1 = DateTime.Now;

int[,] twoDimArray = FillTowDimArray(5, 8);
PrintColorTwoDimArray(twoDimArray);

int sum = CalcDigTwoDimArr(twoDimArray);
Console.WriteLine("Diagonal: " + sum);

Console.WriteLine("Solution time: ");
Console.WriteLine(DateTime.Now - d1);