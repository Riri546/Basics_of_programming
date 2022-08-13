//Write a program that will convert a decimal number to binary.

Console.Clear();

Console.Write("Enter a number in binary calculus: ");

DateTime d1 = DateTime.Now;
Console.WriteLine("A number in binary calculus: " + Convert.ToString(int.Parse(Console.ReadLine() ?? ""), 2));
Console.WriteLine(DateTime.Now-d1);


        