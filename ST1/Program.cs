string? inputLineOne = Console.ReadLine();
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
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}
