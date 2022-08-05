Console.Clear();

Console.Write("Enter number: ");

string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int numberN = int.Parse(inputLineN);

    string lineN = "";
    string lineNNN = string.Empty;
    int s = 1;

    while (s <= numberN)
    {
        lineN = lineN + s + "  ";
        lineNNN = lineNNN + (s * s * s).ToString() + "  ";
        s++;
    }

    Console.WriteLine(lineN);
    Console.WriteLine(lineNNN);
}

