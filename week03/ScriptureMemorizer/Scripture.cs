using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        public Reference Reference { get; private set; }
        private List<Word> Words { get; set; }

        public Scripture(Reference reference, string text)
        {
            Reference = reference;
            Words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        public bool HideRandomWords(int count = 1)
        {
            var wordsToHide = Words.Where(word => !word.IsHidden).OrderBy(_ => Guid.NewGuid()).Take(count).ToList();

            foreach (var word in wordsToHide)
            {
                word.Hide();
            }

            return Words.All(word => word.IsHidden); // Return true if all words are hidden
        }

        public override string ToString()
        {
            string scriptureText = string.Join(" ", Words);
            return $"{Reference}\n{scriptureText}";
        }
    }
}
