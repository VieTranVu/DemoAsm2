namespace DemoAsm2
{
    public class VietnameseComic : Comic
    {
        public VietnameseComic()
        {

        }
        public VietnameseComic(string name, int part) : base(name, part)
        {

        }
        public override string GetName()
        {
            return "Vietnamese Comic: " + Name;
        }
        public override string GetPart()
        {
            return "Part of this Comic: " + Part;
        }
    }
}