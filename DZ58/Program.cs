

Console.WriteLine("Задайте первую матрицу:");
int [,] arr1 = new int [2,2];
for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            Console.Write($"a [{i},{j}] = ");
            arr1[i,j] = int.Parse(Console.ReadLine());
        }
    }
Console.WriteLine("Задайте вторую матрицу: ");
int[,] arr2 = new int [2,2];
for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            Console.Write($"b [{i},{j}] = ");
            arr2[i,j] = int.Parse(Console.ReadLine());
        }
    }

int[,] FindProduct (int[,] array1, int [,] array2)
{
    int[,] Find = new int [array1.GetLength(0),array1.GetLength(1)];
    Find[0,0]= array1[0,0]*array2[0,0]+array1[0,1]*array2[1,0];
    Find[0,1]= array1[0,0]*array2[0,1]+array1[0,1]*array2[1,1];
    Find[1,0]= array1[1,0]*array2[0,0]+array1[1,1]*array2[1,0];
    Find[1,1]= array1[1,0]*array2[0,1]+array1[1,1]*array2[1,1];
    return Find;
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

PrintArr(arr1);
Console.WriteLine();
PrintArr(arr2);
Console.WriteLine();
int[,] product = FindProduct(arr1,arr2);
PrintArr(product);