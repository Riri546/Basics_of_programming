//Form a three-dimensional array of non-repeating two-digit numbers. 
//Write a program that will output an array line by line, adding indexes of each element.

//array size 3 x 3 x 3

Console.Clear();

//Creating a three-dimensional array
int[,,] Fill3DArray(int m, int n, int l)
{
    List<int> list = new List<int>();

    int[,,] outArray = new int[m, n, l];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; j < l; k++)
            {
                 int randomNumberSynthesizer = new Random().Next(10, 100);
                if (!(list.Contains(randomNumberSynthesizer)))
                {
                    outArray[i, j, k] = randomNumberSynthesizer;
                    list.Add(randomNumberSynthesizer);
                    Console.WriteLine(outArray[i, j, k] + "(" + i + "," + j + "," + k + ")");                    
                }
                else k++;
            }
            }
        }
        return outArray;
    }
    
//The method prints an array 
void PrintTwoDimArray(int[,,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            for (int k = 0; k < inputArray.GetLength(2); k++)
            {
                Console.Write(inputArray[i, j, k] + "\t");
            }
        }
        Console.Write("\n");
    }
}

//The body of the task, launches the ce methods
void Result()
{
    DateTime d1 = DateTime.Now;

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Array: ");
    Console.ResetColor();

    int[,,] twoDimArray = Fill3DArray(3, 3, 3);
    PrintTwoDimArray(twoDimArray);
}

Result();