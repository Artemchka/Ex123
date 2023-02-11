Console.WriteLine("Введите число 1 ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3 ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (max > number2) max=number1;
if (number2 > max) max=number2;
if (max > number3) max=number1;
if (number3 > max) max=number3;
if (number2 > number3) max=number2;
if (number3 > number2) max=number3;

Console.WriteLine("Максимальное число ");
Console.WriteLine(max);