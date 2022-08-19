// // Specify a two-dimensional array of size m×n filled with random real numbers.

Console.Clear();

double[,] FillTowDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();

    double[,] outArray = new double[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            outArray[i, j] = numberSyntezator.NextDouble() * 100; 

        }
    }
    return outArray;
}

//Array of colors for the task with *
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.Green,
                                        ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White, 
                                        ConsoleColor.Yellow};

//A method that prints the solution in a multi-colored format
void PrintColorTwoDimArray(double[,] outArray)
{
    for (int i = 0; i < outArray.GetLength(0); i++)
    {
        for (int j = 0; j < outArray.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0,16)];
            Console.Write("{0,6:F2}", outArray[i, j]);
            Console.ResetColor();
        }
        Console.WriteLine("\t");
    }
}

DateTime d1 = DateTime.Now;
double[,] twoDimArray = FillTowDimArray(5, 8);
PrintColorTwoDimArray(twoDimArray);
Console.WriteLine("Solution time: ");
Console.WriteLine(DateTime.Now - d1);

