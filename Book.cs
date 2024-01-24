using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    class Book
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; } 
        public int YearOfCreation { get; set; }

        public Book(string title, string description, string author, int yearOfCreation)
        {
            Title = title;
            Description = description;
            Author = author;
            YearOfCreation = yearOfCreation;
        }
    }
}
