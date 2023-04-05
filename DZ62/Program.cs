
int[,] ArraySpiral ()
{
    int n =4;
    int[,] arr = new int [n,n];
    int num = 1;
    int row=0, col=0, layer=0;
    while(num<=n*n)
    {
        //right
        for (int i = layer; i < n-layer; i++)
        {
            arr[row,i]=num++;
        }
        //down
        for (int i = layer+1; i < n-layer; i++)
        {
            arr[i,n-col-1]=num++;
        }
        //left
        for (int i = n-layer-2; i >= layer; i--)
        {
            arr[n-row-1,i]=num++;
        }
        //up
        for (int i = n-layer-2; i > layer; i--)
        {
            arr[i,col]=num++;
        }
        row++;
        col++;
        layer++;
    }

    return arr;
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

int[,] array = ArraySpiral();
PrintArr(array);