//Specify a two-dimensional array of integers. Find the arithmetic mean of the elements in each column.

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

void ConculeteTask(int[,] inpujitArray)
{
    int summ = 0;
    double average = 0;

    for (int i = 0; i < inpujitArray.GetLength(0); i++)
    {
        for (int j = 0; j < inpujitArray.GetLength(1); j++)
        {
            summ = inpujitArray[j,j] + inpujitArray[j,j];
            average = summ / inpujitArray.GetLength(0);
            Console.WriteLine("Arithmetic mean: " + average);
        }
    }

}

// //The method prints an array in yellow
// void PrintColorTwoDimArray(int[] sum)
// {
//     Console.WriteLine();
//     Console.ForegroundColor = ConsoleColor.Yellow;
//     Console.WriteLine(sum);
// }
// Console.ResetColor();


int[,] twoDimArray = FillTowDimArray(3, 4);
PrintTwoDimArray(twoDimArray);


ConculeteTask(twoDimArray);
// PrintColorTwoDimArray(twoDimArray);

