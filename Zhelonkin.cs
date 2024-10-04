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

            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a % 100 >= 11 && a % 100 <= 19)
            //{
            //    Console.WriteLine(a + " лет");
            //}
            //else
            //{
            //    switch (a % 10)
            //    {
            //        case 1:
            //            Console.WriteLine(a + " год");
            //            break;
            //        case 2:
            //        case 3:
            //        case 4:
            //            Console.WriteLine(a + " года");
            //            break;
            //        default:
            //            Console.WriteLine(a + " лет");
            //            break;
            //    }
            //}
            //Console.ReadKey();

            //string a;
            //Console.WriteLine("Введите день недели");
            //a = Convert.ToString(Console.ReadLine());
            //switch (a)
            //{
            //    case "Понедельник":
            //        Console.WriteLine("1");
            //        break;
            //    case "Вторник":
            //        Console.WriteLine("2");
            //        break;
            //    case "Среда":
            //        Console.WriteLine("3");
            //        break;
            //    case "Четверг":
            //        Console.WriteLine("4");
            //        break;
            //    case "Пятница":
            //        Console.WriteLine("5");
            //        break;
            //    case "Суббота":
            //        Console.WriteLine("6");
            //        break;
            //    case "Воскресенье":
            //        Console.WriteLine("7");
            //        break;
            //    default:
            //        Console.WriteLine("Ошибка");
            //        break;
            //}
            //Console.ReadKey();

            //Console.WriteLine("Введите число от 100 до 999");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a < 100 || a > 999)
            //{
            //    Console.WriteLine("Введено некорректное число");
            //}
            //int handreds = a / 100;
            //int tens = (a / 10) % 10;
            //int ones = a % 10;

            //string result = "";

            //switch (handreds)
            //{
            //    case 1:
            //        result = result + "сто ";
            //        break;
            //    case 2:
            //        result = result + "двести ";
            //        break;
            //    case 3:
            //        result = result + "триста ";
            //        break;
            //    case 4:
            //        result = result + "четыреста ";
            //        break;
            //    case 5:
            //        result = result + "пятьсот ";
            //        break;
            //    case 6:
            //        result = result + "шестьсот ";
            //        break;
            //    case 7:
            //        result = result + "семьсот ";
            //        break;
            //    case 8:
            //        result = result + "восемьсот ";
            //        break;
            //    case 9:
            //        result = result + "девятьсот ";
            //        break;
            //}
            //if (tens == 1)
            //{
            //    switch (ones)
            //    {
            //        case 0:
            //            result = result + "десять ";
            //            break;
            //        case 1:
            //            result = result + "одиннадцать ";
            //            break;
            //        case 2:
            //            result = result + "двенадцать ";
            //            break;
            //        case 3:
            //            result = result + "тринадцать ";
            //            break;
            //        case 4:
            //            result = result + "четырнадцать ";
            //            break;
            //        case 5:
            //            result = result + "пятнадцать ";
            //            break;
            //        case 6:
            //            result = result + "шестнадцать ";
            //            break;
            //        case 7:
            //            result = result + "семнадцать ";
            //            break;
            //        case 8:
            //            result = result + "восемнадцать ";
            //            break;
            //        case 9:
            //            result = result + "девятнадцать ";
            //            break;

            //    }
            //}
            //else
            //{
            //    switch (tens)
            //    {
            //        case 2:
            //            result = result + "двадцать ";
            //            break;
            //        case 3:
            //            result = result + "тридцать ";
            //            break;
            //        case 4:
            //            result = result + "сорок ";
            //            break;
            //        case 5:
            //            result = result + "пятьдесят ";
            //            break;
            //        case 6:
            //            result = result + "шестьдесят ";
            //            break;
            //        case 7:
            //            result = result + "семьдесят ";
            //            break;
            //        case 8:
            //            result = result + "восемьдесят ";
            //            break;
            //        case 9:
            //            result = result + "девяносто ";
            //            break;
            //    }
            //    switch (ones)
            //    {
            //        case 1:
            //            result = result + "один ";
            //            break;
            //        case 2:
            //            result = result + "два ";
            //            break;
            //        case 3:
            //            result = result + "три ";
            //            break;
            //        case 4:
            //            result = result + "четыре ";
            //            break;
            //        case 5:
            //            result = result + "пять ";
            //            break;
            //        case 6:
            //            result = result + "шесть ";
            //            break;
            //        case 7:
            //            result = result + "семь ";
            //            break;
            //        case 8:
            //            result = result + "восемь ";
            //            break;
            //        case 9:
            //            result = result + "девять ";
            //            break;
            //    }

            //}
            //Console.WriteLine(result);
            //Console.ReadKey();

            //int s = 0;
            //Console.WriteLine("Введите начало интервала: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите конец интервала: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //for (int i = a; i <= b; i++)
            //{
            //    s = s + i;
            //}
            //for (int i = b; i <= a; i++)
            //{
            //    s = s + i;
            //}
            //Console.WriteLine($"Сумма чисел равна: {s}");
            //Console.ReadKey();

            //int s = 1;
            //Console.WriteLine("Введите начало интервала: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите конец интервала: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //    for (int i = a; i <= b; i++)
            //{
            //    if (i > 0 && i % 3 == 0)
            //    {
            //        s = s * i;
            //    }
            //}
            //if (s == 1)
            //{
            //    Console.WriteLine("На данном промежутке нет положительных чисел, кратных 3");
            //}
            //else
            //{
            //    Console.WriteLine($"Результат: {s}");
            //}
            //Console.ReadKey();

            //int result = 1;
            //Console.WriteLine("Введите число, факториал которого вы хотите вычислить:");
            //int fac = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= fac; i++)
            //{
            //    result *= i;
            //}
            //Console.WriteLine($"Результат: {result}");
            //Console.ReadKey();

            Console.WriteLine("Введите число, для определения, простое оно или нет:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                if (num % )
            }
                Console.WriteLine($"Введенное число {num} - простое");
                Console.WriteLine($"Введенное число {num} - не простое");
            Console.ReadKey();
        }


    }
}
