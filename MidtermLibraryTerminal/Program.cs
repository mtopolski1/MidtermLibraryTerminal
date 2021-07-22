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
            FileManager.FileCreation();
            MainMenu();
        }

        public static void MainMenu()
        {
            Option listBooks = new Option("View entire book list", ListBooks);
            Option titleSearch = new Option("Search by Title", TitleSearch);
            Option authorSearch = new Option("Search by Author", AuthorSearch);
            Option bookReturn = new Option("Return a book", BookReturn);
            Option saveQuit = new Option("Quit", Quit);


            List<Option> testList = new List<Option> { listBooks, titleSearch, authorSearch, bookReturn, saveQuit };
            Menu.MenuStart(testList, "Welcome to the Library Terminal. Would you like to:");
        }
        public static void ListBooks()
        {
            Console.Clear();
            var bookList = FileManager.ReadBookList();
            //make the book list be scrollable

            List<Option> bookOptions = new List<Option>();

            foreach (var book in bookList)
            {
                Option option = new Option($"{book.Title} - {book.Author}", book.CheckOut);
                bookOptions.Add(option);
            }

            Option menuOption = new Option("Return to Main Menu", MainMenu);
            Option quitOption = new Option("Quit", Quit);
            bookOptions.Add(menuOption);
            bookOptions.Add(quitOption);

            Menu.MenuStart(bookOptions, "Please select a book from the list.");
            //back to the previous menu

        }

        public static void TitleSearch()
        {
            Console.Clear();
            var bookList = FileManager.ReadBookList();

            Console.WriteLine("Please enter a book title: ");
            var userTitle = Console.ReadLine();

            bool match = false;
            foreach (var book in bookList)
            {
                if (userTitle.ToLower() == book.Title.ToLower())
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
                    new Option("Search another book by title", TitleSearch),
                    new Option("Return to main menu", MainMenu),
                    new Option("Quit", Quit)
                };
                Menu.MenuStart(options, $"Sorry, \"{userTitle}\" does not match any titles in this library.");
            }
        }

        public static void AuthorSearch()
        {
            Console.Clear();
            var bookList = FileManager.ReadBookList();

            Console.WriteLine("Please enter a book author: ");
            var userAuthor = Console.ReadLine();

            bool match = false;
            foreach (var book in bookList)
            {
                if (userAuthor.ToLower() == book.Author.ToLower())
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
                    new Option("Search another book by Author", AuthorSearch),
                    new Option("Return to Main Menu", MainMenu),
                    new Option("Quit", Quit)
                };
                Menu.MenuStart(options, $"Sorry, \"{userAuthor}\" does not match any titles in this library.");
            }
        }

        static void BookReturn()
        {
            Console.Clear();
            var bookList = FileManager.ReadBookList();

            Console.WriteLine("Please enter a book title to return:");
            var userReturn = Console.ReadLine().ToLower();
            bool match = false;
            var checkedOutVerification = false;
            foreach (var book in bookList)
            {
                if (userReturn == book.Title.ToLower())
                {
                    if (book.CheckedOut == true)
                    {
                        match = true;
                        book.CheckedOut = false;
                    }
                    else if (book.CheckedOut == true)
                    {
                        Console.WriteLine("$");
                    }
                    break;
                }
            }
            if (match == false)
            {
                List<Option> options = new List<Option>
                {
                    new Option("Search another book title to return", BookReturn),
                    new Option("Return to main menu", MainMenu),
                    new Option("Quit", Quit)
                };
                Menu.MenuStart(options, $"Sorry, \"{userReturn}\" does not exist in the library collection.");
            }
            else if(checkedOutVerification == false)
            {
                List<Option> options = new List<Option>
                {
                    new Option("Search another book title to return", BookReturn),
                    new Option("Return to main menu", MainMenu),
                    new Option("Quit", Quit)
                };
                Menu.MenuStart(options, $"\"{userReturn}\" has not been checked out and cannot be returned");
            }
            else
            {
                FileManager.SaveBookList(bookList);
                List<Option> options = new List<Option>
                {
                    new Option("Search another book title to return", BookReturn),
                    new Option("Return to main menu", MainMenu),
                    new Option("Quit", Quit)
                };
                Menu.MenuStart(options, $"The book {userReturn} was successfully returned.");
            }
        }

        public static void Quit()
        {
            Console.Clear();
            Console.WriteLine("Goodbye!");
        }
    }
}