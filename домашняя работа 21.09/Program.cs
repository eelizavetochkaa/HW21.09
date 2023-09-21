using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace дз_на_21._09
{
    enum AlchoholDegree
    {
        a, b, c, d
    }
    struct Student
    {
        static int count = 0;
        public static int sum = 0;
        public string SecondName;
        public string FirstName;
        public int id;
        public DateTime Birth;
        public AlchoholDegree degree;
        public int volume;
        public Student(string SecondName, string FirstName, DateTime data, AlchoholDegree d, int volume)
        {
            this.SecondName = SecondName;
            this.FirstName = FirstName;
            this.id = count;
            count++;
            this.Birth = data;
            this.degree = d;
            this.volume = volume;
            sum += volume;
        }

        public override string ToString()
        {
            return string.Format("Студент категории {4}: {0} {1} под номером {2} выпил {3} процентов напитка жизни", SecondName, FirstName, id, (double)volume / sum * 100, degree);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Номер 1");
            Console.WriteLine("Программа выводит на экран тип данных, максимальное и минимальное значение");

            Console.WriteLine("Тип: {0}\t\t МАКС: {1, 30}\t\t МИН: {2}", typeof(byte).Name, byte.MaxValue, byte.MinValue); Console.WriteLine("Тип: {0}\t\t МАКС: {1, 30}\t\t МИН: {2}", typeof(sbyte).Name, sbyte.MaxValue, sbyte.MinValue);
            Console.WriteLine("Тип: {0}\t\t МАКС: {1, 30}\t\t МИН: {2}", typeof(int).Name, int.MaxValue, int.MinValue);
            Console.WriteLine("Тип: {0}\t\t МАКС: {1, 30}\t\t МИН: {2}", typeof(uint).Name, uint.MaxValue, uint.MinValue);
            Console.WriteLine("Тип: {0}\t\t МАКС: {1, 30}\t\t МИН: {2}", typeof(long).Name, long.MaxValue, long.MinValue); Console.WriteLine("Тип: {0}\t\t МАКС: {1, 30}\t\t МИН: {2}", typeof(ulong).Name, ulong.MaxValue, ulong.MinValue);
            Console.WriteLine("Тип: {0}\t\t МАКС: {1, 30}\t\t МИН: {2}", typeof(float).Name, float.MaxValue, float.MinValue);
            Console.WriteLine("Тип: {0}\t\t МАКС: {1, 30}\t\t МИН: {2}", typeof(double).Name, double.MaxValue, double.MinValue); Console.WriteLine("Тип: {0}\t\t МАКС: {1, 30}\t\t МИН: {2}", typeof(decimal).Name, decimal.MaxValue, decimal.MinValue);
            Console.WriteLine("Тип: {0}\t\t МАКС: {1, 30}\t\t МИН: {2}", typeof(char).Name, char.MaxValue, char.MinValue);
            Console.WriteLine("Тип: {0}\t\t МАКС: {1, 30}\t\t МИН: {2}", typeof(string).Name, 0, "inf");
            Console.WriteLine("Тип: {0}\t\t МАКС: {1, 30}\t\t МИН: {2}", typeof(bool).Name, 1, 0);

            Console.WriteLine("Номер 2");
            Console.WriteLine("Программа выдаёт имя, город, возраст, пин-код");
            Console.WriteLine("Введите имя\nВведите город\nВведите возраст\nВведите ПИН");
            string name = Console.ReadLine();
            string town = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string PIN = Console.ReadLine();
            var a = new Person(name, town, age, PIN);
            Console.WriteLine(a.ToString());


            Console.WriteLine("Номер 3");
            Console.WriteLine("Программа меняет строчные буквы на заглавные, а заглавные - на строчные");
            Console.WriteLine("Введите строку:");
            string s = Console.ReadLine();
            int numa = (int)'a'; int numz = (int)'z';
            int numA = (int)'A'; int numZ = (int)'Z';
            int rusnuma = (int)'а'; int rusnumz = (int)'я';
            int rusnumA = (int)'А'; int rusnumZ = (int)'Я';
            string anotherstr = ""; for (int i = 0; i < s.Length; i++)
            {
                int x = (int)s[i];
                if (x >= numa && x <= numz)
                {
                    x += numA - numa; anotherstr += (char)x;
                    continue;
                }
                if (x >= numA && x <= numZ)
                {
                    x -= numA - numa; anotherstr += (char)x;
                    continue;
                }
                if (x >= rusnuma && x <= rusnumz)
                {
                    x += rusnumA - rusnuma;
                    anotherstr += (char)x; continue;
                }
                if (x >= rusnumA && x <= rusnumZ)
                {
                    x -= rusnumA - rusnuma;
                    anotherstr += (char)x; continue;
                }
                anotherstr += (char)x;
            }
            Console.WriteLine($"{anotherstr}");

            Console.WriteLine("Номер 4");
            Console.WriteLine("Программа выдаёт количество вхождений второй подстроки в  первую строку");
            Console.WriteLine("Введите первую строку, а затем подстроку");
            string cool = Console.ReadLine();
            string little = Console.ReadLine();
            if (little == "" || cool.Length < little.Length)
            {
                return;
            }
            int count = 0;
            for (int i = 0; i < cool.Length - little.Length + 1; i++)
            {
                string x = ""; for (int j = 0; j < little.Length; j++)
                {
                    x += cool[i + j];
                }
                if (x == little)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество вхождений = {count}");

            Console.WriteLine("Номер 5");
            Console.WriteLine("Программа определяет, сколько бутылок виски беспошлинной торговли вам нужно будет купить, чтобы экономия по сравнению с обычной ценой фактически покрыла расход на отдых");
            int normPrice = 0;
            int salePrice = 0;
            int holidayPrice = 0;
            Console.WriteLine("Введите стандартную цену:");
            normPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите скидку в Duty Free:");
            salePrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость отпуска:");
            holidayPrice = int.Parse(Console.ReadLine());
            Console.WriteLine($"Вам нужно {(int)(holidayPrice / ((double)normPrice * salePrice / 100))}");


            Console.WriteLine("Номер 6");
            Console.WriteLine("Привет, как тебя зовут?");
            string name2 = Console.ReadLine();
            Console.WriteLine("Привет, " + name2);
            Console.WriteLine("Спросите, знает ли консоль что-то о тайной комнате");
            Console.ReadLine();
            Console.WriteLine("Да");
            Console.WriteLine("Спросите,может ли консоль что-то о ней рассказать");
            Console.ReadLine();
            Console.WriteLine("Нет");

            Thread.Sleep(5000);
            Console.WriteLine("Но могу показать");
            Console.BackgroundColor = ConsoleColor.Green;


            Console.WriteLine("Номер 7");
            Console.WriteLine("Программа вычисляет контрольную цифру штрихкода");
            Console.WriteLine("Введите 12 цифр");
            var rr = new Random();
            List<int> ints = new List<int>();
            /*
            for (int i = 0; i < 12; i++) 
            { 
                ints.Add(rr.Next(0, 1)); 
            }
            */
            while (ints.Count < 12)
            {
                int x = Console.Read();
                if (x >= (int)'0' && x <= (int)'9')
                {
                    ints.Add(x - (int)'0');
                }
            }

            int sumnechetnoe = 0;
            int sumchetnoe = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (i % 2 == 0)
                {
                    sumchetnoe += ints[i - 1];
                }
                else
                {
                    sumnechetnoe += ints[i - 1];
                }

            }
            Console.WriteLine($"Контрольная цифра = {10 - ((sumchetnoe * 3 + sumnechetnoe) % 10)}");

            Console.WriteLine("Номер 8");
            Console.WriteLine("Программа считает объём алкоголя и кто сколько процентов выпил");
            List<Student> students = new List<Student>()
            {
            new Student("Петров","Аркадий", new DateTime(2000, 10, 2), AlchoholDegree.a, 100),
            new Student("Смирнов","Валерий", new DateTime(new Random().Next(1000, 3000), new Random().Next(1, 11), new Random().Next(1, 30)), AlchoholDegree.b, 80),
            new Student("Дебров","Дмитрий", new DateTime(new Random().Next(1000, 3000), new Random().Next(1, 11), new Random().Next(1, 30)), AlchoholDegree.c, 60),
            new Student("Лапшев","Вешат", new DateTime(new Random().Next(1000, 3000), new Random().Next(1, 11), new Random().Next(1, 30)), AlchoholDegree.c, 40),
            new Student("Володин","Алан", new DateTime(new Random().Next(1000, 3000), new Random().Next(1, 11), new Random().Next(1, 30)), AlchoholDegree.d, 0),

            };

            Console.WriteLine($"Общий объём алкоголя = {Student.sum}");

            for (int i = 0; i < students.Count(); i++)
            {
                Console.WriteLine("Процентное содержание выпитого = " + students[i].ToString());
            }



            Console.ReadKey();
        }
    }
}
