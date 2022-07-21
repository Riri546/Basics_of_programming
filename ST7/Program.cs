Console.Clear();

Console.Write("Enter a number and I'll tell you if it's even:");

string inputLine = Console.ReadLine();

if (inputLine != null)
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
