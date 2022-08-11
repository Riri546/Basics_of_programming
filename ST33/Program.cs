//Set the array. Write a program that determines whether a given number is present in an array.

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

//The method of solving the problem 33
bool ColculateTask(int[] inputArray, int searchNumber)
{
    bool resultSearch = false;
    int i = 0;
    while (i < 12)
    {
        if (inputArray[i] == searchNumber)
        {
            resultSearch = true;
            break;
        }
        i++;
    }
    return resultSearch;
}

t = Environment.TickCount;
int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
Console.WriteLine("Variant simple time: {0} ms", Environment.TickCount - t);


Console.Write("Plese, enter number: ");
string number = Console.ReadLine() ?? "";
int serchNumber = int.Parse(number);

Console.WriteLine(ColculateTask(bufferArray, serchNumber));