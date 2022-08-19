void CreateArray(int row, int col, int lin)
{
    int[,,] array = new int[row, col, lin];
    int ident = 10;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = ident;
                ident++;
                Console.WriteLine(array[i, j, k] + "(" + i + "," + j + "," + k + ")");
            }
        }
    }
}

Console.WriteLine("Введите размер первого измерения массива: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите размер второго измерения массива: ");
int col = int.Parse(Console.ReadLine());
Console.WriteLine("Введите размер третьего измерения массива: ");
int lin = int.Parse(Console.ReadLine());
CreateArray(row, col, lin);
