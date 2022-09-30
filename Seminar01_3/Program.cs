Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 100 && n < 1000)
{
    Console.Write($"{n % 10}\n");
}
else
{
    Console.WriteLine("Введите трехзначное число!");
}