using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        public string Name { get; }
        public string Publisher { get; }
        public DateTime YearOfPublish { get; }
        public List<string> Genres { get; } // Genres of Book: Could be mulltiple and 
                                            // the book should appear every time when one of its genres were provided
        public Book(string Name, string Publisher)
        {
            this.Name = Name;
            this.Publisher = Publisher;
            YearOfPublish = DateTime.Now.Date;
        }
    }
}
