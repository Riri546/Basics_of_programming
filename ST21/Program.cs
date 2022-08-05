Console.Clear();

int P;

int D1;
int D2;
int D3;
int D4;
int D5;

//
void enterNumber()
{
    Console.Write("Enter Number: ");
    P = int.Parse(Console.ReadLine());
}
//Decomposition of a number
void decompositionOfaNumber()
{
    D1 = (P/10000);
    D2 = (P/1000)%10;
    D3 = (P/100)%10;
    D4 = (P/10)%10;
    D5 = P%10;
}


enterNumber();
decompositionOfaNumber();

    if (D1 == D5 && D2 == D4)
    {
        Console.Write("Is a palindrome");
    }
    else
    {
        Console.Write("Is not a palindrome");
    }