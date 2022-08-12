//Specify a one-dimensional array filled with random numbers. Find the sum of the elements standing in odd positions.
Console.Clear();

int i;

//The method returns an array filled with random numbers 
int[] FillingArray()
{
    int[] outArray = new int[10];
    i = 0;
    System.Random numberSintezator = new Random();

    while (i < 10)
    {
        outArray[i] = numberSintezator.Next(100, 1000);
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

//The method of solving the problem 37
int ColculateTask(int[] inputArray)
{
    Console.Write("Sum of odd numbers: ");
    int sumNumber = 0;

    for (int i = 1; i < inputArray.Length; i += 2)
    {
        sumNumber = sumNumber + inputArray[i];
    }
    return sumNumber;
}

int t = Environment.TickCount;
int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);

Console.WriteLine();
Console.WriteLine(ColculateTask(bufferArray));
Console.WriteLine();
Console.WriteLine("Time to solve the whole problem: {0} ms", Environment.TickCount - t);