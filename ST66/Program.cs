//Write a program that takes two numbers A and B as input, 
//and raises the number to an integer power of B using recursion.

Console.Clear();

int numberA = ReadData("Set the number A: ");
int numberB = ReadData("Set the number B: ");

Console.Write(PowNumber(numberA, numberB));

int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine() ?? "");
}

int PowNumber(int a, int b)
{
    if (b == 1) return a;
    return a * PowNumber(a, --b);
}