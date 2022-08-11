//Write a program replacing array elements: 
//replace the positive elements with the corresponding negative ones, and vice versa.

Console.Clear();

int i;
int t;

//The method returns an array filled with random numbers from -9 to 9.
int[] FillingArray()
{
    int[] outArray = new int[12];
    i = 0;
    System.Random numberSintezator = new Random();

    while (i < 12)
    {
        outArray[i] = numberSintezator.Next(-9, 10);
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

//The method deals with replacing positive numbers with negative ones and vice versa
int[] ColculateTask(int[] inputArray)
{
    int[] outputArray = new int[12];
    int i = 0;
    while (i < 12)
    {
        outputArray[i] = inputArray[i] * (-1);
        i++;
    }
    return outputArray;
}

//A method that works through a tilde
int[] InvertArrayTilda(int[] inputArray)
{
    int i = 0;
    while (i < inputArray.Length)
    {
        inputArray[i] = (~inputArray[i]) + 1;
        i++;
    }
    return inputArray;
}

t = Environment.TickCount;
int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
int[] resultArray = ColculateTask(bufferArray);
PrintIntArray(resultArray);
Console.WriteLine("Variant simple time: {0} ms", Environment.TickCount - t);

t = Environment.TickCount;
resultArray = InvertArrayTilda(bufferArray);
PrintIntArray(resultArray);
Console.WriteLine("Variant tilda time: {0} ms", Environment.TickCount - t);
