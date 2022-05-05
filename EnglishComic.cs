namespace DemoAsm2
{
    public class EnglishComic : Comic
    {
        public EnglishComic()
        {

        }
        public EnglishComic(string name, int part) : base(name, part)
        {

        }
        public override string GetName()
        {
            return "English Comic: " + Name;
        }
        public override string GetPart()
        {
            return "Part of Comic: " + Part;
        }
    }
}