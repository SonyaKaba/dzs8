Console.WriteLine("enter size of array: ");
int size = int.Parse(Console.ReadLine());

int[,] thisarray = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    thisarray[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(thisarray);

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