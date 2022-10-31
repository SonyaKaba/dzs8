Console.WriteLine("enter numbers of lines: ");
int size = int.Parse(Console.ReadLine());
int[,] numbers = new int[size+1, size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int minsum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}

Console.WriteLine("number line min sum = " + (indexLine) + ", sum element = " + (minsum));

void FillArrayRandomNumbers(int[,] thisarray)
{
    for (int i = 0; i < thisarray.GetLength(0); i++)
    {
        for (int j = 0; j < thisarray.GetLength(1); j++)
        {
            thisarray[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] myarray)
{
    for (int i = 0; i < myarray.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < myarray.GetLength(1); j++)
        {
            Console.Write(myarray[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}