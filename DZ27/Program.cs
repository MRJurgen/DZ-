
System.Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

int length = (Convert.ToString(a)).Length;

int result =0;  

for (int i = 0; i < length; i++)
{
    result += (a%10);
    a=a/10;
}

System.Console.WriteLine(result);