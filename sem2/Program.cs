int num = new Random().Next(10, 100);
Console.WriteLine($"Было сгенерировано число {num}");
int x1 = num/10;
int x2 = num % 10;
if (x1>x2)
  Console.WriteLine(x1);
 else if(x1<x2)
Console.WriteLine(x2);
else
Console.WriteLine("Обе цифры этого числа равны");

for (int i=0;i<=10; i++)
Console.Write($"{i}");
