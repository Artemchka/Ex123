// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

int num = new Random().Next(100, 999999);
Console.WriteLine($"Сгенерированное число - {num}");
int num1 = num / 100;
int num2 = num % 10;
Console.WriteLine($"Полученное число -{num1}{num2}");
