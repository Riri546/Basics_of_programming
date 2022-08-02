Console.Clear();


int coordXPointA;
int coordXPointB;
int coordYPointA;
int coordYPointB;

double lengthAB;


//Reads coordinates of points A and B
void readDataOfPoint()
    {
    Console.WriteLine("Enter the X coordinate of point A");
    coordXPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the Y coordinate of point A");
    coordYPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the X coordinate of point B");
    coordXPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the Y coordinate of point B");
    coordYPointB = int.Parse(Console.ReadLine());
    }


//Calculates the distance between points A and B
void conculateLateLengthAB()
{
    lengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordYPointA - coordYPointB), 2));
}

readDataOfPoint();
conculateLateLengthAB();

Console.WriteLine(lengthAB);
}