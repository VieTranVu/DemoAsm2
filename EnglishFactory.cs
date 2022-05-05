using System;

namespace DemoAsm2
{
    public class EnglishFactory : Language
    {
        public override EnglishBook CreateBook(string name, string title)
        {
            return new EnglishBook(name, title);
        }
        public override Comic CreateComic(string name, int part)
        {
            return new EnglishComic(name, part);
        }
    }
}