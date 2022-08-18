int[,] oneArray = {
    {2, 1, 1, 1},
    {1, 1, 5, 4},
    {1, 3, 1, 1},
    {1, 2, 5, 2}
};

int[,] secondArray = {
    {1, 2, 1, 5},
    {1, 1, 4, 1},
    {1, 3, 1, 1},
    {1, 1, 2, 1}
};

void MultipleArray(int[,] firstArray, int[,] secArray)
{
    int[,] resArray = new int[firstArray.GetLength(0), secArray.GetLength(1)];

    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secArray.GetLength(1); j++)
        {
            for (int q = 0; q < firstArray.GetLength(1); q++)
            {
                resArray[i, j] += firstArray[i, q] * secondArray[q, j];
            }
        }
    }
    for (int a = 0; a < firstArray.GetLength(0); a++)
    {
        for (int c = 0; c < secArray.GetLength(1); c++)
        {
            Console.Write(resArray[a, c] + "\t");
        }
        Console.WriteLine();
    }
}


MultipleArray(oneArray, secondArray);
