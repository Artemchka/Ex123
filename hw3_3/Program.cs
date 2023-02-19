// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.



string Palindrom(int a1, int e, int b1, int d1)
{
string res = "Были введены некорректные данные";
if(a1==e && b1==d1)
{
    res="да";
}
else
{
    res="нет";
}
return res;
}

Console.WriteLine("Введите пятизначное число");
int x = Convert.ToInt32(Console.ReadLine());
int a = x % 100000;
int a1 = a/10000;
int b = x % 10000;
int b1 = b/1000;
int d = (x % 100);
int d1 = d/10;
int e = x  % 10;

Palindrom(a1, e, b1,d1);
Console.WriteLine(Palindrom(a1, e, b1,d1));
