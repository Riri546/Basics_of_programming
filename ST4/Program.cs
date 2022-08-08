//Write a program that accepts a three-digit number as input and shows the last digit of this number as output.

Console.Clear();

Console.Write("Enter a three-digit number:");

// string inputLine = Console.ReadLine();
        
// if (inputLine != null)
//  {
//      int inputNumber = int.Parse(inputLine);

//      int outputNumber = inputNumber % 10;

//      Console.WriteLine(outputNumber);
//  }

 string? inputLineOne = Console.ReadLine();
if(inputLineOne != null)
{
    string lastNum = inputLineOne.Substring(2,1);

    Console.WriteLine(lastNum);
}