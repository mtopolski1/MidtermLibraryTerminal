using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermLibraryTerminal
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool CheckedOut { get; set; } //true = available, false = not available (has been checked out)
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
        
    }
}
