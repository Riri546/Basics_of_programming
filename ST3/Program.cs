Console.WriteLine("Enter an integer");

string? inputLineOne = Console.ReadLine();

if(inputLineOne != null)
{
    int inputNumber = int.Parse(inputLineOne);

    int startNumber = 1;

    string lineOutput = "0";

    while (startNumber <= inputNumber)
    {
        lineOutput = startNumber*(-1)+", "+lineOutput+", "+startNumber;
        startNumber++;
    }
        
//  lineOutput = lineOutput+inputNumber; 

    Console.WriteLine(lineOutput);
}
  