// **Задача 12:** 
// Напишите программу, которая будет принимать на вход два числа и проверять является ли первое число квадратом другого.
// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно
// 161 ->  да

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int div = num2 * num2;

if (num1 == div)
{
    Console.WriteLine($"Кратно");
}
else
{
    int ost = num1 % num2;
    Console.WriteLine($"Не кратно, остаток {ost}");
}