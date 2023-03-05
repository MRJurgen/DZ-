System.Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

System.Console.Write("Числа:");

for (int i = 1; i < n+1; i++)
{
    System.Console.Write(Math.Pow(i,3)+" ");
}

System.Console.WriteLine();