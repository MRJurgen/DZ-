System.Console.Write("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine());

double [] a = new double [n];

for (int i = 0; i < a.Length; i++)
{
    System.Console.Write($"a[{i}] = ");
    a[i]= Convert.ToDouble(Console.ReadLine());
}

double min = a[0];
double max = a[0];

for (int i = 0; i < a.Length; i++)
{
    if (min>a[i])
    {
        min = a[i];
    }
    if(max<a[i])
    {
        max = a[i];
    }
}

double diff = max - min ;
System.Console.WriteLine(diff);






