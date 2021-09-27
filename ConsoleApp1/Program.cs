using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "George";
            byte age = 35;
            bool pet = false;
            float shoeSize = 44.5f;
            Console.WriteLine($"Меня зовут {myName}");
            Console.WriteLine($"Мне {age} лет");
            Console.WriteLine($"Есть ли у меня петомец? {pet}");
            Console.WriteLine($"Размер моей ноги {shoeSize}");
            Console.WriteLine($"ByteMax {byte.MaxValue} \nByteMin {byte.MinValue}");
            Console.WriteLine($"floatMax {float.MaxValue} \nfloatMin {float.MinValue}");
            Console.WriteLine($"longMax {long.MaxValue} \nlongMin {long.MinValue}");
            Console.ReadKey();
        }
    }
}
