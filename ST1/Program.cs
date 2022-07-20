Console.WriteLine("Let's check if the first number is the square of the second one?))");
Console.WriteLine("Enter the first number:");
string? inputLineOne = Console.ReadLine();
Console.WriteLine("Enter the second number:");
string? inputLineTwo = Console.ReadLine();

if(inputLineOne != null && inputLineTwo != null){
    int inputNumberOne = int.Parse(inputLineOne);
    int inputNumberTwo = int.Parse(inputLineTwo);
    
    //if (inputNumberOne == inputNumberTwo * inputNumberTwo){
    //    Console.WriteLine("Yes");
    //}
    //else
    //{
    //Console.WriteLine("No");
    //}
    if (inputNumberTwo == Math.Sqrt(inputNumberOne)){
        Console.WriteLine("Constitute");
    }
    else
    {
        Console.WriteLine("Is not");
    }
}
