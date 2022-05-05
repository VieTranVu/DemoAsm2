using System;
using System.Collections.Generic;

namespace DemoAsm2
{
    public class Store 
    {
        private Book book;
        private Comic comic;
        private VietnameseFactory language;
        public  Store() 
        {
            book = language.CreateBook("Topnotch1", "Level 1");
            comic = language.CreateComic("Doraemon", 1);
        }
        public void GetName()
        {
            book.GetName();
            comic.GetName();
        }
        public void GetTitle()
        {
            book.GetTitle();
        }
        public void GetPart()
        {
            comic.GetPart();
        }
        public void ChangeTheme(string name)
        {
            // if (theme == "Vietnamese") language = new VietnameseFactory();
            // else language = new EnglishFactory();
            language = new VietnameseFactory();
            UpdateInteface();
        }
        private void UpdateInteface()
        {
            string nameBook = book.Name;
            string titleBook = book.Title;
            string nameComic = comic.Name;
            int partComic = comic.Part;

            book = language.CreateBook(nameBook, titleBook);
            comic = language.CreateComic(nameComic, partComic);

            GetName();
            GetTitle();
            GetPart();
        }
    }
}