using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace MidtermLibraryTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine("Please enter a book title:");
            var userTitle = Console.ReadLine().ToLower();
            //var titleSelection = bookList.Where(x => userTitle.Contains(x.Title));
            bool match = false;
            foreach (var book in bookList)
            {
                if(userTitle == book.Title.ToLower())
                {
                    match = true;
                    book.CheckOut();
                    break;
                }
            }

                if (match == false)
            {
                List<Option> options = new List<Option>
                {
                    new Option("Search anothe rbook by title", TitleSearch),
                    new Option("Return to main menu", MainMenu),
                    new Option("Quit", SaveAndQuit)
                };
                Menu.MenuStart(options, $"Sorry, \"{userTitle}\" does not match any titles in this library.");
            }
        }
        static void AuthorSearch()
        {
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

            Console.WriteLine("Please enter an author:");
            var userAuthor = Console.ReadLine().ToLower();
            bool match = false;
            foreach (var book in bookList)
            {
                if (userAuthor == book.Author.ToLower())
                {
                    match = true;
                    book.CheckOut();
                    break;
                }
            }

            if (match == false)
            {
                List<Option> options = new List<Option>
                {
                    new Option("Search another book by author", AuthorSearch),
                    new Option("Return to main menu", MainMenu),
                    new Option("Quit", SaveAndQuit)
                };
                Menu.MenuStart(options, $"Sorry, \"{userAuthor}\" does not match any authors in this library.");
            }
        }
        static void BookReturn()
        {

        }
        static void SaveAndQuit()
        {

        }
        
    }
}
