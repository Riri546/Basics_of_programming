// // Specify a two-dimensional array of size m×n filled with random real numbers.

// Console.Clear();

// double[,] a = new double[5, 10];
// Random random = new Random();
// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         a[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
//         Console.Write("{0,6:F2}", a[i, j]);
//     }
//     Console.WriteLine();
// }

//Method for filling a two-dimensional array
double[,] FillTowDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();

    double[,] outArray = new double[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            outArray[i, j] = numberSyntezator.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
            Console.Write("{0,6:F2}", outArray[i, j]);
        }
        Console.WriteLine();
    }
    return outArray;
}


//The method prints an array in yellow
 void PrintColorTwoDimArray(double[,] inpujitArray)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Yellow;

    for (int i = 0; i < inpujitArray.GetLength(0); i++)
    {
        for (int j = 0; j < inpujitArray.GetLength(1); j++)
        {
            Console.Write("{0,6:F2}", inpujitArray[i, j]);
        }
        Console.ResetColor();
    }
    
}
double[,] twoDimArray = FillTowDimArray(3, 4);
PrintColorTwoDimArray(twoDimArray);


