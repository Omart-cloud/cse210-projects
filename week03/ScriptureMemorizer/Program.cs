using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exceeding Requirements: A library of scriptures to choose from
            List<Scripture> scriptures = new List<Scripture>
            {
                new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life."),
                new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths."),
                new Scripture(new Reference("Psalms", 23, 1), "The Lord is my shepherd I shall not want.")
            };

            Random random = new Random();
            Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];
            Console.Clear();
            Console.WriteLine(selectedScripture);

            while (true)
            {
                Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                Console.Clear();

                bool allHidden = selectedScripture.HideRandomWords(3); // Hides 3 words at a time
                Console.WriteLine(selectedScripture);

                if (allHidden)
                {
                    Console.WriteLine("\nAll words are hidden. Well done!");
                    break;
                }
            }
        }
    }
}
