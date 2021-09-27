using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "George";

            Console.WriteLine(myName);
            Console.WriteLine("\tПривет, мир");
            Console.WriteLine("\tМне 27 лет");
            Console.WriteLine("\tMy name is \nGeorge");
            Console.WriteLine("\u0040");
            Console.WriteLine("\x23");
            Console.ReadKey();
        }
    }
}
