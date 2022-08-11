//Write a program that takes two numbers as input and checks whether one number is the square of the other.

Console.Clear();

int inputNumOne;
int inputNumTwo;
int a;
int b;

//The method takes a number from the console
void ReadNumber()
{
    Console.WriteLine("Is one number the square of the second");

    Console.Write("Enter the first number: ");
    string inputLineOne = Console.ReadLine() ?? "";
    inputNumOne = int.Parse(inputLineOne);

    Console.Write("Enter the second number: ");
    string inputLineTwo = Console.ReadLine() ?? "";
    inputNumTwo = int.Parse(inputLineTwo);
}

////Solving the problem
void ConculateSimple()
{
    a = inputNumOne * inputNumOne;
    b = inputNumTwo * inputNumTwo;

    if ((a == inputNumTwo) || (b == inputNumOne))
    {
        Console.WriteLine("Yes!");
    }
    else
    {
        Console.WriteLine("No!");
    }
}

ReadNumber();
ConculateSimple();