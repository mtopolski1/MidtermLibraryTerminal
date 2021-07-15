using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
using System.Text;
using System.Threading.Tasks;
=======
using System.IO;
>>>>>>> master

namespace MidtermLibraryTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
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
=======
            Console.WriteLine("This is the Midterm Project! Library Terminal. Team members Kate, Morgan and Mark");

            #region Menu Testing
            ////the Action for the option MUST be a method that does not have a parameter. 
            ////unfortunately that means we will have to access the file with all of the books in it in each and every method
            //Option testOne = new Option("View entire book list", ListBooks);
            //Option testTwo = new Option("Search by Title", TitleSearch);
            //Option testThree = new Option("Search by Author", AuthorSearch);
            //Option testFour = new Option("Return a book", BookReturn);
            //Option testFive = new Option("Quit", SaveAndQuit);


            //List<Option> testList = new List<Option> { testOne, testTwo, testThree, testFour, testFive };
            //Menu.MenuStart(testList, "Welcome to the Library Terminal. Would you like to:\n");
            #endregion
        }
        static void ListBooks()
        {
            Console.Clear();

            //make the book list be scrollable

            Book bookOne = new Book
            {
                Title = "Test book one",
                Author = "Test author one",
                Status = true,
                DueDate = DateTime.Now
            };
            Book bookTwo = new Book
            {
                Title = "Test book two",
                Author = "Test author two",
                Status = true,
                DueDate = DateTime.Now
            };
            Book bookThree = new Book
            {
                Title = "Test book three",
                Author = "Test author three",
                Status = false,
                DueDate = DateTime.Today
            };
            Book bookFour = new Book
            {
                Title = "Test book four",
                Author = "Test author four",
                Status = true,
                DueDate = DateTime.Now
            };
            Book bookFive = new Book
            {
                Title = "Test book five",
                Author = "Test author five",
                Status = true,
                DueDate = DateTime.Now
            };

            List<Book> bookList = new List<Book> { bookOne, bookTwo, bookThree, bookFour, bookFive };

            foreach (Book book in bookList)
            {
                Console.WriteLine($"{book.Title} - {book.Author}");
            }
            //back to the previous menu
        }

        static void TitleSearch()
        {
            //BookInOut();

        }
        static void AuthorSearch()
        {

        }
        static void BookReturn()
        {

        }
        static void SaveAndQuit()
        {

>>>>>>> master
        }
        
    }
}