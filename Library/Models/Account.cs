using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    class Account
    {
        private string FirstName { get; }
        private string SecondName { get; }
        List<Book> takenBooks = new List<Book>();
        public Account(string FirstName, string SecondName)
        {
            this.FirstName = FirstName;
            this.SecondName = SecondName;
        }
    }
}
