//Write a program that outputs a random three-digit number and deletes the second digit of that number.

Console.Clear();

//Problem solving method option 1
void Variant1(System.Random numberSintezator)

{
    int number;
    int firstNumber;
    int secondNumber;
    int resultNumber;

    //The method takes a number from the console
    void ReadNumber()
    {
        number = numberSintezator.Next(100, 1000);

        Console.Write("This is a random number: ");
        Console.WriteLine(number);
    }

    //Solving the problem
    void ConculateSimple()
    {
        firstNumber = number / 100;

        secondNumber = number % 10;

        resultNumber = firstNumber * 10 + secondNumber;

        Console.Write("Removed the second digit from a random number: ");
        Console.WriteLine(resultNumber);
    }

    ReadNumber();
    ConculateSimple();
}

System.Random numberSintezator = new Random();

Variant1(numberSintezator);