using System;

namespace _6_Задача
{
    class Program
    {
        public static int Input(string str)
        {
            bool ok = true;
            int digit = 0;
            while (ok)
            {
                Console.Write(str);
                ok = int.TryParse(Console.ReadLine(), out digit);
                if (!ok)
                {
                    Console.WriteLine("Ошибка ввода! Повторите ввод...");
                    ok = true;
                }
                else
                {
                    ok = false;
                }
            }
            return digit;
        }

        public static double Recursion(double a, double b, double c, ref int j, int m, int n)
        {
            double last =  c + ( b * a ) / 2;
            if (last % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" {0:F}", last);
                n = n - 1;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine(" {0:F}", last);
            }
            if (last >= m) j++;
            if (n > 0) return Recursion(b, c, last, ref j, m, n);
            return last;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            int a = Input("Введите первое число последовательности: ");
            int b = Input("Введите второе число последовательности: ");
            int c = Input("Введите третье число последовательности: ");
            int m = Input("Введите число для сравнения: ");
            int n = Input("Введите количество четных чисел для добавления: ");

            int j = 0;
            Console.WriteLine("Последовательность из четных чисел:");
            double element = Recursion(a, b, c, ref j, m, n);

            Console.WriteLine("\nКоличество элементов >=M: {0}", j);
        }
    }
}
