int[,] myArray = {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 0, 1, 2},
    {3, 4, 5, 6}
};

if (myArray.GetLength(0) != myArray.GetLength(1))
{
    Console.WriteLine("Это не квадратная матрица");
    return;
}

int[,] Transpose(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[i, j] = array[j, i];
        }
    }
    return result;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
ShowArray(Transpose(myArray));
