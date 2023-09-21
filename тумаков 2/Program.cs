using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тумаков_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 2.1");
            Console.WriteLine("Программа спрашивает имя пользователя и приветствует пользователя по имени");
            Console.WriteLine("Введите имя пользователя");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, " + name);


            Console.WriteLine("Упражнение 2.2");
            Console.WriteLine("Программа выдаёт результат деления первого числа на второе");
            Console.WriteLine("Введите целое число (делимое)");
            double z1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число (делитель)");
            double z2 = double.Parse(Console.ReadLine());
            if (z2 == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
            }
            else
            {
                Console.WriteLine("Частное = " + z1 / z2);
            }

            Console.WriteLine("Домашнее задание 2.1");
            Console.WriteLine("Программа на вход получает букву, а выводит следующую после неё в алфавите");
            char letter = char.Parse(Console.ReadLine());
            char next_letter;
            if (letter == 'я'| letter == 'z' )
            {
                next_letter = 'а';
            }
            else
            {
                next_letter = (char)(((int)letter) + 1);
            }
            Console.WriteLine("Следующая буква - " + next_letter);

            Console.WriteLine("Домашнее задание 2.2");
            Console.WriteLine("Программа находит корни уравнения исходя из введённых коэффициентов");

            Console.WriteLine("Введите старший коэффициент а = ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите коэффициент b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите коэффициент c = ");
            int c = int.Parse(Console.ReadLine());


            double D = (b * b - 4 * a * c);
            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt (D)) / (2 * a);
                double x2 = (-b - Math.Sqrt (D)) / (2 * a);

                Console.WriteLine("Первый корень уравнения = " + x1);

                Console.WriteLine("Второй корень уравнения = " + x2);

            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Корень уравнения один = " + x);

            }
            else
            {
                Console.WriteLine("Корней нет");
            }

            Console.ReadKey();
        }
    }
}
