
int[,] array = FillRandomArr();
double[] middles = MiddleValue(array);
PrintArr2(array);
System.Console.WriteLine();
PrintArr1(middles);


double[] MiddleValue(int[,] arr)
{
    double[] values = new double[arr.GetLength(1)];
    double sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }

        values[j] = Math.Round(sum/arr.GetLength(1),1);
        sum = 0;
    }
    return values;
}

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
            arr[i, j] = rrr.Next(1, 10);
        }
    }
    return arr;
}

void PrintArr2(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],5}");
        }
        Console.WriteLine();
    }
}

void PrintArr1(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {

        Console.Write($"{arr[i],5}");

    }
}

Console.ReadKey();