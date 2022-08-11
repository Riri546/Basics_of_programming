//Write a program that takes a number (N) as input and outputs a table of squares of numbers from 1 to N.

Console.Clear();

Console.Write("Enter number: ");

string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int numberN = int.Parse(inputLineN);

    string lineN = " ";
    string lineNN = string.Empty;
    int s = 1;

    // Cycle
    void Cycle()
    {
        while (s <= numberN)
        {
            lineN = lineN + s + "  ";
            lineNN = lineNN + (s * s).ToString() + "  ";
            s++;
        }
    }

    Cycle();

    Console.WriteLine(lineN);
    Console.WriteLine(lineNN);
}
