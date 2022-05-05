using System;

namespace DemoAsm2
{
    public abstract class Language
    {
        public abstract Book CreateBook(string name, string title);
        public abstract Comic CreateComic(string name, int part);

    }
}