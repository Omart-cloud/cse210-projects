using System;

namespace ScriptureMemorizer
{
    public class Reference
    {
        public string Book { get; private set; }
        public int Chapter { get; private set; }
        public string Verses { get; private set; }

        public Reference(string book, int chapter, int verse)
        {
            Book = book;
            Chapter = chapter;
            Verses = verse.ToString();
        }

        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            Book = book;
            Chapter = chapter;
            Verses = $"{startVerse}-{endVerse}";
        }

        public override string ToString()
        {
            return $"{Book} {Chapter}:{Verses}";
        }
    }
}
