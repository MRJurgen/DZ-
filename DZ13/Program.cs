System.Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
if(a<100&&a>-99) System.Console.WriteLine("Третьей цифры нет");
else 
{
    string value = Convert.ToString(a);
    System.Console.WriteLine(value[2]);
}