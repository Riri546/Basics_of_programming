//The user enters M numbers from the keyboard. Count how many numbers greater than 0 the user entered.

Console.Clear();

//Solution task 44(with the int type, you can enter 4 digits, with long 8)
void ConculateTask()
{
    Console.Write("Enter the elements (separated by a space): ");
    long[] inputArray = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
    long count = inputArray.Count(x => x > 0);
    Console.WriteLine($"Number of elements > 0: {count}");
}
ConculateTask();


//The user enters the number of clicks, then the program monitors 
//the clicks and outputs how many numbers greater than 0 were entered.



