Console.WriteLine("Добро пожаловать, здесь вы сможете найти квадрат любого числа быстро и просто!)))");
Console.WriteLine("Введите число:");
string? inputLine = Console.ReadLine();
if(inputLine != null)
{
    int inputNumber = int.Parse (inputLine);

    ///int outNumber = inputNumber*inputNumber;
    int outNumber = (int)Math.Pow(inputNumber,2);
    Console.WriteLine("Квадрат числа:");
    Console.WriteLine(outNumber);
}