Console.WriteLine("Enter an integer");

string? inputLineOne = Console.ReadLine();

if(inputLineOne != null)
{
    int inputNumber = int.Parse(inputLineOne);

    int startNumber = (inputNumber * -1);

    string lineOutput = "";

    while (startNumber < inputNumber)
    {
        lineOutput = lineOutput+startNumber+", ";
        startNumber++;
    }
        
    lineOutput = lineOutput+inputNumber; 

    Console.WriteLine(lineOutput);
}
  