// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
//Console.WriteLine("Введите число ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//if(num1 % 7 ==0 & num1 % 23 ==0)
// Console.WriteLine("кратно");
//else
// Console.WriteLine("не кратно");

// На входе принимает число

int count = 0;
int num = Convert.ToInt32(Console.ReadLine());
while (num > 0){
    num = num / 10;
    count+=1;

}
Console.WriteLine(count);