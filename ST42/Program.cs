﻿//Without using recursion, output the first N Fibonacci numbers. The first two Fibonacci numbers are 0 and 1.

Console.Clear();

Console.Write("Enter the number of numbers in the Fibonacci series: ");
int decemalNumber = ReadDecemaNumber();
PrintAnswer(Fibonacci(decemalNumber));

int ReadDecemaNumber()
{
    return int.Parse(Console.ReadLine() ?? "");
}
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

void PrintAnswer(string answer)
{
    Console.Write("Fibonacci series for a given number of numbers: " + answer);
}