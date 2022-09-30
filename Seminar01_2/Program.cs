Console.Clear();
Console.Write("Введите положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = n - n * 2;

Console.Write($"{i}\n");
while (i < n)
{
    i++;
    Console.Write($"{i}\n");
}