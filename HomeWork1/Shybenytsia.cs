using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Shybenytsia

    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            string[] words = new string[]
            {
            "стіл", "крісло", "ручка", "телефон", "рюкзак",
            "кіт", "собака", "слон", "жираф", "папуга",
            "дружба", "сонце", "книга", "вікно", "мрія",
            "щастя", "зелений", "вечір", "дорога", "осінь"
            };

            Random random = new Random();
            string targetWord = words[random.Next(words.Length)];

            char[] guessedLetters = new string('_', targetWord.Length).ToCharArray();
            List<char> usedLetters = new List<char>();

            int attempts = 7;

            Console.WriteLine("🎮 Гра «Виселиця»");
            Console.WriteLine("Спробуй відгадати слово по літерах!");

            while (attempts > 0 && new string(guessedLetters) != targetWord)
            {
                Console.Clear();
                DrawHangman(7 - attempts); // Малюємо виселицю залежно від кількості спроб

                Console.WriteLine("\nСлово: " + string.Join(" ", guessedLetters));
                Console.WriteLine("Використані літери: " + string.Join(", ", usedLetters));
                Console.WriteLine($"Залишилось спроб: {attempts}");
                Console.Write("Введи літеру: ");
                string input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input) || input.Length != 1 || !char.IsLetter(input[0]))
                {
                    Console.WriteLine("Введи одну літеру.");
                    continue;
                }

                char letter = input[0];

                if (usedLetters.Contains(letter))
                {
                    Console.WriteLine("Цю літеру вже було введено.");
                    continue;
                }

                usedLetters.Add(letter);

                if (targetWord.Contains(letter))
                {
                    for (int i = 0; i < targetWord.Length; i++)
                    {
                        if (targetWord[i] == letter)
                        {
                            guessedLetters[i] = letter;
                        }
                    }
                    Console.WriteLine("Правильно!");
                }
                else
                {
                    attempts--;
                    Console.WriteLine("Неправильно!");
                }
            }

            if (new string(guessedLetters) == targetWord)
            {
                Console.WriteLine($"Вітаємо! Ви відгадали слово: {targetWord}");
            }
            else
            {
                Console.WriteLine($"На жаль, ви програли. Загадане слово було: {targetWord}");
            }
        }

        static void DrawHangman(int wrongAttempts)
        {
            string[] hangmanStages = new string[]
            {
            // 7 спроб
            @" 
               -----
               |   
               |   
               |   
               |  
               |
            -----",
            // 6 спроб
            @" 
               -----
               |   |
               |   O
               |   
               |  
               |
            -----",
            // 5 спроб
            @" 
               -----
               |   |
               |   O
               |   |
               |  
               |
            -----",
            // 4 спроби
            @" 
               -----
               |   |
               |   O
               |  /|
               |  
               |
            -----",
            // 3 спроби
            @" 
               -----
               |   |
               |   O
               |  /|\
               |  
               |
            -----",
            // 2 спроби
            @" 
               -----
               |   |
               |   O
               |  /|\
               |  / 
               |
            -----",
            // 1 спроба
            @" 
               -----
               |   |
               |   O
               |  /|\
               |  / \
               |
            -----",
            // 0 спроб - за шию його =)
            @" 
               -----
               |   |
               |   O
               |  /|\ 
               |  / \
               |
            -----"
            };

            Console.WriteLine(hangmanStages[wrongAttempts]);
        }

    }
}

