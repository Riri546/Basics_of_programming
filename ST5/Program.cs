//Write a program that accepts two numbers as input and outputs which number is larger and which is smaller.

Console.Clear();

Console.WriteLine("Enter two numbers and I'll tell you more");

Console.Write("Enter the first number: ");
string? inputLineOne = Console.ReadLine();

Console.Write("Enter the second number: ");
string? inputLineTwo = Console.ReadLine();

if (inputLineOne != null && inputLineTwo != null) 
{
    int A = int.Parse(inputLineOne);
    int B = int.Parse(inputLineTwo);

    if (A == B) 
    {
        Console.Write("The numbers are equal!");
    } 
    
    else 
        if (A > B)
        {
            Console.Write("The first number is larger!");
        } 
        else 
        {
            Console.Write("The second number is larger!");
        }
}