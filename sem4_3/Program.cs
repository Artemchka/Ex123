// Задать массив из 12 элементов, заполненных числами из (0 и 9). Найти сумму положительных и отрицательных элементов массива

 Random rnd = new Random();
 int[] array = new int[12];
 int sumPo1 = 0;
 int sumOtr = 0;

 for ( int i=0; i < array.Length; i++)
 {
    array[i] = rnd.Next(-9, 10);
    Console.Write($"{array[i]} ");
    if (array[i] < 0)
    sumOtr +=array[i];
    else
    sumPo1 +=array[i];

 }

 Console.WriteLine();
 Console.Write($"сумма положительных элементов  {sumPo1}; Сумма отрицательных элементов {sumOtr}; ");
 