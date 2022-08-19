//Write a program that takes the positions of an element in a two-dimensional array as input, 
//and returns the value of this element or an indication that there is no such element.

Console.Clear();

//Random Number 

//Method for filling a two-dimensional array
int[,] FillTowDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();

    int[,] outArray = new int[countRow, countColumn];
    int randomNumber = numberSyntezator.Next(0, 101);
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
           outArray[i,j]= 
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