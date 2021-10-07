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
            (string Name, string LastName, string Login, int LoginLenght, bool Pet, double Age, string[] FavColor) User;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Вветите свое имя:");
                User.Name = Console.ReadLine();
                Console.WriteLine("Введите свою фамилию:");
                User.LastName = Console.ReadLine();
                Console.WriteLine("Введите свой логин:");
                User.Login = Console.ReadLine();
                User.LoginLenght = User.Login.Length;
                Console.WriteLine("Есть ли у вас животное? Да или Нет:");
                string HavPet = Console.ReadLine();
                if (HavPet == "Да")
                {
                    User.Pet = true;
                    Console.WriteLine(User.Pet);
                }
                else
                {
                    User.Pet = false;
                    Console.WriteLine(User.Pet);
                }
                Console.WriteLine("Введите возраст пользователя");
                User.Age = double.Parse(Console.ReadLine());
                User.FavColor = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя:");
                for (int j = 0; j < User.FavColor.Length; j++)
                {
                    User.FavColor[i] = Console.ReadLine();
                }
            }
        }   
    }
}
