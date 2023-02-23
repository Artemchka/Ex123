// найти позицию минимального значения массива  в неотстортированной части массива, произвести обмен этого значения со значением первой неотсортированной позиции, повторять пока есть неотсортированные эелементы

int[] arr = {1, 5, 6, 9, 2, 1, 5, 3, 2, 7, 6, 9, 0 };

void Prit(int[] arr)
{
int count = arr.Length;
for(int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void Select(int[] array)
{
 for(int i=0; i<arr.Length-1; i++)
    {
        int minpos = i;
       for(int j = i+1 ;j < arr.Length; j++)
       {
        if(arr[j] < arr[minpos]) 
        {
        minpos = j;
        }
       }

        int temp = arr[i];
        arr[i] = array[minpos];
        arr[minpos] = temp;
    }
}
Prit(arr);
Select(arr);
Prit(arr);