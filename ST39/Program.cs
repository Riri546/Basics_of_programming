//Write a program that will 
//flip a one-dimensional array (the last element will be in the first place, and the first one will be in the last, etc.)

Console.Clear();

int i;

//The method returns an array filled with random numbers 
int[] FillingArray(int arrayLength)
{
    Console.WriteLine("Array: ");
    int[] outArray = new int[arrayLength];
    i = 0;
    System.Random numberSintezator = new Random();

    while (i < arrayLength)
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

//The method expands the array. Variant 1
int[] ReversNewArray(int[] inputArray)
{
    Console.WriteLine();
    Console.WriteLine("Revers array. Variant 1: ");
    int length = inputArray.Length;
    int[] newArray = new int[length];

    for (i = 0; i < length; i++)
    {
        newArray[length - 1 - i] = inputArray[i];
    }
    return newArray;
}

//The method expands the array. Variant 2
int[] ReversSwapArray(int[] inputArray)
{
    Console.WriteLine();
    Console.WriteLine("Revers array. Variant 2: ");
    int length = inputArray.Length;
    int buf;

    for (i = 0; i < length / 2; i++)
    {
        buf = inputArray[i];
        inputArray[i] = inputArray[length - 1 - i];
        inputArray[length - 1 - i] = buf;
    }
    return inputArray;
}

int t = Environment.TickCount;
int[] testArray = FillingArray(13);
PrintIntArray(testArray);

int[] reversedArray = ReversNewArray(testArray);
PrintIntArray(reversedArray);

PrintIntArray(ReversSwapArray(testArray));
PrintIntArray(testArray);

Console.WriteLine();
Console.WriteLine("Time to solve the whole problem: {0} ms", Environment.TickCount - t);


