
Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());

int SumRec(int m, int n)
{
    if (n==m-1) return 0;
    else return n + SumRec(m,n-1);
}
System.Console.WriteLine(SumRec(m,n));

