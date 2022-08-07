//Write a program that takes the number N as input and outputs the product of numbers from 1 to N.

Console.Clear();

Console.Write("Enter number: ");
string inputLine = Console.ReadLine() ?? "";
int inputNum = int.Parse(inputLine);
int t;

t = Environment.TickCount;
Console.WriteLine(SumNums(inputNum));
Console.WriteLine("Simple solution time: {0} ms", Environment.TickCount - t);

t = Environment.TickCount;
Console.WriteLine(MulRec(inputNum));
Console.WriteLine("Recursive solution time: {0} ms", Environment.TickCount - t);


int SumNums(int num)
{
    int sum = 1;
    for (int i = 1; i <= inputNum; i++)
    {
        //sum = sum * i;
        sum *= i;
    }
    return sum;
}

int MulRec(int num)
{
    if (num == 1)
    {
        return 1;
    }
    else
    {
        return num * MulRec(num - 1);
    }
}

