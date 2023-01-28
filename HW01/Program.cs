/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(100,999);
    }

    return arr;
}
int FindEven(int[] arr)
{
  var count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] %2==0)
      count++;
  }
  return count;
}

Console.WriteLine();

int[] array = InitArray(10);
int count = FindEven(array);

Console.WriteLine(string.Join(", ", array));

Console.WriteLine($"-> В указанном массиве находится {count} четных чисел.");


