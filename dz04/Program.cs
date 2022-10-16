// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

Console.Write("Введите число A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int count = num1;
for ( int i = 1; i < num2; i++)
{
    count = num1 * count;
}

Console.WriteLine($"{num1}^{num2} = {count}");


//Задача 27:  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (num > 0)
{
    sum = sum + num % 10;
    num = num / 10;
}
 Console.WriteLine($"Сумма чисел = {sum}");


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

int[] arr = new int[8];

FillArray(arr);
PrintArray(arr);
