//Write a program that will create a copy of a given one-dimensional array using piecemeal copying.

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

//The method copies the array
int[] CopyArayStandartTool(params int[] inputarray)
{
    int[] buferArray = new int[inputarray.Length];
    inputarray.CopyTo(buferArray, 0);
    return buferArray;
}

DateTime d1 = DateTime.Now;
int[] tastArray = FillingArray();
PrintIntArray(tastArray);

int[] resultArray = CopyArayStandartTool(tastArray);
PrintIntArray(resultArray);

Console.WriteLine("Solution time: ");
Console.WriteLine(DateTime.Now - d1);

