using System;

namespace DemoAsm2
{
    public abstract class Comic
    {
        public string Name { get; set; }
        public int Part { get; set; }
        public Comic()
        {

            Name = "No name";
            Part = 1;
        }
        public Comic(string name, int part)
        {
            Name = name;
            Part = part;
        }
        public abstract string GetName();
        public abstract string GetPart();
    }
}
