using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermLibraryTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to thte Library Terminal.");
            Console.WriteLine("=================================");

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("=================================");
            Console.WriteLine("1) See Full Book List");
            Console.WriteLine("2) Search by Author");
            Console.WriteLine("3) Search by Title");
            Console.WriteLine("4) Return a book");
            Console.WriteLine("5) Exit Program");
            Console.WriteLine("=================================");

            switch (Console.ReadLine())
            {
                case "1":
                    //opens up list of books
                    return true;
                case "2":
                    //opens a search to list of books by author
                    return true;
                case "3":
                    //opens a search to list of books by title
                    return true;
                case "4":
                    //returns a book
                    return true;
                case "5":
                    // exits program, with a y/n statement
                    return false;
                default:
                    return true;
            }
        }
    }
}