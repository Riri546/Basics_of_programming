//Write a program that takes the coordinates of a point (X and Y) as input, with X ≠ 0 and Y ≠ 0 
//and outputs the number of the quarter of the plane in which this point is located.

Console.Clear();

Console.Write("Enter a number: ");
string inputLine = Console.ReadLine() ?? "";

//The method reads the points and returns an array with it 
int[,] ReadPoint()

{
    string coordXLine = inputLine.Substring(0, inputLine.IndexOf(";"));
    coordXLine = coordXLine.Substring(coordXLine.IndexOf("=") + 1);

    string coordYLine = inputLine.Substring(inputLine.IndexOf(";") + 1);
    coordYLine = coordYLine.Substring(coordYLine.IndexOf("=") + 1);

    //Console.WriteLine(coordX+" "+coordY);

    int coordX = int.Parse(coordXLine);
    int coordY = int.Parse(coordYLine);

    int[,] arreyOut = new int[1, 2];
    arreyOut[0, 0] = coordX;
    arreyOut[0, 1] = coordY;

    return arreyOut;
    
}

//Prints the quarter number
void PtintQuter(int[,] arreyPoint)
{
    if (arreyPoint[0, 0] > 0 && arreyPoint[0, 1] > 0)
    {
        Console.WriteLine("1 quarter");
    }

    if (arreyPoint[0, 0] < 0 && arreyPoint[0, 1] > 0)
    {
        Console.WriteLine("2 quarter");
    }

    if (arreyPoint[0, 0] < 0 && arreyPoint[0, 1] < 0)
    {
        Console.WriteLine("3 quarter");
    }

    if (arreyPoint[0, 0] > 0 && arreyPoint[0, 1] < 0)
    {
        Console.WriteLine("4 quarter");
    }

}

int[,] arreyPoint = ReadPoint();

PtintQuter(arreyPoint);

//ptintQuter (readPoint());

