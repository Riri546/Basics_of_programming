//Write a program that takes the coordinates of two points as input and finds the distance between them in 3D space.

Console.Clear();

int coordXPointA;
int coordXPointB;
int coordYPointA;
int coordYPointB;
int coordZPointA;
int coordZPointB;

double lengthAB;


//Reads coordinates of points A and B
void readDataOfPoint()
{
    Console.Write("Enter the X coordinate of point A: ");
    string inputNum1 = Console.ReadLine() ?? "";
    coordXPointA = int.Parse(inputNum1);

    Console.Write("Enter the Y coordinate of point A: ");
    string inputNum2 = Console.ReadLine() ?? "";
    coordYPointA = int.Parse(inputNum2);

    Console.Write("Enter the Z coordinate of point A: ");
    string inputNum3 = Console.ReadLine() ?? "";
    coordZPointA = int.Parse(inputNum3);

    Console.Write("Enter the X coordinate of point B: ");
    string inputNum4 = Console.ReadLine() ?? "";
    coordXPointB = int.Parse(inputNum4);

    Console.Write("Enter the Y coordinate of point B: ");
    string inputNum5 = Console.ReadLine() ?? "";
    coordYPointB = int.Parse(inputNum5);

    Console.Write("Enter the Z coordinate of point B: ");
    string inputNum6 = Console.ReadLine() ?? "";
    coordZPointB = int.Parse(inputNum6);
}

//calculates the distance between points A and B
void conculateLateLengthAB()
{
    lengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordYPointA - coordYPointB), 2) + Math.Pow((coordZPointA - coordZPointB), 2));
}

readDataOfPoint();
conculateLateLengthAB();

Console.WriteLine(lengthAB);