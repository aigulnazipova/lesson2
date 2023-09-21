using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace tasks
{
    internal class Program
    {
        struct Person
        {
            public string name;
            public string city;
            public int age;
            public ulong pin;
            public void Print()
            {
                Console.WriteLine($"Имя - {name}, город - {city}, возраст - {age}, PIN - {pin}.\n");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1. Программа выводит информацию о каждом типе данных.");
            Console.WriteLine("Тип данных - uint, минимальное значение = {0}, максимальное значение = {1}", uint.MinValue, uint.MaxValue);
            Console.WriteLine("Тип данных - int, минимальное значение = {0}, максимальное значение = {1}",int.MinValue, int.MaxValue);
            Console.WriteLine("Тип данных - byte, минимальное значение = {0}, максимальное значение = {1}", Byte.MinValue, Byte.MaxValue);
            Console.WriteLine("Тип данных - sbyte, минимальное значение = {0}, максимальное значение = {1}", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("Тип данных - short, минимальное значение = {0}, максимальное значение = {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("Тип данных - ushort, минимальное значение = {0}, максимальное значение = {1}", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("Тип данных - long, минимальное значение = {0}, максимальное значение = {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("Тип данных - ulong, минимальное значение = {0}, максимальное значение = {1}", ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("Тип данных - float, минимальное значение = {0}, максимальное значение = {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("Тип данных - double, минимальное значение = {0}, максимальное значение = {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("Тип данных - decimal, минимальное значение = {0}, максимальное значение = {1}\n", decimal.MinValue, decimal.MaxValue);
        

            Console.WriteLine("Задача 2. Программа принимает и выводит данные о пользователе");
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите город, в котором живете");
            string city = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите PIN");
            ulong pin = Convert.ToUInt64(Console.ReadLine());
            Person person = new Person();
            person.name = name;
            person.city = city;
            person.age = age;
            person.pin = pin;
            person.Print();


            Console.WriteLine("Задача 3. Программа меняет регистры");
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            string new_str = "";
                foreach (char el in str)
                {
                    new_str += Char.IsUpper(el) ? Char.ToLower(el) : Char.ToUpper(el);
                }
                Console.WriteLine($"Новая строка: {new_str}\n");


            Console.WriteLine("Задача 4. Программа считает количество вхождений подстроки в строку");
            Console.WriteLine("Введите строку");
            string String = Console.ReadLine();
            Console.WriteLine("Введите подстроку");
            string Substring = Console.ReadLine();
            Console.WriteLine($"Количество вхождений подстроки в строку - {Regex.Matches(String, Substring).Count}\n");


            Console.WriteLine("Задача 5.");
            Console.WriteLine("Введите стандартную цену виски:");
            int normPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите скидку в Dute Free (в процентах):");
            int salePrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость поездки в отпуск:");
            int holidayPrice = Convert.ToInt32(Console.ReadLine());
            double dutefree_price = normPrice * salePrice/100;
            double number_of_bottles = holidayPrice / dutefree_price;
            Console.WriteLine("Необходимое количество бутылок виски со скидкой, чтобы покрыть расходы на отпуск: {0}.\n", number_of_bottles);


            Console.WriteLine("Задача 6. Программа воспроизводит разговор Гарри Поттера и дневника Тома Реддла.");
            Console.WriteLine("Поздоровайтесь с консолью (напишите: Привет)");
            string answer1 = (Console.ReadLine());
            if (answer1 == "Привет")
            {
                Console.WriteLine("Как Вас зовут?");
                string user_name = Console.ReadLine();
                Console.WriteLine($"Привет, {user_name}!");
            }
            Console.WriteLine("(спросите о тайной комнате)");
            string answer2 = (Console.ReadLine());
            if (answer2 == "Знаешь ли ты что-то о тайной комнате")
            {
                Console.WriteLine("Да");
                string answer3 = Console.ReadLine();
                Console.WriteLine("(попросите рассказать о ней)");
                if (answer3 == "Можешь рассказать")
                {
                    Console.WriteLine("Нет");
                    Thread.Sleep(5000);
                    Console.WriteLine("Но могу показать");
                    Console.BackgroundColor = ConsoleColor.Red;
                }    
            } 
        }
    }
}
