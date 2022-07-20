Console.WriteLine("Welcome, here you can find the square of any number quickly and easily!)))");
Console.WriteLine("Enter a number:");
string? inputLine = Console.ReadLine();
if(inputLine != null)
{
    int inputNumber = int.Parse (inputLine);

    ///int outNumber = inputNumber*inputNumber;
    int outNumber = (int)Math.Pow(inputNumber,2);
    Console.WriteLine("The square of the number:");
    Console.WriteLine(outNumber);
}