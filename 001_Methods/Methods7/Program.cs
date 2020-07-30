using System;

// Рекурсія (проста рекурсія).

// У тілі методу Recursion на 19-му рядку рекурсивно викликається метод Recursion.
// Проста рекурсія - виклик методом самого себе (самовиклик). При кожному виклику будується нова копія методу.

namespace Methods
{
    class Program
    {
        static void Recursion(int counter)
        {
            counter--;

            Console.WriteLine("Перша половина методу: {0}", counter);

            if (counter != 0)
                Recursion(counter);

            Console.WriteLine("Друга половина методу: {0}", counter);
        }

        static void Main()
        {
            Recursion(3);

            // Delay.
            Console.ReadKey();
        }
    }
}
