/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(10,999);
    }

    return arr;
}
int SumOdd(int[] arr)
{
  int sum = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] %2 !=0)
    sum = sum + arr[i];
  }
  return sum;
}

Console.WriteLine();

int[] array = InitArray(10);
int sum = SumOdd(array);

Console.WriteLine(string.Join(", ", array));

Console.WriteLine($"-> В указанном массиве сумма нечетных чисел равна {sum}");