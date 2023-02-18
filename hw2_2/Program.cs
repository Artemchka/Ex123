// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

Console.WriteLine("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
int num1 = num % 10; 
while (num > 0){
    num = num / 10;
    count+=1;
}
if (count <3)
{
    Console.WriteLine(" Третьей цифры нет");
}

else
{
   Console.WriteLine(num1);
}
