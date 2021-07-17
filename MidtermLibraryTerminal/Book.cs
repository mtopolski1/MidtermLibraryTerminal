using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermLibraryTerminal
{
    class Book
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
            bool checkoutValidation = false;
            Console.Clear();
            if (!CheckedOut)
            {
                List<Option> checkoutOptions = new List<Option> 
                {
                    new Option("Yes", () => checkoutValidation = true),
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
                        new Option("Quit", Program.SaveAndQuit)
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
                    new Option("Quit", Program.SaveAndQuit)
                };
                Menu.MenuStart(invalidCheckoutOptions, $"That book has already been checked out and is due back at {DueDate}.");
            }
            
        }
        
    }
}
