//Write a program that will convert a decimal number to binary.

Console.Clear();

Console.Write("Enter a number in binary calculus: ");

int t = Environment.TickCount;
Console.WriteLine("A number in binary calculus: " + Convert.ToString(int.Parse(Console.ReadLine() ?? ""), 2));
Console.WriteLine("Time to solve the problem: {0} ms", Environment.TickCount - t);


        