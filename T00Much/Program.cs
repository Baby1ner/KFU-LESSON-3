using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace T00Much
{
    enum tip
    {
        current,
        saving
    }

    struct bank
    {
        public int num;
        public string tipp;
        public string balans;

        public void Print()
        {
            Console.WriteLine($"Номер = {num}, Тип: {tipp}, Баланс: {balans}");
        }
    }
    enum VUZ
    {
        KGU, KAI, KHTI
    }
    struct work
    {
        public string name;
        public string vuzik;

        public void printt()
        {
            Console.WriteLine($"Имя = {name} , Вуз = {vuzik}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Упражнение 3.1.");
            tip Current = tip.current;
            tip Saving = tip.saving;
            Console.WriteLine($"Текущий, имеет номер = {(int)Current}");
            Console.WriteLine($"Сберегательный, имеет номер = {(int)Saving}");



            Console.WriteLine("Упражнение 3.2.");
            bank score = new bank();
            score.num = 1;
            score.tipp = "Текущий";
            score.balans = "123000 Руб.";
            score.Print();



            Console.WriteLine("Домашнее задание 3.1.");
            work rab = new work();
            rab.name = "Demon";
            rab.vuzik = Convert.ToString(VUZ.KAI);
            rab.printt();


        }
    }
}
