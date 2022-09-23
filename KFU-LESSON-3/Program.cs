using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KFU_LESSON_3
{
    struct polsovatel
    {
        public string name;
        public string city;
        public int age;
        public int pin;
        public void Print1()
        {
            Console.WriteLine($"Имя = {name},Город = {age},Возраст = {age},Pin код = {pin}");
        }

    }
    struct student
    {
        public string surname;
        public string name;
        public int ind;
        public string data;
        public string category;
        public double volume;
        public student(string surname1, string name1, int ind1, string data1, string category1, double volume1)
        {
            this.surname = surname1;
            this.name = name1;
            this.ind = ind1;
            this.data = data1;
            this.category = category1;
            this.volume = volume1;
        }
        public void Print()
        {
            Console.WriteLine($"Имя = {surname}, Фамилия = {name}, Идентификатор = {ind}, Дата рождения: {data}, Категория алкоголизма: {category}, Объём выпитого алкоголя: {volume}");
        }
        public double alko()
        {
            return volume;
        }
        public string imya()
        {
            return name;
        }
    }






    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Задание 1. Создать структуру студента.");
            student student1 = new student("Халиль", "Зиганшин", 1, "04.11.2004", "b", 1.5);
            student1.Print();
            student student2 = new student("Азат", "Залялетдинов", 2, "04.08.2005", "b", 2.5);
            student2.Print();
            student student3 = new student("Илназ", "Мухетдинов", 3, "27.11.2003", "с", 1.8);
            student3.Print();
            student student4 = new student("Илья", "Романов", 4, "05.08.2004", "a", 4.9);
            student4.Print();
            student student5 = new student("Андрей", "Калашников", 5, "17.06.2004", "а", 10.5);
            student5.Print();
            Console.WriteLine(" ");
            double volumeall = student1.alko() + student2.alko() + student3.alko() + student4.alko() + student5.alko();
            Console.WriteLine($"Всего было {volumeall} литров пива");
            Console.WriteLine($"{student1.imya()} выпил {volumeall / student1.alko()} % от общего обьема");
            Console.WriteLine($"{student2.imya()} выпил {volumeall / student2.alko()} % от общего обьема");
            Console.WriteLine($"{student3.imya()} выпил {volumeall / student3.alko()} % от общего обьема");
            Console.WriteLine($"{student4.imya()} выпил {volumeall / student4.alko()} % от общего обьема");
            Console.WriteLine($"{student5.imya()} выпил {volumeall / student5.alko()} % от общего обьема");


            Console.WriteLine(" ");
            Console.WriteLine("Задание 2. Информацию о каждом типе данных.");
            Console.WriteLine($"sbyte минимум = {sbyte.MinValue} sbyte максимум = {sbyte.MaxValue}");
            Console.WriteLine($"byte минимум = {byte.MinValue} byte максимум = {byte.MaxValue}");
            Console.WriteLine($"short минимум = {short.MinValue} short максимум = {short.MaxValue}");
            Console.WriteLine($"ushort минимум = {ushort.MinValue} ushort максимум = {ushort.MaxValue}");
            Console.WriteLine($"int минимум = {int.MinValue} int максимум = {int.MaxValue}");
            Console.WriteLine($"uint минимум = {uint.MinValue} uint максимум = {uint.MaxValue}");
            Console.WriteLine($"long минимум = {long.MinValue} long максимум = {long.MaxValue}");
            Console.WriteLine($"ulong минимум = {ulong.MinValue} ulong максимум = {ulong.MaxValue}");
            Console.WriteLine($"ulong минимум = {ulong.MinValue} ulong максимум = {ulong.MaxValue}");
            Console.WriteLine($"char минимум = U+0000 char максимум = U+FFFF");
            Console.WriteLine($"float минимум = {float.MinValue} float максимум = {float.MaxValue}");
            Console.WriteLine($"double минимум = {double.MinValue} double максимум = {double.MaxValue}");
            Console.WriteLine($"bool минимум - False bool максимум - True");
            Console.WriteLine($"float минимум = {float.MinValue} float максимум = {float.MaxValue}");
            Console.WriteLine($"decimal минимум = {float.MinValue} decimal максимум = {float.MaxValue}");


            Console.WriteLine(" ");
            Console.WriteLine("Задание 3. Данные пользователя.");
            polsovatel polsovatel3 = new polsovatel();
            Console.WriteLine("Введите имя");
            string name3 = Console.ReadLine();
            polsovatel3.name = name3;
            Console.WriteLine("Введите город");
            string city3 = Console.ReadLine();
            polsovatel3.city = city3;
            Console.WriteLine("Введите Возраст");
            int age3 = int.Parse(Console.ReadLine());
            polsovatel3.age = age3;
            Console.WriteLine("Введите Pin-cod");
            int pin3 = int.Parse(Console.ReadLine());
            polsovatel3.pin = pin3;
            polsovatel3.Print1();


            Console.WriteLine(" ");
            Console.WriteLine("Задание 4. Инициалы.");
            Console.WriteLine("Введите Имя");
            string name4 = Console.ReadLine();
            Console.WriteLine("Введите Отчество");
            string surname4 = Console.ReadLine();
            Console.WriteLine($"Ваши инициалы: {name4[0]}.{surname4[0]}.");


            Console.WriteLine(" ");
            Console.WriteLine("Задание 5. Закупка виски.");
            int c = 0;
            Console.WriteLine("Средняя цена за бутылку виски");
            int visk = int.Parse(Console.ReadLine());
            Console.WriteLine("Цена за бутылку виски в DutyFree");
            int freevisk = int.Parse(Console.ReadLine());
            Console.WriteLine("Цена отпуска");
            int otpusk = int.Parse(Console.ReadLine());
            int poshlina = visk - freevisk;
            while (otpusk > 0)
            {
                otpusk -= poshlina;
                c++;
            }
            Console.WriteLine($"Нужно купить {c} бутолок виски");


            Console.WriteLine(" ");
            Console.WriteLine("Задание 6. Перевести км/ч в м/с.");
            Console.WriteLine("Введите скорость в км/ч");
            double km = double.Parse(Console.ReadLine());
            Console.WriteLine($"Скорость в м/c = {Math.Floor(km * 100000 / 3600)}");


            Console.WriteLine(" ");
            Console.WriteLine("Задание 7. Преобразовать строку.");
            Console.WriteLine("Введите строку только из заглавных или из строчных букв");
            string strok = Console.ReadLine();
            int dlina = strok.Length;
            StringBuilder end = new StringBuilder();
            for (int i = 0; i < dlina; i++)
            {
                char caca = strok[i];
                if (Char.IsLower(caca))
                {
                    end.Append(Char.ToUpper(caca));
                }
                else
                {
                    end.Append(Char.ToLower(caca));
                }
            }
            Console.WriteLine(end);

        }
    }
}
