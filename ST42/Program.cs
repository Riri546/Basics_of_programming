//Without using recursion, output the first N Fibonacci numbers. The first two Fibonacci numbers are 0 and 1.

Console.Clear();

Console.Write("Enter the number of numbers in the Fibonacci series: ");
int decemalNumber = ReadDecemaNumber();
PrintAnswer(Fibonacci(decemalNumber));

//The method enters a number
int ReadDecemaNumber()
{
    return int.Parse(Console.ReadLine() ?? "");
}

//The method produces a Fibonacci solution
string Fibonacci(int n)
{
    string answer = "";

    if (n == 2)
    {
        answer = "0 1";
    }
    else if (n == 1)
    {
        answer = "0";
    }
    else
    {
        answer = "0 1";
        int fn_1 = 1;
        int fn_2 = 0;
        int fn;
        for (int i = 0; i < n - 2; i++)
        {
            fn = fn_1 + fn_2;
            answer += " " + fn;
            fn_2 = fn_1;
            fn_1 = fn;
        }
    }
    return answer;
}

//The method outputs the result
void PrintAnswer(string answer)
{
    DateTime d1 = DateTime.Now;
    Console.Write("Fibonacci series for a given number of numbers: " + answer);
    Console.WriteLine();
    Console.WriteLine("Solution time: ");
    Console.WriteLine(DateTime.Now - d1);
}