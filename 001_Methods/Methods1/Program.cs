using System;

// Перевантаження методів. 

namespace Methods
{
    class Program
    {
        // Перевантажені методи можуть відрізнятися типом і кількістю аргументів, а також ref і out параметрами.

        static void Function()                 // 1-ше перевантаження.   
        {
            Console.WriteLine("Hello!");
        }

        static void Function(string s)         // 2-ге перевантаження.
        {
            Console.WriteLine(s);
        }

        static void Function(int i)            // 3-тє перевантаження.
        {
            Console.WriteLine(i);
        }

        static void Function(double d)         // 4-те перевантаження.
        {
            Console.WriteLine(d);
        }

        static void Function(string s, int i)  // 5-те перевантаження.
        {
            Console.WriteLine(s + i);
        }

        static void Function(int i, string s)  // 6-те перевантаження.
        {
            Console.WriteLine(i + s);
        }

        static void Function(ref int i, string s) // 7-ме перевантаження.
        {
            Console.WriteLine(i + s);
        }

        // Перевантажені методи не можуть відрізнятися типом результату метода!
        //static string Function(string s)     // 8-ме перевантаження.              
        //{
        //    return s;
        //}

        // Перевантажені методи не можуть відрізнятися один від одного тільки параметрами ref і out!
        //static void Function(out int i, string s) 
        //{
        //    i = 5;
        //    Console.WriteLine(i + s);       // 9-те перевантаження.
        //}

        static void Main()
        {
            Function();                  // 1-ше перевантаження.
            Function("A");               // 2-ге перевантаження.
            Function(1);                 // 3-тє перевантаження.
            Function(3.14);              // 4-те перевантаження.
            Function("B ", 2);           // 5-те перевантаження.
            Function(3, " C");           // 6-те перевантаження.

            int variable = 5;
            Function(ref variable, "D"); // 7-ме перевантаження.

            // Delay.
            Console.ReadKey();
        }
    }
}
