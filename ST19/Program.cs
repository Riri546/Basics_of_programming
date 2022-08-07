Console.Clear();


int coordXPointA;
int coordXPointB;
int coordYPointA;
int coordYPointB;

double lengthAB;


//Reads coordinates of points A and B
void ReadDataOfPoint()
{
    Console.Write("Enter the X coordinate of point A: ");
    string inputNum1 = Console.ReadLine() ?? "";
    coordXPointA = int.Parse(inputNum1);

    Console.Write("Enter the Y coordinate of point A: ");
    string inputNum2 = Console.ReadLine() ?? "";
    coordYPointA = int.Parse(inputNum2);

    Console.Write("Enter the X coordinate of point B: ");
    string inputNum4 = Console.ReadLine() ?? "";
    coordXPointB = int.Parse(inputNum4);

    Console.Write("Enter the Y coordinate of point B: ");
    string inputNum5 = Console.ReadLine() ?? "";
    coordYPointB = int.Parse(inputNum5);
}


//Calculates the distance between points A and B
void ConculateLateLengthAB()
{
    lengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordYPointA - coordYPointB), 2));
}

ReadDataOfPoint();
ConculateLateLengthAB();

Console.WriteLine(lengthAB);
