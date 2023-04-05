

Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());

string NumbersRec(int b)
{
    if(1<=b)
     return $"{b}, " + NumbersRec(b-1);
    else return string.Empty;
}

System.Console.WriteLine(NumbersRec(n));