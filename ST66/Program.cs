//Write a program that takes two numbers A and B as input, 
//and raises the number to an integer power of B using recursion.

Console.Clear();

int numberA = ReadData("Set the number A: ");
int numberB = ReadData("Set the number B: ");



int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine() ?? "");
}

int MyPow(int a, int b)
{
    if (b == 2)
    {
        return a * a;
    }
    if (b == 1)
    {
        return a;
    }
    if (b % 2 == 0)
    {
        return MyPow(a, b / 2) * MyPow(a, b / 2);
    }
    else
    {
        return MyPow(a, b / 2) * MyPow(a, (b / 2) + 1);
    }
}

int PowNumber(int a, int b)
{
    if (b == 1) return a;
    return a * PowNumber(a, --b);
}

//The body of the task, launches the ce methods
void Result()
{
    DateTime d1 = DateTime.Now;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Solution PowNumber: ");
    Console.WriteLine(PowNumber(numberA, numberB));
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Solution time: ");
    Console.ResetColor();
    Console.WriteLine(DateTime.Now - d1);

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Solution MyPow: ");
    Console.WriteLine(MyPow(numberA, numberB));
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Solution time: ");
    Console.ResetColor();
    Console.WriteLine(DateTime.Now - d1);
}

Result();
