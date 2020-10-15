using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
namespace Library
{
    class Library
    {
        public string Name { get; }
        private static string root { get; } = @"C:\Users\tmk01\source\repos\Library\ExcelFiles"; 

        private static Dictionary<Book, int> books = new Dictionary<Book, int>();
        public static SortedSet<string> Genres = new SortedSet<string>();
        public Library(string LibraryName)
        {
            this.Name = LibraryName;
            string path = root + @"\" + Name;

            using (SpreadsheetDocument mainfile = SpreadsheetDocument.Open(path, true))
            {

                TraverseExcelFile(path);
            }
            // Traverse all books in excel file
        }
        public void AddBook(Book book)
        {
            if (books.ContainsKey(book))
            {
                books[book]++;
            }
            else
            {
                books.Add(book, 1);
            }
            foreach (string genre in book.Genres)
            {
                Genres.Add(genre);
            }
        }
        public void AddBooks(Dictionary<Book, int> newbooks)
        {
            foreach (Book book in newbooks.Keys)
            {
                AddBook(book);
            }
        }
        public static void TakeBook(Book book)
        {
            if (!books.ContainsKey(book))
            {
                Console.WriteLine("No match for this book...");
            }
            else
            {
                books[book]--;
            }
        }
        public List<Book> Search(string input)
        {
            List<Book> found = new List<Book>();
            return found;
        }
        private void TraverseExcelFile(string path)
        {

        }
    }
}
