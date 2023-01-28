/*
Демонстрация решения
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


//инициализируем массив
int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(-9,10);
    }

    return arr;
}

//печатаем массив
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }

    Console.WriteLine();
}

//находим сумму положительных в массиве
int GetPositiveSum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            sum += array[i];
    }

    return sum;
}
//находим сумму отрицательных в массиве
int GetNegativeSumm(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            sum += array[i];
    }
    return sum;
}
(int, int) GetSummsFromArray(int[] array)
{
    int posSum = 0;
    int negSum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            negSum += array[i];
        else
            posSum += array[i];
    }

    return (posSum,  negSum);
}


int[] array = InitArray(12);
PrintArray(array);
int posSum = GetPositiveSum(array);
int negSum = GetNegativeSumm(array);

(int pos, int neg) = GetSummsFromArray(array);

Console.WriteLine($"сумма положительных = {posSum}, отрицательных = {negSum}");
Console.WriteLine($"сумма положительных = {pos}, отрицательных = {neg}");



еще чтото
public double GetRandomNumber(double minimum, double maximum)
{ 
    Random random = new Random();
    return random.NextDouble() * (maximum - minimum) + minimum;
}



______________________________________________________
Задача 32: Напишите программу замена элементов массива: положительные элементы замените 
на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]

Алгоритм решения:
1. Инициализируем массив
2. Заполняем массив случайными числами
3. Переворачиваем числа
4. Выводим на экран


int[] InitArray(int dimension)
{
  int[] arr = new int[dimension];
  Random rnd = new Random();

  for (int i = 0; i < dimension; i++)
  {
    arr[i] = rnd.Next(-9, 10);
  }
  return arr;
}

void ConvertArray(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = -arr[i];
  }
}

int[] array = InitArray(4);
Console.WriteLine(string.Join(",", array));

ConvertArray(array);
Console.WriteLine(string.Join(",", array));
_______________________________________________________________________________________
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да

int[] InitArray(int dimension)
{
  int[] arr = new int[dimension];
  Random rnd = new Random();

  for (int i = 0; i < dimension; i++)
  {
    arr[i] = rnd.Next(-9, 10);
  }
  return arr;
}

bool FindNumber(int find, int [] arr)
{
    bool result = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if(find == arr[i])
        {   
            result = true;
            break;
        }
    }
    return result;
}

int [] arr = InitArray(10);
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine("Что будем искать? ");
int find = Convert.ToInt32(Console.ReadLine());
bool a = FindNumber(find, arr);

if(a) Console.WriteLine("Элемент найден");
else Console.WriteLine("Элемент не найден");
______________________________________________________________________________________
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество
элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5


int[] InitArray(int dimension)
{
  int[] arr = new int[dimension];
  Random rnd = new Random();

  for (int i = 0; i < dimension; i++)
  {
    arr[i] = rnd.Next(0, 1000);
  }
  return arr;
}

int FindCount(int[] arr)
{
  var count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] >= 10 && arr[i] < 100)
      count++;
  }
  return count;
}

Console.WriteLine();

int[] array = InitArray(10);
int count = FindCount(array);

Console.WriteLine(string.Join(", ", array));

Console.WriteLine($"-> В указанном массиве находится {count} двухзначных чисел.");
____________________________________________________________________________________________

Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21

int[] InitArray(int dimension)
{
  int[] arr = new int[dimension];
  Random rnd = new Random();

  for (int i = 0; i < dimension; i++)
  {
    arr[i] = rnd.Next(0, 10);
  }
  return arr;
}

int [] MultiOfNumbers(int [] arr)
{
    bool chetniy = true;
    int [] newArr = null;
    if(arr.Length % 2 == 0)
        newArr = new int [arr.Length / 2];
    else 
    {
        newArr = new int [arr.Length / 2 + 1];
        chetniy = false;
    }
    for (int i = 0; i < newArr.Length; i++)
    {
        if (!chetniy && i == newArr.Length - 1)
            newArr[i] = arr[i];
        else
            newArr[i] = arr[i] * arr[arr.Length - i - 1];
    }
    return newArr;
}

int [] array = InitArray(5);
Console.WriteLine(string.Join(", ", array));
int [] newArray = MultiOfNumbers(array);
Console.WriteLine(string.Join(", ", newArray));
______________________________________________________________________________


*/
