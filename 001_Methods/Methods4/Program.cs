using System;

// Методи з опціональними параметрами.

namespace Methods
{
    class Program
    {
        // Метод викликається так само, якби він був перевантаженим.
        static void Operation(string value1 = "val", int value2 = 10, double value3 = 12.2)
        {
            Console.WriteLine("{0}, {1}, {2}", value1, value2, value3);
        }

        static void Main()
        {
            Operation();                 
            Operation("val");            
            Operation("val", 10);        
            Operation("val", 10, 12.2);


            // Не можна поставити третій параметр value3 = 12.2, замість другого параметра value2 = 10!
            // 12.2 не може бути приведено до int - тут C # намагається залишити за замовчуванням третій параметр, а не другий.
            // Operation ("val", 12.2); // ПОМИЛКА!

            // В даному випадку можливе використання іменованих параметрів.
            // Вони складаються з вказівки, імені параметра, двокрапки і значення, яке ми передаємо.

            Operation("val", value3: 12.2);
            Operation(value2: 33, value3: 12.2);


            // Delay.
            Console.ReadKey();
        }
    }
}
