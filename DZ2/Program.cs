//Задача 4 
System.Console.Write("Value a = ");
int a = int.Parse(Console.ReadLine());
System.Console.Write("Value b = ");
int b = int.Parse(Console.ReadLine());
System.Console.Write("Value c = ");
int c = int.Parse(Console.ReadLine());
int max = a;
if(b>max) max =b;
if(c>max) max =c;
System.Console.WriteLine($"Max = {max}");



