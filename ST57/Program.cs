//Print the first N lines of Pascal's triangle. Make a conclusion in the form of an isosceles triangle.

Console.Clear();

int i, n, c;

//The method accepts a number from the user as input
int ReadLine()
{
    Console.WriteLine("Enter the required number of lines of Pascal's triangle: ");
    int s = int.Parse(Console.ReadLine() ?? "");
    n = Convert.ToInt32(s);
    return n;

}

//The method calculates the factorial
static float factorial(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

//The method creates a Pascal triangle
void PascalTriangle(int n)
{
    for (i = 0; i < n; i++)
    {
        for (c = 0; c <= (n - i); c++) // создаём после каждой строки n-i отступов от левой стороны консоли, чем ниже строка, тем меньше отступ
        {
            Console.Write(" ");
        }
        for (c = 0; c <= i; c++)
        {
            Console.Write(" "); // создаём пробелы между элементами треугольника
            Console.Write(factorial(i) / (factorial(c) * factorial(i - c))); //формула вычисления элементов треугольника
        }
        Console.WriteLine();
        Console.WriteLine(); // после каждой строки с числами отступаем две пустые строчки
    }
    Console.ReadLine();
}

PascalTriangle(ReadLine());
