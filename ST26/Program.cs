Console.Clear();

Console.Write("Enter number: ");
string inputLine = Console.ReadLine() ?? "";
int inputNum = int.Parse(inputLine);
int t;

t = Environment.TickCount;
Console.WriteLine(sumNums(inputNum));
Console.WriteLine("Simple solution time: {0} ms", Environment.TickCount - t);

t = Environment.TickCount;
Console.WriteLine(mulRec(inputNum));
Console.WriteLine("Recursive solution time: {0} ms", Environment.TickCount - t);


int sumNums(int num)
{
    int sum = 1;
    for (int i = 1; i <= inputNum; i++)
    {
        //sum = sum * i;
        sum *= i;
    }
    return sum;
}

int mulRec(int num)
{
    if (num == 1)
    {
        return 1;
    }
    else
    {
        return num * mulRec(num - 1);
    }
}

