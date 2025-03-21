using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_на_1803
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7 Задание
             * string a, b, c;
            int num;
            double chislo1,chislo2;
            Console.WriteLine("Введите номер операции:");
            Console.WriteLine("1 - Cложение, 2 - Вычитание, 3 - Умножение");
            a = Console.ReadLine();
            num = Convert.ToInt32(a);
            Console.WriteLine("Введите 1 число");
            b = Console.ReadLine();
            chislo1 = Convert.ToDouble(b);
            c = Console.ReadLine();
            Console.WriteLine("Введите 2 число");
            chislo2 = Convert.ToDouble(c);
            switch (num)
            {
                case 1:
                    Console.WriteLine("Ваше число:");
                    Console.WriteLine(chislo1 + chislo2); 
                    break;
                case 2:
                    Console.WriteLine("Ваше число:");
                    Console.WriteLine(chislo1 - chislo2);
                    break;
                case 3:
                    Console.WriteLine("Ваше число:");
                    Console.WriteLine(chislo1 * chislo2);

                    break;
                default:
                    Console.WriteLine("операция неопределена");
                    break;
            }


            Console.ReadKey();
            */

            /* 6 задание
             * string a;
            int num;
            Console.WriteLine("Введите номер операции:");
            a = Console.ReadLine();
            num = Convert.ToInt32(a);
            switch (num)
            {
                case 1:
                    Console.WriteLine("Операция номер 1");
                    break;
                case 2:
                    Console.WriteLine("Операция номер 2");
                    break;
                case 3:
                    Console.WriteLine("Операция номер 3");
                    break;
                default:
                    Console.WriteLine("операция неопределена");
                    break;
            } 

            Console.ReadKey();

            */

            /* 5 ЗАДАНИЕ
             * string a, b;
            double num;
            Console.WriteLine("Введите сумму вклада в рублях :");
            a = Console.ReadLine();
            num = Convert.ToDouble(a);
            if (num < 100)
            {
                Console.WriteLine("Ваша итоговая сумма,");
                Console.WriteLine(num + (num * 0.05));
            }
            else if (num > 100 && num < 200)
            {
                Console.WriteLine("Ваша итоговая сумма,");
                Console.WriteLine(num + (num * 0.07));
            }
            else if (num > 200)
            {
                Console.WriteLine("Ваша итоговая сумма,");
                Console.WriteLine(num + (num * 0.1));
            }
            else

            {
                Console.WriteLine("Введите корректное занчение");
            }
            Console.WriteLine("Поздравляю, Вы, участвуете в бонусной системе");
            Console.WriteLine("В итоге окончательная сумма с бонусами составляет: ");
            Console.WriteLine(num + 15);
            Console.ReadKey();
            */

            /* 4 ЗАДАНИЕ 
            string a,b;
            double num;
            Console.WriteLine("Введите сумму вклада в рублях :");
            a = Console.ReadLine();
            num = Convert.ToDouble(a);
            if (num < 100)
            {
                Console.WriteLine("Ваша итоговая сумма,");
                Console.WriteLine(num + (num * 0.05));
            }
            else if (num > 100 && num < 200)
            {
                Console.WriteLine("Ваша итоговая сумма,");
                Console.WriteLine(num + (num * 0.07));
            }
            else if (num > 200)
            {
                Console.WriteLine("Ваша итоговая сумма,");
                Console.WriteLine(num + (num * 0.1));
            }
            else

            {
                Console.WriteLine("Введите корректное занчение");
            }
            Console.ReadKey();
            */

            /* 3 ЗАДАНИЕ
            string a;
            int num;
            Console.WriteLine("Введите число:");
            a = Console.ReadLine();
            num = Convert.ToInt32(a);
            if (num == 5 || num == 10)
            {
                Console.WriteLine("Число либо равно 5, либо равно 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
            Console.ReadKey();
            */



            /* 2 ЗАДАНИЕ
             * 
             * string a;
            int num;
            Console.WriteLine("Введите число:");
            a = Console.ReadLine();
            num = Convert.ToInt32(a);
            if (num > 5 && num < 10 )
            {
                Console.WriteLine("Число больше 5 и меньше 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
            Console.ReadKey();
            */







            /* 1 ЗАДАНИЕ
             * string a, b;
            int num1 , num2;
            Console.WriteLine("Введите 1 число:");
            a = Console.ReadLine();
            num1 = Convert.ToInt32(a);
            Console.WriteLine("Введите 2 число:");
            b = Console.ReadLine();
            num2 = Convert.ToInt32(b);
            if (num1 > num2)
            {
                Console.WriteLine("Первое число больше");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("Второе число больше");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Числа равны");
            }
            else
            {
                Console.WriteLine("Введите числа!!!");
            }
            Console.ReadKey();
            */


        }
    }
}
