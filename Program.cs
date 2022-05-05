using System;

namespace DemoAsm2
{
    class Program
    {
        static void Main(string[] args)
        {
            Store app = new Store();
            
            string theme = Console.ReadLine();
            //app.ChangeTheme(theme);
            bool running = true;
            while(running)
            {
            app.GetName();
            // app.GetTitle();
            // app.GetPart();

            System.Console.WriteLine("Change theme: ");
            System.Console.WriteLine("1. English");
            System.Console.WriteLine("2. Vietnamese");
            System.Console.WriteLine("0. Exit");
            System.Console.Write("Your choice: ");
            }
                        
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                {
                    // app.ChangeTheme("English");
                    break;
                }
                case 2:
                {
                    // app.ChangeTheme("Vietnamese");
                    break;
                }
                case 0:
                {
                    Console.WriteLine("Exit");
                    running = false;
                    break;
                }
                default: Console.WriteLine("Invalid choice");
                break;
            } 
        }
    }
}
