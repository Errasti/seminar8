int [,] array = {
    {1, 2, 3},
    {4, 6, 1},
    {2, 1, 6}
};

int[] sumNumbers = new int[10];

for ( int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumNumbers[array[i,j]] ++;
    }
}

for ( int i = 0; i < sumNumbers.Length; i++ )
{
    if (sumNumbers[i] != 0)
    { 
    Console.WriteLine("Элемент " + i + " встречается " + sumNumbers[i] + " раз");
    }
}
