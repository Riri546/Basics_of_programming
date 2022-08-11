//Write a program that outputs the third digit of a given number or reports that there is no third digit.

Console.Clear();

//Problem solving method option 1
void Variant1(System.Random numberSintezator)

{
    int number;
    int length;
    string str;

    //The method outputs a random number
    void RandomNumber()
    {
        number = numberSintezator.Next();

        Console.Write("This is a random number: ");
        Console.WriteLine(number);
    }

    //The method calculates the length of a number
    void NumberLength()
    {
        length = number.ToString().Length;

        str = number.ToString();
    }

    //The final solution through the condition if
    void FinalSolution()
    {
        if (length >= 3)
        {
            Console.Write("The third digit of a random number: ");
            Console.WriteLine(str[2]);
        }

        else
        {
            Console.Write("Error: not enough numbers");
        }
    }

    RandomNumber();
    NumberLength();
    FinalSolution();
}

System.Random numberSintezator = new Random();

Variant1(numberSintezator);