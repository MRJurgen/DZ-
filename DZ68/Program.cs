

Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());

System.Console.Write($"A({m},{n}) = ");

int Akkerman(int m, int n)
{
    if(m==0)
        return n+1;
    if(m>0&&n==0)
        return Akkerman(m-1,1);
    if(m>0&&n>0)
        return Akkerman(m-1,Akkerman(m,n-1));
    else return 0;
}
System.Console.WriteLine(Akkerman(m,n));

