//Write a program that, according to a given number
//of quarters, shows the range of possible coordinates of points in this quarter (x and y).

Console.Clear();

void PrintAnswer(int number)
{
    if (number == 1) Console.WriteLine("Acceptable: x>0, y>0");
    if (number == 2) Console.WriteLine("Acceptable: x<0, y>0");
    if (number == 3) Console.WriteLine("Acceptable: x<0, y<0");
    if (number == 4) Console.WriteLine("Acceptable: x>0, y<0");
}

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    PrintAnswer(inputNumber);
}