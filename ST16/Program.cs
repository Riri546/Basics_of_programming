//Write a program that accepts a digit indicating the day of the week as input and checks whether this day is a weekend.

Console.Clear();

int number;

//The method takes a number from the console
void ReadNumber()
{
Console.Write("Write a number that corresponds to the ordinal number of the day of the week, and I'll tell you if it's a day off: ");
string numberLine = Console.ReadLine() ?? "";
number = int.Parse(numberLine);
}
    
////Solving the problem
void ConculateNaive()
{
    if (number < 1)
    {
        Console.WriteLine("Error: the number is too small");
    }
    if (number > 7)
    {
        Console.WriteLine("Error: the number is too large");
    }
    else
    {
        switch (number)
        {
            case 6:
                Console.WriteLine("Yes, Saturday is a day off");
                break;

            case 7:
                Console.WriteLine("Yes, Sunday is a day off");
                break;

            default:
                Console.WriteLine("No");
                break;
        }
    }
}

ReadNumber();
ConculateNaive();