﻿Console.Clear();

int coordXPointA;
int coordXPointB;
int coordYPointA;
int coordYPointB;

double lengthAB;


//Считывает координаты точек A и B
void readDataOfPoint()
{
    Console.WriteLine("Введите координату X точки A");
    coordXPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки A");
    coordYPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату X точки B");
    coordXPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки B");
    coordYPointB = int.Parse(Console.ReadLine());
}

//вычисляет растояние между точками A и B
void conculateLateLengthAB()
{
    lengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB),2) + Math.Pow ((coordYPointA - coordYPointB),2));
}

readDataOfPoint();
conculateLateLengthAB();

Console.WriteLine(lengthAB);