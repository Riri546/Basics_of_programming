//The user enters M numbers from the keyboard. Count how many numbers greater than 0 the user entered.

Console.Clear();

int m = 0;
int[] array = new int[m];

//The method takes a number from the console
int[] ReadNumber(int[] array)
{
    Console.Write("Enter the numbers (separated by a space): ");

    for (int i = 0; i < m; i++)
    {
        array[i] = int.Parse(Console.ReadLine() ?? "");
    }

    return array;

}

//Solution task 44
int ConculateTask(int[] array)
{
    int count = 0;
    int i = 0;

    for (i = 0; i < m; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

//The method outputs the result of the solution
void PrintResult(int count)
{
    DateTime d1 = DateTime.Now;
    Console.WriteLine("The entered numbers are greater than 0: " + count);
    Console.WriteLine("Solution time: ");
    Console.WriteLine(DateTime.Now - d1);
}

int[] testArray = ReadNumber();

ConculateTask(testArray);
Console.WriteLine(PrintResult());



//The user enters the number of clicks, then the program monitors 
//the clicks and outputs how many numbers greater than 0 were entered.



// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = arr.Count(x => x > 0);
// Console.WriteLine($"Кол-во элементов > 0: {count}");