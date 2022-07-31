//Метод считывает точки и возвращает массив с ним
int [,] readPoint()
{
    string inputLine = Console.ReadLine();

    string coordX = inputLine.Substring(0,inputLine.IndexOf(";"));
    coordX = coordX.Substring(coordX.IndexOf("=")+1);

    string coordY= inputLine.Substring(inputLine.IndexOf(";")+1);
    coordY = coordY.Substring(coordY.IndexOf("=")+1);

    Console.WriteLine(coordX+" "+coordY);

    return new int [1,1];

}

//Печатает номер четверти
//void ptintQuter(int[,] arrayPoint)
//{

//}

//int[,] arrayPoint = readPoint();

//printQuter(arrayPoint);

//printQuter (readPoint());

