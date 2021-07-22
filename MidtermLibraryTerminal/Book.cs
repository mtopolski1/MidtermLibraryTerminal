using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermLibraryTerminal
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool CheckedOut { get; set; } //true means the book is not available
        public DateTime DueDate { get; set; }
        public Book()
        {

        }
        public DateTime GetDueDate()
        {
            DateTime now = DateTime.Now;
            DateTime dueDate = now.AddDays(14);
            return dueDate;
        }
        public void CheckOut()
        {
            //var bookList = Program.ReadBookList();
            //foreach (var book in bookList)
            //{
            //    if (Title == book.Title)
            //    {

            //    }
            //}

            bool checkoutValidation = false;
            Console.Clear();
            if (!CheckedOut)
            {
                List<Option> checkoutOptions = new List<Option> 
                {
                    new Option("Yes", ConfirmCheckout),
                    new Option("No", Program.MainMenu)
                };
                Menu.MenuStart(checkoutOptions, $"Are you sure you want to check out {Title} by {Author}?");
                Console.Clear();
                if (checkoutValidation)
                {
                    CheckedOut = true;
                    DueDate = DateTime.Today.AddDays(14);
                    List<Option> AfterCheckoutOptions = new List<Option> 
                    {
                        new Option("Return to main menu", Program.MainMenu),
                        new Option("Quit", Program.Quit)
                    };
                    Menu.MenuStart(AfterCheckoutOptions, $"Your book has been successfully checked out and is due back at {DueDate}.\nWhat would you like to do?");
                }
                
            }
            else
            {
                List<Option> invalidCheckoutOptions = new List<Option>
                {
                    new Option("Return to Book List", Program.ListBooks),
                    new Option("Return to Main Menu", Program.MainMenu),
                    new Option("Quit", Program.Quit)
                };
                Menu.MenuStart(invalidCheckoutOptions, $"That book has already been checked out and is due back at {DueDate}.");
            }
            
        }
        public void ConfirmCheckout()
        {
            //this is the list that will overwrite the one in the file. 
            //it's a seperate list from the one this book object is from,
            //which means we have to change the same things in the equivalent book in this other list as the one the current book object is in
            var bookList = FileManager.ReadBookList();
            foreach (var book in bookList)
            {
                if (Title == book.Title)
                {
                    //change the checked out status and the due date in the equivelant book in this book list
                    book.CheckedOut = true;
                    book.DueDate = DateTime.Today.AddDays(14);
                }
            }

            FileManager.SaveBookList(bookList);

            //change the status and due date for the current book object so that the output message can read out correctly
            CheckedOut = true;
            DueDate = DateTime.Today.AddDays(14);

            List<Option> AfterCheckoutOptions = new List<Option>
                    {
                        new Option("Return to main menu", Program.MainMenu),
                        new Option("Quit", Program.Quit)
                    };
            Menu.MenuStart(AfterCheckoutOptions, $"Your book has been successfully checked out and is due back at {DueDate}.\nWhat would you like to do?");
        }
        
    }
}