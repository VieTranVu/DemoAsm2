namespace DemoAsm2
{
    public class VietnameseFactory : Language
    {
        public override Book CreateBook(string name, string title)
        {
            return new VietnameseBook(name, title);
        }
        public override Comic CreateComic(string name, int part)
        {
            return new VietnameseComic(name, part);
        }
    }
}