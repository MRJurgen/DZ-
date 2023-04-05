

int[,] FillRandomArr()
{
    Random rrr = new Random();
    int lengI = rrr.Next(3, 8);
    int lengJ = rrr.Next(3, 8);

    int[,] arr = new int[lengI, lengJ];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1,10);
        }
    }
    return arr;
}

void PrintSortArr(int[,] arr)
{
    int [,] NewArr = new int [arr.GetLength(0),arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int[] arr2 = new int [arr.GetLength(1)];
        //int max =arr[i,0];
        //int min= arr[i,arr.GetLength(0)-1];
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr2[j] = arr[i,j];
        }
        Array.Sort(arr2);
        Array.Reverse(arr2);
        for (int z = 0; z < arr2.Length; z++)
        {
            Console.Write($"{arr2[z],3}");
        }
        Console.WriteLine();

    }
    
}

void PrintArr(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            Console.Write($"{ar[i, j],3}");
        }
        Console.WriteLine();
    }
}

int[,] OurArr =FillRandomArr();
PrintArr(OurArr);
Console.WriteLine();
PrintSortArr(OurArr);