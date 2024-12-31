// 1. Калькулятор середньої зарплати працівників за місяць
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_23._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int count = 0;
            string input;

            Console.WriteLine("Введіть зарплату кожного працівника за місяць, наприколад '10 500' (для завершення введення введіть у поле '='):");

            do
            {
                Console.Write("Введіть зарплату: ");
                input = Console.ReadLine();

                if (input != "=")
                {
                    if (double.TryParse(input, out double salary))
                    {
                        sum += salary;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Будь ласка, введіть коректне числове значення або '=' для завершення вводу.");
                    }
                }
            } while (input != "=");

            if (count > 0)
            {
                double averageSalary = sum / count;
                Console.WriteLine($"Середній заробіток: {averageSalary}");
            }
            else
            {
                Console.WriteLine("Не було введено жодної зарплати.");
            }

            Console.WriteLine("Натисніть будь-яку клавішу для завершення програми...");
            Console.ReadKey();
        }
    }
*/

// 2. Побудова графіку зірочками
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_23._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість рядків графіка: ");
            if (int.TryParse(Console.ReadLine(), out int rows))
            {
                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(); // Перехід на новий рядок
                }
            }
            else
            {
                Console.WriteLine("Будь ласка, введіть коректне числове значення.");
            }
            Console.WriteLine("Натисніть будь-яку клавішу для завершення програми...");
            Console.ReadKey();
        }
    }
}
*/

// 3. Генератор простих чисел
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_23._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть число: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 1)
            {
                Console.WriteLine($"Прості числа від 1 до {n}:");

                for (int i = 2; i <= n; i++)
                {
                    int count = 0;

                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;
                        }
                    }

                    if (count == 2)
                    {
                        Console.WriteLine($"{i} ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Будь ласка, введіть ціле число більше за 1.");
            }

            Console.WriteLine("Натисніть будь-яку клавішу для завершення програми...");
            Console.ReadKey();
        }
    }
}
*/

// 4. Перевірка паролю

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_23._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть пароль: ");
            string password = Console.ReadLine();

            if (password.Length < 8)
            {
                Console.WriteLine("Пароль не відповідає вимогам. Менше 8 символів.");
                return;
            }

            bool hasDigit = false;
            bool hasSpecialChar = false;

            for (int i = 0; i < password.Length; i++)
            {
                char c = password[i];

                // Перевіряємо, чи це цифра
                if (char.IsDigit(c))
                    hasDigit = true;

                // Перевіряємо, чи це спеціальний символ
                if (!char.IsLetterOrDigit(c))
                    hasSpecialChar = true;

                // Якщо знайдені і цифра, і спеціальний символ, зупиняємо перевірку
                if (hasDigit && hasSpecialChar)
                    break;
            }

            // Результат перевірки
            if (hasDigit && hasSpecialChar)
            {
                Console.WriteLine("Пароль прийнятний.");
            }
            else
            {
                Console.WriteLine("Пароль не відповідає вимогам.");
            }

            Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}

// 5. Генерація фібоначчівської послідовності 

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_23._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість чисел Фібоначчі: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int first = 0, second = 1;
                Console.WriteLine("Послідовність Фібоначчі:");

                for (int i = 0; i < n; i++)
                {
                    Console.Write(first + " ");
                    int next = first + second;
                    first = second;
                    second = next;
                }
            }
            else
            {
                Console.WriteLine("Будь ласка, введіть додатнє ціле число.");
            }
            Console.WriteLine("Натисніть будь-яку клавішу для завершення програми...");
            Console.ReadKey();
        }
    }
}
*/

// 6. Калькулятор оплати праці за годину

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_23._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hoursWorked = 0;
            double hourlyRate = 0;

            while (true)
            {
                Console.Write("Введіть кількість годин, працюваних за день: ");
                if (double.TryParse(Console.ReadLine(), out hoursWorked) && hoursWorked > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Некоректне значення. Спробуйте ще раз.");
                }
            }

            while (true)
            {
                Console.Write("Введіть розмір годинної ставки: ");
                if (double.TryParse(Console.ReadLine(), out hourlyRate) && hourlyRate > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Некоректне значення. Спробуйте ще раз.");
                }
            }

            double dailyPay = hoursWorked * hourlyRate;
            Console.WriteLine($"Оплата за день: {dailyPay} грн.");

            Console.WriteLine("Натисніть будь-яку клавішу для завершення програми...");
            Console.ReadKey();
        }
    }
}
*/

// 7. Генерація таблиці множення для конкретного числа
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_23._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int startNumber = 1;
            const int end = 10;

            Console.Write("Введіть цифру для якої потрібна таблиця множення: ");
            var numbString = Console.ReadLine();

            if (int.TryParse(numbString, out int numb))
            {
                for (int i = startNumber; i <= end; i++)
                {
                    Console.WriteLine($"{numb} * {i} = {numb * i}");
                }
            }
            else
            {
                Console.WriteLine("Ви ввели некоректне значення. Будь ласка, введіть число.");
            }

            Console.WriteLine("Натисніть будь-яку клавішу для завершення програми...");
            Console.ReadKey();
        }
    }
}
*/

// 8. Перевірка числа на простоту
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_23._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть число для перевірки: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number > 1)
                {
                    bool isPrime = true;

                    for (int i = 2; i < number; i++)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        Console.WriteLine($"Число {number} є простим.");
                    }
                    else
                    {
                        Console.WriteLine($"Число {number} не є простим.");
                    }
                }
                else
                {
                    Console.WriteLine($"Число {number} не є простим.");
                }
            }
            else
            {
                Console.WriteLine("Будь ласка, введіть коректне число.");
            }

            Console.WriteLine("Натисніть будь-яку клавішу для завершення програми...");
            Console.ReadKey();
        }
    }
}
*/