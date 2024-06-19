using System;

class Program
{
    static void Main()
    {
        double a, b, alpha;

        // Введення сторін та кута паралелограма
        Console.WriteLine("Введіть сторону a:");
        if (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
        {
            Console.WriteLine("Некоректне значення для сторони a. Введіть додатне число.");
            return;
        }

        Console.WriteLine("Введіть сторону b:");
        if (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
        {
            Console.WriteLine("Некоректне значення для сторони b. Введіть додатне число.");
            return;
        }

        Console.WriteLine("Введіть гострий кут alpha в градусах:");
        if (!double.TryParse(Console.ReadLine(), out alpha) || alpha <= 0 || alpha >= 180)
        {
            Console.WriteLine("Некоректне значення для кута alpha. Введіть значення від 0 до 180 градусів.");
            return;
        }

        // Переведення кута з градусів в радіани
        double alphaRad = Math.PI * alpha / 180.0;

        // Обчислення площі паралелограма
        double area = a * b * Math.Sin(alphaRad);

        // Виведення результату
        Console.WriteLine($"Площа паралелограма: {area}");
    }
}
