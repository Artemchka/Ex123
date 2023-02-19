// Напишите программу которая принимает на вход координаты икс и игрик, причем  икс и игрик не равны нулю, и выдает номер четверти плоскости, в которой эта точка

void CheckKoord(int x)
{
    if (x == 1)
        Console.WriteLine("x > 0, y > 0");
    else if (x == 4)
        Console.WriteLine("x > 0, y < 0");
    else if (x == 3)
        Console.WriteLine("x < 0, y < 0");
    else if (x == 2)
        Console.WriteLine("x < 0, y > 0");
    else
        Console.WriteLine("Введены некорректные данные");
}

string CheckKoord2(int x)
{
    string res="Были введены некорректные данные";
    if (x == 1)
        res="x > 0, y > 0";
    else if (x == 4)
        res="x > 0, y < 0";
    else if (x == 3)
        res="x < 0, y < 0";
    else if (x == 2)
        res="x < 0, y > 0";
    return res;
}



try
{
    Console.WriteLine("Введите координату Х");
    int x = Convert.ToInt32(Console.ReadLine());
    CheckKoord(x);
    Console.WriteLine(CheckKoord2(x));
}
catch
{
    Console.WriteLine("Были введены некорректные данные");
}