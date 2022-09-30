//Write a program for calculating the Ackerman function using recursion. 
//Two non-negative numbers m and n are given

Console.Clear();

int numberM = ReadData("Set the number M: ");
int numberN = ReadData("Set the number N: ");

//Variable input method
int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine() ?? "");
}

///Method for calculating the Ackerman function
int AckermannFunction(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
    return AckermannFunction(numberM, numberN);
}

//The body of the task, launches the ce methods
void Result()
{
    DateTime d1 = DateTime.Now;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"Ackerman function for numbers A({numberM},{numberN}) = ");
    Console.ResetColor();
    Console.WriteLine(AckermannFunction(numberM, numberN));
    
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Solution time: ");
    Console.ResetColor();
    Console.WriteLine(DateTime.Now - d1);
}

Result();
