
int [] a = new int [4];
int count = 0;

for (int i = 0; i < a.Length; i++)
{
    a[i]= new Random().Next(100,1000);
    if (a[i]%2==0)
    {
        count++;
    }
}


foreach (int item in a)
{
    System.Console.Write(item+" ");
}

System.Console.WriteLine(count);