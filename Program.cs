using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_var4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                // Вывод меню
                Console.WriteLine("=== ВЫЧИСЛЕНИЕ ПАРАМЕТРОВ ПРЯМОУГОЛЬНОГО ТРЕУГОЛЬНИКА ===");
                Console.WriteLine();
                Console.WriteLine("ОПЕРАЦИИ:");
                Console.WriteLine("1. Гипотенуза");
                Console.WriteLine("2. Площадь");
                Console.WriteLine("3. Периметр и радиус вписанной окружности");
                Console.WriteLine("4. Выход из программы");
                Console.WriteLine("Введите номер операции (1..4): ");

                // Обработка ввода меню
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 4!");
                    Console.WriteLine();
                    continue;
                }

                // Выбор операции
                switch (choice)
                {
                    case 1:
                        Hypotinuse();
                        break;
                    case 2:
                        Square();
                        break;
                    case 3:
                        Perimeter();
                        break;
                    case 4:
                        Console.WriteLine("Выход из программы...");
                        break;
                }

                if (choice != 4) Console.WriteLine();
            } while (choice != 4);
        }

        // Обработчик ошибок
        static double ReadPositiveDouble(string prompt)
        {
            double value;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                // Проверка на пустой ввод
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Ошибка: ввод не может быть пустым!");
                    Console.WriteLine();
                    continue;
                }

                // Проверка на то, что введено число
                if (!double.TryParse(input, out value))
                {
                    Console.WriteLine("Ошибка: введите корректное числовое значение!");
                    Console.WriteLine();
                    continue;
                }

                // Проверка на положительность
                if (value <= 0)
                {
                    Console.WriteLine("Ошибка: значение должно быть положительным числом!");
                    Console.WriteLine();
                    continue;
                }

                return value; // Возвращаем валидное значение
            }
        }

        // Рассчет гипотенузы
        static void Hypotinuse()
        {
            Console.WriteLine("=== Вычисление гипотенузы прямоугольного треугольника ===");
            Console.WriteLine();

            // Ввод катетов
            double catet_a = ReadPositiveDouble("Введите катет a: ");
            double catet_b = ReadPositiveDouble("Введите катет b: ");

            // Вычисление гипотенузы
            double hypotenuse = Math.Sqrt(Math.Pow(catet_a, 2) + Math.Pow(catet_b, 2));

            // Вывод результата
            Console.WriteLine();
            Console.WriteLine("=== Результат ===");
            Console.WriteLine();
            Console.WriteLine($"Гипотенуза = {hypotenuse:F2}");
        }

        // Рассчет площади
        static void Square()
        {
            Console.WriteLine("=== Вычисление площади прямоугольного треугольника ===");
            Console.WriteLine();

            // Ввод катетов с полной валидацией
            double catet_a = ReadPositiveDouble("Введите катет a: ");
            double catet_b = ReadPositiveDouble("Введите катет b: ");

            // Вычисление площади
            double square = (catet_a * catet_b) / 2;

            // Вывод результата
            Console.WriteLine();
            Console.WriteLine("=== Результат ===");
            Console.WriteLine();
            Console.WriteLine($"Площадь = {square:F2}");
        }

        // Рассчет периметра и радиуса вписанной окружности
        static void Perimeter()
        {
            Console.WriteLine("=== Вычисление периметра треугольника и радиуса вписанной окружности ===");
            Console.WriteLine();

            // Ввод катетов
            double catet_a = ReadPositiveDouble("Введите катет a: ");
            double catet_b = ReadPositiveDouble("Введите катет b: ");

            // Вычисление гипотенузы
            double hypotenuse = Math.Sqrt(Math.Pow(catet_a, 2) + Math.Pow(catet_b, 2));

            // Вычисление периметра и радиуса
            double perimeter = catet_a + catet_b + hypotenuse;
            double radius = (catet_a * catet_b) / (perimeter / 2);

            // Вывод результатов
            Console.WriteLine();
            Console.WriteLine("=== Результат ===");
            Console.WriteLine();
            Console.WriteLine($"Периметр = {perimeter:F2}");
            Console.WriteLine($"Радиус вписанной окружности = {radius:F2}");
        }
    }
}
