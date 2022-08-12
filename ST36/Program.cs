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

//The method of solving the problem 36
int ColculateTask(int[] inputArray)
{
    Console.WriteLine("Even numbers: ");
    int resultNumber = 0;
    i = 0;

    while (i < inputArray.Length)
    {

        if (inputArray[i] % 2 == 0)
        {
            resultNumber++;
            
            Console.Write(inputArray[i] + " ");
           
        }
        i++;
    }
    return resultNumber;
     
}

int t = Environment.TickCount;
int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
Console.WriteLine();
Console.WriteLine("Number of even numbers: " + ColculateTask(bufferArray));
Console.WriteLine();
Console.WriteLine("Variant simple time: {0} ms", Environment.TickCount - t);
