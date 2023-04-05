


int[,] FillRandomRectangularArr()
{
    Random rrr = new Random();
    int lengI = rrr.Next(3, 8);
    int lengJ = lengI - rrr.Next(1, lengI-1);

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

void PrintMinLine(int[,] arr)
{
    int [] mins = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            mins[i]+=arr[i,j];
        }
    }

    Console.WriteLine((Array.IndexOf(mins,mins.Min())+1)+" строка");    

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

int[,] OurArr =FillRandomRectangularArr();
PrintArr(OurArr);
PrintMinLine(OurArr);
