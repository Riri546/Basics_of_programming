//Specify an array of 12 elements filled with random numbers from the interval [-9, 9]. 
//Find the sum of the negative and positive elements of the array.

Console.Clear();

int positivSum = 0;
int negativSum = 0;
int t;

//The method returns an array filled with random numbers from -9 to 9.
int[] FillingArray()
{
    int[] outArray = new int[12];
    int i = 0;
    System.Random numberSintezator = new Random();

    while (i < 12)
    {
        outArray[i] = numberSintezator.Next(-9, 10);
        i++;
    }
    return outArray;
}

//The method starts a loop to search for positive and negative array numbers.
void ColculateTask(int[] outArray)
{
    int i = 0;
    while (i < 12)
    {
        if (outArray[i] > 0)
        {
            positivSum++;
        }
        else
        {
            negativSum++;
        }

        i++;
    }
}

//The method outputs the result of the solution to the console.
void PrintResult()
{
    Console.WriteLine("Number of positive array elements: " + positivSum);
    Console.WriteLine("Number of negative array elements: " + negativSum);
}

void VariantNaive()
{
    int[] bufferArray = FillingArray();
    ColculateTask(bufferArray);
    PrintResult();

    // ColculateTask(FillingArray());
    // PrintResult();
}

VariantNaive();