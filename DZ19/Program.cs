System.Console.Write("Ввидите число: ");
string a = Console.ReadLine();
if(a.Length ==5)
{
    if(a[0]==a[4]&&a[1]==a[3])
    {
        System.Console.WriteLine("Да");
    }
    else System.Console.WriteLine("Нет");
}
else System.Console.WriteLine("Ошибка в формате числа");
