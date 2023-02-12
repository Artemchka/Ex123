int[] array = {1, 901, 76, 89, 901, 675, 1009, 876};

int n = array.Length;
int find = 901;

int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}


