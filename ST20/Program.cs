Console.Clear();

Console.Write("Enter number: ");

string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int numberN = int.Parse(inputLineN);

    string lineN = " ";
    string lineNN = string.Empty;
    int s = 1;

    while (s <= numberN)
    {
        lineN = lineN + s + "  ";
        lineNN = lineNN + (s * s).ToString() + "  ";
        s++;
    }

    Console.WriteLine(lineN);
    Console.WriteLine(lineNN);
}
