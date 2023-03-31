//  var array = 
// {
//     {1,2,3,4},
//     {5,6,7,8},
//     {9,1,2,3}
// };




int[,] array = FillRandomArr();

Console.WriteLine("Введите значения индекса i и j");
Console.Write("i = ");
int i = int.Parse(Console.ReadLine());
Console.Write("j = ");
int j = int.Parse(Console.ReadLine());

PrintArr(array);

if(Contain(array,i,j)==true)
    System.Console.WriteLine($"[{i},{j}] = {array[i,j]}");

else
    System.Console.WriteLine("Такого элемента в массиве нет");

bool Contain(int[,]arr, int i, int j )
{
    bool contain = false;
    if (i<=arr.GetLength(0)&&j<=arr.GetLength(1))
        contain=true;
    return contain;
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3}");
        }
        Console.WriteLine();
    }
}

int[,] FillRandomArr()
{
    Random rrr = new Random();
    int lengI = rrr.Next(3,8);
    int lengJ = rrr.Next(3,8);

    int[,] arr = new int[lengI, lengJ];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rrr.Next(1,10);
        }
    }
    return arr;
} 
