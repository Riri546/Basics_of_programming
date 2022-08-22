//Write a program that takes the positions of an element in a two-dimensional array as input, 
//and returns the value of this element or an indication that there is no such element.

Console.Clear();

int number;

//The method accepts a number from the console
void ReadNumber()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Enter number: ");
    Console.ResetColor();

    number = int.Parse(Console.ReadLine() ?? "");
}

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

//The method solves the problem 51
bool ContainsZero(int[,] inpujitArray)
{
    Console.ForegroundColor = ConsoleColor.Yellow;

    for (int i = 0; i < inpujitArray.GetLength(0); i++)
    {
        for (int j = 0; j < inpujitArray.GetLength(1); j++)
        {
            if (inpujitArray[i, j] == number)
            {
                Console.WriteLine("This number is in the array: " + inpujitArray[i, j]);
                return true;
            }
        }
    }
    Console.WriteLine("This number is not in the array");
    Console.ResetColor();
    return false;
}

//The method that runs all other methods and outputs the result of the solution (the root of the program)
void Result()
{
    DateTime d1 = DateTime.Now;
    ReadNumber();

    int[,] twoDimArray = FillTowDimArray(4, 8);
    PrintTwoDimArray(twoDimArray);

    bool result = ContainsZero(twoDimArray);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Solution time: ");
    Console.ResetColor();
    Console.WriteLine(DateTime.Now - d1);
}

Result();

