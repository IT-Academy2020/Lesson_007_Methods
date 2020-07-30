using System;
using System.Text;

// Іменовані аргументи методів

namespace Methods
{
    class Program
    {
        static int Difference(int height, int width)
        {
            return height - width;
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Можна викликати метод так:
            int difference = Difference(6, 5);

            //difference = Difference(5, 6);

            Console.WriteLine("Різниця дорівнює: {0}", difference);

            // А тепер, ось так:
            difference = Difference(width: 5, height: 6);

            Console.WriteLine("Різниця дорівнює: {0}", difference);

            Console.ReadKey();
        }
    }
}
