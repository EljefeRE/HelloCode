// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray(int[] arr)
{
    int size = arr.Length;
    int i = 0;
    while (i < size)
    {
        arr[i] = new Random().Next(99, 1000);
        i++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int j = 0;
    while (j < count)
    {
        Console.Write($"{col[j]} ");
        j++;
    }
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);

int cou = 0;
for (int x = 0; x < array.Length; x++)
{
    if (array[x] % 2 == 0)
    {
        cou++;
    }
}
Console.WriteLine();
Console.WriteLine($"Колличество четных чисел в массиве = {cou}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

void FillArray(int[] arr)
{
    int size = arr.Length;
    int i = 0;
    while (i < size)
    {
        arr[i] = new Random().Next(1, 5);
        i++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int j = 0;
    while (j < count)
    {
        Console.Write($"{col[j]} ");
        j++;
    }
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);

int sum = 0;
for (int x = 0; x < array.Length; x++)
{
    if (x % 2 == 0)
    {
        sum = sum + array[x];
    }
}
Console.WriteLine();
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {sum}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(int[] arr)
{
    int size = arr.Length;
    int i = 0;
    while (i < size)
    {
        arr[i] = new Random().Next(1, 50);
        i++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int j = 0;
    while (j < count)
    {
        Console.Write($"{col[j]} ");
        j++;
    }
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);

int max = array[0];
int min = array[0];

for (int x = 1; x < array.Length; x++)
{
    if (array[x] > max)
    {
        max = array[x];
    }
    if (array[x] < min)
    {
        min = array[x];
    }
}

Console.WriteLine();
Console.WriteLine($"{max} - {min} = {max - min}");