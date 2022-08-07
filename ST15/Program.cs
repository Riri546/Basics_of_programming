Console.Clear();

//Problem solving method option 1

void Variant1(System.Random numberSintezator)

{
    int number = numberSintezator.Next();

        Console.Write("This is a random number: ");
        Console.WriteLine(number);

        int length = number.ToString().Length;

        string str = number.ToString();

        if (length > 3)
        {
            Console.Write("The third digit of a random number: ");
            Console.WriteLine(str[2]);
        }

        else
        {
             Console.Write("Error: not enough numbers: ");
        }
}

System.Random numberSintezator = new Random();

Variant1(numberSintezator);