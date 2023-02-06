// Задача 34. задайте массив заполненный случайными 
// положительными трехзначными числами.
// 345, 897, 568, 234 -> 2

int[] array = new int[4];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count = count + 1;
    }
}

Console.WriteLine($"Чётных чисел в масиве: {count}");