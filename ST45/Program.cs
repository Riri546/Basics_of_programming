//Write a program that finds the intersection point of two straight lines given by the equations 
//y = k1 * x + b1, y = k2 * x + b2; the values b1, k1, b2 and k2 are set by the user.

Console.Clear();

double b1;
double k1;
double b2;
double k2;
double x;
double y;

//The method accepts input data from the user
void ReadLine()
{
    Console.Write("Enter the b1: ");
    b1 = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Enter the k1: ");
    k1 = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Enter the b2: ");
    b2 = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Enter the k2: ");
    k2 = int.Parse(Console.ReadLine() ?? "");
}

//The method solves the task 45
void ConculateTask()
{
    x = ((b2 - b1) / (k1 - k2));
    y = k1 * ((b2 - b1) / (k1 - k2)) + b1;


}

//The method prints the result
void PrintSolution()
{
    Console.WriteLine("( x= " + x + "; y= " + y + ")");
}

ReadLine();
ConculateTask();
PrintSolution();