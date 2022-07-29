Console.Clear();

Console.Write("Write a number that corresponds to the ordinal number of the day of the week, and I'll tell you if it's a day off: ");
string? numberLine = Console.ReadLine();
if(numberLine != null)
{
    int number = int.Parse (numberLine);

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
        switch(number)
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
