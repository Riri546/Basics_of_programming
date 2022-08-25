//Create a frequency dictionary of elements of a two-dimensional array. 
//The frequency dictionary contains information about. how many times do the input data elements occur

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
            outArray[i, j] = numberSyntezator.Next(0, 10);
        }
    }
    return outArray;
}

//The method prints an array in green
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

//Solution task 55
int[] FreqmancyCollect(int[,] inputArray, int alphadetLength)
{
    Console.WriteLine();

    int[] resultArray = new int[alphadetLength];
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = i;
        while (j < inputArray.GetLength(0))
        {
            //array = [0,1,3,1,2,1,3,1,2,2]
            //alphadet = [0,1,2,3]
            //freqmency = [2,4,3,2]

            //We collect the frequency of occurrence of elements
            resultArray[inputArray[i, j]]++;
            j++;
        }
        i++;
    }
    return resultArray;
}

//The method outputs a random array of numbers to the console
void PrintIntArray(int[] resultArray)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Alphabet frequency: ");
    Console.ResetColor();

    int i;
    for (i = 0; i < resultArray.Length - 1; i++)
    {
        Console.Write(resultArray[i] + ", ");
    }
    Console.WriteLine(resultArray[i]);
}

//The body of the task, launches the ce methods
void Result()
{
    DateTime d1 = DateTime.Now;

    int[,] twoDimArray = FillTowDimArray(10, 10);
    PrintColorTwoDimArray(twoDimArray);
    Console.WriteLine();

    int[] freqmancy = FreqmancyCollect(twoDimArray, 10);
    PrintIntArray(freqmancy);

    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Solution time: ");
    Console.ResetColor();
    Console.WriteLine(DateTime.Now - d1);
}

Result();
