// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] array = new int[8];

void PrintMass(int[] arr)
{
    Random rnd = new Random();
    for (int i=0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 9);
        Console.Write($"{arr[i]} ");

    }
}
PrintMass(array);
