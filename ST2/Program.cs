Console.WriteLine("Write down the number and I'll tell you the day of the week:");
string? inputLine = Console.ReadLine();
if(inputLine != null)
{
    int inputNumber = int.Parse (inputLine);
    
    string[] day0Week = new string[7];

    day0Week[0] = "Monday";
    day0Week[1] = "Tuesday";
    day0Week[2] = "Wednesday";
    day0Week[3] = "Thursday";
    day0Week[4] = "Friday";
    day0Week[5] = "Saturday";
    day0Week[6] = "Sunday";
    
            
    Console.WriteLine(day0Week[inputNumber-1]);
}