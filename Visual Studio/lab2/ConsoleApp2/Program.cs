using System;

class Word
{
    private string word;

    public void Input()
    {
        Console.WriteLine("Введіть слово:");
        word = Console.ReadLine();
    }

    public void CountDigits()
    {
        int digitCount = 0;

        foreach (char character in word)
        {
            if (char.IsDigit(character))
            {
                digitCount++;
            }
        }

        Console.WriteLine($"Кількість цифр у слові \"{word}\": {digitCount}");
    }
}

class Program
{
    static void Main()
    {
        Word myWord = new Word();

        myWord.Input();

        myWord.CountDigits();
    }
}

