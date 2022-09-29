//
Console.Clear();

int numberM = ReadData("Set the number M: ");
int numberN = ReadData("Set the number N: ");


int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine() ?? "");
}

