using System;

namespace DemoAsm2
{
    public abstract class Book
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public Book()
        {
            Name = "No name";
            Title = "No title";
        }
        public Book(string name, string title)
        {
            Name = name;
            Title = title;
        }
        public abstract string GetName();
        public abstract string GetTitle();
    }
}
