// напишите программу, которая принимает на входе координаты двух точек и находит расстояние между ними в 2Д пространстве AB = √((xb - xa)2 + (yb - ya)2).


Console.WriteLine("Введите координату x первой точки");
int x =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки");
int y =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x второй точки");
int x1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y  второй точки");
int y1 =Convert.ToInt32(Console.ReadLine());

double Distance(int x, int y, int x1, int y1){
  double res = Math.Sqrt((x1-x)*(x1-x)+(y1-y)*(y1-y));
  return res;  
}
Console.WriteLine(Distance(x,y,x1,y1));
