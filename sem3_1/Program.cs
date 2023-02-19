// Напишите программу, которая по заданному номеру четвеоти. показывает пиапазон возможных координат точек в этои четверти (Х и у).

Console.WriteLine("Введите номер четверти ");
int num = Convert.ToInt32(Console.ReadLine());
CheckKoord(num);

void CheckKoord(int num)
{
    if (num == 1)
        Console.WriteLine("x > 0, y > 0");
    else if (num == 4)
        Console.WriteLine("x > 0, y < 0");
    else if (num == 3)
        Console.WriteLine("x < 0, y < 0");
    else if (num == 2)
        Console.WriteLine("x < 0, y > 0");
    else
        Console.WriteLine("Введены некорректные данные");
}