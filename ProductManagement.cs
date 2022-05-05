using System;

namespace DemoAsm2
{
    public class ProductManagement : Menu
    {
        protected override void PrintMenu()
        {
            System.Console.WriteLine("1. English");
            Console.WriteLine("2. Vietnamese");
            Console.WriteLine("0. Exit");
        }
        protected override void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: English();
                break;
                case 2: Vietnamese();
                break;
                case 3: Console.WriteLine("Exit");
                break;
                default: Console.WriteLine("Invalid choixe, please choice again!");
                break;
            }
        }
        private void English()
        {

        }
        private void Vietnamese()
        {
            
        }

    }
}