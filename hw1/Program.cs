Console.WriteLine("Введите число 1 ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
int B = Convert.ToInt32(Console.ReadLine());

int max = A;
int min = B;

if (A > B) max =A;
if (B > A) max =B;
if (A < B) min =A;
if (B < A) min =B;


Console.Write("max= ");
Console.WriteLine(max);
Console.Write("min= ");
Console.WriteLine(min);