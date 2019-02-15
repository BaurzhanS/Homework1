using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiplicTable();
        }

        /*1.Написать программу, которая считывает символы с клавиатуры, 
        пока не будет введена точка.Программа должна сосчитать количество 
        введенных пользователем пробелов.*/
        static void ReadSymbols()
        {
            char input = ' '; 
            int symbols = 0;
            int count = 0;
            while (input != '.')
            {
                input=Console.ReadKey().KeyChar;
                symbols++;
                if(input==' ')
                {
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Общее количество введенных символов: {0}", symbols);
            Console.WriteLine("Количество пробелов: {0}", count);
        }

        /*4.Даны целые положительные числа A и B(A<B). Вывести все целые 
         числа от A до B включительно; каждое число должно выводиться 
         на новой строке; при этом каждое число должно выводиться количество раз,
         равное его значению.*/
         static void PrintNumbersCount()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int count = a;

            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }

        /*10. Дано двузначное число.Найти:
        a.число десятков в нем;
        b.число единиц в нем;
        c.сумму его цифр;
        d.произведение его цифр*/
        static void SplitNumber()
        {
            int a = int.Parse(Console.ReadLine());
            //Console.WriteLine(a / 10);
            //Console.WriteLine(a / 1);
            int count = a;
            int sum = 0;
            int mult = 1;
            while (count > 0)
            {
                a = count % 10;
                sum = sum + a;
                mult = mult * a;
                count = count / 10;
            }
            Console.WriteLine(sum);
            Console.WriteLine(mult);
        }
        /*15. Напечатать "столбиком": 
        a.	все целые числа от 20 до 35;
        b.	квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);
        c.	третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50);
        d.	все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).
        */
        static void PrintDiffNumbers()
        {
            Console.WriteLine("Choose letter: ");
            char select = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (select == 'a')
            {

                for (int i = 20; i <= 35; i++)
                {
                    Console.WriteLine(i);
                }
            }
            if (select == 'b')
            {
                int b = int.Parse(Console.ReadLine());
                for (int i = 10; i <= b; i++)
                {
                    Console.WriteLine(i * i);
                }
            }
            if (select == 'c')
            {
                int a = int.Parse(Console.ReadLine());
                for (int i = a; i <= 50; i++)
                {
                    Console.WriteLine(i * i * i);
                }
            }

            if (select == 'd')
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                for (int i = a; i <= b; i++)
                {
                    Console.WriteLine(i);
                }
            }

        }
        /* 28.	Вычислить значение логического выражения при следующих 
        значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь: 
        a.	не А и В; 
        b.	А или не В; 
        c.	А и В или С.
        */
        static void FindTrueOrFalse()
        {
            bool A = true;
            bool B = false;
            bool C = false;
            Console.WriteLine(!A && B);
            Console.WriteLine(A || !B);
            Console.WriteLine((A && B) || B);


        }
        /* Дано двузначное число. Определить: 
        a.	какая из его цифр больше: первая или вторая; 
        b.	одинаковы ли его цифры.
        */
        static void FindLargerNumber()
        {
            int num = int.Parse(Console.ReadLine());
            int first = num / 10;
            int second = num % 10;
            if (first > second)
            {
                Console.WriteLine(first);
            }
            else if (first < second)
            {
                Console.WriteLine(second);
            }
            else
            {
                Console.WriteLine("They are equal");
            }


        }
        /*35.Составить программу, которая в зависимости от порядкового
        номера дня месяца (1, 2, ..., 12) выводит на экран 
        его название (январь, февраль, ..., декабрь).*/
        static void PrintMonth()
        {
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                    Console.WriteLine("Январь");
                    break;
                case 2:
                    Console.WriteLine("Февраль");
                    break;
                case 3:
                    Console.WriteLine("Март");
                    break;
                case 4:
                    Console.WriteLine("Апрель");
                    break;
                case 5:
                    Console.WriteLine("Май");
                    break;
                case 6:
                    Console.WriteLine("Июнь");
                    break;
                case 7:
                    Console.WriteLine("Июль");
                    break;
                case 8:
                    Console.WriteLine("Август");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Декабрь");
                    break;
            }
        }
        /* 39.	Напечатать ряд чисел 20 в виде: 20 20 20 20 20 20 20 20 20 20 */
        static void PrintNumber()
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", num);
            }
            

        }
        /* 41.	Напечатать таблицу соответствия между весом в фунтах и весом в килограммах
        для значений 1, 2, ..., 10 фунтов (1 фунт = 453 г). */
        static void WeightConverter()
        {
            double pound_in_kg = 0.453;
            double kg_in_pound = 1 / pound_in_kg;
            double input = double.Parse(Console.ReadLine());
            double res = input * pound_in_kg;
            Console.WriteLine(res);
        }
        /* 42.	Напечатать таблицу умножения на 9: 9 х 1 = 9 9 х 2 = 18 ... 9 х 9 = 81 */
        static void MultiplicTable()
        {
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine("9 * {0} = {1}",i,(i * 9));
            }
        }


    }
}
