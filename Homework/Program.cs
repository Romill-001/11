using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    struct student
    {
        public string firstname;
        public string secondname;
        public int ind;
        public string data;
        public string cat;
        public double alko;
        public student(string FirstName, string SecondName, int Ind, string Data, string Cat, double Alko)
        {
            this.firstname = FirstName;
            this.secondname = SecondName;
            this.ind = Ind;
            this.data = Data;
            this.cat = Cat;
            this.alko = Alko;
        }
        public double get_alko()
        {
            return alko;
        }
        public void Print1()
        {
            Console.WriteLine($"Имя: {firstname}, Фамилия: {secondname}, Индикатор: {ind}, Дата рождения: {data}, Категория алкоголизма: {cat}, Объём выпитого: {alko}");
        }

    }
    struct User
    {
        public string name;
        public string town;
        public int age;
        public int pin;
        public User(int Age, string Name, string Town, int PIN)
        {
            this.name = Name;
            this.town = Town;
            this.age = Age;
            this.pin = PIN;
        }
        public void Print()
        {
            Console.WriteLine($"Имя: {name}, Город: {town}, Возраст: {age}, PIN: {pin}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            student stud1 = new student("Камиль", "Ахметзянов", 1, "14.10.2004", "b", 1.5);
            stud1.Print1();
            student stud2 = new student("Лейсан", "Фаррахова", 2, "24.08.2004", "с", 0.5);
            stud2.Print1();
            student stud3 = new student("Андрей", "Калашников", 3, "20.05.2005", "с", 0.8);
            stud3.Print1();
            student stud4 = new student("Аделя", "Гильфанова", 4, "26.05.2004", "a", 2.9);
            stud4.Print1();
            student stud5 = new student("Халиль", "Зиганшин", 5, "14.01.2004", "b", 2.5);
            stud5.Print1();
            double all = stud1.get_alko() + stud2.get_alko() + stud3.get_alko() + stud4.get_alko() + stud5.get_alko();
            Console.WriteLine($"Первый студент выпил: {Math.Round((stud1.get_alko() / all) * 100, 1)}%" + "\n" +
            $"Второй студент выпил: {Math.Round((stud2.get_alko() / all) * 100, 1)}%" + "\n" +
            $"Третий студент выпил: {Math.Round((stud3.get_alko() / all) * 100, 1)}%" + "\n" +
            $"Четвёртый студент выпил: {Math.Round((stud4.get_alko() / all) * 100, 1)}%" + "\n" +
            $"Пятый студент выпил: {Math.Round((stud5.get_alko() / all) * 100, 1)}%" + "\n" + $"Общий объём алкоголя: {all} литров");


            Console.WriteLine("Task 2");
            Console.WriteLine($"sbyte: {sbyte.MinValue} ... {sbyte.MaxValue}" + "\n" +
            $"byte: {byte.MinValue} ... {byte.MaxValue}" + "\n" +
            $"short: {short.MinValue} ... {short.MaxValue}" + "\n" +
            $"ushort: {ushort.MinValue} ... {ushort.MaxValue}" + "\n" +
            $"int: {int.MinValue} ... {int.MaxValue}" + "\n" +
            $"uint: {uint.MinValue} ... {uint.MaxValue}" + "\n" +
            $"long: {long.MinValue} ... {long.MaxValue}" + "\n" +
            $"ulong: {ulong.MinValue} ... {ulong.MaxValue}" + "\n" +
            $"char: U+000 ... U+ffff" + "\n" +
            $"float: {float.MinValue} ... {float.MaxValue}" + "\n" +
            $"double: {double.MinValue} ... {double.MaxValue}" + "\n" +
            "bool: true ... false" + "\n" +
            $"decimal: {decimal.MinValue} ... {decimal.MaxValue}" + "\n" +
            "string: Ограничено только системной памятью" + "\n" +
            "object: Практически всё, что угодно" + "\n");


            Console.WriteLine("Task 3");
            User new_user = new User();
            Console.WriteLine("Введите имя");
            new_user.name = Console.ReadLine();
            Console.WriteLine("Введите город");
            new_user.town = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            new_user.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите PIN");
            new_user.pin = int.Parse(Console.ReadLine());
            new_user.Print();


            Console.WriteLine("Task 4");
            Console.WriteLine("Введите ваше имя");
            string[] name = Console.ReadLine().Split(' ');
            Console.WriteLine($"{name[0][0].ToString().ToUpper()}.{name[1][0].ToString().ToUpper()}");


            Console.WriteLine("Task 5");
            bool bebr = false;
            int zapas = -1, regularPrice = -1, sale = -1;
            while (bebr == false)
            {
                Console.Write("На какую сумму хотите отдохнуть?: ");
                bebr = int.TryParse(Console.ReadLine(), out zapas);
            }
            bebr = false;
            while (bebr == false)
            {
                Console.Write("Стандартная цена бутылки виски: ");
                bebr = int.TryParse(Console.ReadLine(), out regularPrice);
            }
            bebr = false;
            while (bebr == false)
            {
                Console.Write("Скидка на одну бутылку: ");
                bebr = int.TryParse(Console.ReadLine(), out sale);
            }
            Console.WriteLine($"Вам надо купить : {zapas / (regularPrice * sale / 100)}\n");

            Console.WriteLine("Task 6");
            Console.WriteLine("Введите скорость в км/ч:");
            int S = int.Parse(Console.ReadLine().Replace(".", ","));
            Console.WriteLine($"Скорость в см/c равна: {(S * 27.777778) - (S * 27.777778) % 1}");



            Console.WriteLine("Task 7");
            string strInput = Console.ReadLine();
            StringBuilder strOutput = new StringBuilder();
            foreach (Char c in strInput.ToCharArray())
            {
                if (Char.IsLower(c))
                {
                    strOutput.Append(Char.ToUpper(c));
                }
                else
                {
                    strOutput.Append(Char.ToLower(c));
                }
            }
            Console.WriteLine(strOutput);
            Console.ReadKey();
        }
    }
}  
 


