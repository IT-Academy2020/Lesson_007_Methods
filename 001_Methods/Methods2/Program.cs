using System;

// Перевантаження методів.

namespace Methods
{
    class Program
    {
        static void Operation()                                         // 1-ше перевантаження.
        {
            Operation("val", 10, 12.2);
        }

        static void Operation(string value1)                            // 2-ге перевантаження.
        {
            Operation(value1, 10, 12.2);
        }

        static void Operation(string value1, int value2)                // 3-тє перевантаження.
        {
            Operation(value1, value2, 12.2);
        }

        static void Operation(string value1, int value2, double value3) // 4-те перевантаження.
        {
            Console.WriteLine("{0},{1},{2}", value1, value2, value3);
        }

        static void Main()
        {
            Operation();                  // 1-ше перевантаження.
            Operation("val");             // 2-ге перевантаження.
            Operation("val", 10);         // 3-тє перевантаження. 
            Operation("val", 10, 12.2);   // 4-те перевантаження.

            // Delay.
            Console.ReadKey();
        }
    }
}
