int A = 2;
int B = 10;


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