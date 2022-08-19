void Spiral(int[,] array)
{
    int count = 1;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        array[0, i] = count;
        count++;
    }
    for (int x = 1; x < array.GetLength(0); x++)
    {
        array[x, array.GetLength(1) - 1] = count;
        count++;
    }
    for (int z = array.GetLength(1) - 2; z >= 0; z--)
    {
        array[array.GetLength(0) - 1, z] = count;
        count++;
    }
    for (int t = array.GetLength(0) - 2; t > 0; t--)
    {
        array[t, 0] = count;
        count++;
    }

    // новые координаты заполнения
    int c = 1;
    int d = 1;



    while (count < array.GetLength(0) * array.GetLength(1))
    {
        // движемся вправо
        while (array[c, d + 1] == 0)
        {
            array[c, d] = count;
            count++;
            d++;
        }
        // движемся вниз
        while (array[c + 1, d] == 0)
        {
            array[c,d] = count;
            count++;
            c++;
        }
        // движемся влево

        while(array[c, d-1] == 0)
        {
            array[c,d] = count;
            count++;
            d--;
        }
        // движемся вверх

        while(array[c - 1, d] == 0)
        {
            array[c,d] = count;
            count++;
            c--;
        }
    }

    for (int x = 0; x < array.GetLength(0); x++ )
    {
        for ( int y = 0; y < array.GetLength(1); y++ )
        {
            if (array[x,y] == 0)
            {
                array[x,y] = count;
            }
        }
    }

    for ( int n = 0; n < array.GetLength(0); n++)
    {
        for ( int m = 0; m < array.GetLength(1); m++)
        {
            Console.Write(array[n,m] + "\t");
        }
        Console.WriteLine();
    }    
}

int[,] myArray = new int[4,4];

Spiral(myArray);
