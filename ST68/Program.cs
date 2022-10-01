//Set the values of M and N. Write a program that finds the sum of natural elements in the range from M to N.

Console.Clear();

int numberM = ReadData("Set the number M: ");
int numberN = ReadData("Set the number N: ");

//Variable input method
int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine() ?? "");
}

//method of finding the sum of numbers from M to N by the formula: ∑= (N 2– М 2+ М+ N)/ 2
static int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            // If M is zero
    else if (N == 0) return (M * (M + 1)) / 2;       // If N is zero
    else if (M == N) return M;                       // If M=N
    else if (M < N) return N + SumNumbers(M, N - 1); // If M<N
    else return N + SumNumbers(M, N + 1);            // If M>N
}

//The body of the task, launches the ce methods
void Result()
{
    DateTime d1 = DateTime.Now;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Result, sum numbers = ");
    Console.ResetColor();
    Console.WriteLine(SumNumbers(numberM, numberN));

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Solution time: ");
    Console.ResetColor();
    Console.WriteLine(DateTime.Now - d1);
}

Result();



