//Write a program that will accept a number as input and return the sum of its numbers. 

Console.Clear();

int number = ReadData("Set the number: ");
Console.WriteLine(Sum(number));

int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine() ?? "");
}

int Sum(int num)
{
    if (num > 0)
    {
        return num % 10 + Sum(num / 10);
    }
    else
    {
        return 0;
    }
}
