using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TumakovLabs1 { 
    struct Worker
    {
        public string name;
        public int vuz;

        public Worker(string Name, int Vuz)
        {
            this.name = Name;
            this.vuz = Vuz;
        }
        public void Print1()
        {
            Console.WriteLine($"Имя: {name}, Вуз: {vuz}");
        }
    }
    enum Unis
    {
        kgu = 0, kai = 1, khti = 2
    }

    struct Bank
    {
        public string type;
        public int number;
        public string balance;
        public Bank(int Number, string Type, string Balance)
        {
            this.number = Number;
            this.type = Type;
            this.balance = Balance;
        }
        public void Print()
        {
            Console.WriteLine($"Номер: {number}, Тип: {type}, Баланс: {balance}");
        }
    }
    enum Types
    {
        Текущий, Сберегательный
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3.1");
            foreach (Types credit in Enum.GetValues(typeof(Types)))
            {
                Console.WriteLine("Кредит - {0}, Номер - {1}", credit, (int)credit);
            }
            Console.WriteLine("Задание 3.2");
            Bank info = new Bank(210011349, "Сберегательный", "2000000$");
            info.Print();

            Console.WriteLine("ДЗ 3.1");
            Worker worker1 = new Worker("Иван Иванов", (int)Unis.kai);
            worker1.Print1();
            Worker worker2 = new Worker("Пётр Климов", (int)Unis.khti);
            worker2.Print1();
            Worker worker3 = new Worker("Слава Мэрлоу", (int)Unis.kgu);
            worker3.Print1();
            Console.WriteLine("0 - КАИ / 1 - КХТИ / 2 - КГУ");
            Console.ReadKey();       
        }
    }
}
