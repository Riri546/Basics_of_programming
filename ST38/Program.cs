// Specify an array of real numbers. Find the difference between the maximum and minimum array elements.

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

//Sorting by insertion method
int[] InsertionSort(int[] inputArray)
{
    Console.WriteLine();
    Console.WriteLine("Sorting by insertion method: ");
    for (int i = 0; i < inputArray.Length; i++)
    {
        int cur = inputArray[i];

        while (i > 0 && cur < inputArray[i - 1])
        {
            inputArray[i] = inputArray[i - 1];
            i--;
        }
        inputArray[i] = cur;
    }
    return inputArray;
}

//The method implements sorting by counting
int[] CountingSort(int[] inputArray)
{
    Console.WriteLine();
    Console.WriteLine("Implements sorting by counting: ");
    int[] sortedArray = new int[inputArray.Length];

    int minVal = inputArray[0];
    int maxVal = inputArray[0];
    for (int i = 1; i < inputArray.Length; i++)
    {
        if (inputArray[i] < minVal) minVal = inputArray[i];
        else if (inputArray[i] > maxVal) maxVal = inputArray[i];
    }

    int[] counts = new int[maxVal - minVal + 1];

    for (int i = 0; i < inputArray.Length; i++)
    {
        counts[inputArray[i] - minVal]++;
    }

    counts[0]--;
    for (int i = 1; i < counts.Length; i++)
    {
        counts[i] = counts[i] + counts[i - 1];
    }

    for (int i = inputArray.Length - 1; i >= 0; i--)
    {
        sortedArray[counts[inputArray[i] - minVal]--] = inputArray[i];
    }

    return sortedArray;
}

//The method of solving the problem 38
int ColculateTask(int[] inputArray)
{
    Console.WriteLine("The difference between the maximum and minimum numbers of the array: ");
    int max = 0;
    int min = int.MaxValue;

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i] > max)
        {
            max = inputArray[i];
        }
        if (inputArray[i] < min)
        {
            min = inputArray[i];
        }
    }
    return (max - min);
}

int t = Environment.TickCount;
int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);

t = Environment.TickCount;
int[] resultArray = InsertionSort(bufferArray);
PrintIntArray(resultArray);
Console.WriteLine("Time spent for sorting by insertion method: {0} ms", Environment.TickCount - t);

t = Environment.TickCount;
int[] resultArray2 = CountingSort(bufferArray);
PrintIntArray(resultArray2);
Console.WriteLine("time spent for sorting by counting method: {0} ms", Environment.TickCount - t);

Console.WriteLine();
Console.WriteLine(ColculateTask(bufferArray));
Console.WriteLine();
Console.WriteLine("Time to solve the whole problem: {0} ms", Environment.TickCount - t);
