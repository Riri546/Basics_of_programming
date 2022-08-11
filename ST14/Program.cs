//Write a program that accepts a three-digit number as input and shows the second digit of this number as output

Console.Clear();

//Problem solving method option 1

void Variant1(System.Random numberSintezator)

{
    int number;
    int firstNumber;
    int resultNumber;

    //The method outputs a random number
    void RandomNumber()
    {
        number = numberSintezator.Next(100, 1000);

        Console.Write("This is a random number: ");
        Console.WriteLine(number);

    }

    //Solving the problem
    void ConculateSimple()
    {
        firstNumber = number % 100;

        resultNumber = firstNumber / 10;
    }

    //The method outputs the result of the solution
    void PrintResult()
    {
        Console.Write("The second digit of the random number: ");
        Console.WriteLine(resultNumber);
    }

    RandomNumber();
    ConculateSimple();
    PrintResult();
}

System.Random numberSintezator = new Random();

Variant1(numberSintezator);