// Specify an array filled with random positive three-digit numbers. 
//Write a program that will show the number of even numbers in the array.

Console.Clear();

int i;

//The method returns an array filled with random numbers 
int[] FillingArray()
{
    int[] outArray = new int[123];
    i = 0;
    System.Random numberSintezator = new Random();

    while (i < 123)
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

//The method performs bubble sorting of the array
static int[] SortArray(int[] inputArray)
{
    Console.WriteLine();
    Console.WriteLine("Bubble sort array: ");
    int length = inputArray.Length;

    int temp = inputArray[0];

    for (int i = 0; i < length; i++)
    {
        for (int j = i + 1; j < length; j++)
        {
            if (inputArray[i] > inputArray[j])
            {
                temp = inputArray[i];

                inputArray[i] = inputArray[j];

                inputArray[j] = temp;
            }
        }
    }
    return inputArray;
}

//The method of solving the problem 36
int ColculateTask(int[] inputArray)
{
    Console.Write("Even numbers: ");
    int resultNumber = 0;
    i = 0;

    while (i < inputArray.Length)
    {

        if (inputArray[i] % 2 == 0)
        {
            resultNumber++;

            Console.Write(inputArray[i] + " ");
        }
        i+=2;
    }
    return resultNumber;
}

int t = Environment.TickCount;
int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);

int[] resultArray = SortArray(bufferArray);
PrintIntArray(resultArray);

Console.WriteLine();
Console.WriteLine("; Number of even numbers: " + ColculateTask(bufferArray));
Console.WriteLine();
Console.WriteLine("Time to solve the whole problem: {0} ms", Environment.TickCount - t);