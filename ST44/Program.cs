//The user enters M numbers from the keyboard. Count how many numbers greater than 0 the user entered.

Console.Clear();

//Solution task 44(with the int type, you can enter 4 digits, with long 8)
void ConculateTask()
{
    //Outputs text to the console
    Console.Write("Enter the elements (separated by a space): ");

    //Array.ConvertAll - Converts an array of one type to an array of another type.
    //.Split - The String.Split method creates an array of substrings by splitting the input string
    // by one or more delimiters. This method is often the simplest 
    //a way to divide a string by word boundaries. It is also used to split strings
    // by other specific characters or strings.

    long[] inputArray = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

    //Checking for "> 0"
    long count = inputArray.Count(x => x > 0);

    //Outputs the result to the console
    Console.WriteLine($"Number of elements > 0: {count}");
}
ConculateTask();




