//Set a one-dimensional array of 123 random numbers. Find the number of array elements whose values 
//lie in the segment [10,99].

Console.Clear();

int i;
int t;

//The method returns an array filled with random numbers 
int[] FillingArray()
{
    int[] outArray = new int[123];
    i = 0;
    System.Random numberSintezator = new Random();

    while (i < 123)
    {
        outArray[i] = numberSintezator.Next(~1000, 1000);
        i++;
    }
    return outArray;
}

//The method outputs a random array of numbers to the console
void PrintIntArray(int[] inputArray)
{
    i = 0;

    while (i < inputArray.Length - 1)
    {
        Console.Write(inputArray[i] + ", ");
        i++;
    }
    Console.WriteLine(inputArray[i]);
}

//The method of solving the problem 34
int ColculateTask(int[] inputArray, int downBorder, int upBorder)
{
    int resultCount = 0;
    int i = 0;
    while (i < inputArray.Length)
    {
        if (inputArray[i] >= downBorder && inputArray[i] <= upBorder)
        {
            Console.WriteLine(inputArray[i] + " ");
            resultCount++;
        }
        i++;
    }
    return resultCount;
}

t = Environment.TickCount;
int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
Console.WriteLine("Variant simple time: {0} ms", Environment.TickCount - t);

Console.WriteLine("The number of numbers in the range [10,99]: " + ColculateTask(bufferArray, 10, 99));