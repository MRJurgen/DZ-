System.Console.WriteLine("Введите координаты точек");

System.Console.Write("X1: ");
int x1 = int.Parse(Console.ReadLine());

System.Console.Write("Y1: ");
int y1 = int.Parse(Console.ReadLine());

System.Console.Write("Z1: ");
int z1 = int.Parse(Console.ReadLine());

System.Console.Write("X2: ");
int x2 = int.Parse(Console.ReadLine());

System.Console.Write("Y2: ");
int y2 = int.Parse(Console.ReadLine());

System.Console.Write("Z2: ");
int z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
System.Console.WriteLine(Math.Round(result,2,MidpointRounding.ToZero));
