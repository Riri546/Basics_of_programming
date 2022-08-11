//Find the product of pairs of numbers in a one-dimensional array. We consider the first and last element as a pair, 
//the second and penultimate, etc. Write the result in a new array.

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

//The method of solving the problem 35
int[] ColculateTask(int[] inputArray)
{
    int[] resultArray = new int[inputArray.Length / 2 + 1];
    i = 0;

    while (i < resultArray.Length)
    {
        resultArray[i] = inputArray[i] * inputArray[inputArray.Length - 1 - i];
        i++;
    }
    return resultArray;
}

t = Environment.TickCount;
int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
int[] resultArray = ColculateTask(bufferArray);
PrintIntArray(resultArray);
Console.WriteLine("Variant simple time: {0} ms", Environment.TickCount - t);
