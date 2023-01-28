/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
double[] InitArray(double dimension)
{
    double[] arr = new double[10];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }

    return arr;
}

Console.WriteLine();
double[] array = InitArray(10);
Console.WriteLine(string.Join(", ", array));
double Min = array.Min();
double Max = array.Max();
double diff = Max - Min;
Console.WriteLine($"-> В указанном массиве разница между максимальным числом {Max} и минимальным числом {Min} составила {diff}");
