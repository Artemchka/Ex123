int Max(int arg1, int arg2, int arg3)
{
int result = arg1;
if(arg2> result) result = arg2;
if(arg3> result) result = arg3;
return result;
}

int a = 2;
int a1 = 5;
int a2 = 18;
int b = 2013;
int b1 = 25;
int b2 = 184;
int c = 200;
int c1 = 5;
int c2 = 118;

int max1 = Max(a, b, c);
int max2 = Max(a1, b1, c1);
int max3 = Max(a2, b2, c2);
int max = Max(max1, max2, max3);

Console.WriteLine(max);