System.Random numberSintezator = new Random();

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
