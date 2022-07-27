Console.Clear();

//Problem solving method option 1

void variant1(System.Random numberSintezator)
{
    Console.WriteLine("Problem solving method option 1");

    int number = numberSintezator.Next(10,100);

    Console.Write("This is a random number: ");
    Console.WriteLine(number);

    int firstNumber = number/10;

    int secondNumber = number%10;

    if (firstNumber>secondNumber)
    {
        Console.Write("The largest digit of the number: ");
        Console.WriteLine(firstNumber);
    }
    else
    {
        Console.Write("The largest digit of the number: ");
        Console.WriteLine (secondNumber); 
    }

}

//Problem solving method option 2
void variant2(System.Random numberSintezator)

{
    Console.WriteLine("Problem solving method option 2");

    int numberLili = new Random().Next(10,100);

    Console.Write("This is a random number: ");
    Console.WriteLine(numberLili);

    string stringNum = numberLili.ToString();

    Console.Write("The biggest digit is: ");
    if (stringNum[0] > stringNum[1])
    {
        Console.WriteLine(stringNum[0]);
    }
    else 
    {
     Console.WriteLine(stringNum[1]);   
    }
}

//Problem solving method option 3
void variant3(System.Random numberSintezator)

{
    Console.WriteLine("Problem solving method option 3");

    char[] digits = numberSintezator.Next(10,100).ToString().ToArray();

    Console.Write("This is a random number: ");
    Console.WriteLine(digits);

    int firstNumber = ((int)digits[0])-48;
    int secondNumber = ((int)digits[1])-48;

    int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;

    Console.Write("The biggest digit is: ");
    Console.WriteLine(resultNumber);
}




System.Random numberSintezator = new Random();

variant1(numberSintezator);

variant2(numberSintezator);

variant3(numberSintezator);