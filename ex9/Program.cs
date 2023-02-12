int Max(int arg1, int arg2, int arg3)
{
int result = arg1;
if(arg2> result) result = arg2;
if(arg3> result) result = arg3;
return result;
}
int[] array = {11, 45, 56, 78, 98, 24,12, 9, 76};
array[0] = 12;
Console.WriteLine(array[0]);

int max = Max(Max(a, b, c), Max(a1, b1, c1), Max(a2, b2, c2));

Console.WriteLine(max);

