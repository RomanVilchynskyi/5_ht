using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ht
{
    internal class Book
    {
        public string Title { get; set; }
        public string FullName { get; set; }
        public string Janr { get; set; }
        public int Year { get; set; }

        public Book(string title, string fullName, string janr, int year)
        {
            Title = title;
            FullName = fullName;
            Janr = janr;
            Year = year;
        }

        public override string ToString()
        {
            return $"Title :: {Title}, Fullname :: {FullName}, Janr :: {Janr}, Year :: {Year}";
        }
    }
}
