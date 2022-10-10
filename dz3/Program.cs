// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num - num + 1;
int i = 1;
Console.WriteLine("{0}\t{1}\t{2}", "Число", "Квадрат", "Корень");
while (i <= num)
{
    // int cor =  num1*num1;
    // int coub = num1*num1*num1;
    //Console.WriteLine(coub);
    Console.WriteLine("{0}\t{1}\t{2}", i, Math.Pow(i, 2), Math.Pow(i, 3));
    //num1++;
    i++;
}

// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = num % 10;
            int i = 10000;
            int result = 0;
            int result1 = num;
            int count = 0;
            
            while (count < 5)
            {
                a = num % 10;
                num = num / 10;
                result = result + a * i;           
                i = i / 10;
                count ++;
            }
            if (result == result1)
            {
                Console.WriteLine($"Да {result}");
            }
            else 
            {
               Console.WriteLine($"Нет {result1}"); 
            }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Координаты точки A: ");
int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Координаты точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());
int zb = Convert.ToInt32(Console.ReadLine());

int sum = ((xb-xa)*(xb-xa))+((yb-ya)*(yb-ya))+((zb - za)*(zb-za));
double distance = Math.Round(Math.Sqrt(sum),2);
Console.WriteLine(distance);