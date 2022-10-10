// **Задача 11:**
// Напишите программу, которая выводит случайное 
//трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);
Console.WriteLine(num);
// int num1 = num / 100;
// int num2 = num % 10;

// Console.WriteLine(num);
// Console.WriteLine(num1);
// Console.WriteLine(num2);
// Console.WriteLine($"{num1}{num2}");

int num1 = num / 100;
int num2 = num % 10;
int sum = num1 * 10 + num2;
Console.WriteLine(sum);

                                                                                                                                                                     