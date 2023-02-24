// Напишите метод нахождения количества чисел в числе

int Razr(int num)
{
    int count = 0;
    while(num !=0)
    {
        num /= 10;
        count++;
    }
    return count;
}
try{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Количество чисел в числе - {Razr(number)}");

}
catch
{
    Console.WriteLine(" Введены некорректные данные ");
    
}
