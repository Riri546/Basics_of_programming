//Write a program that accepts three numbers as input and checks whether a triangle with sides of this length can exist.

Console.Clear();

int sideA = 0;
int sideB = 0;
int sideC = 0;
int t;

ReadSides();
bool res = Testtraingle();
PrintAnswer(res);

//The method takes a number from the console
void ReadSides()
{
    Console.Write("Plese, enter first number: ");
    sideA = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Enter second number: ");
    sideB = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Enter third number: ");
    sideC = int.Parse(Console.ReadLine() ?? "");
}

//The method checks the values in order to tell if a triangle will turn out
bool Testtraingle()
{
    bool answer = ((sideA + sideB > sideC)
    && (sideB + sideC > sideA)
    && (sideA + sideC > sideB)) ? true : false;

    return answer;
}

//The method outputs a response to the user
void PrintAnswer(bool answer)
{
    if (answer)
    {
        t = Environment.TickCount;
        Console.WriteLine("From these segments, you can make a triangle");
        Console.WriteLine("Time to solve the problem: {0} ms", Environment.TickCount - t);
    }
    else
    {
        t = Environment.TickCount;
        Console.WriteLine("It is impossible to make a triangle out of these segments");
        Console.WriteLine("Time to solve the problem: {0} ms", Environment.TickCount - t);
    }
}




