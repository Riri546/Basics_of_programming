Console.Clear();

//Problem solving method option 1

void Variant1(System.Random numberSintezator)

{
    int number = numberSintezator.Next(100,1000);

        Console.Write("This is a random number: ");
        Console.WriteLine(number);

    int firstNumber = number % 100;

    int resultNumber = firstNumber / 10;

        Console.Write("The second digit of the random number: ");
        Console.WriteLine(resultNumber);
}

System.Random numberSintezator = new Random();

Variant1(numberSintezator);