﻿//Write a program that outputs an array of 8 elements filled with zeros and ones in random order.

Console.Clear();

System.Random numberSintezator = new Random();

void VariantNaive()
{
    int i = 0;
    Console.Write("[");
    while (i < 8 - 1)
    {
        Console.Write(numberSintezator.Next(0, 2) + ",");
        i++;
    }
    Console.Write(numberSintezator.Next(0, 2));
    Console.Write("]");
}


VariantNaive();