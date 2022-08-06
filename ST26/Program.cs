Console.Clear();

Console.Write("Enter number: ");
string inputLine = Console.ReadLine() ?? "";
int inputNum = int.Parse(inputLine);

Console.WriteLine(sumNums(inputNum));

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
