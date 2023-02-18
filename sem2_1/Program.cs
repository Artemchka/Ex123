// Напишите программу? которая будет принимать на вход 2 числа и выводить, является ли второе число кратным первому
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num2 % num1 ==0)
 Console.WriteLine($"{num2} кратно {num1}");
else
{
 int num3 = num2 % num1;
 Console.WriteLine($"{num2} не кратно {num1} остатком является {num3}");
}
