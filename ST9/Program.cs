//Write a program that outputs a random number from the segment [10, 100] and shows the largest digit of the number.

Console.Clear();

//Problem solving method option 1

void Variant1(System.Random numberSintezator)
{
    int number;
    int firstNumber;
    int secondNumber;

    //The method outputs a random number
    void RandomNumber()
    {
        Console.WriteLine("Problem solving method option 1");

        number = numberSintezator.Next(10, 100);

        Console.Write("This is a random number: ");
        Console.WriteLine(number);
    }

    //Parsing the number
    void ParsingNumber()
    {
        firstNumber = number / 10;

        secondNumber = number % 10;
    }

    //The final solution through the condition if
    void ConculateSimple()
    {
        if (firstNumber > secondNumber)
        {
            Console.Write("The largest digit of the number: ");
            Console.WriteLine(firstNumber);
        }
        else
        {
            Console.Write("The largest digit of the number: ");
            Console.WriteLine(secondNumber);
        }
    }

    RandomNumber();
    ParsingNumber();
    ConculateSimple();
}

//Problem solving method option 2
void Variant2(System.Random numberSintezator)

{
    int numberLili;
    string stringNum;

    //The method outputs a random number
    void RandomNumber()
    {
        Console.WriteLine("Problem solving method option 2");

        numberLili = new Random().Next(10, 100);

        Console.Write("This is a random number: ");
        Console.WriteLine(numberLili);
    }

    //Solution via toString
    void SolutionToString()
    {
        stringNum = numberLili.ToString();

        Console.Write("The biggest digit is: ");
    }

    //The final solution through the condition if
    void ConculateSimple()
    {
        if (stringNum[0] > stringNum[1])
        {
            Console.WriteLine(stringNum[0]);
        }
        else
        {
            Console.WriteLine(stringNum[1]);
        }
    }

    RandomNumber();
    SolutionToString();
    ConculateSimple();
}


//Problem solving method option 3
void Variant3(System.Random numberSintezator)
{
    char[] digits;
    int firstNumber;
    int secondNumber;
    int resultNumber;

    //The method outputs a random number
    void RandomNumber()
    {
        Console.WriteLine("Problem solving method option 3");

        digits = numberSintezator.Next(10, 100).ToString().ToArray();

        Console.Write("This is a random number: ");
        Console.WriteLine(digits);
    }

    //The final solution 
    void ConculateSimple()
    {
        firstNumber = ((int)digits[0]) - 48;
        secondNumber = ((int)digits[1]) - 48;

        resultNumber = firstNumber > secondNumber ? resultNumber = firstNumber : resultNumber = secondNumber;

        Console.Write("The biggest digit is: ");
        Console.WriteLine(resultNumber);
    }

    RandomNumber();
    ConculateSimple();
}

System.Random numberSintezator = new Random();

Variant1(numberSintezator);

Variant2(numberSintezator);

Variant3(numberSintezator);