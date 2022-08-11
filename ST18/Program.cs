//Write a program that, according to a given number
//of quarters, shows the range of possible coordinates of points in this quarter (x and y).

Console.Clear();

Console.Write("Enter number: ");
string inputLine = Console.ReadLine() ?? "";
int inputNumber = int.Parse(inputLine);

//The method outputs the result to the console 
void PrintAnswer(int number)
{

    if (number == 1) Console.WriteLine("Acceptable: x>0, y>0");
    if (number == 2) Console.WriteLine("Acceptable: x<0, y>0");
    if (number == 3) Console.WriteLine("Acceptable: x<0, y<0");
    if (number == 4) Console.WriteLine("Acceptable: x>0, y<0");
}

Console.ReadLine();

PrintAnswer(inputNumber);

