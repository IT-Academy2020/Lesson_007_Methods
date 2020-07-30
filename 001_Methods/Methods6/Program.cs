using System;

// Повернення значень з методу Main ()

// Перевантаження методу Main () - допустимо.

// Точкою входу в програму може бути метод Main (), який повертає значення типу void або int.

namespace Methods
{
    class Program
    {

        // Перевантаження. (Не є точкою входу)
        static string Main(string argument)
        {
            return "Hello " + argument + "!";
        }


        // Точка входу у программу.
        static int Main()
        {
            string @string = Main("World");

            Console.WriteLine(@string);

            // Delay.
            Console.ReadKey();

            return 0;
        }
    }
}
