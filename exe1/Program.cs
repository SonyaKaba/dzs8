Console.WriteLine(" enter line number: ");
int lines = int.Parse(Console.ReadLine());
Console.WriteLine(" enter column number: ");
int columns = int.Parse(Console.ReadLine());
int[,] numbers = new int[lines, columns];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Arary ");
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < numbers.GetLength(1) - 1; z++)
        {
            if (numbers[i, z] > numbers[i, z + 1])
            {
                int temp = 0;
                temp = numbers[i, z];
                numbers[i, z] = numbers[i, z + 1];
                numbers[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Sorted array ");
PrintArray(numbers);

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