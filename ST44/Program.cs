//The user enters M numbers from the keyboard. Count how many numbers greater than 0 the user entered.

Console.Clear();

int i;
int m = 0;

//The method takes a number from the console
int[] ReadNumber()
{
    Console.Write("Enter a number: ");
    int[] array = new int[m];

    for (i = 0; i < m; i++)
    {
        array[i] = int.Parse(Console.ReadLine() ?? "");
    }
    return array;
}

//The method outputs a random array of numbers to the console
void PrintIntArray(int[] array)
{
    i = 0;

    while (i < array.Length - 1)
    {
        Console.Write(array[i] + ", ");
        i++;
    }
    Console.WriteLine(array[i]);
}

//Solution task 44
int ConculateTask(int[] array)
{
    int resultNumber = 0;
    i = 0;

    for (i = 0; i < m; i++)
    {
        if (array[i] > 0)
        {
            resultNumber++;
        }
    }
    return resultNumber;
}

//The method outputs the result of the solution
void PrintResult(int resultNumber)
{
    DateTime d1 = DateTime.Now;
    Console.WriteLine("The entered numbers are greater than 0: " + resultNumber);
    Console.Write("Solution time: ");
    Console.WriteLine(DateTime.Now - d1);
}


int[] testArray = ReadNumber();
PrintIntArray(testArray);

int resultNumber = ConculateTask(testArray);
PrintResult(resultNumber);



//The user enters the number of clicks, then the program monitors 
//the clicks and outputs how many numbers greater than 0 were entered.