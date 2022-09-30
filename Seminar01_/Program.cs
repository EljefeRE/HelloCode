Console.Clear();

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
    Console.WriteLine("$Число {num1} является квадрато числа {num2}");
}
else
{
    Console.WriteLine("$Число {num1} НЕ является квадратом число {num2}");
}