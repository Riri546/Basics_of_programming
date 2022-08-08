//Write a program that takes a number 
//as input and outputs whether the number is even (whether it is divisible by two without remainder).

Console.Clear();

Console.Write("Enter a number and I'll tell you if it's even:");

string? inputLine = Console.ReadLine();
if(inputLine != null)
    {
        int inputNumber = int.Parse(inputLine);

        int outputNumber = inputNumber % 2;

        if (inputNumber % 2 == 0)
        {
            Console.WriteLine("Even number");
        }
        else
        {
           Console.WriteLine("Odd number"); 
        }
    }
