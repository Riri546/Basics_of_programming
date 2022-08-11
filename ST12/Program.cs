//Write a program that takes a number as input and checks whether it is a multiple of 7 and 23 at the same time.

Console.Clear();

int number;
int resultNumber1;
int resultNumber2;

//The method takes a number from the console
void ReadNumber()
{
    Console.WriteLine("Is your number a multiple of 7 and 23?");

    Console.Write("Enter number: ");
    string firstNumber = Console.ReadLine() ?? "";
    number = int.Parse(firstNumber);
}

//The method checks whether the entered number is a multiple of 7
void MultipleOf7()
{
    resultNumber1 = number % 7;

    if (resultNumber1 == 0)
    {
        Console.WriteLine("Yes, this number is a multiple of 7!");
    }
    else
    {
        Console.WriteLine("No , this number is not a multiple of 7: " + resultNumber1);
    }
}

////The method checks whether the entered number is a multiple of 23
void MultipleOf23()
{
    resultNumber2 = number % 23;

    if (resultNumber2 == 0)
    {
        Console.WriteLine("Yes, this number is a multiple of 23!");
    }
    else
    {
        Console.WriteLine("No , this number is not a multiple of 23: " + resultNumber2);
    }
}

ReadNumber();
MultipleOf7();
MultipleOf23();