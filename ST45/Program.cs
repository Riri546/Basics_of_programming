//Write a program that finds the intersection point of two straight lines given by the equations 
//y = k1 * x + b1, y = k2 * x + b2; the values b1, k1, b2 and k2 are set by the user.

///* Find the area of the triangle formed by the intersection of 3 straight lines
Console.Clear();

double b1;
double k1;

double b2;
double k2;

double b3;
double k3;

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

    Console.Write("Enter the b3: ");
    b3 = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Enter the k3: ");
    k3 = int.Parse(Console.ReadLine() ?? "");
}

//Solushion Task 45
void ConculateTask()
{
    double x1;
    double x2;
    double x3;

    double y1;
    double y2;
    double y3;

    double a;
    double b;
    double c;

    double s;

    //find the coordinates of the intersection point
    void IntersectionPoints()
    {
        x1 = (b1 / k1);
        x2 = (b2 / k2);
        x3 = (b3 / k3);
        // x = ((b3 - b2 - b1) / (k3 - k1 - k2));

        y1 = (k1 * x1) + b1;
        y2 = (k2 * x2) + b2;
        y3 = (k3 * x3) + b3;
        //y = k1 * ((b3 - b2 - b1) / (k3 - k1 - k2)) + b1;
    }

    //The method finds the length of the segment
    void ConculateLateLengthABC()
    {
        a = Math.Sqrt(Math.Pow((x1 - y1), 2));
        b = Math.Sqrt(Math.Pow((x2 - y2), 2));
        c = Math.Sqrt(Math.Pow((x3 - y3), 2));
    }

    //The method finds the area of the triangle
    void AreaTriangle()
    {
        s = a * b / 2;
    }

    //The method prints the result
    void PrintSolution()
    {
        DateTime d1 = DateTime.Now;

        ReadLine();
        IntersectionPoints();
        ConculateLateLengthABC();
        AreaTriangle();

        Console.WriteLine("Intersection points: x1 = " + x1 + "; y1 = " + y1 +
                                                "; x2 = " + x2 + "; y2 = " + y2 +
                                                "; x3 = " + x3 + "; y3 = " + y3);
        Console.WriteLine("The length of the straight A: " + a + "; B: " + b + "; C:" + c);
        Console.WriteLine("The area of the triangle: " + s);

        Console.WriteLine("Solution time: ");
        Console.WriteLine(DateTime.Now - d1);
    }

    //The method outputs the result of the solution to the console
    PrintSolution();
}

ConculateTask();






