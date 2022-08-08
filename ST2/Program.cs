//Write a program that will give the name of the day of the week by a given number.

Console.Clear();

int inputNumber;
int t;

//The method takes a number from the console
void ReadNumber()
{
    Console.Write("Write down the number and I'll tell you the day of the week: ");
    string inputLine = Console.ReadLine() ?? "";
    inputNumber = int.Parse(inputLine);
}

//The method solves using Switch
void SolutionSwitch()
{
    switch (inputNumber)
    {
        case 1:
            t = Environment.TickCount;
            Console.WriteLine("Switch solution: Monday");
            Console.WriteLine("Switch solution time: {0} ms", Environment.TickCount - t);
            break;

        case 2:
            t = Environment.TickCount;
            Console.WriteLine("Switch solution: Tuesday");
            Console.WriteLine("Switch solution time: {0} ms", Environment.TickCount - t);
            break;

        case 3:
            t = Environment.TickCount;
            Console.WriteLine("Switch solution: Wednesday");
            Console.WriteLine("Switch solution time: {0} ms", Environment.TickCount - t);
            break;

        case 4:
            t = Environment.TickCount;
            Console.WriteLine("Switch solution: Thursday");
            Console.WriteLine("Switch solution time: {0} ms", Environment.TickCount - t);
            break;

        case 5:
            t = Environment.TickCount;
            Console.WriteLine("Switch solution: Friday");
            Console.WriteLine("Switch solution time: {0} ms", Environment.TickCount - t);
            break;

        case 6:
            t = Environment.TickCount;
            Console.WriteLine("Switch solution: Saturday");
            Console.WriteLine("Switch solution time: {0} ms", Environment.TickCount - t);
            break;


        case 7:
            t = Environment.TickCount;
            Console.WriteLine("Switch solution: Sunday");
            Console.WriteLine("Switch solution time: {0} ms", Environment.TickCount - t);
            break;
    }
}

//The method solves in a simple way
void ConculateSimple()
{
    string[] day0Week = new string[7];

    day0Week[0] = "Monday";
    day0Week[1] = "Tuesday";
    day0Week[2] = "Wednesday";
    day0Week[3] = "Thursday";
    day0Week[4] = "Friday";
    day0Week[5] = "Saturday";
    day0Week[6] = "Sunday";

    t = Environment.TickCount;
    Console.WriteLine("Simple solution: " + day0Week[inputNumber - 1]);
    Console.WriteLine("Simple solution time: {0} ms", Environment.TickCount - t);
}

ReadNumber();
SolutionSwitch();
ConculateSimple();

