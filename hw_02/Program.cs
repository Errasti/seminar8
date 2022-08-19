int[,] myArray = {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {0, 0, 1, 2},
    {3, 4, 5, 6}
};

int[] FindMinSum(int[,] array)
{
    int[] sum = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum[i] = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i, j];
        }
    }
    return sum;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Массив сумм строк: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
ShowArray(FindMinSum(myArray));

void FindMinLine(int[] array)
{
    int iMin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[iMin])
        {
            iMin = i;
        }
    }
    iMin++; // Потому что переменная по факту это номер индекса, а нам нужен номер строки, соответственно добавляем единицу
    Console.WriteLine("Строка с минимальной суммой: " + iMin);
}

Console.WriteLine();
FindMinLine(FindMinSum(myArray));
