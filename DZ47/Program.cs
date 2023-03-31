System.Console.WriteLine("Задайте размерность m x n");
System.Console.Write("m = ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("n = ");
int n = int.Parse(Console.ReadLine());

double[,] ar = FillRandomArr(m, n);
PrintArr(ar);

double[,] FillRandomArr(int lengI, int lengJ)
{
    double[,] arr = new double[lengI, lengJ];
    Random rrr = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(rrr.NextDouble()*10 , 1);
        }
    }
    return arr;
}

void PrintArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j],6}");
        }
        System.Console.WriteLine();
    }
}




