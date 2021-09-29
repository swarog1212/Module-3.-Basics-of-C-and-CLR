using System;

namespace ConsoleApp2
{
    class Program
    {
        //enum DaysOfWeek
        //{
        //   Monday = 1,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday
        //}
        static void Main(string[] args)
        {

            Console.Write("Введите ваше имя: ");
            var name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            var age = checked ((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Ваше имя {0} и возраст {1} лет", name, age);
            Console.Write("Введите дату вашего рождения: ");
            var data = Console.ReadLine();
            Console.WriteLine("Ваша дата рождения: {0}", data);
        }   
    }
}
