// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 5)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Будни");
}
