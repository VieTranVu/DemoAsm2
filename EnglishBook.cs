namespace DemoAsm2
{
    public class EnglishBook : Book
    {
        public EnglishBook()
        {

        }
        public EnglishBook(string name, string title) : base(name, title) 
        {

        }
        public override string GetName()
        {
            return "English Book: " + Name;
        }
        public override string GetTitle()
        {
            return "Title of this book: " + Title;
        }
    }
}