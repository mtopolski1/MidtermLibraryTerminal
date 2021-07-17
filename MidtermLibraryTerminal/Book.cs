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
            CheckedOut = true;
            DueDate = DateTime.Today.AddDays(14);
        }
        
    }
}
