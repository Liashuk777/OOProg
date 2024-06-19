using System;

namespace WordArrayExample
{
    class Word
    {
        public string Text { get; private set; }

        public Word(string text)
        {
            Text = text;
            Console.WriteLine($"Створено слово: {text}");
        }

        ~Word()
        {
            Console.WriteLine($"Знищено слово: {Text}");
        }

        public int CountDigits()
        {
            int count = 0;
            foreach (char c in Text)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Word[] words = {
                new Word("привіт123"),
                new Word("світ4567"),
                new Word("CSharp890"),
                new Word("приклад22"),
                new Word("програмування5")
            };

            Word wordWithMostDigits = words[0];
            int maxDigits = words[0].CountDigits();

            foreach (var word in words)
            {
                int digitCount = word.CountDigits();
                if (digitCount > maxDigits)
                {
                    maxDigits = digitCount;
                    wordWithMostDigits = word;
                }
            }

            Console.WriteLine($"Слово з найбільшою кількістю цифр: {wordWithMostDigits.Text}, кількість цифр: {maxDigits}.");

            // Затримка, щоб програма не закрилася відразу
            Console.WriteLine("Натисніть будь-яку клавішу для виходу.");
            Console.ReadKey();
        }
    }
}
