

int[,,] TripleArray ()
{
    int[,,] arr = new int[2,2,2];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
               arr[i, j, z] = new Random().Next(10,100);
            }
        }        
    }
    return arr;
}

void PrintArr(int[,,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            for (int z = 0; z < ar.GetLength(2); z++)
            {
            Console.Write($"{ar[i, j, z]}({i},{j},{z})   ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] array = TripleArray();
PrintArr(array);