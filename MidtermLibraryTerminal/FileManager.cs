using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MidtermLibraryTerminal
{
    public class FileManager
    {
        public FileManager()
        {

        }
        public static void FileCreation()
        {
            if (!File.Exists("BookList.txt"))
            {
                using StreamWriter streamWriter = new StreamWriter("BookList.txt");
                streamWriter.WriteLine("I Am Legend|Richard Matheson|Jan 1, 2020|false");
                streamWriter.WriteLine("2001: A Space Odyssey|Arthur C. Clarke|Jan 1, 2020|false");
                streamWriter.WriteLine("The Hero of Ages|Brandon Sanderson|Jan 1, 2020|false");
                streamWriter.WriteLine("Ender's Game|Orson Scott Card|Jan 1, 2020|false");
                streamWriter.WriteLine("Frog and Toad Are Friends|Arnold Lobel|Jan 1, 2020|false");
                streamWriter.WriteLine("Fantasyland|Kurt Andersen|Jan 1, 2020|false");
                streamWriter.WriteLine("The Legend of Huma|Richard A. Knaak|Jan 1, 2020|false");
                streamWriter.WriteLine("A Contract with God|Will Eisner|Jan 1, 2020|false");
                streamWriter.WriteLine("Ex-Heroes|Peter Clines|Jan 1, 2020|false");
                streamWriter.WriteLine("Sisters of the Sword|Maya Snow|Jan 1, 2020|false");
                streamWriter.WriteLine("1984|George Orwell|Jan 1, 2020|false");
                streamWriter.WriteLine("The Lightning Thief|Rick Riordan|Jan 1, 2020|false");
            }
        }
        public static List<Book> ReadBookList()
        {

            using StreamReader streamReaderBookList = new StreamReader("BookList.txt");

            List<string> lines = File.ReadAllLines("BookList.txt").ToList();
            List<Book> bookList = new List<Book>();

            foreach (string line in lines)
            {
                var splitline = line.Split('|');
                Book currentBook = new Book();
                currentBook.Title = splitline[0];
                currentBook.Author = splitline[1];
                currentBook.DueDate = DateTime.Parse(splitline[2]);
                currentBook.CheckedOut = bool.Parse(splitline[3]);

                bookList.Add(currentBook);
            }
            return bookList;
        }

        public static void SaveBookList(List<Book> books)
        {
            //get the current book information

            using StreamWriter streamWriterBookList = new StreamWriter("BookList.txt");
            foreach (var item in books)
            {
                streamWriterBookList.WriteLine($"{item.Title}|{item.Author}|{item.DueDate.ToString()}|{item.CheckedOut.ToString()}");
            }
        }
    }
}
