int[,] myArray = {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 0, 1, 2},
    {3, 4, 5, 6},
    {7, 8, 9, 0}
};

void Swap(int[,] array)
{
    int temp = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
       temp = array[0,i];
       array[0,i] = array[array.GetLength(0) - 1, i];
       array[array.GetLength(0) - 1, i] = temp;
    }
}

void ShowArray (int[,] array)
{
    for( int i = 0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
Swap(myArray);
ShowArray(myArray);