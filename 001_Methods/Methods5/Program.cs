﻿using System;

// Повернення значень з методу Main ()

// По завершенню програми є можливість повернути значення з методу Main () процесу, який виклакає або операційній системі.

// Значення, що повертається з методу Main () може бути тільки типу int.

// Як правило, значення, що повертається методом Main (), вказує на нормальне завершення програми,
// або на аварійне її завершення.
// Умовно нульове значення, що повертається зазвичай вказує на нормальне завершення програми,
// а всі інші значення позначають тип помилки, яка виникла.

namespace Methods
{
    class Program
    {       
        static int Main()
        {
            Console.WriteLine("Hello world!");

            // Delay.
            Console.ReadKey();

            return 0;
        }
    }
}
