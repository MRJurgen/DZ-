//Задача 2 
System.Console.Write("Value a = ");
int a = int.Parse(Console.ReadLine());
System.Console.Write("Value b = ");
int b = int.Parse(Console.ReadLine());
int max = a;
int min = b;
if(b>max) max =b;
if(a<min) min=a;
System.Console.WriteLine($"Max = {max}");
System.Console.WriteLine($"Min = {min}");


