// напишите программу, которая принимает на вход число и выдает таблицу квадратов чисел от 1 до числа (5=4 9 16 25)

Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int x1 =x;
string res ="";
for (int i=0; i <= x; i++){
 int tmp =i * i;
 res += $"{tmp}, ";

}

Console.WriteLine(res);
