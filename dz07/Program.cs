// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// void PrintArray(double[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//     Console.WriteLine();
//     }
// }

// void FillArray(double[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = Convert.ToDouble(new Random().Next(-100,100) / 10.0); 
//         }
//     }
// }

// double[,] matrix = new double[3, 4];

// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// // и возвращает значение этого элемента или же указание, что такого элемента нет.

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void IndexOf(int[,] collection, int find1, int find2)
// {

//     for (int i = 0; i < collection.GetLength(0); i++)
//     {
//          if (find1 > collection.GetLength(0) && find2 > collection.GetLength(1))
//             {
//                 Console.WriteLine("Такого числа в массиве нет");
//                 break;
//             }
//         for (int j = 0; j < collection.GetLength(1); j++)
//         {
//             if (i == find1 && j == find2)
//             {
//                 Console.WriteLine($"{collection[i,j]}");
//             }
//         }
//     }

// }

// int[,] matrix = new int[3, 4];
// Console.WriteLine("Введите номер строки: ");
// int posRow = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столба: ");
// int posCol = Convert.ToInt32(Console.ReadLine());

// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);
// IndexOf(matrix, posRow, posCol);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 5);
        }
    }
}

double[,] matrix = new double[5, 5];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    double tmp = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        tmp += matrix[i, j];
    }
    double ColAvg = tmp / matrix.GetLength(0);
    Console.WriteLine("Среднее арифметическое столбца " + (i) + " равно: " + ColAvg);
}
