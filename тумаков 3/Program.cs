using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace тумаков_3
{
    public enum bank : int
    {
        tecuchy = 135000,
        sbereg = 12600
    }
    public struct bank_information
    {
        public int number;
        public string type;
        public int balance;
        public void Print()
        {
            Console.WriteLine($"Номер - {number}, Тип: - {type}, баланс: - {balance}");
        }
        struct Worker
        {
            public string name;
            public Univer vuz;
            public void Print()
            {
                Console.WriteLine($"Имя - {name}, Вуз - {vuz}");
            }
        }
        enum Univer
        {
            КФУ,
            КАИ,
            КХТИ
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Упражнение 3.1");
                Console.WriteLine("Программа выводит значения бюджетов");

                bank t = bank.tecuchy;
                bank s = bank.sbereg;
                Console.WriteLine("Текущий бюджет - {0}, сберегательный бюджет - {1}", (int)t, (int)s);


                Console.WriteLine("Упражнение 3.2");
                Console.WriteLine("Программа выводит информацию о банке");

                bank_information b = new bank_information();
                b.balance = 135000;
                b.type = "Текущий";
                b.number = 555555;
                b.Print();


                Console.WriteLine("Домашнее задание 3.1");
                Console.WriteLine("Программа выводит информацию о месте работы сотрудника");

                Univer vuz = Univer.КФУ;
                Worker name = new Worker();
                name.name = "Лиза";
                name.vuz = vuz;
                name.Print();
                Console.ReadKey();
            }








        }

    }
} 
    
   



         
               
            

            
        
    

