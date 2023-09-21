using System;


namespace Тумаков2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Упражнение 2.1. Программа приветствует пользователя");
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine($"Здравствуйте, {name}\n");


            Console.WriteLine("Упражнение 2.2. Программа выводит результат деления одного числа на другое");
            Console.WriteLine("Введите число 1");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 != 0)
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя! Введите новое число 2");
                int new_num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / new_num2);
            }
            
            

            Console.WriteLine("\nД/з 2.1. Программа считывает букву с экрана и выводит следующую за ней букву в алфавитном порядкею");
            Console.WriteLine("Введите букву");
            char input = Console.ReadKey().KeyChar;
            char letter = char.ToLower(input);
            char nextChar;
            if (letter == 'z')
                nextChar = 'a';
            else
                nextChar = (char)(((int)letter) + 1);
            Console.WriteLine("\n{0}\n", nextChar);
            


            Console.WriteLine("Д/з 2.2. Программа считает корни квадратного уравнения по заданным коэффициентам");
            double x1, x2, X, a, b, c, d;
            Console.WriteLine("Введите a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c");
            c = Convert.ToDouble(Console.ReadLine());

            d = b * b - 4 * a * c;

            if (d < 0)
            {
                Console.WriteLine("Нет корней");
            }

            else if (d == 0)
            {
                X = -b / (2 * a);
                Console.WriteLine("x={0}", X);
            }

            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1={0}; x2={1}", x1, x2);
            }
        }
    }
}


