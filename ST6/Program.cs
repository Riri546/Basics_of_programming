Console.Clear();

Console.WriteLine("Enter two numbers and I'll tell you more");

Console.Write("Enter the first number: ");
string? inputLineOne = Console.ReadLine();

Console.Write("Enter the second number: ");
string? inputLineTwo = Console.ReadLine();

Console.Write("Enter the third number: ");
string? inputLineThree = Console.ReadLine();

   if (inputLineOne != null && inputLineTwo != null && inputLineThree != null)
{
   int A = int.Parse(inputLineOne);
   int B = int.Parse(inputLineTwo);
   int C = int.Parse(inputLineThree);
      if (A > B)
   {
         if (A > C)
      {
         Console.Write("The first number is larger!");
      }
   else
{
   Console.Write("The third number is larger!");
}
   }
   else
   {  
   if (B > C)
   {
   Console.Write("The second number is larger!");
   }
   else
   {
   Console.Write("The third number is larger!");
   }
   }
}
