//*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53*//

Console.WriteLine("Введите координату x первой точки");
int x =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки");
int y =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки");
int z =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x второй точки");
int x1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки");
int y1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки");
int z1 =Convert.ToInt32(Console.ReadLine());


double Distance(int x, int y, int x1, int y1, int z, int z1){
  double res = Math.Sqrt((x1-x)*(x1-x)+(y1-y)*(y1-y)+(z1-z)*(z1-z));
  return res;  
}
Console.WriteLine(Distance(x,y,x1,y1,z,z1));
