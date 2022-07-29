Console.Clear();

Console.WriteLine("Is one number the square of the second");

Console.Write("Enter the first number: ");
string? inputLineOne = Console.ReadLine();

Console.Write("Enter the second number: ");
string? inputLineTwo = Console.ReadLine();

if ((inputLineOne != null) && (inputLineTwo != null))
{
    int inputNumOne = int.Parse(inputLineOne);
    int inputNumTwo = int.Parse(inputLineTwo);

    int a = inputNumOne * inputNumOne;
    int b = inputNumTwo * inputNumTwo;

    if((a == inputNumTwo) || (b == inputNumOne))
    {
        Console.WriteLine("Yes!");
    }
    else
    {
        Console.WriteLine("No!");
    }
}