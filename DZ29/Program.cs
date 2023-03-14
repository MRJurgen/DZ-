
int [] arr = new int [8];

System.Console.WriteLine("Введите массив");

for (int i = 0; i < arr.Length; i++)
{
    System.Console.Write($"a[{i+1}] = ");
    arr[i] = int.Parse(Console.ReadLine());
}
System.Console.Write("[ ");
foreach (int item in arr)
{
    System.Console.Write(item + " ");
}
System.Console.Write("]");
