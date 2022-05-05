namespace DemoAsm2
{
    public class VietnameseBook : Book
    {
        public VietnameseBook()
        {

        }
        public VietnameseBook(string name, string title) : base(name, title)
        {
        }
        public override string GetName()
        {
            return "Vietnamese Book: " + Name;
        }
        public override string GetTitle()
        {
            return "Title of Book: " + Title;
        }
    }
}