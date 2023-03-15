
System.Console.Write("Количество чисел = ");
int m = int.Parse(Console.ReadLine());

int [] a = new int [m];
int count = 0;

for (int i = 0; i < m; i++)
{
    System.Console.Write($"a[{i}] = ");
    a[i]= int.Parse(Console.ReadLine());

    if (a[i]>0)
    {
        count++;
    }
}

System.Console.WriteLine($" -> {count}");