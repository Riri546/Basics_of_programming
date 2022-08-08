//Write a program that takes a number (N) as input, and shows all even numbers from 1 to N as output.

Console.Clear();

Console.Write("Enter an integer: ");
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    if (inputNumber < 1)
    {
        Console.Write("This number is less than 1, enter another number");
    }
    else
    {
        int B = 2;
        
        string line = "";
        
        while (B <= inputNumber - 2)
        {
            
            line = line + B + ", ";
            
            B = B + 2;
        }
            line = line + B;

        Console.WriteLine("All even numbers from 1 to " + inputNumber + ": ");

        Console.WriteLine(line);
    }
}