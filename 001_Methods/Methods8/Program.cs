using System;

// Рекурсія (складна рекурсія).

// Складна рекурсія - виклик методом себе, через інший метод.

namespace Methods
{
    class Program
    {
        static void Recursion(int counter)
        {
            counter--;

            Console.WriteLine("Перша половина метода Recursion: {0}", counter);

            if (counter != 0)
                Method(counter);

            Console.WriteLine("Друга половина метода Recursion: {0}", counter);
        }

        static void Method(int counter)
        {
            Console.WriteLine("Перша половина метода Method: {0}", counter);

            Recursion(counter);

            Console.WriteLine("Друга половина метода Method: {0}", counter);
        }

        static void Main()
        {
            Method(3);

            // Delay.
            Console.ReadKey();
        }
    }
}
