System.Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());

System.Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

int result = 1;

for (int i = 1; i <=b; i++)
{
    result = result*a;
}

System.Console.WriteLine("Ответ:" + result);