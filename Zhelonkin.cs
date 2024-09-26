using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = Convert.ToInt32(Console.ReadLine());
            //    if (a % 2 == 0)
            //        Console.WriteLine("Число " + a + " - чётное");
            //    else
            //        Console.WriteLine("Число " + a + " - нечётное");
            //    Console.ReadKey();

            //int a, b;
            //Console.WriteLine("Введите первое число");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите второе число");
            //b = Convert.ToInt32(Console.ReadLine());
            //if (a > b)
            //    Console.WriteLine("Первое число больше второго");
            //else if (a < b)
            //    Console.WriteLine("Первое число меньше второго");
            //else
            //    Console.WriteLine("Числа равны");
            //Console.ReadKey();

            //int a, b, c, m;
            //Console.WriteLine("Введите первое число");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите второе число");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите третье число");
            //c = Convert.ToInt32(Console.ReadLine());
            //if (a > b && a > c)
            //    m = a;
            //if (b > c && b > c)
            //    m = b;
            //else 
            //    m = c;
            //Console.WriteLine("Наибольшее число " + m);
            //Console.ReadKey();

            //int a, b, c;
            //Console.WriteLine("Введите первое число");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите второе число");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Какой результат?");
            //c = Convert.ToInt32(Console.ReadLine());
            //if (a * b == c)
            //    Console.WriteLine("Правильно!");
            //else
            //    Console.WriteLine("Не правильно! Ответ: " + a * b);
            //Console.ReadKey();

            //int a, b;
            //Console.WriteLine("Введите первое число");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите второе число");
            //b = Convert.ToInt32(Console.ReadLine());
            //if (a % b == 0)
            //    Console.WriteLine("Разделить возможно. Частное: " + a / b);
            //else
            //    Console.WriteLine("Невозможно выполнить операцию. Частное: " + a/b + " Остаток: " + a % b);
            //Console.ReadKey();

            //Console.WriteLine("Введите год");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if ((a % 4 == 0 && a % 100 !=0) || (a % 400 == 0))
            //        Console.WriteLine("Високосный год");
            //else
            //    Console.WriteLine("Не високосный год");
            //Console.ReadKey();

            //Console.WriteLine("Введите первое число");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите второе число");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите третье число");
            //int c = Convert.ToInt32(Console.ReadLine());
            //if ((a > b && a < c) || (a < b && a > c))
            //    Console.WriteLine("Среднее число: " + a);
            //else if ((b > a && b < c) || (b < a && b > c))
            //    Console.WriteLine("Среднее число: " + b);
            //else if ((c > a && c < b) || (c < a && c > b))
            //    Console.WriteLine("Среднее число: " + c);
            //else
            //    Console.WriteLine("Ошибка: имеются одинаковые числа");
            //Console.ReadKey();

            //Console.WriteLine("Введите число");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите 'b' для перевода в байты или 'k' для перевода в килобайты");
            //char b = Convert.ToChar(Console.ReadLine());
            //if (b == 'b')
            //    Console.WriteLine(a + " байтов.");
            //else if (b == 'k' && a / 1024 != 0)
            //    Console.WriteLine((a / 1024) + " килобайтов.");
            //else if (a / 1024 == 0)
            //    Console.WriteLine("Введённое число невозможно сконвертировать в килобайты, поэтому ответ представлен в байтах: " + a % 1024 + " байт.");
            //else
            //    Console.WriteLine("Неверный ввод");
            //Console.ReadKey();

            //Console.WriteLine("Введите коэфициент a:");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите коэфициент b:");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите коэфициент c:");
            //double c = Convert.ToDouble(Console.ReadLine());
            //double disc = (b * b - 4 * a * c);
            //if (disc > 0)
            //{
            //    double x1 = (-b + Math.Sqrt(disc)) / (2 * a);
            //    double x2 = (-b - Math.Sqrt(disc)) / (2 * a);
            //    Console.WriteLine("Корни уравнения: x1 = " + x1 + ", x2 = " + x2);
            //}
            //else if (disc == 0)
            //{
            //    double x = -b / (2 * a);
            //    Console.WriteLine("Корень уравнения: x = " + x);
            //}
            //else
            //{
            //    Console.WriteLine("Уравнение не имеет действительных корней");
            //}
            // Console.ReadKey();

            //Console.WriteLine("Введите первое число");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите второе число");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите третье число");
            //int c = Convert.ToInt32(Console.ReadLine());
            //if (a == b && b == c)
            //{
            //    Console.WriteLine("Ответ: 3");
            //}
            //else if (a == b || b == c || a == c)
            //{
            //    Console.WriteLine("Ответ: 2");
            //}
            //else
            //{
            //    Console.WriteLine("Ответ: 0");
            //}
            //Console.ReadKey();  

            //Console.WriteLine("Введите четырех значное число");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int a = (num / 1000);
            //int b = (num / 100) % 10;
            //int c = (num / 10) % 10;
            //int d = (num % 10);
            //if (a == d && b == c)
            //    Console.WriteLine("Введенное число - симметричное");
            //else
            //    Console.WriteLine("Число не является симметричным");
            //Console.ReadKey();

            //Console.WriteLine("Введите ширину шоколадки (в плитках)");
            //int m = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите длину шоколадки (в плитках)");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите желаемое число отломленных плиток");
            //int k = Convert.ToInt32(Console.ReadLine());
            //if (k % m == 0 && k < n * m || k % n == 0 && k < n * m)
            //    Console.WriteLine("Да");
            //else
            //    Console.WriteLine("Нет");
            //Console.ReadKey();

            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a % 100 >= 11 && a % 100 <= 19)
            //{
            //    Console.WriteLine(a + " рублей");
            //}
            //else
            //{
            //    switch (a % 10)
            //    {
            //        case 1:
            //            Console.WriteLine(a + " рубль");
            //            break;
            //        case 2:
            //        case 3:
            //        case 4:
            //            Console.WriteLine(a + " рубля");
            //            break;
            //        default:
            //            Console.WriteLine(a + " рублей");
            //            break;
            //    }
            //}
            //Console.ReadKey();


        }


    }
}
